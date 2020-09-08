﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mutantes.Core.Entities;
using Mutantes.Core.Interfaces;
using Mutantes.Infraestructura.Repositories;
namespace Mutantes.Infraestructura.Repositories
{
    public class StatsRepository : IStatsRepository
    {

        public async Task<Stats> GetStats()
        {
            var stats =  new Stats
            {
                count_human_dna = 1,
                count_mutant_dna = 1,
            };

           await Task.Delay(1);
            return stats;
        }
    }
}
