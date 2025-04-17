using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_escolar.Classes
{
    internal class Escola
    {
        List<Aluno> alunosMatriculados = new List<Aluno>();
        public void CadastrarAluno(string aluno, string cpf)
        {
            Aluno novoAluno = new Aluno();
            novoAluno.SetNome(aluno);
            novoAluno.SetCpf(cpf);
            alunosMatriculados.Add(novoAluno);
        }
    }
}
