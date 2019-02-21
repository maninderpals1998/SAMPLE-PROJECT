using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Player
    {

        public Player()
        {
            
        }
        public Player(string name, Team team)
        {
           Name = name;
            Team = team;
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private Team _team;

        public Team Team
        {
            get { return _team; }
            set { _team = value; }
        }

        
        
    }

