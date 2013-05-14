using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballInfoSystem.Data;

namespace FootballInfoSystem.Logic {
    class GamePredictor {
        private const int PREDICTED_GAMES_COUNT = 5;
        private Team team;

        public GamePredictor(int teamId) {
            team = DBUtils.GetTeam(teamId);
        }

        public IList<Prediction> predictGames() {
            double homeTeamWinCoef, drawCoef, awayTeamWinCoef;
            IList<Prediction> predictions = new List<Prediction>();
            IList<Game> futureGames = DBUtils.getFutureGamesForTeam(team.Id, PREDICTED_GAMES_COUNT);
            foreach (Game game in futureGames) {
                IList<Game> homeTeamLatestGames = DBUtils.getLatestGamesForTeam(game.homeTeam.Id, PREDICTED_GAMES_COUNT);
                IList<Game> awayTeamLatestGames = DBUtils.getLatestGamesForTeam(game.awayTeam.Id, PREDICTED_GAMES_COUNT);
                int gamesCount = Math.Min(homeTeamLatestGames.Count, awayTeamLatestGames.Count);
                double homeTeamPoints = getTeamPoints(homeTeamLatestGames, game.homeTeam.Id, gamesCount);
                double awayTeamPoints = getTeamPoints(awayTeamLatestGames, game.awayTeam.Id, gamesCount);
                if (homeTeamPoints > awayTeamPoints) {
                    homeTeamWinCoef = normalize((homeTeamPoints - awayTeamPoints) / (homeTeamPoints + 1));
                    drawCoef = normalize((homeTeamPoints + awayTeamPoints) / (2 * awayTeamPoints + 1));
                    awayTeamWinCoef = normalize((homeTeamPoints - awayTeamPoints) / (awayTeamPoints + 1));
                } else if (homeTeamPoints == awayTeamPoints) {
                    homeTeamWinCoef = normalize((homeTeamPoints + awayTeamPoints) / (awayTeamPoints + 1));
                    drawCoef = normalize((homeTeamPoints + awayTeamPoints) / (2 * awayTeamPoints + 1));
                    awayTeamWinCoef = normalize((homeTeamPoints + awayTeamPoints) / (awayTeamPoints + 1));
                } else {
                    homeTeamWinCoef = normalize((awayTeamPoints - homeTeamPoints) / (homeTeamPoints + 1));
                    drawCoef = normalize((homeTeamPoints + awayTeamPoints) / (2 * homeTeamPoints + 1));
                    awayTeamWinCoef = normalize((awayTeamPoints - homeTeamPoints) / (awayTeamPoints + 1));
                }
                predictions.Add(new Prediction(game.homeTeam, game.awayTeam, homeTeamWinCoef, awayTeamWinCoef, drawCoef));
            }
            return predictions;
        }

        private double normalize(double coeficient) {
            if (coeficient <= 1) {
                return Math.Round(coeficient + 1.2, 2);
            }
            if (coeficient > 3) {
                return Math.Round((coeficient + 1.4) / coeficient, 2);
            }
            return Math.Round(coeficient, 2);
        }

        private double getTeamPoints(IList<Game> homeTeamLatestGames, int teamId, int gamesCount) {
            double points = 0;
            for (int i = 0; i < gamesCount; i++) {
                Game game = homeTeamLatestGames.ElementAt(i);
                string result = game.result;
                string[] goals = result.Split(':');
                int homeTeamGoals = int.Parse(goals[0]);
                int awayTeamGoals = int.Parse(goals[1]);
                if (game.homeTeam.Id == teamId) {
                    if (homeTeamGoals > awayTeamGoals) {
                        points += 3;
                    }
                } else {
                    if (awayTeamGoals > homeTeamGoals) {
                        points += 3;
                    }
                }
                if (homeTeamGoals == awayTeamGoals) {
                    points += 1;
                }
            }
            return points;
        }
    }
}
