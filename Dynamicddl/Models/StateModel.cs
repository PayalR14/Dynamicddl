using Dynamicddl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dynamicddl.Models
{
    public class StateModel
    {
        public int State_Id { get; set; }
        public string State_Name { get; set; }
        public List<StateModel> GetStateName()
        {
            DynamicddlEntities db = new DynamicddlEntities();
            List<StateModel> lstSname = new List<StateModel>();
            var SName = db.tblStates.ToList();
            if (SName != null)
            {
                foreach (var s in SName)
                {
                    lstSname.Add(new StateModel
                    {
                        State_Id = s.State_Id,
                        State_Name = s.State_Name,
                    });
                }

            }
            return lstSname;
        }
    }
}