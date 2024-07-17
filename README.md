<h1>MCVC - Mirth Connect Version Control</h1>

![MCVClogo](https://github.com/user-attachments/assets/7aa0d96f-4d1b-4f3f-bb56-ddb2bc5abdf1)

**Allow you to backup your Mirth Connect Channels with full changes history**

<h2>About this Project</h2>

With this tool, you will be able to monitor what changes occur in the configuration of channels saved in the database. 
An independently running application, after connecting to the database, monitors the table with channels, 
and after a change occurs, saves the configuration of a given channel to the repository directory.

Supported databases:
- MSSQL
- PostgreSQL
- MySQL
- Oracle

<h2>How to use</h2>
After starting the application, we have a list of available listeners in the main window. 
At the bottom of the window, there is a list where application logs will appear.

![MainWindow](https://github.com/user-attachments/assets/102085c6-f245-490b-8afb-44432c715ab2)

Before starting the listener, you must first enter the database connection configuration.
By clicking 'Edit', a window will open where you can enter the ConnectionString. 
![EditSetting](https://github.com/user-attachments/assets/8d47cca6-865b-4611-b646-731785ba3a29)

To start the listener, you just need to check the checkbox next to its name. 
After starting, an entry will appear in the logs with information about logging into the database and, if any, saving channels from the database. 
In case of any errors they would be also logged in here and checkbox will uncheck.

![MainWindow_Logs](https://github.com/user-attachments/assets/bfba7fb1-f601-441e-b289-1309894aaa5f)

The paths to the logs and the repository can be set in the options that can be accessed by clicking the Settings button.

![GlobalSettings](https://github.com/user-attachments/assets/aba61f95-f340-4aa0-b100-3f78f36e427f)

**Log path** - specifies the location where the application logs are saved.

**Repo path** - specifies the location where the repository of saved channel files is located.

**Use git** - If not checked, each version of the file will be saved separately with a specified date and revision number. If checked, the saved files will be overwritten and a commit will be performed for each change made.

**Close on exit** - If unchecked, clicking the close button icon will minimize it to the bar. If checked, it will close the program as standard.
