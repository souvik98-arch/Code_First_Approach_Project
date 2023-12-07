using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Code_First_Approach_Project.Models;

namespace Code_First_Approach_Project.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext ec = new EmployeeContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View(ec.Employees.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var data = ec.Employees.Where(a => a.Emp_ID == id).FirstOrDefault();
            return View(data);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                ec.Employees.Add(emp);
                ec.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ec.Employees.Where(a => a.Emp_ID == id).FirstOrDefault());
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                ec.Entry(emp).State = EntityState.Modified;
                ec.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ec.Employees.Where(a => a.Emp_ID == id).FirstOrDefault());
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Employee emp = ec.Employees.Where(a => a.Emp_ID == id).FirstOrDefault();
                ec.Employees.Remove(emp);
                ec.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
