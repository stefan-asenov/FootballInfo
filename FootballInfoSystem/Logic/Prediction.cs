using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballInfoSystem.Logic {
    class Prediction {
        public string homeTeam { get; private set; }
        public double homeWinCoef { get; private set; }
        public double drawCoef { get; private set; }
        public double awayWinCoef { get; private set; }
        public string awayTeam { get; private set; }

        public Prediction(Team homeTeam, Team awayTeam, double homeWinCoef, double awayWinCoef, double drawCoef) {
            this.homeTeam = homeTeam.name;
            this.homeWinCoef = homeWinCoef;
            this.drawCoef = drawCoef;
            this.awayWinCoef = awayWinCoef;
            this.awayTeam = awayTeam.name;
        }
    }
}
