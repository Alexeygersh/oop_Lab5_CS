using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace oop_Lab5_GershA_c_
{
    [Serializable]
    public class PlayerContainer
    {
        private List<Player> players = new List<Player>();

        public void AddPlayer()
        {
            Player newPlayer = new Player();
            newPlayer.ReadFromConsole();
            players.Add(newPlayer);
        }

        public void AddOnlinePlayer()
        {
            OnlinePlayer newOnlinePlayer = new OnlinePlayer();
            newOnlinePlayer.ReadFromConsole();
            players.Add(newOnlinePlayer);
        }

        public void DisplayPlayers()
        {
            foreach (var player in players)
            {
                player.DisplayToConsole();
            }
        }

        public void LoadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                using (var fileStream = new FileStream(filename, FileMode.Open))
                {
                    var serializer = new XmlSerializer(typeof(List<Player>));
                    players = (List<Player>)serializer.Deserialize(fileStream);
                }
            }
            else
            {
                Console.WriteLine($"Файл {filename} не найден.");
            }
        }

        public void SaveToFile(string filename)
        {
            using (var fileStream = new FileStream(filename, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(List<Player>));
                serializer.Serialize(fileStream, players);
            }
        }

        public void ClearPlayers()
        {
            players.Clear();
            Console.WriteLine("Список игроков очищен.");
        }
    }
}


