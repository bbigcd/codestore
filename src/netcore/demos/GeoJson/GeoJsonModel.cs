using System;
using System.Collections.Generic;
namespace GeoJson
{
    public class GeoJsonModel<T>
    {
        public string type { get; set; }
        public List<Features<T>> features { get; set; }
    }

    public class Features<T>
    {
        public string type { get; set; }
        public Geometry<T> geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class Geometry<T>
    {
        public string type { get; set; }
        public List<T> coordinates { get; set; }
    }

    public class Properties
    {
        public string abcode { get; set; }
        public string name { get; set; }
        public string[] center { get; set; }
        public string[] centroid { get; set; }
        public int childrenNum { get; set; }
        public string level { get; set; }
        public int subFeatureIndex { get; set; }
        public string[] acroutes { get; set; }
        public Parent parent { get; set; }
    }

    public class Parent
    {
        public string abcode { get; set; }
    }
}