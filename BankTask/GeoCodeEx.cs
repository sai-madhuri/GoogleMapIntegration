using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace BankTask
{
    class GeoCodeEx
    {
        //public static Coordinate GetCoordinates(string region)
       // {
        //    using (var client = new WebClient())
        //    {
        //        string uri = "https://maps.googleapis.com/maps/api/geocode/json?address=&#8221;" + region + "&key=AIzaSyA89izrN_Pi3G-rjT6Qi8PvtzpdGv3UIIQ";
        //        string url1 = "https://maps.googleapis.com/maps/api/geocode/json?address=1301%20lombard%20street%20philadelphia&key=AIzaSyA89izrN_Pi3G-rjT6Qi8PvtzpdGv3UIIQ";

        //        string geocodeInfo = client.DownloadString(url1);
        //        object o = JsonConvert.DeserializeObject(geocodeInfo);
                //string json2 = JsonConvert.SerializeObject(o, Formatting.Indented);
               // GoogleGeoCodeResp latlongdata =(GoogleGeoCodeResp)o;

                //return new Coordinate(Convert.ToDouble(latlongdata.results[0].geometry.location.lat), Convert.ToDouble(latlongdata.results[0].geometry.location.lng));
          //  }
      //  }

        public struct Coordinate
        {
            private double lat;
            private double lng;

            public Coordinate(double latitude, double longitude)
            {
                lat = latitude;
                lng = longitude;

            }

            public double Latitude { get { return lat; } set { lat = value; } }
            public double Longitude { get { return lng; } set { lng = value; } }

        }
    }
}
