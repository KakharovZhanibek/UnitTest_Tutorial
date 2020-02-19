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
            _lst = new List<string>();
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
                new City{Id=1,Name="Madrid"}
            };
        }
    }
}