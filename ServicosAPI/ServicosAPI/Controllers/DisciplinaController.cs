using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositorio;
using Repositorio.Models;
using ServicosAPI.Mapper;
using ServicosAPI.Models;

namespace ServicosAPI.Controllers
{
    public class DisciplinaController : ApiController
    {
        since2013bdEntities db = new since2013bdEntities();

        //List<Aluno> lista = null;

        public List<Disciplina> Get()
        {
            var results = db.Disciplinas.ToList();
            return results;
        }

        public void Post(string nome)
        {
            Disciplina obj = new Disciplina();

            obj.disc_nome = nome;
           (new DisciplinaRepositorio()).inserir(obj);



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
        */

        //DELETE: api/Alunos/5


        public void Delete(string nome)
        {


            Disciplina obj = new Disciplina();

            obj.disc_nome = nome;

            if (nome != "")
            {
                (new DisciplinaRepositorio()).excluir(obj);
            }
            //var results = db.Alunos.ToList();
            //results.RemoveAt(results.IndexOf(results.First(x => x.alu_nome.Equals(nome))));

        }
    }
}
