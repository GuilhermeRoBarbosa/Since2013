using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Models
{

   
    public class AlunoRepositorio
    {
        // private static List<Aluno> alunos = new List<Aluno>();

        public void inserir(string nome)
        {
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                db.Alunos.Add(nome);
                db.SaveChanges();
            }
        }
        public List<Aluno> localizar()
        {
            List<Aluno> lista = null;
            using (since2013bdEntities db = new since2013bdEntities())
            {
                lista = (from u in db.Alunos
                         orderby u.alu_nome
                         select u
                         ).ToList();
            }
            return lista;
        }


    }
}
