using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Web;
using System.Diagnostics;


namespace ETS2_Company_Telemetry_Logger
{
    public partial class Principal : Form
    {
        //VARIABLES*
        //**        
        OBD obdConnect = new OBD();
        Log log;
        private int maxSpeed=0;
        private bool flagLog = false,refuel = false;
        private double fuelS=999999, fuelT;
        public Principal()
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\server\Ets2Telemetry.exe");
            InitializeComponent();
            Properties.Settings.Default.LogPath = Application.StartupPath;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.First) //Just on the first inicialization
            {                
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.Description = "That's all right, to continue select a path for de Logs folder:";
                path.ShowDialog();
                Properties.Settings.Default.LogPath = path.SelectedPath;
                Properties.Settings.Default.First = false;
                Properties.Settings.Default.Save();
            }
            if (!Directory.Exists(Properties.Settings.Default.LogPath+@"\Logs")) { // Verify if exist the directory "Logs" on root of program
                Directory.CreateDirectory(Properties.Settings.Default.LogPath + @"\Logs"); //If dont, its created
            }           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                bt_restart.Visible = false;
                obdConnect.RunJson();                
                statusLabel(1);
                
            }
            catch
            {
                realTime_timer.Enabled = false;
                bt_restart.Visible = true;
                MessageBox.Show("ERROR! : RunJson, check if sever is online!");
                statusLabel(3);
            }
            if (obdConnect.getTrailerAttached()) //Trigger to Log Start
            {
                trailerOn();
            }
            else { trailerOff();} //Trigger to Log Stop
            if (!obdConnect.getEngineOn()&&obdConnect.getTruckFuel()>=fuelS) //Check if there was a refuel
            {
                refuel = true;
            }
            //SPEED
            lbl_speed.Text = Convert.ToString(obdConnect.getSpeed());
            if (obdConnect.getSpeed() > maxSpeed) {
                maxSpeed = obdConnect.getSpeed();
            }
            lbl_maxSpeed.Text = Convert.ToString(maxSpeed);
            //GEAR            
            lbl_gear.Text = obdConnect.getDGear();
            //JOB INCOME
            lbl_income.Text = "$"+Convert.ToString(obdConnect.getIncome());
            //TRAILER
            lbl_trailerName.Text = obdConnect.getTrailerName();
            if (obdConnect.getTrailerDamage() < 1)
            {
                lbl_trailerDamage.Text = "0";
            }else{  lbl_trailerDamage.Text = Convert.ToString(obdConnect.getTrailerDamage()); }            
        }

        private void trailerOn() //Happen when the log start
        {
            if (flagLog == false)
            {
                pb_trailerAttached.Image = ETS2_Company_Telemetry_Logger.Properties.Resources.att; //Change the trailer attached image
                fuelS = obdConnect.getTruckFuel();
                log = new Log();
                log.newLine(obdConnect.getTrailerName()+"|"+Convert.ToString(obdConnect.getMassTrailer())+"|"+Convert.ToString(obdConnect.getIncome())); //Write a line on Log: Cargo Name + Weight + Income
                log.newLine(obdConnect.getSourceCompany() + "|" + obdConnect.getSourceCity() + "|" + obdConnect.getDestinyCompany() + "|" + obdConnect.getDestinyCity()); //Write a line on Log: Sender + Sender City + Receiver + Receiver City
                log.newLine(Convert.ToString(fuelS));                
                flagLog = true;
                maxSpeed = 0;
            }
        }

        private void trailerOff() //Happen when the log stop
        {
            if (flagLog == true)
            {
                pb_trailerAttached.Image = ETS2_Company_Telemetry_Logger.Properties.Resources.not_att; //Change the trailer attached image
                fuelT = obdConnect.getTruckFuel();
                log.newLine(Convert.ToString(refuel));
                log.newLine(Convert.ToString(fuelT));
                log.newLine(Convert.ToString((fuelS-fuelT)));
                log.newLine(Convert.ToString(maxSpeed));
                log.newLine(Convert.ToString((obdConnect.getTrailerDamage()*100)));
                log.writeOnFile();
                maxSpeed = 0;
                refuel = false;
                flagLog = false;
            }
        }

        private void statusLabel(int status){
        if(status == 1){
            lbl_status.Text = "Running";
            lbl_status.ForeColor = Color.Green;
        }
        else if (status == 3)
        {
            lbl_status.Text = "Stopped!";
            lbl_status.ForeColor = Color.Red;
        }
        else if(status == 2){
            lbl_status.Text = "Working...";
            lbl_status.ForeColor = Color.Gold;
        }

        }//Control the Status Label("[1]Running","[2]Stopped","[3]Working") 

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) //Up menu bar: Settings
        {
            Settings set = new Settings();
            set.ShowDialog(); //Open the Settings window
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Up menu bar: Exit
        {
            this.Close();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e) //When the form is closed the server as closed too
        {
            Process[] processes = Process.GetProcessesByName("Ets2Telemetry");
 
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void bt_restart_Click(object sender, EventArgs e)// If the application dont recognize the server, this button turn visible to try again the connection
        {
            realTime_timer.Enabled = true;
        }
  }
}
