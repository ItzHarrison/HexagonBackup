using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace HexagonBackup
{
    public partial class MainWindow : Form
    {
        //~~Configuration~~
        public MainWindow()
        {
            InitializeComponent();
        }

        private string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\HexagonBackup";
        private bool BACKUP_IN_PROGRESS = false;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                textbox_Target.Text = File.ReadAllText(AppDataFolder + @"\item.tgt");
            }
            catch (DirectoryNotFoundException)
            {
                BuildTargetItem(AppDataFolder);
            }
            catch (FileNotFoundException)
            {
                BuildTargetItem(AppDataFolder);
            }

            try
            {
                string[] sourceFile = File.ReadAllLines(AppDataFolder + @"\list.src");
                for (int i = 0; i < sourceFile.Length; i++)
                {
                    list_SourceDirectories.Items.Add(sourceFile[i]);
                }
            }
            catch (DirectoryNotFoundException)
            {
                BuildSourceList(AppDataFolder);
            }
            catch (FileNotFoundException)
            {
                BuildSourceList(AppDataFolder);
            }

            try
            {
                string sourceFile = File.ReadAllLines(AppDataFolder + @"\shutdown.check")[0];
                Console.WriteLine($"content: {sourceFile}");
                if (sourceFile == "True")
                {
                    check_Shutdown.Checked = true;
                }
            }
            catch (DirectoryNotFoundException)
            {
                BuildShutdownCheck(AppDataFolder);
            }
            catch (FileNotFoundException)
            {
                BuildShutdownCheck(AppDataFolder);
            }
        }


        //~~Saving~~
        private void BuildSourceList(string path)
        {
            Directory.CreateDirectory(path);

            string list = "";
            foreach (string source in list_SourceDirectories.Items)
            {
                list += source + "\n";
            }

            File.WriteAllText(path + @"\list.src", list);
        }

        private void BuildTargetItem(string path)
        {
            Directory.CreateDirectory(path);
            File.WriteAllText(path + @"\item.tgt", textbox_Target.Text);
        }

        private void BuildShutdownCheck(string path)
        {
            Directory.CreateDirectory(path);
            File.WriteAllText(path + @"\shutdown.check", check_Shutdown.Checked.ToString());
        }


        //~~Source~~
        private void button_BrowseSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            FolderBrowser.Description = "Please select a folder to be added to the source list.";
            FolderBrowser.ShowNewFolderButton = true;
            FolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;

            DialogResult status = FolderBrowser.ShowDialog();

            if (status == DialogResult.OK)
            {
                if (Directory.GetFiles(FolderBrowser.SelectedPath).Length == 0 && Directory.GetDirectories(FolderBrowser.SelectedPath).Length == 0)
                {
                    DialogResult result = MessageBox.Show("The folder you selected is empty, would you still like to add it as a source?", "Warning - Folder is empty.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        textbox_AddSource.Text = FolderBrowser.SelectedPath;
                    }
                }

                else
                {
                    textbox_AddSource.Text = FolderBrowser.SelectedPath;
                }
            }
        }

        private void textbox_AddSource_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_AddSource.Text))
            {
                button_AddSource.Enabled = true;
            }
            else
            {
                button_AddSource.Enabled = false;
            }
        }

        private void button_AddSource_Click(object sender, EventArgs e)
        {
            textbox_AddSource.Text = textbox_AddSource.Text.Replace('/', '\\');

            if (!Directory.Exists(textbox_AddSource.Text))
            {
                MessageBox.Show($"{textbox_AddSource.Text} is not a folder. Please check the path entered.", "Warning - Folder doesn't exist.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool inList = false;
                foreach (string source in list_SourceDirectories.Items)
                {
                    if (source == textbox_AddSource.Text && !inList)
                    {
                        inList = true;
                        MessageBox.Show("The folder you selected is already in the source list.", "Warning - Folder already source.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (!inList)
                {
                    list_SourceDirectories.Items.Add(textbox_AddSource.Text);
                    BuildSourceList(AppDataFolder);
                }

                textbox_AddSource.Text = "";
            }            
        }

        private void list_SourceDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_SourceDirectories.SelectedIndex != -1)
            {
                button_RemoveSource.Enabled = true;
            }
        }

        private void button_RemoveSource_Click(object sender, EventArgs e)
        {
            list_SourceDirectories.Items.RemoveAt(list_SourceDirectories.SelectedIndex);
            BuildSourceList(AppDataFolder);
            button_RemoveSource.Enabled = false;
        }

        private void button_ClearSource_Click(object sender, EventArgs e)
        {
            DialogResult clear = MessageBox.Show("Are you sure you want to clear the source list? This action cannot be undone.", "Warning - Clear source list.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (clear == DialogResult.OK)
            {
                list_SourceDirectories.Items.Clear();
                BuildSourceList(AppDataFolder);
            }            
        }


        //~~Target~~
        private void button_BrowseTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            FolderBrowser.Description = "Please select a Target Folder.";
            FolderBrowser.ShowNewFolderButton = true;
            FolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;

            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                textbox_Target.Text = FolderBrowser.SelectedPath;
            }
        }

        private void textbox_Target_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_Target.Text))
            {
                button_Backup.Enabled = true;
                button_OpenTarget.Enabled = true;
            }
            else
            {
                button_Backup.Enabled = false;
                button_OpenTarget.Enabled = false;
            }

            BuildTargetItem(AppDataFolder);
        }

        private void button_OpenTarget_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textbox_Target.Text))
            {
                Process.Start(new ProcessStartInfo { Arguments = textbox_Target.Text, FileName = "explorer.exe" });
            }
            else
            {
                button_OpenTarget.Enabled = false;
            }
        }


        //~~Backup~~
        private void Backup(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (FileInfo fi in source.GetFiles())
            {
                string status = $"Status: Copying {fi.Name}";
                if(status.Length > 25)
                {
                    status = status.Substring(0, 22)+"...";
                }
                label_Status.Text = status;
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                progress_Backup.PerformStep();
            }
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                Backup(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void button_Backup_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textbox_Target.Text))
            {
                DialogResult result = MessageBox.Show("The directory selected does not exist.", "Error - Directory doesn't exist.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    button_Backup_Click(new object(), new EventArgs());
                }
            }
            else
            {
                progress_Backup.Value = 0;
                progress_Backup.UseWaitCursor = true;

                button_Backup.Enabled = false;
                button_Backup.Text = "Backup in progress";
                button_BrowseTarget.Enabled = false;
                textbox_Target.Enabled = false;

                label_Status.Enabled = true;
                progress_Backup.Enabled = true;

                BACKUP_IN_PROGRESS = true;

                int TotalFileCount = 0;
                foreach (string source in list_SourceDirectories.Items)
                {
                    TotalFileCount += Directory.GetFiles(source, "*", SearchOption.AllDirectories).Length;
                }

                progress_Backup.Maximum = TotalFileCount;

                Thread backupThread = new Thread(() =>
                {
                    DateTime start = DateTime.Now;

                    label_Status.Text = "Status: Creating backup folder";
                    string date = DateTime.Now.Date.ToShortDateString().Replace('/', '.');
                    string target = textbox_Target.Text + $"/Backup {date}";
                    Directory.CreateDirectory(target);

                    bool ERROR = false;

                    try
                    {
                        foreach (string source in list_SourceDirectories.Items)
                        {
                            if (!ERROR)
                            {
                                target = textbox_Target.Text + $"/Backup {date}/{source.Split('\\')[source.Split('\\').Length - 1]}";
                                Directory.CreateDirectory(target);
                                Backup(new DirectoryInfo(source), new DirectoryInfo(target));
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        DialogResult result = MessageBox.Show($"An unexpected error occured. Please retry.\n\nError: {ex.Message}", "Error - Couldn't backup.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Retry)
                        {
                            button_Backup_Click(new object(), new EventArgs());
                        }
                        ERROR = true;
                    }

                    BACKUP_IN_PROGRESS = false;

                    TimeSpan elapsedTime = DateTime.Now - start;
                    if (ERROR)
                    {
                        label_Status.Text = "Status: Error";
                    }
                    else if(!check_Shutdown.Checked)
                    {
                        label_Status.Text = "Status: Complete";
                        MessageBox.Show($"Success - Backup completed in {elapsedTime.ToString("g").Split('.')[0]}.", "Success - Backup completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }

                    progress_Backup.UseWaitCursor = false;
                    button_Backup.Enabled = true;
                    button_Backup.Text = "Backup";
                    button_BrowseTarget.Enabled = true;
                    textbox_Target.Enabled = true;
                    label_Status.Enabled = false;
                    progress_Backup.Enabled = false;                    
                    progress_Backup.Value = 0;
                });

                backupThread.IsBackground = true;
                backupThread.Start();
            }
        }

        
        //~~Misc~~
        private void label_Developer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/ItzHarrison");
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BACKUP_IN_PROGRESS)
            {
                DialogResult result = MessageBox.Show("A backup is currently running. Closing the app will stop the backup and may cause errors. Are you sure you want to continue?", "Warning - Backup in progress.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void check_Shutdown_CheckedChanged(object sender, EventArgs e)
        {
            BuildShutdownCheck(AppDataFolder);
        }
    }
}
