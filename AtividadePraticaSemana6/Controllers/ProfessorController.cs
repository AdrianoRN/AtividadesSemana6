using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtivIdColabProfadePraticaSemana6.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        [HttpGet]
        public List<Professor> Listar()
        {
            List<Professor> Professores = new List<Professor>();

            Professor Professor1 = new Professor
            {
                IdColabProf = 1,
                CpfProf = "000.000.000-01",
                NomeProf = "Yoda"
            };

            Professores.Add(Professor1);

            Professor Professor2 = new Professor
            {
                IdColabProf = 2,
                CpfProf = "666.888.777-78",
                NomeProf = "Obiwan Kenobi"
            };

            Professores.Add(Professor2);

            Professor Professor3 = new Professor
            {
                IdColabProf = 3,
                CpfProf = "222.222.333-54",
                NomeProf = "Luke Skywalker"
            };

            Professores.Add(Professor3);

            return Professores;
        }

        [HttpPost]
        public string Cadastrar([FromBody]Professor novoProfessor)
        {
            return "Professor(a) cadastrado(a) com sucesso!";
        }

        [HttpPut]
        public string Alterar([FromBody]Professor Professor)
        {
            return "Professor(a) alterado(a) com sucesso!";
        }

        [HttpGet]
        public Professor Consultar(int IdColabProfProfessor)
        {
            return new Professor 
            { 
                IdColabProf = 1,
                CpfProf = "666.666.666-66",
                NomeProf = "Anakin Skywalker"
            };
        }

        [HttpDelete("{IdColabProfProfessor}")]
        public string Excluir(int IdColabProfProfessor)
        {
            return "Professor(a) excluído(a) com sucesso!";
        }
    }
}