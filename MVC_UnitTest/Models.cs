using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_UnitTest
{
    public class Models
    {
    }
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Service
    {
        private List<string> _lst;
        public Service(int ICount)
        {
            for (int i = 0; i < ICount; i++)
            {
                _lst.Add(i.ToString());
            }
        }
        public List<string> getArray
        {
            get {
                return _lst;
            }
        }
        public List<City> Lst()
        {
            return new List<City>()
            {
                new City{Id=1,Name="Astana"},
                new City{Id=2,Name="Madrid"},
                new City{Id=3,Name="Geneva"}
            };
        }
    }
}