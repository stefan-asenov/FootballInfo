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
            IList<Prediction> predictions = new List<Prediction>();
            IList<Game> latestGames = DBUtils.getLatestGamesForTeam(team.Id, PREDICTED_GAMES_COUNT);
            foreach (Game game in latestGames) {
                
            }
            return predictions;
        }
    }
}
