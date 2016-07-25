# ETS2-Company-Telemetry-Logger
This system generate a log of the last cargo automatically on ETS2. The generated log can be sended to a virtual company for avaliation.
<h1>Download Application - ETS2 Company Telemetry Logger </h1>
Download only the application
http://www.mediafire.com/download/eofp91ble5i3412/ETS2_Company_Telemetry_Logger_0.1v.rar

<h1>Installation and Use</h1>
<p>1. After the download, extract the application in some folder.
<p>2. Click on the truck icon.
<p> <b>OBS:</b> If appeared some dialog message about some error on RunJs just ignore and click on OK.
<p>3. When you start the app for the first time you need to install the ETS2 Telemetry Server, so just click on install and after, you can minimize the window.
<p>4. Now you need to choose a folder for the Logs, if you cancel the folder gonna be on the .../YourApplicationFolder/Logs.
<p>5. If has a red button on interface saying RESTART, click on it.
<p>6. The status need to be changed to "Running", case not, close the program and open again.
<p>7. To start a new log you just need enter on your ETS2, choose and attach a cargo, the log start and stop AUTOMATICALLY when you finnish the job.You can check if the Log has started on interface.
<p>8. After you job you can see the Log on your Log Folder.
<p>9. Now, you can send the log to your company and validate your job.

<h1>Log</h1>
For while we don't have a Log Interpreter so this is the structure of the Log generated:
<code>
<p>#1 TRAILER NAME | TRAILER WEIGHT | TRAILER INCOME
<p>#2 SOURCE COMPANY | SOURCE CITY | DESTINY COMPANY | DESTINY CITY
<p>#3 FUEL ON START
<p>#4 IF HAS BEEN REFUELED
<p>#5 FINAL FUEL
<p>#6 WASTED FUEL
<p>#7 GREATER SPEED REACHED
<p>#8 TRAILER DAMAGE
</code>

<h1>About the Project</h1>
<p>This project uses the project ETS2 Telemetry Server: https://github.com/Funbit/ets2-telemetry-server
<p>The code has been writed on C#, utilizing .NET Framework 4.5.
