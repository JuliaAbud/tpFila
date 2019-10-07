using System;
using System.Collections.Generic;
using System.Text;

namespace tp1aed_julia
{
    class FilaClientes
    {
        private Cliente frente; 
        private Cliente tras;
        public int counterEnfileirados;

        public FilaClientes ()
        {
            Cliente cli;
            cli = new Cliente();
            frente = cli;
            tras = cli;
            counterEnfileirados = 0;
        }

        public Boolean filaVazia()
        {
            if (frente == tras)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void enfileirar(Cliente aux)
        {
            tras.proximo = aux;
            tras = aux;
            counterEnfileirados++;
        }

        public Cliente desenfileirar()
        {
            Cliente aux = frente.proximo;
            if (!(filaVazia()))
            {
                frente.proximo = aux.proximo;
                aux.proximo = null;
                counterEnfileirados--;
            }
            return aux;
        }

        public Cliente obterPrimeiro()
        {
            Cliente aux = frente.proximo;
            if ((filaVazia()))
            {
                return null;
            }
            return aux;
        }

        public void imprimir()
        {
            while (counterEnfileirados > 0)
            {
                Cliente cliente = obterPrimeiro();
                Console.WriteLine("{0}", cliente.id);
                desenfileirar();
            }
        }

        public FilaClientes dividir()
        {
            FilaClientes par = new FilaClientes();
            FilaClientes impar = new FilaClientes();
            while (counterEnfileirados > 0)
            {
                if (counterEnfileirados % 2 == 0)
                {
                    par.enfileirar(obterPrimeiro());
                    desenfileirar();
                }
                else
                {
                    impar.enfileirar(obterPrimeiro());
                    desenfileirar();
                }
            }

            return par;
        }
    }
}
