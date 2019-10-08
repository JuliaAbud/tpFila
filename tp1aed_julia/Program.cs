using System;

namespace tp1aed_julia
{
    class Program
    {
    
        static void Main(string[] args)
        {
            bool runTurn = true;
            Random random = new Random();
            FilaClientes fila = new FilaClientes();
            FilaClientes fila2 = new FilaClientes();
            bool createdNewFila = false;
            int choice = 0;

            while (runTurn)
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("           BANCO PUC            ");
                Console.WriteLine("------------------------------\n");

                Console.WriteLine("(1). Iniciar turno");
                Console.WriteLine("(2). Encerrar atendimentos \n");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Quantidade de pessoas na fila: " + fila.counterEnfileirados);
                if (createdNewFila)
                {
                    Console.WriteLine("\nFila 2 criada.\n");
                    Console.WriteLine("Quantidade de pessoas na fila 2: " + fila2.counterEnfileirados);
                }
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    choice = 0;
                }
                switch (choice)
                {
                    case 0: break;
                    case 1:
                        if (!fila.filaVazia())
                        {
                            Cliente emAtendimento = fila.obterPrimeiro();
                            if (emAtendimento.atendimento == 0)
                            {
                                fila.desenfileirar();
                            }
                            emAtendimento = fila.obterPrimeiro();
                            emAtendimento.atendimento--;
                            if (createdNewFila)
                            {
                                Cliente emAtendimento2 = fila2.obterPrimeiro();
                                if (emAtendimento2.atendimento == 0)
                                {
                                    fila2.desenfileirar();
                                }
                                emAtendimento2 = fila2.obterPrimeiro();
                                emAtendimento2.atendimento--;
                            }
                        }
                        int numClientes = random.Next(0, 3);
                        for (int i = 0; i < numClientes; i++)
                        {
                            Cliente cliente = new Cliente();
                            if (createdNewFila && fila.counterEnfileirados <= fila2.counterEnfileirados || !createdNewFila)
                            {
                                fila.enfileirar(cliente);
                            }
                            else if (createdNewFila && fila.counterEnfileirados > fila2.counterEnfileirados)
                            {
                                fila2.enfileirar(cliente);
                            }
                   
                        }
                        if (fila.counterEnfileirados > 6 && !createdNewFila)
                        {
                            createdNewFila = true;
                            fila2 = fila.dividir();
                        }
                        break;
                    case 2:
                        runTurn = false; 
                        break;
                    default: break;
                   
                }
               


            }
        }
    }
}
