using BDScoreSystem.Data.Models;
using BDScoreSystem.Models;

namespace BDScoreSystem.Interfaces
{
    public interface IBDScoreService
    {
        void SaveScore(DressageResultViewModel newDressageResult);
        IQueryable<DressageResult> GetScores();
    }
}