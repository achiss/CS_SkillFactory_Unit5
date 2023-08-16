
//
//

namespace Unit5_result
{
    class Program
    {
        private static void Main(string[] args)                     // main method
        {

        }

        public static string GetDataFromConsole()
        {
            string data = Console.ReadLine();
            
            if(data == null)
            {
                Console.WriteLine("Данные не были введены.");
                return GetDataFromConsole();
            }
            else
            {
                return data;
            }
        }

        public static int GetNumberDataFromConsole()
        {
            int number = int.Parse(GetDataFromConsole());
            
            if((number == 0) || (number < 0))
            {
                Console.WriteLine("Введите корректные значения (не могут быть меньше или равны 0).");
                return GetNumberDataFromConsole();
            }
            else
            {
                return number;
            }
        }

        public static bool CheckValueDataFromConsole()              // need to update!
        {
            bool check = false;
            return check;
        }


    }
}