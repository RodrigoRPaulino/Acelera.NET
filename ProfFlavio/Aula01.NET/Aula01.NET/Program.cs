class Program
{
    static void Main(string[] args)
    {
        //ACELERA.NET 2023/24
        //MÓDULO 8 - Programação em C#
        //Professor: Flavio Siqueira - flaviosiqueira@outlook.com

        //A aplicação console abaixo implementa:
        // Tipos de Variáveis: Int, String, Char, Double, Double[]
        // Estrutura de decisão
        // Estrutura condicional
        // Funções de Escrita e Leitura em Console
        // Funções/Métodos com e sem parametros

        ///////////////////////////////////////////////////////
        //--------------------NECESSÁRIO---------------------//
        //-----***IMPLEMENTAR LAÇO FOR E WHILE/DO WHILE------//
        ///////////////////////////////////////////////////////

        char calcula;
        do
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("**        CALCULADORA MEGA ULTRA 2.0         **");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**   Seja bem vindos amigos do ACELERA.NET   **");
            Console.WriteLine("***********************************************");
            Console.WriteLine("");
            Console.WriteLine("Escolha o calculo que deseja:");
            Console.WriteLine("");
            Console.WriteLine("1 - CALCULAR MÉDIA DE NOTAS");
            Console.WriteLine("2 - CALCULAR IMC");
            Console.WriteLine("");
            Console.Write("Opção: ");

            int opcao = (Convert.ToInt32(Console.ReadLine()));
            
           

            switch (opcao)
            {
                case 1:
                    calculaMedia();
                    break;

                case 2:
                    calculaIMC();
                    break;
                case 3:
                    Console.WriteLine("Obrigado por usar o nosso sistema!");
                    return;   
            }
            Console.WriteLine("Deseja fazer outro calculo? (S/N):");
            calcula = Convert.ToChar(Console.ReadLine());
            void calculaIMC()
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o peso (kg): ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura (cm): ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a idade: ");
                double idade = Convert.ToDouble(Console.ReadLine());

                double IMC = peso / (altura * altura);
                //***CALCULE O IMC DA PESSOA, UTILIZANDO A FÓRMULA...
                //IMC = PESO / ALTURA² (Altura em metros)

                Console.WriteLine("");
                Console.WriteLine($"O IMC do {nome} é de : " + IMC);

                Console.WriteLine("Classificação: " + classificaIMC(IMC));
            }

            string classificaIMC(double iMC)
            {
                string classificacao = "";
                if (iMC < 18.5)
                {
                    classificacao = "Magreza";
                }
                else if (iMC < 24.9)
                {
                    classificacao = "Peso Normal";
                }
                else if (iMC < 29.9)
                {
                    classificacao = "Sobrepeso";
                }
                else if (iMC < 39.9)
                {
                    classificacao = "Obesidade";
                }
                else if (iMC > 40)
                {
                    classificacao = "Obesidade Grave";
                }

                //***IMPLEMENTE A CLASSIFICAÇÃO DE ACORDO COM O IMC
                //MENOR QUE 18,5    = MAGREZA
                //ENTRE 18,5 E 24,9 = NORMAL
                //ENTRE 25,0 E 29,9 = SOBREPESO
                //ENTRE 30,0 E 39,9 = OBESIDADE
                //MAIOR QUE 40,0    = OBESIDADE GRAVE

                return classificacao;
            }

            void calculaMedia()
            {
                double[] notas = new double[3];
                Console.WriteLine("Digite a primeira nota:");
                notas[0] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota:");
                notas[1] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota:");
                notas[2] = Convert.ToDouble(Console.ReadLine());

                double media = (notas[0] + notas[1] + notas[2]) / 3;

                Console.WriteLine("O aluno foi " + verificaAprovacao(media));

                Console.WriteLine("Média: " + media);
            }

            string verificaAprovacao(double media)
            {

                //***IMPLEMENTE AQUI O CÓDIGO PARA VERIFICAR SE O ALUNO FOI APROVADO
                //Se media menor que 5 = REPROVADO
                //Se media maior que 5 e menor que 7 = RECUPERAÇÃO
                //Se media maior ou igual a 7 = APROVADO

                string resultado = "";
                if (media < 5)
                {
                    resultado = "Reprovado";
                }
                else if (media > 5 && media < 7)
                {
                    resultado = "Recuperação";
                }
                else if (media >= 7)
                {
                    resultado = "Aprovado";
                }

                return (resultado);


            }
            //***IMPLEMENTE UM RETORNO AO INICIO DA CALCULADORA SE O USUARIO DESEJA FAZER UM NOVO CALCULO
            //***OU UMA MSG DE DESPEDIDA CASO ELE NÃO QUEIRA CALCULAR NOVAMENTE
        } while (Char.ToUpper(calcula)== 'S');

       

    }
}