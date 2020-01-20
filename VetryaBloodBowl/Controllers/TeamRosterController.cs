using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VetryaBloodBowl.DAL;
using VetryaBloodBowl.Models;

namespace VetryaBloodBowl.Controllers
{
    public class TeamRosterController : BaseController
    {

        // GET: TeamRoster
        public ActionResult Index()
        {
            return View(context.TeamRoster.ToList());
        }

        // GET: TeamRoster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamRoster teamRoster = context.TeamRoster.Find(id);
            if (teamRoster == null)
            {
                return HttpNotFound();
            }
            return View(teamRoster);
        }

        // GET: TeamRoster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamRoster/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,RerollMaxQuantity,RerollCost,SpecialRules")] TeamRoster teamRoster)
        {
            if (ModelState.IsValid)
            {
                context.TeamRoster.Add(teamRoster);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teamRoster);
        }

        // GET: TeamRoster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamRoster teamRoster = context.TeamRoster.Find(id);
            if (teamRoster == null)
            {
                return HttpNotFound();
            }
            return View(teamRoster);
        }

        // POST: TeamRoster/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,RerollMaxQuantity,RerollCost,SpecialRules")] TeamRoster teamRoster)
        {
            if (ModelState.IsValid)
            {
                context.Entry(teamRoster).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teamRoster);
        }

        // GET: TeamRoster/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamRoster teamRoster = context.TeamRoster.Find(id);
            if (teamRoster == null)
            {
                return HttpNotFound();
            }
            return View(teamRoster);
        }

        // POST: TeamRoster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeamRoster teamRoster = context.TeamRoster.Find(id);
            context.TeamRoster.Remove(teamRoster);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
