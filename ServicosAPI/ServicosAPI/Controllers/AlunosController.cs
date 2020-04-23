﻿using System;
using System.Collections.Generic;
using System.Dynamic;
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
    public class AlunosController : ApiController
    {
        since2013bdEntities db = new since2013bdEntities();
        
        //List<Aluno> lista = null;

        public List<Aluno> Get()
        {
            var results = db.Alunos.ToList();
            return results;
        }
      
        

        public void Post(string nome, string ra, string telefone)
        {
            Aluno obj = new Aluno();



            obj.alu_nome = nome;
            obj.alu_RA =ra;
            obj.alu_telefone =telefone;

            (new AlunoRepositorio()).inserir(obj);                 
              
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


            Aluno obj = new Aluno();

            obj.alu_nome = nome;

            if (nome != "")
            { 
                (new AlunoRepositorio()).excluir(obj);
            }
            //var results = db.Alunos.ToList();
            //results.RemoveAt(results.IndexOf(results.First(x => x.alu_nome.Equals(nome))));

        }
    }
}
