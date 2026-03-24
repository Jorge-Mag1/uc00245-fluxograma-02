using System.Reflection;

namespace Fluxograma02
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("=== FLUXOGRAMA DE TRABALHO ===\n");

            //Inicio
            Console.WriteLine("1. INICIO");

            //Comecei a Trabalhar
            Console.WriteLine("2. COMECEI A TRABALHAR");
        
            //Recebi 10 documentos
            Console.WriteLine("3. RECEBI 10 DOCUMENTOS");
            int documentos = 10;
            int contador = 0;

            //Repetidor -- FOR, WHILE e o DO WHILE
            Console.WriteLine("4. AINDA TEM DOCUMENTOS PARA AUDITAR E ASSINAR?");

            while (contador <  documentos)
            {
                Console.WriteLine ("SIM -> AUDITANDO E ASSINANDO");
                Console.WriteLine ( $"DOCUMENTOS {contador + 1} ");
                contador++;


            }//fim do while

            // Acabaram os documentos
            Console.WriteLine("JÁ NÃO HÁ DOCUMENTOS");
            Console.WriteLine("AINDA TEM ATIVIDADE");

            // Variavel do tipo boleana
            bool temAtividade = true; // podemos mudar para falso

            if (temAtividade == true)
            {
                Console.WriteLine("SIM, TEM ATIVIDADE");
            }
            else
            {
                Console.WriteLine("NÃO TEM ATIVIDADE");
            }

            // BLOCO DO FIM
            Console.WriteLine("6. FIM");

            Console.WriteLine("\n ******FIM DE PROGRAMA******");


        }// fim main


    }// fim program

} // fim namespace