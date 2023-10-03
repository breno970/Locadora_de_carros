using NUnit.Framework;
using ConcessionariaWeb.Model;
using System;

namespace ConcessionariaWeb.TESTE
{
    public class TesteFuncionario
    {
        ConcessionariaContext db;
        [SetUp]
        public void Setup()
        {
            db = new ConcessionariaContext();


        }

        [Test]
        public void Incluir()
        {
          
                Funcionario ocat = new Funcionario();
                ocat.nome = "Inclus�o:" + DateTime.Now.ToString("HH:mm:ss");
                db.Funcionario.Add(ocat);
                db.SaveChanges();
                Assert.Pass();
            }
    
        [Test]
        public void Alterar()
        {
            Funcionario ?ocat = db.Funcionario.Find(1);
            if(ocat!= null)
            {
                ocat.nome = "Altera��o" + DateTime.Now.ToString("HH:mm:ss");
                db.Entry(ocat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Assert.Pass();
            }
            else
            {
                Assert.Fail("N�o encontrou um nome para alterar");
            }

           
        }
    }
}