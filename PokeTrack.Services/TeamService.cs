﻿using PokeTrack.Data;
using PokeTrack.Models.TeamModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrack.Services
{
    public class TeamService
    {
        
        public bool CreateTeam(TeamCreate model)
        {
            var entity =
                 new Team()
                 {
                     
                     TeamName = model.TeamName,

                 };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.TeamDb.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TeamListItem> GetTeams()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .TeamDb
                        .Where(e => e.TeamID == e.TeamID)
                        .Select(
                            e =>
                                new TeamListItem
                                {
                                    TeamID = e.TeamID,
                                    TeamName = e.TeamName,
                                   
                                }
                        );

                return query.ToArray();
            }
        }

        public IEnumerable<TeamListItem> GetTeamByTeamName(string teamName)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .TeamDb
                        .Where(e => e.TeamName == teamName)
                        .Select(
                            e =>
                                new TeamListItem
                                {
                                    TeamID = e.TeamID,
                                    TeamName = e.TeamName,
                                }
                        );

                return query.ToArray();
            }
        }

        /*public IEnumerable<TeamListItem> GetTeamByUser()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .TeamDb
                        .Where(e => e.UserName == e.UserName)
                        .Select(
                            e =>
                                new TeamListItem
                                {
                                    TeamID = e.TeamID,
                                    TeamName = e.TeamName,
                                    UserName = e.UserName,
                                    PokemonTeam = e.PokemonTeam

                                }
                        );

                return query.ToArray();
            }
        }*/

        public bool UpdateTeam(TeamEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .TeamDb
                    .Single(e => e.TeamID == model.TeamID);
               
                entity.TeamName = model.TeamName;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteTeam(int teamID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .TeamDb
                    .Single(e => e.TeamID == teamID);

                ctx.TeamDb.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
