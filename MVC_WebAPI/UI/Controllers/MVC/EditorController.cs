using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLayer.DBLayer;
using DataLayer.Repositories;

namespace UI.Controllers.MVC
{
    public class EditorController : Controller
    {

        //IGenericRepository<Rent> _repository;
        //public EditorController(IGenericRepository<Rent> repository)
        //{
        //    _repository = repository;
        //}



        private RentDBModel db = new RentDBModel();

        // GET: Rents
        public async Task<ActionResult> Index()
        {
            return View(await db.Rents.ToListAsync());
        }

        // GET: Rents/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rent rent = await db.Rents.FindAsync(id);
            if (rent == null)
            {
                return HttpNotFound();
            }
            return View(rent);
        }

        // GET: Rents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RentId,RentName,dogovor,DateStart,DateEnd,EDRPOU,Telephon,ContactaName,LegalAddress,RentAddress,SquareArea,Credit,Debet,Latitude,Longitude")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                db.Rents.Add(rent);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(rent);
        }

        // GET: Rents/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rent rent = await db.Rents.FindAsync(id);
            if (rent == null)
            {
                return HttpNotFound();
            }
            return View(rent);
        }

        // POST: Rents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RentId,RentName,dogovor,DateStart,DateEnd,EDRPOU,Telephon,ContactaName,LegalAddress,RentAddress,SquareArea,Credit,Debet,Latitude,Longitude")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rent).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(rent);
        }

        // GET: Rents/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rent rent = await db.Rents.FindAsync(id);
            if (rent == null)
            {
                return HttpNotFound();
            }
            return View(rent);
        }

        // POST: Rents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Rent rent = await db.Rents.FindAsync(id);
            db.Rents.Remove(rent);
            await db.SaveChangesAsync();
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
