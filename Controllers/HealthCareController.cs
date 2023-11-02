using RazorCodeApp.DoctorRepository;
using RazorCodeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorCodeApp.Controllers
{
    public class HealthCareController : Controller
    {
        // GET: HealthCare
        public ActionResult Index()
        {
            DoctorData repository = new DoctorData();
            DoctorsData obj = new DoctorsData();
            obj.DoctorList = repository.GetAllDoctors();
            return View(obj);
        }
    }
}