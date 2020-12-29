using System;
namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new HouseOfSantaClaus();
            house.AddChild(new Child("Настя", 20, "Поставьте зачет, пожалуймста"));
            house.AddChild(new Child("Катя", 9, "Всюду снег"));
            house.AddChild(new Child("Дима", 12, "Кто согреет солнышко?"));
            house.AddChild(new Child("Нури", 10, "Первый снег"));
            house.AddChild(new Child("Саша", 5, "Письмо"));
            house.Show();
            house.RemoveChild(3);
            Console.WriteLine("\n");
            house.Show();
        }

    }
}