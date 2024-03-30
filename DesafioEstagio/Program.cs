using DesafioEstagio.Problems;

class Program
{
    static void Main()
    {
        Problem1 problem1 = new Problem1();
        Problem2 problem2 = new Problem2();
        Problem4 problem4 = new Problem4();
        Problem5 problem5 = new Problem5();
        while (true)
        {
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Lógica");
            Console.WriteLine("3. Fibonacci");
            Console.WriteLine("4. Interruptores");
            Console.WriteLine("5. Inverter String");
       

            Console.WriteLine("0. Sair");

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    problem1.Main(); 
                    break;
                case 2:
              problem2.Main();
                
                    Console.WriteLine("a) 9\r\nb) 128\r\nc) 49\r\nd) 98\r\ne) 13\r\nf) 20");
                    break;

                case 3:          
                    Console.WriteLine("Acender uma lampada e deixar por bastante tempo ate que ou a lampada, o soquete ou a fiacao ganhasse temperatura, abrir a porta, checar e depois fazer o mesmo com outro interruptor e assim descobrir a terceira opcao");
                    break;
                case 4:
                    
                    problem4.Main();
                    break;
                case 5:
                    problem5.Main();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
