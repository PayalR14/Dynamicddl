using Dynamicddl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dynamicddl.Models
{
    public class CityModel
    {
        public int City_Id { get; set; }
        public string City_Name { get; set; }
        public int State_Id { get; set; }
        public List<CityModel>GetCityNameddl(int State_Id)
        {
            DynamicddlEntities db= new DynamicddlEntities();    
            List<CityModel>lstCity=new List<CityModel>();
            var CityData=db.tblCities.Where(p=>p.State_Id==State_Id).ToList();
            if (CityData != null)
            {
                foreach(var city in CityData)
                {
                    lstCity.Add(new CityModel()
                    {
                        State_Id = city.State_Id,
                        City_Id = city.City_Id,
                        City_Name = city.City_Name,
                    });
                }
            }
            return lstCity;
        }

    }
}

