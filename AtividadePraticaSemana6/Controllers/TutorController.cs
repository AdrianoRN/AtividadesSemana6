using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtivIdColabTutoradePraticaSemana6.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TutorController : ControllerBase
    {
        [HttpGet]
        public List<Tutor> Listar()
        {
            List<Tutor> Tutores = new List<Tutor>();

            Tutor Tutor1 = new Tutor
            {
                IdColabTutor = 1,
                CpfTutor = "989.102.333-75",
                NomeTutor = "Conde Dookan"
            };

            Tutores.Add(Tutor1);

            Tutor Tutor2 = new Tutor
            {
                IdColabTutor = 2,
                CpfTutor = "899.888.577-43",
                NomeTutor = "Darth Sidious"
            };

            Tutores.Add(Tutor2);

            Tutor Tutor3 = new Tutor
            {
                IdColabTutor = 3,
                CpfTutor = "147.256.333-74",
                NomeTutor = "Darth Maul"
            };

            Tutores.Add(Tutor3);

            return Tutores;
        }

        [HttpPost]
        public string Cadastrar([FromBody]Tutor novoTutor)
        {
            return "Tutor(a) cadastrado(a) com sucesso!";
        }

        [HttpPut]
        public string Alterar([FromBody]Tutor Tutor)
        {
            return "Tutor(a) alterado(a) com sucesso!";
        }

        [HttpGet]
        public Tutor Consultar(int IdColabTutorTutor)
        {
            return new Tutor 
            { 
                IdColabTutor = 1,
                CpfTutor = "102.162.333-66",
                NomeTutor = "Darth Vader"
            };
        }

        [HttpDelete("{IdColabTutorTutor}")]
        public string Excluir(int IdColabTutorTutor)
        {
            return "Tutor(a) excluído(a) com sucesso!";
        }
    }
}