using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }

    // Клас Футбольна Команда
    public class FootballTeam : IEnumerable<Player>
    {
        private List<Player> players;

        public FootballTeam()
        {
            players = new List<Player>();
        }

        // Додати гравця до команди
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        // Реалізація ітератора
        public IEnumerator<Player> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Створення Футбольної Команди
            FootballTeam team = new FootballTeam();

            // Додавання гравців до команди
            team.AddPlayer(new Player("Василь", 10));
            team.AddPlayer(new Player("Ігор", 7));
            team.AddPlayer(new Player("Петро", 9));
            team.AddPlayer(new Player("Дмитро", 11));
            team.AddPlayer(new Player("Олександр", 13));

            // Використання foreach для Футбольної Команди
            foreach (Player player in team)
            {
                Console.WriteLine($"Гравець: {player.Name}, Номер: {player.Number}");
            }
            Console.WriteLine();
        }
    }
}
