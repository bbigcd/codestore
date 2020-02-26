using System.Drawing;
using System.Collections.Generic;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace GeoJson
{
    class Program
    {
        const double eps = 1e-6;
        static void Main(string[] args)
        {
            var myJsonString = File.ReadAllText("Json/nanshan.json");
            var myJsonObject = JsonConvert.DeserializeObject<GeoJsonModel<List<List<List<float>>>>>(myJsonString);

            // Console.WriteLine($"{myJsonObject.features[0].geometry.coordinates[0][0].Count}");
            // Console.WriteLine($"{myJsonObject.features[0].geometry.coordinates[1][0].Count}");
            // Console.WriteLine($"{myJsonObject.features[0].geometry.coordinates[2][0].Count}");
            // Console.WriteLine($"{myJsonObject.features[0].geometry.coordinates[3][0].Count}");

            List<float> insidePoint = new List<float> { 113.9553451F, 22.5550498F };
            List<float> outsidePoint = new List<float> { 113.8774108F, 22.5677317F };
            List<float> insidePoint2 = new List<float> { 113.8506317F, 22.5106539F };

            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[0][0].IsPointInPolygon(insidePoint));
            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[1][0].IsPointInPolygon(insidePoint2));
            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[2][0].IsPointInPolygon(insidePoint2));
            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[3][0].IsPointInPolygon(insidePoint2));

            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[0][0].IsPointInPolygon(outsidePoint));
            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[1][0].IsPointInPolygon(outsidePoint));
            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[2][0].IsPointInPolygon(outsidePoint));
            Console.WriteLine(myJsonObject.features[0].geometry.coordinates[3][0].IsPointInPolygon(outsidePoint));
        }

    }
}
