using System;

namespace tp1aed_julia
{
    class Program
    {
        // Nome: JULIA RAFAEL CORREA ABUD
        // Matricula: 647464
        // TP1 FILAS
        static void Main(string[] args)
        {
            bool runTurn = true;
            Random random = new Random();
            FilaClientes fila = new FilaClientes();

            while (runTurn)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("BANCO PUC");
                Console.WriteLine("------------------------------\n\n");

                Console.WriteLine("(1). Iniciar turno");
                Console.WriteLine("(2). Encerrar atendimentos");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if(!fila.filaVazia())
                        {
                            Cliente emAtendimento = fila.obterPrimeiro();
                            emAtendimento.atendimento--;
                        }
                        int numClientes = random.Next(0, 3);
                        for (int i = 0; i < numClientes; i++)
                        {
                            Cliente cliente = new Cliente();
                            fila.enfileirar(cliente);
                        }
                        break;
                }



            }
        }
    }
}
