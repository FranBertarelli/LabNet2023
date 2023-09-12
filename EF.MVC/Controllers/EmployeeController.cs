using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF.Entities;
using EF.Logic;
using EF.MVC.Models;

namespace EF.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeesLogic logic = new EmployeesLogic();

        // GET: Employee
        public ActionResult Index()
        {
            var employees = logic.GetAll();
            return View(employees);
        }

        public ActionResult Insert()
        {
            return View(new EmployeeView());
        }

        [HttpPost]
        public ActionResult Insert(EmployeeView model)
        {
            if (ModelState.IsValid)
            {
                logic.Add(new Employees
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Title = model.Title
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Update(int id)
        {
            var employee = logic.GetById(id);
            var model = new EmployeeView
            {
                Id = employee.EmployeeID,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Title = employee.Title
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(EmployeeView model)
        {
            if (ModelState.IsValid)
            {
                var employee = logic.GetById(model.Id);
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.Title = model.Title;
                logic.Update(employee);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}