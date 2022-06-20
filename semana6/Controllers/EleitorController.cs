using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace semana6.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EleitorController : ControllerBase
    {
        [HttpGet]
        public List<Eleitor> Listar()
        {
            List<Eleitor> eleitores = new List<Eleitor>();

            Eleitor eleitor1 = new Eleitor
            {
                Id = 1,
                Cpf = "102.102.333-55",
                Nome = "Chewbacca de Almeida"
            };

            eleitores.Add(eleitor1);

            Eleitor eleitor2 = new Eleitor
            {
                Id = 2,
                Cpf = "999.888.777-66",
                Nome = "Tilápia Souza"
            };

            eleitores.Add(eleitor2);

            Eleitor eleitor3 = new Eleitor
            {
                Id = 3,
                Cpf = "111.222.333-44",
                Nome = "Baccachew Silva"
            };

            eleitores.Add(eleitor3);

            return eleitores;
        }

        [HttpPost]
        public string Cadastrar([FromBody]Eleitor novoEleitor)
        {
            return "Eleitor(a) cadastrado(a) com sucesso!";
        }

        [HttpPut]
        public string Alterar([FromBody]Eleitor eleitor)
        {
            return "Eleitor(a) alterado(a) com sucesso!";
        }

        [HttpGet]
        public Eleitor Consultar(int idEleitor)
        {
            return new Eleitor 
            { 
                Id = 1,
                Cpf = "102.102.333-55",
                Nome = "Chewbacca de Almeida"
            };
        }

        [HttpDelete("{idEleitor}")]
        public string Excluir(int idEleitor)
        {
            return "Eleitor(a) excluído(a) com sucesso!";
        }
    }
}