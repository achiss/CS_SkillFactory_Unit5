
//
//

namespace Unit5_result
{
    class Program
    {
        private static void Main(string[] args)                     // main method
        {
            UserData();
            ShowUserData();

            Console.ReadKey();
        }

        public static string GetDataFromConsole()                   // Получение строчки 
        {
            string data = Console.ReadLine();
            
            if(string.IsNullOrEmpty(data))                          // ! IsNullOrEmpty() - есть ли аналоги?
            {
                Console.WriteLine("Данные не были введены.");
                Console.Write("Введите данные: ");
                return GetDataFromConsole();
            }
            else
            {
                return data;
            }
        }

        public static int GetNumberDataFromConsole()                // Получение числовых значений 
        {
            int number;
            bool CheckNumber = int.TryParse(GetDataFromConsole(), out number);

            if(CheckNumber)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Данные не были введены корректно.");
                Console.Write("Введите данные: ");
                return GetNumberDataFromConsole();
            }
        }

        public static void UserData()
        {
            (string Name, string Surname, int Age, string Pet, string[] PetCount, string[] FavFlowers) UserList;

            Console.Write("Введите имя: ");
            UserList.Name = GetDataFromConsole();
            
            Console.Write("Введите фамилию: ");
            UserList.Surname = GetDataFromConsole();

            Console.Write("Введите возраст: ");
            UserList.Age = GetNumberDataFromConsole();
        }

        public static void GetArraysUserData()
        {

        }

        public static void ShowUserData()
        {
            Console.WriteLine($"Добрый день {}");
        }
    }
}