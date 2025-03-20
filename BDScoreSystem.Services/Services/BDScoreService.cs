using BDScoreSystem.Data.Models;
using BDScoreSystem.Interfaces;
using BDScoreSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BDScoreSystem.Services
{
    public class BDScoreService : IBDScoreService
    {
        private BDScoreDbContext dbContext;
        public BDScoreService(IDbContextFactory<BDScoreDbContext> dbFactory)
        {
            dbContext = dbFactory.CreateDbContext();
        }

        public void SaveScore(DressageResultViewModel newDressageResult)
        {
            var result = dbContext.Set<DressageResult>().AddAsync(new DressageResult
            {
                Date = newDressageResult.Date.GetValueOrDefault().ToDateTime(TimeOnly.MinValue),
                Judge = newDressageResult.JudgeName,
                Venue = newDressageResult.Venue,
                Result = newDressageResult.Result,
                Placing = newDressageResult.Placing
            }).Result;

            dbContext.SaveChanges();
        }

        public IQueryable<DressageResult> GetScores()
        {
            return dbContext.Set<DressageResult>().AsQueryable();
        }
    }
}
