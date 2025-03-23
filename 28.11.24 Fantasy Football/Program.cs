namespace _28._11._24_Fantasy_Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run_Fantasy_Football();
            Console.WriteLine("Fantasy Football has closed.\n========\n\nEND.");
            Console.ReadLine();
        }
        static void Run_Fantasy_Football() 
        {
            string fileName = "FantasyFootball.txt";
            Console.Write("Make a new file? (Y/N): ");
            if (Console.ReadLine() == "Y")
            { File.WriteAllText(fileName,""); }
            string header = "Player name|| Goals scored||Yellow cards || Red cards || Score\n==============================================================\n";

            bool continue_ = true;
            int choice;
            while (continue_)
            {
                Display_Menu();
                
                choice = Convert.ToInt16(Console.ReadLine());
                Console.Write("\n");

                //Specific procedure is called when option is selected.
                switch (choice)
                {   case 1: Add_Player(fileName); break;
                    case 2: Remove_Player(fileName); break;
                    case 3: View_Players(fileName); break;
                    case 4: View_Team_Value(fileName); break;
                    case 5: continue_ = false;break;
                    default: break;
                }
            }
            //When user wants to quit, continue -> false, while loop is exited and procedure is exited.

        }
        static void Display_Menu() //purely displays messages on console to instruct user.
        {
            Console.WriteLine("\nWelcome to Fantasy Football.\n"); //Welcome message.
            Console.WriteLine("What would you like to do?"); //instructions and options
            Console.WriteLine("(1)--- Add Player\n(2)--- Remove Player\n(3)--- View Team\n(4)--- View Team Value\n(5)--- Quit\n");
        }
        static void Add_Player(string fileName)
        {
            string maximum_message = "Maximum reached.\nWould you like to replace a player? (Y/N): ";
            if (Valid_Player_Count(fileName,0))
            {
                string player_name;
                int num_goals;
                int num_yellow_cards;
                int num_red_cards;
                int player_score;

                bool continue_ = true;
                while (continue_ && Valid_Player_Count(fileName,1))
                {
                    //inputs player stats
                    Console.Write("Player name: ");
                    player_name = Console.ReadLine().ToLower();

                    Console.Write("Number of goals scored: ");
                    num_goals = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Number of yellow cards: ");
                    num_yellow_cards = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Number of red cards: ");
                    num_red_cards = Convert.ToInt16(Console.ReadLine());

                    player_score = 10 * num_goals - 5 * num_red_cards - 2 * num_yellow_cards;

                    //writes values into file (seperated by "\t|\t")
                    using (StreamWriter sw = new StreamWriter(fileName, true))
                    {
                        sw.WriteLine("{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", player_name, Convert.ToString(num_goals), Convert.ToString(num_yellow_cards), Convert.ToString(num_red_cards), Convert.ToString(player_score));
                    }

                    //asks whether to continue adding
                    Console.WriteLine("Would you like to add another player? (Y/N): ");
                    if ((Console.ReadLine()) == "N") { continue_ = false; }
                }
                Console.WriteLine(maximum_message); if (Console.ReadLine() == "Y") { Remove_Player(fileName); }
            }
            else { Console.WriteLine(maximum_message); if (Console.ReadLine() == "Y") { Remove_Player(fileName); } }
        }
        static void Remove_Player(string fileName) //removes a row(player) from file
        {
            //string[] team_data = File.ReadAllText(fileName).Substring(126).Split("\n"); // trims off headings and creates array of rows
            string[] team_data =File.ReadAllText(fileName).Split('\n');
            string player_data;
            string player_name;
            Console.Write("Who would you like to remove?: ");
            player_name = Console.ReadLine().ToLower();
            for (int i=0; i < team_data.Length-1; i++)
            {
                player_data = team_data[i];
                if (player_data.Contains(player_name))
                {
                    Console.WriteLine("Do you want to remove this player? (Y/N):\n{0}", player_data);
                    if (Console.ReadLine() == "Y")
                    {
                        //team_data.Remove(i);
                    }
                }
                else if (i==team_data.Length-1){ Console.WriteLine("Player cannot be found."); }
            }
        }
        static void View_Players(string fileName)
        {
            using(StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                { Console.WriteLine(line); }
            }
        }
        static void View_Team_Value(string fileName)
        {
            int score=0;
            int total=0;
            string line;

            //int position = File.ReadAllText(fileName).LastIndexOf("=");
            //string[] team_data = File.ReadAllText(fileName).Substring(position+2).Split("\n");
            string[] team_data = File.ReadAllText(fileName).Split('\n');

            Console.WriteLine("=====");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(team_data[i]);
            }
            Console.WriteLine("=====");
            for (int i = 0; i < team_data.Length-1; i++)
            {
                line = team_data[i];
                string[] player_data = line.Split("\t|\t");
                
                score = Convert.ToInt16(player_data[4]);
                total += score;
            }
            Console.WriteLine("Team value: "+total);
        }
        static bool Valid_Player_Count(string fileName, int pre_vs_aft)
        {
            bool is_valid = false;
            //string[] team_data = File.ReadAllText(fileName).Substring(126).Split("\n");
            string[] team_data = File.ReadAllText(fileName).Split('\n');
            if (team_data.Length < 5+pre_vs_aft) { is_valid = true; }
            return is_valid;
        }
    }
}
