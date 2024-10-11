    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        
    public override double CalcularSalario()
    {
        return base.CalcularSalario() + Bonus;
    }

        public Gerente(string nome, int idade, double bonus) : base(nome, idade)
    {
        Bonus = bonus;
    }

    }
