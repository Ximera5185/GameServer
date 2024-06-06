using System;

namespace GameServer
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Database database = new Database();

            int maxValuePlayers = 3;

            database.ShowTopPlayerLevel(maxValuePlayers);

            database.ShowTopPlayerPower(maxValuePlayers);

            Console.ReadKey();
        }
    }
}