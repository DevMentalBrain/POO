using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_escolar.Classes
{
    internal class Aluno
    {
        private string nome = "";
        private string cpf = "";
        Dictionary<string, double> notas = new Dictionary<string, double>();

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetCpf()
        {
            return this.cpf;
        }

        public void SetNotaAluno(string disciplina, double nota) 
        {
            notas.Add(disciplina, nota);
        }
    }
}
