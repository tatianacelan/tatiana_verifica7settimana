using System;

namespace tatiana_verifica7settimana
{
    class Program
    {
        //risposta a test 
        //1. d
        //2. a , d
        //3. a, d 

    
        private static DBScuolaManager db = new DBScuolaManager();
    
        static void Main(string[] args)
        {
            Console.WriteLine("Verifica ");

            bool continua = true;
            while (continua)
            {
                Console.WriteLine("--------------------------------Menu----------------------------");
                Console.WriteLine("Premi 1 per vedere tutti gli studenti");


                Console.WriteLine("0. Exit");


                int scelta;
                do
                {
                    Console.WriteLine("Scegli cosa fare!");
                } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 1));

                switch (scelta)
                {
                    case 1:

                        ViewAllStudents();

                        break;
                    case 0:
                        Console.WriteLine("Alla prossima!");
                        continua = false;
                       break;

                }

            }
        }

        private static void ViewAllStudents()
        {
            Console.WriteLine("La lista di tutti i studenti :\n");
            var studenti = db.GetAllStudents();
            int elenca = 1;
            foreach (var item in studenti)
            {
                Console.WriteLine($"{elenca++}. {item.ToString()}");
            }
        }
    }
}
