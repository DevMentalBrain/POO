using sistema.Classes;

List<Funcionario> funcionariosCadastrados =  new List<Funcionario>();

Funcionario beto = new FuncionarioRegular("Beto", 20, 1500);
Funcionario fatima = new Gerente("Fatima", 40, 5700, 300);
Funcionario douglas = new Diretor("Douglas", 37, 8750, 15);

funcionariosCadastrados.Add(beto);
funcionariosCadastrados.Add(fatima);
funcionariosCadastrados.Add(douglas);

foreach(Funcionario funcionario in funcionariosCadastrados)
{
    if(funcionario is Gerente)
    {
        Gerente gerente = (Gerente)funcionario;
        Console.WriteLine($"\n{gerente.Nome} é Gerente e tem um bonus de R${gerente.Bonus} por mês.");
        Console.WriteLine($"O salario do(a) {gerente.Nome} foi de R${gerente.CalcularSalario()} esse mês.");
        gerente.AumentarSalario(10);
        Console.WriteLine($"O {gerente.Nome} teve um aumento de 10% esse mês, seu salario atual é de R${gerente.CalcularSalario()}");
    }
    else if (funcionario is Diretor)
    {
        Diretor diretor = (Diretor)funcionario;
        Console.WriteLine($"\n{diretor.Nome} é um Diretor e teve uma participação de {diretor.ParticipacaoMensal}% esse mês.");
        Console.WriteLine($"O salario do {diretor.Nome} foi de R${diretor.CalcularSalario()} esse mês.");
        diretor.AumentarSalario(7);
        Console.WriteLine($"O {diretor.Nome} teve um aumento de 7% esse mês, seu salario atual é de R${diretor.CalcularSalario()}");
    }
    else
    {
        Console.WriteLine($"\n{funcionario.Nome} é um Funcionario e tem o salario de R${funcionario.SalarioBase}");
        Console.WriteLine($"O salario do {funcionario.Nome} foi de R${funcionario.CalcularSalario()} esse mês.");
    }
}