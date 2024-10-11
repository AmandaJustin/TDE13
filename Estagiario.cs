public class Estagiario : Funcionario
{
    public override double CalcularSalario()
    {
        return base.CalcularSalario()/2;
    }

    public Estagiario(string nome, int idade) : base(nome, idade)
    {
    }

    
}