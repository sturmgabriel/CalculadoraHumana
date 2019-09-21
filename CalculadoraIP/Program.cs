using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIP
{
    class Program
    {
        static void Main(string[] args)
        {
            string PrimeiraOpcao;
            string SegundaOpcao;
            string v1;
            string v2;
            int op1;
            int op2;

            Console.WriteLine("=-=-=-=Calculadora IP=-=-=-=");
            Console.WriteLine("1) IP DE REDE");
            Console.WriteLine("2) HOST INICIAL");
            Console.WriteLine("3) MÁSCARA DE REDE");
            Console.WriteLine("4) QUANTIDADE DE IPS");
            Console.WriteLine("5) QUANTIDADE DE GRUPOS");
            Console.WriteLine("6) IP DE BROADCAST");
            Console.WriteLine("7) HOST FINAL");
            Console.WriteLine("8) CIDR");
            Console.WriteLine("9) QUANTIDADE DE HOSTS");
            Console.WriteLine("10) QUAL GRUPO SE ENCONTRA");
            Console.WriteLine("\nInsira a primeira Opção/Valor:");
            PrimeiraOpcao = Console.ReadLine();
            Console.WriteLine("\nInsira a segunda Opção/Valor:");
            SegundaOpcao = Console.ReadLine();

            string[] opList1 = PrimeiraOpcao.Split('/');
            string[] opList2 = SegundaOpcao.Split('/');

            op1 = Convert.ToInt32(opList1[0]);
            op2 = Convert.ToInt32(opList2[0]);

            if (op1 == 7 && op2 == 9)
            {
                Console.WriteLine("NAO É POSSIVEL CALCULAR COM ESSAS O´Ç~EOS");
                
            }
            //else if (op1 = & op2 = )
            //{


            //}
            //else if (op1 = & op2 = )
            //{


            //}
            //else if (op1 = & op2 = )
            //{


            //}
            //else if (op1 = &op2 = )
            //{


            //}
            //else if (op1 = &op2 = )
            //{


            //}
            //else if (op1 = &op2 = )
            //{


            //}
            //else if (op1 = &op2 = )
            //{


            //}
            //else if (op1 = &op2 = )
            //{


            //}
            //else if (op1 = &op2 = )
            //{


            //}
            //else {
            //    Console.WriteLine("OPÇÃO INVALIDA!");
            //}

        }

        static void calcula() {

        }

    }
}
