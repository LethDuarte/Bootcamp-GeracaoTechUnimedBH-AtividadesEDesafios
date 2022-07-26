using System; 

namespace EstruturaDoPrograma
{
    class Program 
    {
        static void Main()
        {
            static void Declaracoes()
            {
                int a;
                int b = 2, c = 3;
                const int d = 4;  //constante, não pode ter seu valor redeclarado
                a = 1;
                
                Console.WriteLine(a + b + c + d);
            }

            static void InstrucaoIf(string[] args)
            {
                if (args.Length == 0) //.Length retorna a quantidade de itens do array
                {
                    Console.WriteLine("Nenhum argumento.");
                }
                else if (args.Length == 1)
                {
                    Console.WriteLine("Um argumento");
                }
                else
                {
                    System.Console.WriteLine($"{args.Length} argumentos.");
                }
            }

            static void InstrucaoForEach(string[] args)
            {
                foreach(string s in args)
                {
                    Console.WriteLine(s);
                }
            }

            static void InstrucaoBreak(string[] args)
            {
                while(true)
                {
                    string s = Console.ReadLine();

                    if(string.IsNullOrEmpty(s))
                        break;
                    
                    Console.WriteLine(s);
                }
            }

            static void InstrucaoContinue(string[] args)
            {
                for(int i = 0; i < args.Length; i++)
                {
                    if(args[i].StartsWith("/"))
                    {
                        continue;
                    }

                    Console.WriteLine(args[i]);
                }
            }
        
        }
    }
}

    
