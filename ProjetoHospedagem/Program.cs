using System.Globalization;
using System.Text;
using ProjetoHospedagem.Models;


Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "David");
Pessoa p2 = new Pessoa(nome: "Marcela");

Suite suite = new Suite(tipoSuite: "Premiun", capacidade: 3, valorDiaria: 30);

hospedes.Add(p1);
hospedes.Add(p2);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

System.Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
System.Console.WriteLine($"Valor diaria: {reserva.CalcularValorDiaria().ToString("F2",CultureInfo.InvariantCulture)}");

