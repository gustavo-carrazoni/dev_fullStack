using Semana_04.Classes;


Cliente cliente = new Cliente("Gus", DateTime.Parse("12/04/1995"), "Monitor", Semana_04.Classes.Enum.EstadoCivil.SOLTEIRO, Semana_04.Classes.Enum.TipoPessoa.FISICA);

Console.WriteLine($"Foi cadastrado o cliente chamado {cliente.Nome}, nascido em {cliente.Nascimento:d}," +
    $" trabalha como {cliente.Profissao}," +
    $" {cliente.EstadoCivil}, pessoa {cliente.TipoPessoa}.");
