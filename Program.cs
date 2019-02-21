using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {    Console.WriteLine("Enter the team count");
        int k = int.Parse(Console.ReadLine());
        TeamBO team = new TeamBO();
        Team[] ti = new Team[k];
        PlayerBo pbo = new PlayerBo();

        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("Enter team {0} details", (i + 1));
            string teams = Console.ReadLine();
            ti[i] = team.CreateTeam(teams);

        }
        Console.WriteLine("Enter the player count");
        int w = int.Parse(Console.ReadLine());
        Player[] player = new Player[w];
        Team[] tk = new Team[w];
        for (int i = 0; i < w; i++)
        {
            Console.WriteLine("Enter player {0} details", (i + 1));
            string playerss = Console.ReadLine();

            player[i] = pbo.CreatePlayer(playerss, ti);


        }

        Console.WriteLine("Enter the player name for which you need to find the team name");
        string playname = Console.ReadLine();
        PlayerBo pb = new PlayerBo();
        string teamname = pb.FindTeamName(player, playname);

        Console.WriteLine("{0} belongs to {1}", playname, teamname);


        Console.WriteLine("Enter 2 player names");
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();

        bool qw = pb.FindWhetherPlayersAreInSameTeam(player, name1, name2);

        if (qw)
        {
            Console.WriteLine("The 2 player are in the same team");
        }
        else
        {
            Console.WriteLine("The 2 player are in the different teams");
        }



        Console.ReadLine();
    }



}
    
