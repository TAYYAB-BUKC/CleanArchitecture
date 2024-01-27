using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public List<Team> GetAllTeams()
        {
            return GenerateMockTeams(30);
        }

        public static List<Team> GenerateMockTeams(int count)
        {
            List<Team> teams = new List<Team>();

            for (int i = 1; i <= count; i++)
            {
                Team mockTeam = new Team
                {
                    teamId = i,
                    teamName = $"Team{i}",
                    teamImage = $"Image{i}.jpg",
                    teamBio = $"Bio for Team{i}",
                    teamLeadName = $"Lead{i}",
                    isActive = true,
                    isDeleted = false,
                    createdBy = 1,
                    createdDate = DateTime.Now,
                    updatedBy = 1,
                    updateDate = DateTime.Now
                };
                teams.Add(mockTeam);
            }

            return teams;
        }
    }
}
