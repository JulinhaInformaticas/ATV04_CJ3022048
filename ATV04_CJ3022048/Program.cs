namespace ATV04_CJ3022048 

{ 

    internal class Program 

    { 

        static void Main(string[] args) 

        { 

            int opcgeral; 

  

            Console.WriteLine("**MENU DE ATIVIDADES** \n 1-ATIVIDADE DE SALA \n 2-EXERCÍCIO 1 \n 3-EXERCÍCIO 2 \n 4-EXERCÍCIO 3 \n 5-EXERCÍCIO 4 \n 6-EXERCÍCIO 5 \n 7-EXERCÍCIO 6"); 

            opcgeral = int.Parse(Console.ReadLine()); 

  

            switch (opcgeral) 

            { 

                case 1: 

                    // ATV SALA 

                    float n1, n2, adi, mult, div, sub; 

                    int opc; 

  

                    Console.WriteLine("vamos fazer uma calculadora! \n"); 

                    Console.WriteLine("digite um valor: "); 

                    n1 = int.Parse(Console.ReadLine()); 

                    Console.WriteLine("digite outro valor: "); 

                    n2 = int.Parse(Console.ReadLine()); 

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

                    break; 

  

                case 2: 

                    // ATV 1 

                    Console.WriteLine("CONTANDO OS DIAS DA SEMANA"); 

                    int opc1; 

  

                    Console.WriteLine("digite um número de 1 a 7 equivalente a um dia da semana: "); 

                    opc1 = int.Parse(Console.ReadLine()); 

  

                    switch (opc1) 

                    { 

                        case 1: 

                            Console.WriteLine("domingo."); 

                            break; 

                        case 2: 

                            Console.WriteLine("segunda-feira."); 

                            break; 

                        case 3: 

                            Console.WriteLine("terça-feira."); 

                            break; 

                        case 4: 

                            Console.WriteLine("quarta-feira."); 

                            break; 

                        case 5: 

                            Console.WriteLine("quinta-feira."); 

                            break; 

                        case 6: 

                            Console.WriteLine("sexta-feira."); 

                            break; 

                        case 7: 

                            Console.WriteLine("sábado."); 

                            break; 

                        default: 

                            Console.WriteLine("opção inválida"); 

                            break; 

                    } 

                    break; 

  

                case 3: 

                    //ATV2 

                    Console.WriteLine("VAMOS CALCULAR O VALOR DE UMA COMPRA"); 

  

                    float valorfinal, cred, deb, pix, di; 

                    int opc2; 

  

                    Console.WriteLine("digite o valor final da compra: "); 

                    valorfinal = float.Parse(Console.ReadLine()); 

                    Console.WriteLine("**forma de pagamento** \n 1-dinheiro \n 2-pix \n 3-débito \n 4-crédito"); 

                    opc2 = int.Parse(Console.ReadLine()); 

  

                    switch (opc2) 

                    { 

                        case 1: 

                            Console.WriteLine("você escolheu dinheiro"); 

                            di = valorfinal - (valorfinal * 0.15f); 

                            Console.WriteLine("o valor final ficou: {0}", di); 

                            break; 

                        case 2: 

                            Console.WriteLine("você escolheu Pix"); 

                            pix = valorfinal - (valorfinal * 0.10f); 

                            Console.WriteLine("o valor final ficou: {0}", pix); 

                            break; 

                        case 3: 

                            Console.WriteLine("você escolheu débito"); 

                            deb = valorfinal + (valorfinal * 0.05f); 

                            Console.WriteLine("o valor final ficou: {0}", deb); 

                            break; 

                        case 4: 

                            Console.WriteLine("você escolheu crédito"); 

                            cred = valorfinal + (valorfinal * 0.10f); 

                            Console.WriteLine("o valor final ficou: {0}", cred); 

                            break; 

                        default: 

                            Console.WriteLine("opção inválida"); 

                            break; 

  

                    } 

                    break; 

  

                case 4: 

                    //ATV 3 

                    Console.WriteLine("VAMOS SABER A QUANTIDADE DE DIAS DE CADA MÊS"); 

  

                    int opc3, ano; 

  

                    Console.WriteLine("digite o ano: "); 

                    ano = int.Parse(Console.ReadLine()); 

                    Console.WriteLine("digite um número de 1 a 12 referente a um mês do ano: "); 

                    opc3 = int.Parse(Console.ReadLine()); 

  

                    switch (opc3) 

                    { 

                        case 1: 

                            Console.WriteLine("o mês de janeiro tem 31 dias"); 

                            break; 

                        case 2: 

                            Console.WriteLine("Qual é o ano: "); 

                            ano = int.Parse(Console.ReadLine()); 

                            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) 

                            { 

                                Console.WriteLine("O mês é fevereiro e tem 29 dias,pois, o ano é bissexto"); 

                                break; 

                            } 

                            else 

                            { 

                                Console.WriteLine("O mês é fevereiro e tem 28 dias"); 

                                break; 

                            } 

                        case 3: 

                            Console.WriteLine("O mês de março tem 31 dias."); 

                            break; 

                        case 4: 

                            Console.WriteLine("O mês de abril tem 30 dias."); 

                            break; 

                        case 5: 

                            Console.WriteLine("O mês de maio tem 31 dias."); 

                            break; 

                        case 6: 

                            Console.WriteLine("O mês de junho tem 30 dias."); 

                            break; 

                        case 7: 

                            Console.WriteLine("O mês de julho tem 31 dias."); 

                            break; 

                        case 8: 

                            Console.WriteLine("O mês de agosto tem 31 dias."); 

                            break; 

                        case 9: 

                            Console.WriteLine("O mês de setembro tem 30 dias."); 

                            break; 

                        case 10: 

                            Console.WriteLine("O mês de outubro tem 31 dias."); 

                            break; 

                        case 11: 

                            Console.WriteLine("O mês de novembro tem 30 dias."); 

                            break; 

                        case 12: 

                            Console.WriteLine("O mês de dezembro tem 31 dias."); 

                            break; 

                        default: 

                            Console.WriteLine("opção inválida"); 

                            break; 

                    } 

                break; 

  

                case 5: 

                    //ATV 4 

                    float x, y, ad, mul, divi, subt, pot; 

                    int opc4; 

  

                    Console.WriteLine("vamos fazer uma calculadora! \n"); 

                    Console.WriteLine("digite um valor: "); 

                    n1 = int.Parse(Console.ReadLine()); 

                    Console.WriteLine("digite outro valor: "); 

                    n2 = int.Parse(Console.ReadLine()); 

                    Console.WriteLine("escolha a operação: \n 1-adição \n 2-subtração \n 3-multiplicação \n 4-divisão \n 5-potência"); 

                    opc = int.Parse(Console.ReadLine()); 

  

                    switch (opc) 

                    { 

                        case 1: 

                            Console.WriteLine("você escolheu adição."); 

                            ad = x + y; 

                            Console.WriteLine("o resultado é: {0}", ad); 

                            break; 

  

                        case 2: 

                            Console.WriteLine("você escolheu subtração."); 

                            subt = x - y; 

                            Console.WriteLine("o resultado é : {0} ", subt); 

                            break; 

  

                        case 3: 

                            Console.WriteLine("você escolheu multiplicação."); 

                            mul = x * y; 

                            Console.WriteLine("o resultado é: {0} ", mul); 

                            break; 

  

                        case 4: 

                            Console.WriteLine("você escolheu divisão."); 

                            divi = x / y; 

                            Console.WriteLine("o resultado é: {0} ", divi); 

                            break; 

  

                        case 5: 

                            Console.WriteLine("você escolheu potência."); 

                            pot = x / y; 

                            Console.WriteLine("o resultado é: {0} ", pot); 

                            break; 

  

                        default: 

                            Console.WriteLine("opção inválida"); 

                            break; 

                    } 

                break; 

  

                case 6: 

                    //ATV 5 

  

                    int codigo; 

                    float salario, novo_salario; 

  

                    Console.WriteLine("Digite o valor do seu sálario: "); 

                    salario = int.Parse(Console.ReadLine()); 

                    Console.WriteLine("Digite o codigo do seu cargo:\nProfessor - 101\nSecretário - 102\nPublicitário - 103\nJornalista - 204\nMecânico - 206\nEstagiário - 301\nTécnico de TI - 302"); 

                    codigo = int.Parse(Console.ReadLine()); 

  

                    switch (codigo) 

                    { 

                        case 101: 

                            novo_salario = salario + (salario * 0.75f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                        case 102: 

                            novo_salario = salario + (salario * 0.97f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                        case 103: 

                            novo_salario = salario + (salario * 1.17f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                        case 204: 

                            novo_salario = salario + (salario * 0.89f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                        case 206: 

                            novo_salario = salario + (salario * 1.324f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                        case 301: 

                            novo_salario = salario + (salario * 1.04f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                        case 302: 

                            novo_salario = salario + (salario * 1.46f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                        default: 

                            novo_salario = salario + (salario * 4.35f); 

                            Console.WriteLine("Novo Salário = {0}", novo_salario); 

                            break; 

                    } 

                break;                  

  

                case 7: 

                    //ATV 6 

                    Console.WriteLine("VAMOS CALCULAR IMPOSTOS"); 

  

                    float sal; 

                    int opc6; 

  

                    Console.WriteLine("**digite o número referente ao seu salário** \n 1-Até R$ 1.903,98 \n 2-Entre R$ 1.903,99 e R$ 2.826,65 \n 3-Entre R$ 2.826,66 e R$ 3.751,05 \n 4-Entre R$ 3.751,06 e R$ 4.664,6 \n 5- Acima de R$ 4.664,68"); 

                    opc6 = int.Parse(Console.ReadLine()); 

  

                    switch (opc6) 

                    { 

                        case 1: 

                            Console.WriteLine("você está isento de imposto"); 

                            break; 

                        case 2: 

                            sal = opc6 - (opc6 * 0.075f); 

                            Console.WriteLine("seu salário será: {0}", sal); 

                        break; 

                        case 3: 

                            sal = opc6 - (opc6 * 0.15f); 

                            Console.WriteLine("seu salário será: {0}", sal); 

                        break; 

                        case 4: 

                            sal = opc6 - (opc6 * 0.225f); 

                            Console.WriteLine("seu salário será: {0}", sal); 

                        break; 

                        case 5: 

                            sal = opc6 - (opc6 * 0.275f); 

                            Console.WriteLine("seu salário será: {0}", sal); 

                        break; 

                            default : 

                            Console.WriteLine(" opção invalida"); 

                            break; 

                    } 

                break; 

            } 

  

  

        } 

    } 

} 
