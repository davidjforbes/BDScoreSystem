using BDScoreSystem.Services.Models;

namespace BDScoreSystem.Models
{
    public class DressageResultViewModel
    {
        public DateOnly? Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public string Venue { get; set; } = string.Empty;
        public string JudgeName { get; set; } = string.Empty;
        public decimal MovementTotal { get; set; }
        public decimal MaxScore { get; set; }
        public int DressageTestId { get; set; }

        public List<DressageTestViewModel> DressageTests { get; set; } = [
            new() { Id = 1, Name = "Intro 1"},
            new() { Id = 1, Name = "Intro 2"},
            new() { Id = 1, Name = "Prelim 1"},
            new() { Id = 1, Name = "Prelim 2"},
            new() { Id = 1, Name = "Prelim 3"},
            new() { Id = 1, Name = "Prelim 4"},
            new() { Id = 1, Name = "Prelim 5"},
            new() { Id = 1, Name = "Prelim 6"},
            new() { Id = 1, Name = "Novice 1"},
            new() { Id = 1, Name = "Novice 2"},
            new() { Id = 1, Name = "Novice 3"},
            new() { Id = 1, Name = "Novice 4"},
            new() { Id = 1, Name = "Novice 5"},
            new() { Id = 1, Name = "Novice 6"},
            new() { Id = 1, Name = "Elementary 1"},
            new() { Id = 1, Name = "Elementary 2"},
            new() { Id = 1, Name = "Elementary 3"},
            new() { Id = 1, Name = "Elementary 4"},
            new() { Id = 1, Name = "Elementary 5"},
            new() { Id = 1, Name = "Elementary 6"},
            new() { Id = 1, Name = "Medium 1"},
            new() { Id = 1, Name = "Medium 2"},
            new() { Id = 1, Name = "Medium 3"},
            new() { Id = 1, Name = "Medium 4"},
            new() { Id = 1, Name = "Medium 5"},
            new() { Id = 1, Name = "Medium 6"}
            ];

        public List<CollectiveMarkViewModel> CollectiveMarks { get; set; } = [
            new() { Name = "Rhythm", Multiplier = 2, Mark = 0 },
            new() { Name = "Suppleness", Multiplier = 2, Mark = 0 },
            new() { Name = "Contact", Multiplier = 2, Mark = 0 },
            new() { Name = "Rider's position", Multiplier = 2, Mark = 0 },
            new() { Name = "Rider's results", Multiplier = 2, Mark = 0 }
        ];

        public decimal Result { get
            {
                if (MaxScore == 0) return 0;
                return decimal.Round(((MovementTotal + CollectiveMarks.Select(x => x.Total).Sum()) / MaxScore) * 100, 2, MidpointRounding.AwayFromZero);
            }
        } 

        public int Placing { get; set; }
    }
}
