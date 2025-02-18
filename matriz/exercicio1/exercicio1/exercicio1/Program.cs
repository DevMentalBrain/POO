// See https://aka.ms/new-console-template for more information

double[,] notasAlunos = new double[5 , 6];

void zerarVetor(double[,] vetor){
    for (int i = 0; i < vetor.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < vetor.GetLength(1) - 1; j++)
        {
            vetor[i, j] = 0;
        }
    }
}

double solicitarNota(int aluno,int numeroNota)
{
    bool verificarNota = false;
    double notaAluno = 0;
    string notaTeste = "";
    do
    {
        Console.Write($"Informe a {numeroNota} nota do aluno {aluno}: ");
        notaTeste = Console.ReadLine();
        if (double.TryParse(notaTeste, out notaAluno) == false)
            notaAluno = Convert.ToDouble(notaTeste);
            return notaAluno;
    } while (double.TryParse(notaTeste, out notaAluno) == false);
}

void calcularMedia(double[,] vetor, int aluno)
{
    for (int i = 0; i < vetor.GetLength(1) - 1; i++)
    {
        vetor[aluno, vetor.GetLength(1) - 1] += vetor[aluno, i];
    }
    Console.WriteLine($"asdasdasd{vetor[aluno, vetor.GetLength(1) - 1] = vetor[aluno, vetor.GetLength(1) - 1] / vetor.GetLength(1) - 1}");
    vetor[aluno, vetor.GetLength(1) - 1] = vetor[aluno, vetor.GetLength(1) - 1] / vetor.GetLength(1) - 1;
}

//Inicio do programa

//Zera valores Vetor
zerarVetor(notasAlunos);

//Solicita as notas ao usuario
for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        notasAlunos[i,j] = solicitarNota(i + 1, j + 1);
    }
}

//Calcular Média
for(int i = 0; i < 5; i++)
{
    calcularMedia(notasAlunos, i);   
}

//Printar Notas
for(int i = 0;i < 5; i++)
{
    Console.WriteLine($"\nAluno: {i}");
    for (int j = 0;j < 6; j++)
    {
        if(j == 5)
            Console.WriteLine($"Média {j}: [{notasAlunos[i, j]}]");
        else
            Console.WriteLine($"Nota {j}: [{notasAlunos[i, j]}]");
    }
}