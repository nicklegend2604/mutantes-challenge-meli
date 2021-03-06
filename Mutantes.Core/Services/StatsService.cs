using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mutantes.Core.Entities;
using Mutantes.Core.Interfaces;
using Mutantes.Infraestructura.Interfaces;

namespace Mutantes.Core.Services
{
    public class StatsService : IStatsService
    {
        readonly IStatsRepository _statsRepository;
        public StatsService(IStatsRepository statsRepository)
        {
            _statsRepository = statsRepository;
        }

        public async Task<StatsEntitie> GetStats()
        {
           
            var stats = await _statsRepository.GetStats();
            var ratio = stats.MutantsFound != 0 ? (double)decimal.Divide(stats.HumansFound, stats.MutantsFound) : stats.HumansFound;

            var stataEntitie = new StatsEntitie
            {
                count_human_dna = stats.HumansFound,
                count_mutant_dna = stats.MutantsFound,
                ratio = Math.Round(ratio, 3)
                
            };


            return stataEntitie;
        }


    }
}
