using CRUD_APP_MVC_Dapper.Models;
using CRUD_APP_MVC_Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_APP_MVC_Dapper.Controllers
{
    public class CarController : Controller
    {

        public ActionResult Index()
        {
            CarRepository EmpRepo = new CarRepository();
            return View(EmpRepo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Car Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CarRepository EmpRepo = new CarRepository();
                    EmpRepo.Create(Emp);
                    ViewBag.Message = "Records added successfully.";
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id, Car c)
        {
            CarRepository cr = new CarRepository();

            cr.Update(c);

            return RedirectToAction("GetAllEmpDetails"); ;
        }

        [HttpPost]
        public ActionResult Details(int id, Car c)
        {
            CarRepository EmpRepo = new CarRepository();
            EmpRepo.Get(c);
            return RedirectToAction("Index");


        }

        public ActionResult Delete(int id, Car c)
        {
            CarRepository EmpRepo = new CarRepository();
            EmpRepo.Get(c);
            return RedirectToAction("Index");
        }
    }
}

