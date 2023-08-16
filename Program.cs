
// resulted task, Unit 5
// august 2023

namespace Unit5_result {

    class Program {

        static (string Name, string Surname, int Age, string Pet, string[] PetList, string[] FavFlowers) UserList;

        private static void Main(string[] args) {
            UserData(ref UserList);
            ShowUserData(UserList);

            Console.ReadKey();
        }


        public static string GetDataFromConsole() {
            string dataString = Console.ReadLine();

            if (string.IsNullOrEmpty(dataString))                          // ! IsNullOrEmpty() - есть ли аналоги?
            {
                Console.WriteLine("Данные не были введены.");
                Console.Write("Введите данные: ");
                return GetDataFromConsole();
            }
            else
            {
                return dataString;
            }
        }


        public static int GetNumberDataFromConsole() {
            int numberString;
            bool CheckNumberString = int.TryParse(GetDataFromConsole(), out numberString);

            if (CheckNumberString)
            {
                return numberString;
            }
            else
            {
                Console.WriteLine("Данные не были введены корректно.");
                Console.Write("Введите данные: ");
                return GetNumberDataFromConsole();
            }
        }


        public static void UserData(ref (string Name, string Surname, int Age, string Pet, string[] PetList, string[] FavFlowers) tuple) {
            Console.Write("Введите имя: ");
            tuple.Name = GetDataFromConsole();

            Console.Write("Введите фамилию: ");
            tuple.Surname = GetDataFromConsole();

            Console.Write("Введите возраст: ");
            tuple.Age = GetNumberDataFromConsole();

            Console.WriteLine("Есть ли у вас животные? (да или нет)");
            tuple.Pet = GetDataFromConsole().ToLower();
            if ((tuple.Pet == "нет") || (tuple.Pet == "н"))
            {
                tuple.Pet = "Домашних питомцев нет.";
                tuple.PetList = new string[0];
            }
            else
            {
                Console.WriteLine("Сколько питомцев Вы имеете? (ответ цифрами)");
                tuple.PetList[0] = Console.ReadLine();
                if (tuple.PetList.Length <= 2)
                {
                    Console.Write("Введите кличку Вашего питомца: ");
                    tuple.PetList[1] = GetDataFromConsole();
                }
                else
                {
                    for (int i = 1; i < int.Parse(tuple.PetList[0]); i++)
                    {
                        Console.Write($"Введите кличку {i} питомца");
                        tuple.PetList[i] = GetDataFromConsole();
                    }
                }
            }

            Console.WriteLine("Сколько цветов Вам нравится? (ответ цифрами)");
            int FavFlowersCount = GetNumberDataFromConsole();
            for (int i = 0; i < FavFlowersCount; i++)
            {
                Console.Write("Введите цвет:");
                tuple.FavFlowers[i] = GetDataFromConsole();
            }
        }   


        public static void ShowUserData((string Name, string Surname, int Age, string Pet, string[] PetList, string[] FavFlowers) tuple) {
            Console.WriteLine($"\n\tДобрый день {tuple.Surname} {tuple.Name}, Ваш возраст {tuple.Age}" +
                $"\n\t" +
                $"\n\tВаши любимые цветы: ");
        }
    }
}
