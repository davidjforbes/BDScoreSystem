namespace BDScoreSystem.Services.Models
{
    public class CollectiveMarkViewModel
    {
        public string Name { get; set; } = string.Empty;
        public int Multiplier { get; set; } = 2;
        public decimal Mark { get; set; }
        public decimal Total => decimal.Round(Mark * Multiplier);
    }
}
