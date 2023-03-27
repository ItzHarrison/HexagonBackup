
# Hexagon Backup

![Logo](https://user-images.githubusercontent.com/94720214/228078271-4cdac992-ac85-46c0-b02e-0fb30972e184.png)

A simple tool for copying multiple folders. Made to help with backups, hence the name.

---

## Version 1.1.0
- Added icon to the app
- Added basic error handling on the backup functionality
- Fixed time elapsed on completion message box
- Allowed user to make new folder in folder browser

---

## Overview of the UI
![image](https://user-images.githubusercontent.com/94720214/228080569-1414753c-564a-47cc-b3ff-3d23aa75e3e6.png)

---

## How to use Hexagon Backup
### **Adding a source**
To add a source simply either click browse and select a source from the folder browser.
Alternatively, you can enter the path into the text input in the sources box.
Once a path as been selected press "Add source directory" and it will add it to the list above.

### **Removing a source**
To remove a source simply select the source you want to remove from the list then click the remove selected button.

### **Clearing the source list**
Clicking the clear all directories button will empty the list. This is irreversible and therefore has an extra step.
A warning will appear asking if you are sure you wish to clear the list. Click "OK" to proceed.
The list will now be clear.

### **Selecting the target**
Press browse and select a source from the folder browser or enter a path into the text box. It will be validated when the backup is started.
The target does not need to be manualy saved or added to a list.

### **Complete a backup**
Click the begin backup button. It will start working immediately. The process bar shows the % of files that have been copied.
The bar may not be indicative of if the process is complete, so wait for the message confirmation to appear.
In the event of an error, either retry or cancel at your choice.

### **View the target directory**
Opening the target directory will give you an easy way to verify the backup was a success once complete.
It also lets you see that the destination was correct.
