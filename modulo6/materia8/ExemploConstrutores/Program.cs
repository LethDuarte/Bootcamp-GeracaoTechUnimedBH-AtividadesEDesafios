using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao (int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();

            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;

            // op.Invoke(10,10);

            // Data data = new Data();
            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();

            //data.SetMes(2);         

            // Aluno a1 = new Aluno("Mario","Andrade");
            // a1.Apresentar();
        }
    }
}
