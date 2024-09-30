namespace TesteMesa3
{
    public class Investimento
    {
        public double capitalInicial { get; set; }
        public double taxaJurosDiaria { get; set; }
        public DateTime inicioInvestimento { get; set; }
        public DateTime fimInvestimento { get; set; }
        public DateTime dataAtual;
        public double rendimentoTotal;
        public double rendimentoDiario;
        public double taxaTotal;

        public Investimento(double capital, double taxa, DateTime comecoInvestimento, DateTime finalInvestimento)
        {
            capitalInicial = capital;
            taxaJurosDiaria = taxa;
            inicioInvestimento = comecoInvestimento;
            fimInvestimento = finalInvestimento;
        }

        public void Investir()
        {
            while (inicioInvestimento < fimInvestimento)
            {
                taxaTotal = Math.Pow(1 + taxaJurosDiaria / 100, 30) - 1;
                rendimentoDiario = capitalInicial * taxaTotal;
                rendimentoTotal += rendimentoDiario;
                inicioInvestimento = inicioInvestimento.AddDays(1);
            }
            Console.WriteLine(rendimentoTotal);
        }

        public void MostrarInvestimentoFuturo()
        {
            Console.WriteLine("Investimento feito com sucesso!");
            Console.WriteLine($"R${rendimentoTotal:F2}");
        }
    }
}
