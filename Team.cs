using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Team
    {
        public Team()
        {
            string _name=string.Empty;
            string _home=string.Empty;
        }
        public Team(string name, string home)
        {
            this.Name = name;
            this.Home = home;
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _home;

        public string Home
        {
            get { return _home; }
            set { _home = value; }
        }
        
        


    }

