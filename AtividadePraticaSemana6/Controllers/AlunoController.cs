using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtividadePraticaSemana6.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        public List<Aluno> Listar()
        {
            List<Aluno> Alunos = new List<Aluno>();

            Aluno aluno1 = new Aluno
            {
                NumMatricula = 1,
                CpfAluno = "102.102.333-55",
                NomeAluno = "Chewbacca de AlmeNumMatriculaa"
            };

            Alunos.Add (aluno1);

            Aluno aluno2 = new Aluno
            {
                NumMatricula = 2,
                CpfAluno = "999.888.777-66",
                NomeAluno = "Tilápia Souza"
            };

            Alunos.Add(aluno2);

         Aluno aluno3 = new Aluno
            {
                NumMatricula = 3,
                CpfAluno = "111.222.333-44",
                NomeAluno = "Baccachew Silva"
            };

            Alunos.Add (aluno3);

            return Alunos;
        }

        [HttpPost]
        public string Cadastrar([FromBody] Aluno novoAluno)
        {
            return  "Aluno(a) cadastrado(a) com sucesso!";
        }

        [HttpPut]
        public string Alterar([FromBody] Aluno aluno)
        {
            return  "Aluno(a) alterado(a) com sucesso!";
        }

        [HttpGet]
        public Aluno Consultar(int idAluno)
        {
            return new Aluno 
            { 
                NumMatricula = 1,
                CpfAluno = "102.102.333-55",
                NomeAluno = "Chewbacca de souza"
            };
        }

        [HttpDelete("{idAluno}")]
        public string Excluir(int idAluno)
        {
            return  "Aluno(a) excluído(a) com sucesso!";
        }
    }
}