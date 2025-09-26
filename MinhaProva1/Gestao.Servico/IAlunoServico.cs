using Gestao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Servico
{
    public interface IAlunoServico
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
    }
}
