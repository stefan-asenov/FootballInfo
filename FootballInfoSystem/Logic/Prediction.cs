using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballInfoSystem.Logic {
    class Prediction {
        private Team homeTeam;
        private double homeWinCoef;
        private double awayWinCoef;
        private double drawCoef;
        private Team awayTeam;

        public Prediction(Team homeTeam, Team awayTeam, double homeWinCoef, double awayTeamCoef, double drawCoef) {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.homeWinCoef = homeWinCoef;
            this.awayWinCoef = awayWinCoef;
            this.drawCoef = drawCoef;
        }
    }
}
