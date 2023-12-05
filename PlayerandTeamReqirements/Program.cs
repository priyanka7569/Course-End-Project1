using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlayerandTeamReqirements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string choice;
            do
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players");
            if (int.TryParse(Console.ReadLine(), out int selectedOption))
                {
                    switch (selectedOption)
                    {
                        case 1:
                            Console.WriteLine("Enter Player Id:");
                            int playerId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Player Name:");
                            string playerName = Console.ReadLine();
                            Console.WriteLine("Enter Player Age:");
                            int playerAge = int.Parse(Console.ReadLine());
                            Player newPlayer = new Player
                            {
                                PlayerId = playerId,
                                PlayerName = playerName,
                                PlayerAge = playerAge
                            };
                            team.Add(newPlayer);
                            Console.WriteLine("Player is Added Successfully");
                            break;
                        case 2:
                            Console.WriteLine("Enter Player Id to remove:");
                            int idToRemove = int.Parse(Console.ReadLine());
                            team.Remove(idToRemove);
                            Console.WriteLine("Player is removed Sucessfully");
                            break;
                        case 3:
                            Console.WriteLine("Enter Player Id to get:");
                            int idToGet = int.Parse(Console.ReadLine());
                            Player playerById = team.GetPlayerById(idToGet);
                            if (playerById != null)
                            {
                                Console.WriteLine($"Id: {playerById.PlayerId}, Name:{  playerById.PlayerName}, Age: { playerById.PlayerAge} ");
                             }
                            else
                            {
                                Console.WriteLine("Player not found with the given Id.");
                             }
                            break;
                        case 4:
                            Console.WriteLine("Enter Player Name to get:");
                            string nameToGet = Console.ReadLine();
                            Player playerByName =
                            team.GetPlayerByName(nameToGet);
                            if (playerByName != null)
                            {
                                Console.WriteLine($"Id: {playerByName.PlayerId}, Name: { playerByName.PlayerName}, Age: { playerByName.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found with the " +"given Name.");
                             }
                            break;
                        case 5:
                            List<Player> allPlayers = team.GetAllPlayers();
                            foreach (Player player in allPlayers)
                            {
                                Console.WriteLine($"Id: {player.PlayerId}, Name: { player.PlayerName}, Age: { player.PlayerAge}");
                             }
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                Console.WriteLine("Do you want to continue (yes/no):");
                choice = Console.ReadLine().ToLower();
            } 
            while (choice == "yes");
            Console.ReadKey();

        }
    }
}
