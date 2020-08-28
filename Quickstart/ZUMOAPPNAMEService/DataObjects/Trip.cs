using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace MyTripPlannerService.DataObjects
{
    public class Trip : EntityData
    {
        public string name { get; set; }
        public bool complete { get; set; }
        public string startDate { get; set; }

    }
}