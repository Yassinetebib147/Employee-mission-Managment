using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_Dotnet.Models
{
    public class Mission
    {
        public int id_Mission { get; set; }
        public String nom_Mission { get; set; }
        public String description_Mission { get; set; }
        public DateTime date_Debut_Mission { get; set; }
        public int duree_Mission { get; set; }
        public String zone_Mission { get; set; }




    }
}