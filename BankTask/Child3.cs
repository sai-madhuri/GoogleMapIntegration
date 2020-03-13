using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;

namespace BankTask
{
    public class Child3 
    {
        public int value;

        public int prop { get; set; }

        User user = new User();
        public void Page_Load()
        {
           var address = "Stavanger, Norway";

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var latitude = point.Latitude;
            var longitude = point.Longitude;
            Console.WriteLine("Latitude : " + latitude);
            Console.Write("Longitude : " + longitude);
        }
    }
}