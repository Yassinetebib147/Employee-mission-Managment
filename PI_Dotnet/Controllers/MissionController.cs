using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PI_Dotnet.Models;
using PI_Dotnet.ViewModels;

namespace PI_Dotnet.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission/AllMissions
        public ActionResult AllMissions()
        {
            var missions = new List<Mission>
            { new Mission() { nom_Mission = "Super Ninif Sans plomb", zone_Mission = "Ariana", duree_Mission = 1 },
             new Mission() { nom_Mission = "Super Yassine Sans plomb", zone_Mission = "Ariana", duree_Mission = 3 },
             new Mission() { nom_Mission = "Super 3ézdin Sans plomb", zone_Mission = "Ariana", duree_Mission = 2}

            };

            var viewModel = new AllMissionViewModel()
            { Missions = missions };
            return View(viewModel);
        }
        // GET: Mission/DetailsMission
        public ActionResult DetailsMission()
        {
            var mission = new Mission()
            {
                nom_Mission = "Katouss falouss",
                id_Mission = 1,
                date_Debut_Mission = DateTime.Now,
                description_Mission = " Zoghlola Zoghlola Sikimi Bikini",
                zone_Mission = " Hammamet "
            };
            return View(mission);

        }
    }
}