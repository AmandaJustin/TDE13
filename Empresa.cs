public class Empresa
{
    private List<Funcionario> Funcionarios;

    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void ListarFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            Console.WriteLine($"Nome do funcionario: {funcionario.Nome}");
            Console.WriteLine($"O salário do funcionario: R${funcionario.CalcularSalario():F2}");
        }
    }
}
