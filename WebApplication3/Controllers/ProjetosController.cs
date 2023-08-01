using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProjetosController : Controller
    {
        private DBContexto db = new DBContexto();

        // GET: Projetos
        public ActionResult Index()
        {
            return View(db.ProjetosObj.ToList());
        }

        // GET: Projetos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.ProjetosObj.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            return View(projeto);
        }

        // GET: Projetos/Create
        public ActionResult Create()
        {
            var pessoa = db.PessoasObj.ToList();
            ViewBag.ClienteId = new SelectList(pessoa, "Id", "Nome");
            //ViewBag.ClienteId = (from c in db.PessoasObj
            //                     select c).Distinct(); 

            return View();
        }

        // POST: Projetos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,DataInicio,DataPrevisaoFim,DataFim,Descricao,Status,Orcamento,Risco,IdGerente")] Projeto projeto)
        {
            Pessoa pessoa = db.PessoasObj.Find(projeto.IdGerente);

            if (ModelState.IsValid && pessoa.Funcionario)
            {
                projeto.Risco = Enum.GetName(typeof(Models.enums.RiscoEnum),Models.enums.RiscoEnum.baixo_risco);
                projeto.Status = Enum.GetName(typeof(Models.enums.StatusEnum), Models.enums.StatusEnum.iniciado);
                
                var membros = new Membro { IdPessoa = pessoa.Id, Pessoa = pessoa, Projeto = projeto };

                db.ProjetosObj.Add(projeto);
                db.MembrosObj.Add(membros);
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projeto);
        }

        // GET: Projetos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.ProjetosObj.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            return View(projeto);
        }

        // POST: Projetos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,DataInicio,DataPrevisaoFim,DataFim,Descricao,Status,Orcamento,Risco,IdGerente")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projeto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projeto);
        }

        // GET: Projetos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.ProjetosObj.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            return View(projeto);
        }

        // POST: Projetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projeto projeto = db.ProjetosObj.Find(id);
            db.ProjetosObj.Remove(projeto);
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
