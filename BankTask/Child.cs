using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;

namespace BankTask
{
    public class Child
    {
        public string strAddress = "Noida 201301,India";

        string url = "http://maps.google.com/maps/api/geocode/xml?address=Noida&sensor=false&key=AIzaSyA89izrN_Pi3G-rjT6Qi8PvtzpdGv3UIIQ";

        public DataTable GetdtLatLong(string url)

        {
            WebRequest request = WebRequest.Create(url);

            using (WebResponse response = (HttpWebResponse)request.GetResponse())

            {

                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))

                {

                    DataSet dsResult = new DataSet("Result");

                    dsResult.ReadXml(reader);

                    DataTable dtCoordinates = new DataTable();

                    dtCoordinates.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),

                    new DataColumn("Address", typeof(string)),

                    new DataColumn("Latitude",typeof(string)),

                    new DataColumn("Longitude",typeof(string)) });

                    foreach (DataRow row in dsResult.Tables["result"].Rows)

                    {

                        string geometry_id = dsResult.Tables["geometry"].Select("result_id = " + row["result_id"].ToString())[0]["geometry_id"].ToString();

                        DataRow location = dsResult.Tables["location"].Select("geometry_id = " + geometry_id)[0];

                        dtCoordinates.Rows.Add(row["result_id"], row["formatted_address"], location["lat"], location["lng"]);

                    }

                    DataTable dtGMap = dtCoordinates;

                    return dtGMap;

                }
            }
        }
    }
}