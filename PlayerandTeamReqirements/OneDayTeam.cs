using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerandTeamReqirements
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            // Set the capacity to 11 in the constructor
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }
        public void Remove(int playerId)
        {
            Player player = GetPlayerById(playerId);
            if (player != null)
            {
                oneDayTeam.Remove(player);
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(player => player.PlayerId == playerId);
        }
        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(player => player.PlayerName == playerName);
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}