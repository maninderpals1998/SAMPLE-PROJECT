using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PlayerBo
    {

        public Player CreatePlayer(String data, Team[] teamList)
        {
            string[] inputs = data.Split(',');
            Team tt = null;
            foreach (Team t in teamList)
            {
                if (t.Name == inputs[1])
                {
                    tt = t;
                    break;
                }
            }
            Player p = new Player (inputs[0],tt);
            return p;
        
        }

        public String FindTeamName(Player[] playerList, String playername)
        {
            string teamname = string.Empty;
            foreach (Player p in playerList)
            {
                if (p.Name == playername)
                {
                    teamname = p.Team.Name;
                }
            }
            return teamname;

        }

        public Boolean FindWhetherPlayersAreInSameTeam(Player[] playerList, String playername1, String playername2)
        {
            string team1 = string.Empty;
            string team2 = string.Empty;
            foreach (Player p in playerList)
            {
                if (p.Name == playername1)
                {
                    team1 = p.Team.Name;
                }
                if (p.Name == playername2)
                {
                    team2 = p.Team.Name;
                }
            }
            if (team1 == team2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

