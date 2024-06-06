using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            new Player("Игрок1", 10, 15);
            new Player("Игрок2", 15, 12);
            new Player("Игрок3", 30, 30);
            new Player("Игрок4", 34, 45);
            new Player("Игрок5", 11, 45);
            new Player("Игрок6", 16, 16);
            new Player("Игрок7", 18, 18);
            new Player("Игрок8", 19, 20);
            new Player("Игрок9", 110, 25);
            new Player("Игрок10", 11, 34);
        }
    }
}