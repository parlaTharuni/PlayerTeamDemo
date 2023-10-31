using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playerdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam oneDayTeam = new OneDayTeam();
            int choice;

            do
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players 0:Exit ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Console.WriteLine("Enter player details:");
                        Console.Write("Enter player Id: ");
                        int playerId = int.Parse(Console.ReadLine());
                        Console.Write("Enter player Name: ");
                        string playerName = Console.ReadLine();
                        Console.Write("Enter Player Age: ");
                        int playerAge = int.Parse(Console.ReadLine());
                        Player newPlayer = new Player { PlayerName = playerName, PlayerId = playerId, PlayerAge = playerAge };
                        oneDayTeam.Add(newPlayer);
                        Console.WriteLine("Player is added successfully");
                        break;
                    case 2:
                        Console.Write("Enter Player Id to Remove: ");
                        int idToRemove = int.Parse(Console.ReadLine());
                        oneDayTeam.Remove(idToRemove);
                        Console.WriteLine("Player is removed successfully");
                        break;
                    case 3:
                        Console.Write("Enter Player Id: ");
                        int idToGet = int.Parse(Console.ReadLine());
                        Player playerById = oneDayTeam.GetPlayerById(idToGet);
                        if (playerById != null)
                            Console.WriteLine($"Player: {playerById.PlayerName}, Id: {playerById.PlayerId}, Age:{playerById.PlayerAge}");

                        else
                            Console.WriteLine("Player not found.");
                        break;
                    case 4:
                        Console.Write("Enter Player Name to Get: ");
                        string nameToGet = Console.ReadLine();
                        Player playerByName = oneDayTeam.GetPlayerByName(nameToGet);
                        if (playerByName != null)
                            Console.WriteLine($"Player: {playerByName.PlayerName}, Id: {playerByName.PlayerId}, Age: {playerByName.PlayerAge}");
                        else
                            Console.WriteLine("Player not found.");
                        break;
                    case 5:
                        List<Player> allPlayers = oneDayTeam.GetAllPlayers();
                        Console.WriteLine("All Players:");
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Name:{player.PlayerName}, ID:{player.PlayerId}, Age:{player.PlayerAge}");

                        }
                        break;
                }

                Console.Write("Do you want to continue (yes/no)? ");
            } while (Console.ReadLine().ToLower() == "yes");
        }
    }
}
            
   