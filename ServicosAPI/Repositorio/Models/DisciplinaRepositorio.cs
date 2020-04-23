using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Models
{
    public class DisciplinaRepositorio
    {

        public void inserir(Disciplina obj)
        {
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                db.Disciplinas.Add(obj);
                db.SaveChanges();
            }
        }

        public Disciplina Localizar()
        {
            Disciplina lista = null;
            using (since2013bdEntities db = new since2013bdEntities())
            {
                lista = (from u in db.Disciplinas
                         select u
                         ).FirstOrDefault();
            }
            return lista;
        }

        public Disciplina Localizar2()
        {
            Disciplina model = null;
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                model = db.Disciplinas.Find();
            }
            return model;
        }

        public void excluir(Disciplina disc)
        {
            using (since2013bdEntities db =
                new since2013bdEntities())  
            {
                //alterar status para excluido
                db.Entry(disc).State =
                    System.Data.Entity.EntityState.Deleted;
                //salvar
                db.SaveChanges();
            }

        }
    }
}
