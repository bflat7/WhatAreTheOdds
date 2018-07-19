using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatAreTheOdds
{
    public class OddsLibrary
    {
        public OddsResults calculateOdds(int userValue, int opponentValue, int odds)
        {
            if (userValue == opponentValue)
                return OddsResults.Match;
            else if (userValue + opponentValue == odds)
                return OddsResults.ReMatch;
            else if (odds == 2)
                return OddsResults.RoleReverse;
            else
                return OddsResults.NonMatch;
        }

        public bool ValidateInput(int userValue, int opponentValue, int odds)
        {
            return (userValue <= odds) && (opponentValue <= odds) && (userValue > 0) && (opponentValue > 0);
        }
    }

    public enum OddsResults
    {
        NonMatch,
        Match,
        ReMatch,
        RoleReverse
    }
}
