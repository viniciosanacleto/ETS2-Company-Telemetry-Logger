# ETS2-Company-Telemetry-Logger
This system generate a log of the last cargo automatically on ETS2. The generated log can be sended to a virtual company for avaliation.
<h1>Download Application - ETS2 Company Telemetry Logger </h1>
Download only the application
http://www.mediafire.com/download/eofp91ble5i3412/ETS2_Company_Telemetry_Logger_0.1v.rar

<h1>Log</h1>
For while we don't have a Log Interpreter so this is the structure of the Log generated:
##1 TRAILER NAME | TRAILER WEIGHT | TRAILER INCOME
##2 SOURCE COMPANY | SOURCE CITY | DESTINY COMPANY | DESTINY CITY
##3 FUEL ON START
##4 IF HAS BEEN REFUELED
##5 FINAL FUEL
##6 WASTED FUEL
##7 GREATER SPEED REACHED
##8 TRAILER DAMAGE

<h1>Project</h1>
This project uses the project ETS2 Telemetry Server: https://github.com/Funbit/ets2-telemetry-server
The code has been writed on C#, utilizing .NET Framework 4.5.
