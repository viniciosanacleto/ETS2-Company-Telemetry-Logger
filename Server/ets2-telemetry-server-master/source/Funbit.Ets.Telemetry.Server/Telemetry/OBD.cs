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

namespace Funbit.Ets.Telemetry.Server.Telemetry
{
    class OBD
    {
        private string url = "http://localhost:25555/api/ets2/telemetry";
        private string json, gameJson, trailerJson, truckJson, jobJson, navigationJson, sourceCity, sourceCompany, destinyCity, destinyCompany, idTrailer, nameTrailer; //Principal Tokens
        private double massTrailer, trailerDamage;
        private int speed, gear, income;
        private bool attachedTrailer;

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

        public int getSpeed()
        {
            if (this.speed < 0)
            {
                this.speed = this.speed * (-1);
            }
            return this.speed;
        }
        public int getGear()
        {
            return this.gear;
        }
        public int getIncome()
        {
            return this.income;
        }
        public double getTrailerDamage()
        {
            return this.trailerDamage;
        }
        public double getMassTrailer()
        {
            return this.massTrailer;
        }
        public string getSourceCity()
        {
            return this.sourceCity;
        }
        public string getSourceCompany()
        {
            return this.sourceCompany;
        }
        public string getDestinyCity()
        {
            return this.destinyCity;
        }
        public string getDestinyCompany()
        {
            return this.destinyCompany;
        }
        public string getIdTrailer()
        {
            return this.idTrailer;
        }
        public string getTrailerName()
        {
            return this.nameTrailer;
        }
    }
}
