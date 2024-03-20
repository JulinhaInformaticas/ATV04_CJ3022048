namespace ATV04_CJ3022048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, adi, mult, div, sub;
            int opc;

            Console.WriteLine("vamos fazer uma calculadora! \n");
            
            Console.WriteLine("digite um valor: ");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro valor: ");
            n2= int.Parse(Console.ReadLine());
            Console.WriteLine("escolha a operação: \n 1-adição \n 2-subtração \n 3-multiplicação \n 4-divisão");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("você escolheu adição.");
                    adi = n1 + n2;
                    Console.WriteLine("o resultado é: {0}", adi);
                    break;

                    case 2:
                    Console.WriteLine("você escolheu subtração.");
                    sub = n1 - n2;
                    Console.WriteLine("o resultado é : {0} ", sub);
                    break;

                    case 3:
                    Console.WriteLine("você escolheu multiplicação.");
                    mult = n1 * n2;
                    Console.WriteLine("o resultado é: {0} ", mult);
                    break;
                    
                    case 4:
                    Console.WriteLine("você escolheu divisão.");
                    div = n1 / n2;
                    Console.WriteLine("o resultado é: {0} ", div);
                    break;

                    default:
                    Console.WriteLine("opção inválida");
                    break;

            }
        }
    }
}
