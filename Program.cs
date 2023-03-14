using System;
using System.Globalization;
using System.Threading;

namespace DatasCSharp
{
    class Program
    {
        static void Main(string[] args){   

            ComparandoDatas();
           
        }

        static void DateTimeSts(){

            Console.Clear();
            var data = new DateTime(2023,03,14, 12,23,14); //Cria uma estrutura de data
            //var data = DateTime.Now; // Tras a data de hoje
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
        }

        static void FormatandoDatas(){
            Console.Clear();

            var data = DateTime.Now;

            var formata = String.Format("{0:yyyy-MM-dd hh:mm:ss}", data); //Formtação de datas TOPEEEEE
            //var formata = String.Format("{0:u}", data); //Formtação de datas TOPEEEEE

            Console.WriteLine(formata);      
            Thread.Sleep(5000);
        }

        static void AdicionandoValores(){
            Console.Clear();

            var data = DateTime.Now;
            Console.WriteLine(data.AddDays(1));

            Console.WriteLine(data.AddMonths(1));            

            Console.WriteLine(data.AddYears(1));
        }

        static void ComparandoDatas(){
            Console.Clear();

            var data = DateTime.Now;


            if (data.Date == DateTime.Now.Date){
                Console.WriteLine("Datas são iguais!");
            }
            else
            {
                Console.WriteLine("Datas não são iguais!");
            };
            
            Console.WriteLine(data);
            Thread.Sleep(5000);
        }

        static void FusoHorarios(){
            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString("D",en)); // Altera a forma de valor para outra lingua nesse caso Ingles.
            Console.WriteLine(String.Format("{0:D}",DateTime.Now));


        }
    }   
        
}
