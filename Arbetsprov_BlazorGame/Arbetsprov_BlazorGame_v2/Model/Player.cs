namespace Arbetsprov_BlazorGame_v2.Model
{
    public class Player
    {
        public string Name { get; internal set; }
        public Dictionary<string, int> Scores { get; set; } = new Dictionary<string, int>();
        public int TotalScore { get; internal set; }
    }
}
