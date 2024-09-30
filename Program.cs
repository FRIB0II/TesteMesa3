namespace TesteMesa3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine(new string('-', 25));
            Console.WriteLine("Escolha uma das opções abaixo para mexer com seus investimentos: ");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("Sair do sistema - 0");
            Console.WriteLine("Iniciar um investimento - 1");
            Console.WriteLine(new string('-', 25));

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:
                    Environment.Exit(1);
                    break;
                case 1:
                    InstanciarInvestimento();
                    Console.ReadKey();
                    Menu();
                    break;;
            }
        }

        static Investimento InstanciarInvestimento()
        {
            Console.WriteLine("");

            Console.Write("Informe o capital inicial: R$");
            double capitalInicial = double.Parse(Console.ReadLine());

            Console.Write("Informe a taxa diária: ");
            double taxaDiaria = double.Parse(Console.ReadLine());

            Console.Write("Informe a data de inicio: ");
            DateTime dataAtual = DateTime.ParseExact(Console.ReadLine(), "d", null);

            Console.Write("Informe a data final: ");
            DateTime dataFinal = DateTime.ParseExact(Console.ReadLine(), "d", null);

            Investimento investimento = new Investimento(capitalInicial, taxaDiaria, dataAtual, dataFinal);
            investimento.Investir();
            investimento.MostrarInvestimentoFuturo();
            return investimento;
        }
    }
}
