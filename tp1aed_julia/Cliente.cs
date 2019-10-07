using System;
using System.Collections.Generic;
using System.Text;

namespace tp1aed_julia
{
    class Cliente
    {
        private int _id;

        public int id {
            get { return _id; }
            set { _id = value; }
        }

        private int _espera;

        public int espera {
            get { return _espera; }
            set { _espera = value; }
        }

        private int _atendimento;

        public int atendimento {
            get { return  _atendimento; }
            set {  _atendimento = value; }
        }

        public Cliente proximo;
        public static int counterClientes;

        public Cliente()
        { 
            id = counterClientes;
            counterClientes++;
            Random tempAtendimento = new Random();
            atendimento = tempAtendimento.Next(2, 7);
        }

    }
}
