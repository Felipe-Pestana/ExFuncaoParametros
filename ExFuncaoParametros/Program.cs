internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        double numero2=10.2;
        Console.WriteLine("Informe um valor para verificar se é Par: ");
        numero = int.Parse(Console.ReadLine());

        //imprime(numero2, numero);


        if (ehPar(numero))
        {
            Console.WriteLine("O valor é Par!");
        }
        else
        {
            Console.WriteLine("O valor é Impar!");
        }

        bool ehPar (int valor)
        {
            bool resposta = false;
            if (valor % 2 == 0)
            {
                resposta = true;
            }
            return resposta;
        }

        void imprime(int valor, double numero) 
        {
            Console.WriteLine("Valor é = " + valor);
            Console.WriteLine("Numero = " + numero);
        }

    }
}