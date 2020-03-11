using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Model Define for bus reservation
namespace OnlineBusReservationV6.Models
{
    public class BusDriverView
    {
        public Bus Bus { get; set; }

        public List<Driver> Drivers { get; set; }
            
    }
}