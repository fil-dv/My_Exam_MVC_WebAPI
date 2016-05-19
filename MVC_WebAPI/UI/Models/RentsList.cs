using DataLayer.DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class RentsList
    {
     
        public List<Rent> RentList { get; set; }

        public RentsList(List<Rent> list)
        {
            RentList = list;
        }
    }
}