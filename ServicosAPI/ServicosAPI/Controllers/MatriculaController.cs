using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Web.Http;
using Repositorio;
using Repositorio.Models;
using ServicosAPI.Mapper;
using ServicosAPI.Models;

namespace ServicosAPI.Controllers
{
    public class MatriculaController : ApiController
    {
        since2013bdEntities db = new since2013bdEntities();

        //List<Aluno> lista = null;

        public List<Matricula> Get()
        {
            var results = db.Matriculas.ToList();
            return results;
        }

        public void Post(decimal nota1, decimal nota2)
        {
           
            Matricula obj = new Matricula();

            
                decimal media = (nota1 + nota2)/2;
                obj.mat_nota1 = nota1;
                obj.mat_nota2 = nota2;
                obj.mat_media = media;

                if (media >= 7)
                {
                  obj.mat_status = "Aprovado";
                }
                else
                {
                  obj.mat_status = "Reprovado";
                }         

                (new MatriculaRepositorio()).inserir(obj);

            

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


        public void Delete(int cod)
        {


            Matricula obj = new Matricula();

            obj.mat_cod = cod;

           (new MatriculaRepositorio()).excluir(obj);
         
        }
    }
}
