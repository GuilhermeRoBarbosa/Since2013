﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Models
{  
    public class AlunoRepositorio
    {
        // private static List<Aluno> alunos = new List<Aluno>();

        public void inserir(Aluno obj)
        {
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                db.Alunos.Add(obj);
                db.SaveChanges();
            }
        }
       
        public Aluno Localizar()
        {
            Aluno lista = null;
            using (since2013bdEntities db = new since2013bdEntities())
            {
                lista = (from u in db.Alunos
                         select u
                         ).FirstOrDefault();    
            }
            return lista;
        }

        public List<Aluno> Localizar2(string nome)
        {
            List<Aluno> lista = null;
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                lista = (from al in db.Alunos
                         where al.alu_nome.Contains(nome)
                         orderby al.alu_nome
                         select al
                         ).ToList();
            }
            return lista;
        }


        public void excluir(Aluno alu)
        {
            using (since2013bdEntities db =
                new since2013bdEntities())
            {
                //alterar status para excluido
                db.Entry(alu).State =
                    System.Data.Entity.EntityState.Deleted;
                //salvar
                db.SaveChanges();
            }

        }


    }
}
