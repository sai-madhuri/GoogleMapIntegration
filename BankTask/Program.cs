using System;
using System.Data;
using static BankTask.GeoCodeEx;

namespace BankTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //User user = new User();
            // Console.Write("Enter your name : ");
            // user.Name = Console.ReadLine();

            PartialClass partialClass = new PartialClass();
            partialClass.Read();

            //Child child = new Child();
            //string url = "http://maps.google.com/maps/api/geocode/xml?address=Noida 201301,India& sensor=false";
            //DataTable dtGMap = child.GetdtLatLong(url);

            // Console.Write(dtGMap.Columns[0]);

           // Coordinate coordinate = new Coordinate();
           // coordinate = GetCoordinates("New York");
           // Console.WriteLine("New York: Latitude: { 0} and Longitude : { 1}", coordinate.Latitude, coordinate.Longitude);
          //  coordinate = GetCoordinates("8.8.8.8");
           // Console.WriteLine("8.8.8.8 : Latitude: { 0} and Longitude : { 1}", coordinate.Latitude, coordinate.Longitude);
           // coordinate = GetCoordinates("90001");
          //  Console.WriteLine("90001 : Latitude: { 0} and Longitude : { 1}", coordinate.Latitude, coordinate.Longitude);

            Console.ReadLine();
        }
    }
}
