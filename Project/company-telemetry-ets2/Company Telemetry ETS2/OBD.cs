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

namespace ETS2_Company_Telemetry_Logger
{
    class OBD
    {
        private string url = "http://localhost:25555/api/ets2/telemetry";
        private string json, gameJson, trailerJson, truckJson, jobJson, navigationJson, sourceCity, sourceCompany, destinyCity, destinyCompany, idTrailer, nameTrailer; //Principal Tokens
        private double massTrailer, trailerDamage,truckFuel;
        private int speed, gear,dGear, income;
        private bool attachedTrailer,engineOn;

        public void RunJson()
        {
            json = new WebClient().DownloadString(url);
            JToken token = JObject.Parse(json);

            #region Get Principal Tokens

            gameJson = Convert.ToString(token.SelectToken("game"));//Token "game"
            trailerJson = Convert.ToString(token.SelectToken("trailer"));//Token "trailer"
            truckJson = Convert.ToString(token.SelectToken("truck"));//Token "truck"
            jobJson = Convert.ToString(token.SelectToken("job"));//Token "job"
            navigationJson = Convert.ToString(token.SelectToken("navigation"));//Token "navigation"

            #endregion

            #region Token Truck

            JToken truckToken = JObject.Parse(truckJson);
            speed = Convert.ToInt32(truckToken.SelectToken("speed"));//Speed of Truck
            gear = Convert.ToInt32(truckToken.SelectToken("gear"));//Gear engaged
            dGear = Convert.ToInt32(truckToken.SelectToken("displayedGear"));//Gear displayed
            truckFuel = Convert.ToDouble(truckToken.SelectToken("fuel"));//Truck fuel
            engineOn = Convert.ToBoolean(truckToken.SelectToken("engineOn"));
            #endregion

            #region Token Job

            JToken jobToken = JObject.Parse(jobJson);
            income = Convert.ToInt32(jobToken.SelectToken("income")); //Money received by job
            sourceCity = Convert.ToString(jobToken.SelectToken("sourceCity"));//Start City
            sourceCompany = Convert.ToString(jobToken.SelectToken("sourceCompany"));//Start Company
            destinyCity = Convert.ToString(jobToken.SelectToken("destinationCity"));//Finish City
            destinyCompany = Convert.ToString(jobToken.SelectToken("destinationCompany"));//Finish Company

            #endregion

            #region Token Trailer

            JToken trailerToken = JObject.Parse(trailerJson);
            attachedTrailer = Convert.ToBoolean(trailerToken.SelectToken("attached"));//If Trailer is connected with Truck
            idTrailer = Convert.ToString(trailerToken.SelectToken("id"));//Trailer ID
            nameTrailer = Convert.ToString(trailerToken.SelectToken("name"));//Trailer Name
            massTrailer = Convert.ToDouble(trailerToken.SelectToken("mass"));//Trailer Wheight in KG
            trailerDamage = Convert.ToDouble(trailerToken.SelectToken("wear"));//Trailer Damage 0(min) and 1(max)


            #endregion
            
        }

        public int getSpeed() {
            if (this.speed < 0)
            {
                this.speed = this.speed * (-1);
            }
            return this.speed;
        }
        public string getGear() {
            if (this.gear < 0)
            {
                return "R" + Convert.ToString(this.gear);
            }
            else if (this.gear == 0)
            {
                return "N";
            }
            else
            {
                return Convert.ToString(this.gear);
            }
        }
        public string getDGear()
        {
            if (this.dGear < 0)
            {
                return "R" + Convert.ToString(this.dGear*-1);
            }
            else if (this.dGear == 0)
            {
                return "N";
            }
            else
            {
                return Convert.ToString(this.dGear);
            }
        }
        public int getIncome() {
            return this.income;
        }
        public double getTrailerDamage() {
            return this.trailerDamage;
        }
        public double getMassTrailer() {
            return this.massTrailer;
        }
        public string getSourceCity() {
            return this.sourceCity;
        }
        public string getSourceCompany() {
            return this.sourceCompany;
        }
        public string getDestinyCity() {
            return this.destinyCity;
        }
        public string getDestinyCompany() {
            return this.destinyCompany;
        }
        public string getIdTrailer() {
            return this.idTrailer;
        }
        public string getTrailerName() {
            return this.nameTrailer;
        }
        public bool getTrailerAttached()
        {
            return this.attachedTrailer;
        }
        public double getTruckFuel()
        {
            return truckFuel;
        }
        public bool getEngineOn()
        {
            return engineOn;
        }
    
    }
}
