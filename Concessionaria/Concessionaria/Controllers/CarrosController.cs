using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConcessionariaWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace Concessionaria.View.Controllers
{
    public class CarrosController : Controller
    {
        // GET: FuncionariosController
        ConcessionariaContext odb;
        public CarrosController()
        {
            odb = new ConcessionariaContext();
        }
        public ActionResult Index()
        {
            List<Veiculo> oVeiculo = odb.Veiculo.ToList();
            return View(oVeiculo);
        }

        // GET: CarrosController/Details/5
        public ActionResult Details(int ID)
        {
            if (ID != null)
            {
                Veiculo oCat = odb.Veiculo.Find(ID);
                return View(oCat);
            }
            else return NotFound();
        }

        // GET: CarrosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarrosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Veiculo oCat)
        {
            odb.Veiculo.Add(oCat);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CarrosController/Edit/5
        public ActionResult Edit(int? ID)
        {
            if (ID != null)
            {
                Veiculo oCat = odb.Veiculo.Find(ID);
                return View(oCat);
            }
            else return NotFound(); 
            
        }

        // POST: CarrosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ID, Veiculo oCat)
        {
            
            var oCatBanco = odb.Veiculo.Find(ID);
            oCatBanco.marca = oCat.marca;
            oCatBanco.modelo = oCat.modelo;
            oCatBanco.anoFabricacao = oCat.anoFabricacao;
            oCatBanco.valor = oCat.valor;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CarrosController/Delete/5
        public ActionResult Delete(int ID)
        {
            if (ID != null)
            {
                Veiculo oCat = odb.Veiculo.Find(ID);
                return View(oCat);
            }
            else return NotFound();
        }

        // POST: CarrosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ID, Veiculo oCat)
        {


            var oCatBanco = odb.Veiculo.Find(ID);
            oCatBanco.marca = oCat.marca;
            oCatBanco.modelo = oCat.modelo;
            oCatBanco.anoFabricacao = oCat.anoFabricacao;
            oCatBanco.valor = oCat.valor;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
