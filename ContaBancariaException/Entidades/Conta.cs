using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaBancariaException.Entidades.Exception;

namespace ContaBancariaException.Entidades
{
    internal class Conta
    {
        public int Numero { get; set; }
        public String Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito (double quantidade)
        {
            Saldo = Saldo + quantidade;
        }

        public void Saque (double quantidade)
        {
            if (Saldo < 0 || quantidade > LimiteSaque)
            {
                throw new ExcecaoDominio("Valor indisponível para saque");
            }
            Saldo = Saldo - quantidade;
        }

        public override string ToString()
        {
            return "Dados da conta bancária:  " + "Número: " + Numero + " ," + "Titular: " + Titular + " ," + "Saldo: " + Saldo + " ," + "Limite de Saque: " + LimiteSaque;
        }
    }
}
