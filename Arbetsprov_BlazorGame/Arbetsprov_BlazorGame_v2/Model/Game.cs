namespace Arbetsprov_BlazorGame_v2.Model
{
    public class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public List<Event> Events { get; set; } = new List<Event>();
        public bool IsGameFinished { get; set; } = false;


        public void AddPlayer(string playerName)
        {
            var newPlayer = new Player { Name = playerName };
            Players.Add(newPlayer);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }
        public void AddEvent(string eventName)
        {
            var newEvent = new Event { Name = eventName, Players = Players };
            Events.Add(newEvent);
        }
        public void RemoveEvent(Event evnt)
        {
            Events.Remove(evnt);
        }
        public int GetScore(Player player, string eventName)
        {
            if (player.Scores.ContainsKey(eventName))
            {
                return player.Scores[eventName];
            }
            return 0;
        }
        public void AddScore(Player player, string eventName)
        {
            if (!player.Scores.ContainsKey(eventName))
            {
                player.Scores[eventName] = 0;
            }
            player.Scores[eventName]++;
            player.TotalScore++;
        }

        public Player GetSecondPlace()
        {
            return Players.OrderByDescending(p => p.TotalScore).Skip(1).FirstOrDefault();
        }

        public Player GetThirdPlace()
        {
            return Players.OrderByDescending(p => p.TotalScore).Skip(2).FirstOrDefault();
        }

        public List<Player> GetWinners()
        {
            var winners = new List<Player>();
            var players = Players.OrderByDescending(p => p.TotalScore);
            var highestScore = players.First().TotalScore;

            foreach (var player in players)
            {
                if (player.TotalScore == highestScore)
                {
                    winners.Add(player);
                }
                else
                {
                    break;
                }
            }

            return winners;
        }
    }
}
