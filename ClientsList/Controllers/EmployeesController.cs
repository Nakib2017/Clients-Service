using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClientsList.DAL;
using ClientsList.Models;
using System.IO;
using ImageResizer;

namespace ClientsList.Controllers
{
    public class EmployeesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,EmployeeName,Honors,Masters,BSC,Diploma,HSC,SSC,SBroad,HBroad,DVersity,HVersity,MVersity,BVersity,HVDepartment,MVDepartment,BVDepartment,DDepartment,DYear,SYear,HYear,HVYear,MVYear,BVYear,FatherName,MotherName,FGovtIdNo,OfficeId,Experience,ImageName,ImageFile,GovtIdNo,PhoneNo,Designation,PresentAddress,permanentAddress,FirstReferenceName,FRAddress,FRPhone,SecondReferenceName,SRAddress,SRPhone,JoinDate,ResignationDate,Description")] Employee employee, HttpPostedFileBase file)
        {
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Files"), fileName);
                file.SaveAs(path);

                ResizeSettings resizeSetting = new ResizeSettings
                {
                    Width = 600,
                    Height = 600

                };
                ImageBuilder.Current.Build(path, path, resizeSetting);

                employee.ImageName = fileName;
                //photo.OtherName = fileName;
                employee.ImageFile = "~/Files";
                //photo.OtherFile= "~/Files";
            }
            db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,EmployeeName,Honors,Masters,BSC,Diploma,HSC,SSC,SBroad,HBroad,DVersity,HVersity,MVersity,BVersity,HVDepartment,MVDepartment,BVDepartment,DDepartment,DYear,SYear,HYear,HVYear,MVYear,BVYear,FatherName,MotherName,FGovtIdNo,OfficeId,Experience,ImageName,ImageFile,GovtIdNo,PhoneNo,Designation,PresentAddress,permanentAddress,FirstReferenceName,FRAddress,FRPhone,SecondReferenceName,SRAddress,SRPhone,JoinDate,ResignationDate,Description")] Employee employee, HttpPostedFileBase file)
        {
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Files"), fileName);
                file.SaveAs(path);

                ResizeSettings resizeSetting = new ResizeSettings
                {
                    Width = 600,
                    Height = 600

                };
                ImageBuilder.Current.Build(path, path, resizeSetting);

                employee.ImageName = fileName;
                //photo.OtherName = fileName;
                employee.ImageFile = "~/Files";
                //photo.OtherFile= "~/Files";
            }
            db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
