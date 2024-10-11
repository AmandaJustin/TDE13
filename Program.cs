 Empresa empresa = new Empresa();
 Funcionario func1 = new Funcionario("Alberto", 26);
 Gerente gerente = new Gerente("Lucas", 30, 2000);
 Estagiario estagiario = new Estagiario("Pedro", 18);

 empresa.AdicionarFuncionario(func1);
 empresa.AdicionarFuncionario(gerente);
 empresa.AdicionarFuncionario(estagiario);

 empresa.ListarFuncionarios();
