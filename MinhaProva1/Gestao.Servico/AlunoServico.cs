using Gestao.Dominio;
using Gestao.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;

        public AlunoServico(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome))
                throw new Exception("O nome do aluno é obrigatório.");

            _repositorio.Adicionar(aluno);
        }

        public List<Aluno> Listar() => _repositorio.Listar();
    }
}
