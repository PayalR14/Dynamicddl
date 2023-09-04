using Dynamicddl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dynamicddl.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int State { get; set; }
        public int City { get; set; }
        public string State_Name { get; set; }
        public string City_Name { get; set; }

        public string saveEmployee(EmployeeModel model)
        {
            string msg = "";
            DynamicddlEntities db= new DynamicddlEntities();
            {
                var EmployeeData = new tblEmployee()
                {
                    FirstName = model.FirstName,
                    Lastname = model.Lastname,
                    Email = model.Email,
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                };
                db.tblEmployees.Add(EmployeeData);
                db.SaveChanges();
                return msg;
            }
            
        }
        public List<EmployeeModel> GetEmpList(EmployeeModel model)
        {
            DynamicddlEntities db=new DynamicddlEntities();
            List<EmployeeModel>lstEmpList= new List<EmployeeModel>();
            var Employeedata = (from e in db.tblEmployees
                                join s in db.tblStates on e.State equals s.State_Id
                                join c in db.tblCities on e.City equals c.City_Id

                                select new
                                {
                                    e.Id,
                                    e.FirstName,
                                    e.Lastname,
                                    e.Email,
                                    e.Address,
                                    s.State_Name,
                                    c.City_Name
                                });
            if (Employeedata != null)
            {

                foreach(var Employee in Employeedata)
                {
                    lstEmpList.Add(new EmployeeModel()
                    {
                        Id = Employee.Id,
                        FirstName = Employee.FirstName,
                        Lastname = Employee.Lastname,
                        Email = Employee.Email,
                        Address = Employee.Address,
                        State_Name = Employee.State_Name,
                        City_Name = Employee.City_Name,
                    });
                }
            }
            return lstEmpList;

        }


    }
}