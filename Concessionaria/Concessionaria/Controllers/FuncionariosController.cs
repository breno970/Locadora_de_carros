using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConcessionariaWeb.Model;

namespace Concessionaria.View.Controllers
{
    public class FuncionariosController : Controller
    {
        // GET: FuncionariosController
        ConcessionariaContext odb;
        public FuncionariosController()
        {
            odb = new ConcessionariaContext();
        }
        public ActionResult Index()
        {
            List<Funcionario> oFuncionario = odb.Funcionario.ToList();
            return View(oFuncionario);
        }

        // GET: FuncionariosController/Details/5
        public ActionResult Details(int ID)
        {
            if (ID != null)
            {
                Funcionario oCat = odb.Funcionario.Find(ID);
                return View(oCat);
            }
            else return NotFound();
        }

        // GET: FuncionariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuncionariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario oCat)
        {
           odb.Funcionario.Add(oCat);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: FuncionariosController/Edit/5
        public ActionResult Edit(int? ID)
        {
            if (ID != null)
            {
                Funcionario oCat = odb.Funcionario.Find(ID);
                return View(oCat);
            }
            else return NotFound();
        }

        // POST: FuncionariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ID, Funcionario oCat)
        {
            

            var oCatBanco = odb.Funcionario.Find(ID);
            oCatBanco.nome = oCat.nome;
            oCatBanco.email = oCat.email;
            oCatBanco.CPF = oCat.CPF;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: FuncionariosController/Delete/5
        public ActionResult Delete(int ID)
        {
            if (ID != null)
            {
                Funcionario oCat = odb.Funcionario.Find(ID);
                return View(oCat);
            }
            else return NotFound();
        }

        // POST: CarrosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ID, Funcionario oCat)
        {


            var oCatBanco = odb.Funcionario.Find(ID);
            oCatBanco.nome = oCat.nome;
            oCatBanco.email = oCat.email;
            oCatBanco.CPF = oCat.CPF;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
