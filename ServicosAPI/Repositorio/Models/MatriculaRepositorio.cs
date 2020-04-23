using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Models
{
    public class MatriculaRepositorio
    {

        // private static List<Aluno> alunos = new List<Aluno>();

        public void inserir(Matricula obj)
        {
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                db.Matriculas.Add(obj);
                db.SaveChanges();
            }
        }

        public Matricula Localizar()
        {
            Matricula lista = null;
            using (since2013bdEntities db = new since2013bdEntities())
            {
                lista = (from u in db.Matriculas
                         select u
                         ).FirstOrDefault();
            }
            return lista;
        }

        public Matricula Localizar2(int cod)
        {
            Matricula model = null;
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                model = db.Matriculas.Find(cod);
            }
            return model;
        }


        public void excluir(Matricula mat)
        {
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                //alterar status para excluido
                db.Entry(mat).State =
                    System.Data.Entity.EntityState.Deleted;
                //salvar
                db.SaveChanges();
            }

        }
    }
}
