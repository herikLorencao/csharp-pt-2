﻿namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; private set; }

        private double _saldo = 100;

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
            TotalContasCriadas++;
        }


        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (_saldo < 0)
                    return;

                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}