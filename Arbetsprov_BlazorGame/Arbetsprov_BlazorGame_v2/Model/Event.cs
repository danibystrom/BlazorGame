namespace Arbetsprov_BlazorGame_v2.Model
{
    public class Event
    {
        public string Name { get; internal set; }
        public int TotalScore { get; set; }
        public List<Player> Players { get; internal set; }
    }
}
