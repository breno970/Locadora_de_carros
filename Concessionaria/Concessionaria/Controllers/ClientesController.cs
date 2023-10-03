using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConcessionariaWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace Concessionaria.View.Controllers
{
    public class ClientesController : Controller
    {
        // GET: FuncionariosController
        ConcessionariaContext odb;
        public ClientesController()
        {
            odb = new ConcessionariaContext();
        }
        public ActionResult Index()
        {
            List<Clientes> oClientes = odb.Clientes.ToList();
            return View(oClientes);
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int ID)
        {
            if (ID != null)
            {
                Clientes oCat = odb.Clientes.Find(ID);
                return View(oCat);
            }
            else return NotFound();
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Clientes oCat)
        {
            odb.Clientes.Add(oCat);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int? ID)
        {
            if (ID != null)
            {
                Clientes oCat = odb.Clientes.Find(ID);
                return View(oCat);
            }
            else return NotFound();

        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ID, Clientes oCat)
        {

            var oCatBanco = odb.Clientes.Find(ID);
            oCatBanco.ID = oCat.ID;
            oCatBanco.cliente = oCat.cliente;
            oCatBanco.CEP = oCat.CEP;
            oCatBanco.endereço = oCat.endereço;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int ID)
        {
            if (ID != null)
            {
                Clientes oCat = odb.Clientes.Find(ID);
                return View(oCat);
            }
            else return NotFound();
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ID, Clientes oCat)
        {


            var oCatBanco = odb.Clientes.Find(ID);
            oCatBanco.ID = oCat.ID;
            oCatBanco.cliente = oCat.cliente;
            oCatBanco.CEP = oCat.CEP;
            oCatBanco.endereço = oCat.endereço;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
