using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositorio;
using Repositorio.Models;

namespace ServicosAPI.Controllers
{
    public class AlunosController : ApiController
    {
        
        // GET: api/Alunos
        //private static List<Aluno> alunos = new List<Aluno>();
       private static List<AlunoRepositorio> lista = new List<AlunoRepositorio>();

        Aluno alu = new Aluno();
        
        
        public List<AlunoRepositorio> Get()
        {
            return lista;
        }

        public void Post(string nome)
        {
            //if (!string.IsNullOrEmpty(nome)) { 
            // alu.alu_nome = nome;
            //  lista.Add(new Aluno(alu.alu_nome));
            // }

            if (!string.IsNullOrEmpty(nome)) { 
              alu.alu_nome = nome;
                lista.Add(new AlunoRepositorio());

                //lista.Add(new Aluno(alu.alu_nome));
            }


        }


        // GET: api/Alunos/5
        /*public string Get(int id)
        {
            return "value";
        }

        // POST: api/Alunos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Alunos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Alunos/5
        public void Delete(int id)
        {
        }*/
    }
}
