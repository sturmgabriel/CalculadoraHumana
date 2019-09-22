using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIP
{
    public class Program
    {
        static string[,] MascaraCIDR = new string[,] { { "255.0.0.0", "8", "16777216", "16777214" },
                                                    { "255.128.0.0", "9", "8388608", "8388606" },
                                                    { "255.192.0.0", "10", "4194304", "4194302" },
                                                    { "255.224.0.0", "11", "2097152", "2097150" },
                                                    { "255.240.0.0", "12", "1048576", "1048574" },
                                                    { "255.248.0.0", "13", "524288", "524286" },
                                                    { "255.252.0.0", "14", "262144", "262142" },
                                                    { "255.254.0.0", "15", "131072", "131070" },
                                                    { "255.255.0.0", "16", "65536", "65534" },
                                                    { "255.255.128.0", "17", "32768", "32766" },
                                                    { "255.255.192.0", "18", "16384", "16382" },
                                                    { "255.255.224.0", "19", "8192", "8190" },
                                                    { "255.255.240.0", "20", "4096", "4094" },
                                                    { "255.255.248.0", "21", "2048", "2046" },
                                                    { "255.255.252.0", "22", "1024" , "1022" },
                                                    { "255.255.254.0", "23", "512", "510" },
                                                    { "255.255.255.0", "24", "256", "254" },
                                                    { "255.255.255.128", "25", "128", "126" },
                                                    { "255.255.255.192", "26", "64", "62" },
                                                    { "255.255.255.224", "27", "32", "30" },
                                                    { "255.255.255.240", "28", "16", "14" },
                                                    { "255.255.255.248", "29", "8", "6" },
                                                    { "255.255.255.252", "30", "4", "2" }};
        static string erro = null;
        static string[] Result = new string[9];
        //Result[0] = ip de rede
        //Result[1] = host inicial
        //Result[2] = HOST FINAL
        //Result[3] = IP DE BROADCAST
        //Result[4] = QUANTIDADE DE HOSTS
        //Result[5] = MÁSCARA DE REDE
        //Result[6] = CIDR
        //Result[7] = QUANTIDADE DE IPS
        //Result[8] = QUANTIDADE DE GRUPOS
        //Result[9] = QUAL GRUPO SE ENCONTRA

        public static void Main(string[] args)
        {

            string PrimeiraOpcao;
            string SegundaOpcao;
            string v1;
            string v2;
            int op1;
            int op2;

            while (true)
            {
                erro = null;
                Console.WriteLine("=-=-=-=Calculadora IP=-=-=-=");
                Console.WriteLine("0) SAIR");
                Console.WriteLine("1) IP DE REDE");
                Console.WriteLine("2) HOST INICIAL");
                Console.WriteLine("3) HOST FINAL");
                Console.WriteLine("4) IP DE BROADCAST");
                Console.WriteLine("5) QUANTIDADE DE HOSTS");
                Console.WriteLine("6) MÁSCARA DE REDE");
                Console.WriteLine("7) CIDR");
                Console.WriteLine("8) QUANTIDADE DE IPS");
                Console.WriteLine("9) QUANTIDADE DE GRUPOS");
                Console.WriteLine("10) QUAL GRUPO SE ENCONTRA");
                Console.WriteLine("\nInsira a primeira Opção/Valor:");
                PrimeiraOpcao = Console.ReadLine();
                string[] opList1 = PrimeiraOpcao.Split('/');
                op1 = Convert.ToInt32(opList1[0]);
                v1 = opList1[1];
                if (op1 == 0)
                {
                    break;
                }

                Console.WriteLine("\nInsira a segunda Opção/Valor:");
                SegundaOpcao = Console.ReadLine();
                string[] opList2 = SegundaOpcao.Split('/');
                op2 = Convert.ToInt32(opList2[0]);
                v2 = opList2[1];
                if (op2 == 0)
                {
                    break;
                }

                distribuiCalculo(op1, op2, v1, v2);

                if (erro == null)
                {
                    foreach (var item in Result)
                    {
                        Console.WriteLine('\n' + item);
                    }
                }
                else
                {
                    Console.WriteLine("\n" + erro);
                }
            }

        }

        private static void distribuiCalculo(int op1, int op2, string v1, string v2)
        {

            if (op1 == 1 && op2 == 2 && String.IsNullOrEmpty(erro))
            {
                erro = "Impossível calcular os IPs a partir destas informações";
            }
            if (op1 == 3 && op2 == 4 && String.IsNullOrEmpty(erro))
            {
                erro = "Impossível calcular os IPs a partir destas informações";
            }
            if (op1 == 1 & op2 == 10 && String.IsNullOrEmpty(erro))
            {
                erro = "Impossível calcular os IPs a partir destas informações";
            }
            if (op1 == op2 && String.IsNullOrEmpty(erro))
            {
                erro = "As opções devem ser diferentes";
            }
            if ((op1 == 1 || op2 == 1) && String.IsNullOrEmpty(erro))
            {
                if (op1 == 1)
                {
                    calculaIpDeRede(v1);
                }
                else if (op2 == 1)
                {
                    calculaIpDeRede(v2);
                }
            }
            if ((op1 == 6 || op2 == 6) && String.IsNullOrEmpty(erro))
            {
                if (op1 == 6)
                {
                    calculaMascara(v1);
                }
                else if (op2 == 6)
                {
                    calculaMascara(v2);
                }
            }
            if ((op1 == 7 || op2 == 7) && String.IsNullOrEmpty(erro))
            {
                if (op1 == 7)
                {
                    calculaCIDR(v1);
                }
                else if (op2 == 7)
                {
                    calculaCIDR(v2);
                }
            }
            if ((op1 == 8 || op2 == 8) && String.IsNullOrEmpty(erro))
            {
                if (op1 == 8)
                {
                    calculaQntdIps(v1);
                }
                else if (op2 == 8)
                {
                    calculaQntdIps(v2);
                }
            }
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

        private static void calculaMascara(string valor)
        {
            string[] camposValor = valor.Split('.');

            int contador = camposValor.Count();

            if (contador != 4)
            {
                erro = "MASCARA DE REDE INVALIDA!";
            }

            else if (erro == null)
            {
                foreach (var item in camposValor)
                {
                    if (Convert.ToInt32(item) < 0 && Convert.ToInt32(item) > 255)
                    {
                        erro = "MASCARA DE REDE INVALIDA!";
                    }
                }

                if (Convert.ToInt32(camposValor[0]) != 255)
                {
                    erro = "MASCARA DE REDE INVALIDA!";
                }
                if (Convert.ToInt32(camposValor[1]) == 0 && (Convert.ToInt32(camposValor[2]) != 0 || Convert.ToInt32(camposValor[3]) != 0))
                {
                    erro = "MASCARA DE REDE INVALIDA!";
                }
                if (Convert.ToInt32(camposValor[2]) == 0 && Convert.ToInt32(camposValor[3]) != 0)
                {
                    erro = "MASCARA DE REDE INVALIDA!";
                }

                if (erro == null)
                {
                    erro = "MASCARA DE REDE INVALIDA!";
                    for (int i = 0; i <= 22; i++)
                    {
                        for (int u = 0; u <= 3; u++)
                        {
                            if (valor == MascaraCIDR[i, 0])
                            {
                                Result[4] = MascaraCIDR[i, 3];
                                Result[5] = valor;
                                Result[6] = MascaraCIDR[i, 1];
                                Result[7] = MascaraCIDR[i, 2];
                                erro = null;
                            }
                        }
                    }
                }
            }
        }
        private static void calculaCIDR(string valor)
        {

            if (Convert.ToInt32(valor) >= 8 && Convert.ToInt32(valor) <= 30)
            {
                if (erro == null)
                {
                    erro = "CIDR INVALIDO!";
                    for (int i = 0; i <= 22; i++)
                    {
                        for (int u = 0; u <= 3; u++)
                        {
                            if (valor == MascaraCIDR[i, 1])
                            {
                                Result[4] = MascaraCIDR[i, 3];
                                Result[5] = MascaraCIDR[i, 0];
                                Result[6] = valor;
                                Result[7] = MascaraCIDR[i, 2];
                                erro = null;
                            }
                        }
                    }
                }
                Console.WriteLine(Result[4]);
                Console.WriteLine(Result[5]);
                Console.WriteLine(Result[6]);
                Console.WriteLine(Result[7]);
            }
            else
            {
                erro = "CIDR INVALIDO!";
            }

        }

        public static void calculaQntdIps(string valor)
        {
            if (erro == null)
            {
                erro = "QUANTIDADE DE IPS INVALIDO!";
                for (int i = 0; i <= 22; i++)
                {
                    for (int u = 0; u <= 3; u++)
                    {
                        if (valor == MascaraCIDR[i, 2])
                        {
                            Result[4] = MascaraCIDR[i, 3];
                            Result[5] = MascaraCIDR[i, 0];
                            Result[6] = MascaraCIDR[i, 1];
                            Result[7] = valor;
                            erro = null;
                        }
                    }
                }
                Console.WriteLine(Result[4]);
                Console.WriteLine(Result[5]);
                Console.WriteLine(Result[6]);
                Console.WriteLine(Result[7]);
            }
        }

        public static void calculaIpDeRede(string valor)
        {
            string[] camposValor = valor.Split('.');

            int contador = camposValor.Count();

            if (contador != 4)
            {
                erro = "IP DE REDE INVALIDO!";
            }

            else if (erro == null)
            {

                foreach (var item in camposValor)
                {
                    if (Convert.ToInt32(item) < 0 && Convert.ToInt32(item) > 255)
                    {
                        erro = "IP DE REDE INVALIDO!";
                    }
                }

                if (erro == null)
                {
                    Result[0] = valor;

                    camposValor[3] = Convert.ToString(Convert.ToInt32(camposValor[3]) + 1);

                    string hostInicial = camposValor[0] + "." + camposValor[1] + "." + camposValor[2] + "." + camposValor[3];

                    Result[1] = hostInicial;
                }

            }


        }
    }
}
