using projetodio_dotnet.Model;

Reserva reserva = new Reserva();
reserva.HospedeReserva.Nome = "Guilherme";
reserva.SuiteReserva.NomeSuite = "Presidencial";
reserva.SuiteReserva.Preco = Convert.ToDouble(100.00);
reserva.NumeroDias = 5;

double valorReserva = reserva.CalcularReserva();

Console.WriteLine($"Valor da Reserva : R$ {valorReserva}");