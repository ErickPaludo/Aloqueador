namespace Paletes
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Altura do produto:");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Comprimento do produto:");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Largura do produto:");
                double l = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de itens:");
                int i = int.Parse(Console.ReadLine());
                double m = (a / 100) * (c / 100) * (l / 100);
                double itenspalete = Math.Round(1.92 / m);
                Console.WriteLine($"\nCobagem do produto é de {m.ToString("f4")}m³\n");
                Console.WriteLine($"O palete possui 1,92m³, nele caberão {itenspalete.ToString("f0")} itens\n");
                Console.WriteLine($"Cubagem de todos os paletes: {(i * m).ToString("f4")}m³\n");


                double paletecompleto = (i * m) / 1.92;


                for (int j = 0; j <= (int)paletecompleto; j++)
                {
                    if (j < (int)paletecompleto)
                    {
                        Console.WriteLine($"Palete {j + 1} - {itenspalete} itens (completo)");
                    }
                    else
                    {
                        Console.WriteLine($"Palete {j + 1} - {i - ((int)paletecompleto * itenspalete)}/{itenspalete} itens (incompleto)");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
