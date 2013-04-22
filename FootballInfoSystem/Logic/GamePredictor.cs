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
                int homeTeamPoints = getTeamPoints(homeTeamLatestGames, game.homeTeam.Id);
                int awayTeamPoints = getTeamPoints(awayTeamLatestGames, game.awayTeam.Id);
                if (homeTeamPoints > awayTeamPoints) {
                    homeTeamWinCoef = 1.5;
                    drawCoef = 2.5;
                    awayTeamWinCoef = 2.2;
                } else if (homeTeamPoints == awayTeamPoints) {
                    homeTeamWinCoef = 2.0;
                    drawCoef = 2.5;
                    awayTeamWinCoef = 2.0;
                } else {
                    homeTeamWinCoef = 2.2;
                    drawCoef = 2.5;
                    awayTeamWinCoef = 1.5;
                }
                predictions.Add(new Prediction(game.homeTeam, game.awayTeam, homeTeamWinCoef, awayTeamWinCoef, drawCoef));
            }
            return predictions;
        }

        private int getTeamPoints(IList<Game> homeTeamLatestGames, int teamId) {
            int points = 0;
            foreach (Game game in homeTeamLatestGames) {
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
