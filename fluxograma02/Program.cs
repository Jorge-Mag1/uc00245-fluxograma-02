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

        }// fim main


    }// fim program

} // fim namespace