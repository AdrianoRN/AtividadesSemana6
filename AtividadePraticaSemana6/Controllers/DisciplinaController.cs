using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtivCodDisciplinaadePraticaSemana6.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        [HttpGet]
        public List<Disciplina> Listar()
        {
            List<Disciplina> Disciplinas = new List<Disciplina>();

            Disciplina Disciplina1 = new Disciplina
            {
                CodDisciplina = 1,
                CargaHoraria = "40 H/A",
                NomeDisciplina = "Desenvolvimento WEBIII"
            };

            Disciplinas.Add(Disciplina1);

            Disciplina Disciplina2 = new Disciplina
            {
                CodDisciplina = 2,
                CargaHoraria = "40 H/A",
                NomeDisciplina = "Projeto Integrador"
            };

            Disciplinas.Add(Disciplina2);

            Disciplina Disciplina3 = new Disciplina
            {
                CodDisciplina = 3,
                CargaHoraria = "40 H/A",
                NomeDisciplina = "Banco de DadosII"
            };

            Disciplinas.Add(Disciplina3);

            return Disciplinas;
        }

        [HttpPost]
        public string Cadastrar([FromBody]Disciplina novoDisciplina)
        {
            return "Disciplina(a) cadastrado(a) com sucesso!";
        }

        [HttpPut]
        public string Alterar([FromBody]Disciplina Disciplina)
        {
            return "Disciplina(a) alterado(a) com sucesso!";
        }

        [HttpGet]
        public Disciplina Consultar(int CodDisciplinaDisciplina)
        {
            return new Disciplina 
            { 
                CodDisciplina = 1,
                CargaHoraria = "35 H/A",
                NomeDisciplina = "Data Science "
            };
        }

        [HttpDelete("{CodDisciplinaDisciplina}")]
        public string Excluir(int CodDisciplinaDisciplina)
        {
            return "Disciplina(a) excluído(a) com sucesso!";
        }
    }
}