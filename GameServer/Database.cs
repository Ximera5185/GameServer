using System;
using System.Collections.Generic;
using System.Linq;

namespace GameServer
{
    internal class Database
    {
        private List<Player> _players = new List<Player>();

        public Database()
        {
            AddPlayers();
        }

        private void AddPlayers()
        {
            _players.Add(new Player("Игрок1", 10, 15));
            _players.Add(new Player("Игрок2", 15, 12));
            _players.Add(new Player("Игрок3", 30, 30));
            _players.Add(new Player("Игрок4", 34, 45));
            _players.Add(new Player("Игрок5", 11, 54));
            _players.Add(new Player("Игрок6", 16, 16));
            _players.Add(new Player("Игрок7", 18, 18));
            _players.Add(new Player("Игрок8", 19, 20));
            _players.Add(new Player("Игрок9", 110, 25));
            _players.Add(new Player("Игрок10", 11, 34));
        }

        public void ShowTopPlayerLevel(int maxValuePlayers)
        {
            var sortPlayerLevel = _players.OrderByDescending(player => player.Level).Take(maxValuePlayers);

            ShowTopPlayers(sortPlayerLevel);
        }

        public void ShowTopPlayerPower(int maxValuePlayers)
        {
            var sortPlayerPower = _players.OrderByDescending(player => player.Power).Take(maxValuePlayers);

            ShowTopPlayers(sortPlayerPower);
        }

        private void ShowTopPlayers(IEnumerable<Player> sortList)
        {
            foreach (Player player in sortList)
            {
                Console.WriteLine($"{player.Name} Level - {player.Level} Power - {player.Power}");
            }

            Console.WriteLine();
        }
    }
}