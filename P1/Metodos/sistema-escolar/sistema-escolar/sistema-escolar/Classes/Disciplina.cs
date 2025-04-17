using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_escolar.Classes
{
    internal class Disciplina
    {
        private string nome;
        private double notaMinimaAprovacao;
        List<Aluno> alunos;

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetNotaMinimaAprovacao(double nota)
        {
            notaMinimaAprovacao = nota;
        }

        public string GetNome(string nome)
        {
            return this.nome;
        }

        public double GetNotaMinimaAprovacao()
        {
            return notaMinimaAprovacao;
        }

        public void CadastrarAluno(Aluno aluno)
        {
            if (alunos. Contains(aluno) == true)
            {
                Console.WriteLine($"O aluno {aluno.GetNome} já esta cadastrado em nosso sistema");
            }

            alunos.Add(aluno);

            if (alunos.Contains(aluno) == true)
            {
                Console.WriteLine($"Aluno {aluno.GetNome} foi cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Ocorreu um problema com o cadastro, tente novamente!");
            }
        }
    }
}
