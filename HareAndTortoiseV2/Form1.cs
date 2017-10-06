using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace HareAndTortoiseV2
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Program Wide Vars and Consts
        string fileName = "characters.info";//Default will be changed by user at later date... TODO
        int noOfRacers = 0;
        int[] wins = new int[0];
        bool toLoad = true;

        List<string> names = new List<string>();//Create a names list
        List<int> min = new List<int>();//As above but for Minimum speeds
        List<int> max = new List<int>();//As above but for Maximum speeds
        List<int> endurance = new List<int>();//as above but for Endurance

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//Get file info on application Load
        {
            int text = 0;//for text handling
            if (File.Exists(fileName))
            {
                IEnumerable<string> fileContents = File.ReadLines(fileName);//Get contents of file
                foreach (string s in fileContents)
                {
                    //ERROR CHECKING HERE NEEDS!!!!
                    if (s.Contains("name"))
                    {
                        names.Add(s.Substring(6));//add name sections to list, remove "<name>"
                    }
                    else if (s.Contains("minS"))
                    {
                        text = Int16.Parse(s.Substring(6));//get text as a number, remove "<minS>"
                        min.Add(text);//add speed sections to list
                    }
                    else if (s.Contains("maxS"))
                    {
                        text = Int16.Parse(s.Substring(6));// get text as a number, remove "<maxS>"
                        max.Add(text);//add minspeed to list
                    }
                    else if (s.Contains("endu"))
                    {
                        text = Int16.Parse(s.Substring(6));//get text as a number, remove "<endu>"
                        endurance.Add(text);//add endurance sections to list

                    }
                }
                noOfRacers = names.Count;
                wins = new int[noOfRacers];
            }
            else
            {
                toLoad = false;
                string message = "No file found, Please create one using the Character Generator program. " + Environment.NewLine + "The program will close when you try to Race.";
                const string title = "Error! File not found";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            if (toLoad == true)
            {
                //Variables
                int distance = 0;

                distance = (int)numDistance.Value;//get the distance of the race from the user
                if (names.Count == min.Count && min.Count == max.Count && max.Count == endurance.Count)//Check that all lists have the same value if possible... 
                {
                    Race(distance);//RACE
                }
                else
                {
                    string message = "The file was not set up correctly, Please restart the program.";
                    string title = "Something went wrong.";
                    MessageBox.Show(message, title,MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Race(int distance)
        {
            int movement = 0;
            int round = 1;
            int winners = 0;
            string winner = "";
            Random random = new Random();
            int[] location = new int[noOfRacers];

            //Process
            while (winner == "")
            {
                rtbRace.AppendText(Environment.NewLine + "Round " + round + Environment.NewLine);
                for (int i = 0; i < noOfRacers; i++)
                {
                    if (endurance[i] > 0)
                    {
                        movement = random.Next(min[i], max[i]);
                        location[i] += movement;
                        endurance[i] -= movement;  
                    }
                    else
                    {
                        endurance[i] += (min[i] * 3);
                    }
                    if (location[i] >= distance)
                    {
                        winner = names[i];
                        winners++;
                        wins[i]++;
                    }
                    rtbRace.AppendText(names[i] + ": " + location[i] + Environment.NewLine);
                }
                round++;
            }

            if (winners > 1)
            {
                lblOut.Text = "The Winner is " + winner;
            }
            else
            {
                lblOut.Text = "It's A Draw!";
            }
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            //Title
            File.AppendAllText("Wins.txt", Environment.NewLine + "Sorting by Wins" + Environment.NewLine);
            rtbWinners.AppendText(Environment.NewLine + "Sorting by Wins" + Environment.NewLine);

            //Sorting
            int[] tmpWins = wins;//Doesn't effect primary array
            string[] nameArray = names.ToArray();//array from names
            Array.Sort(nameArray, tmpWins);//sort with each other

            //output names
            foreach (var item in nameArray)
            {
                File.AppendAllText("Wins.txt", item + " | ");
                rtbWinners.AppendText(item + " | ");
            }

            //line
            File.AppendAllText("Wins.txt", Environment.NewLine);
            rtbWinners.AppendText(Environment.NewLine);

            //Other outs
            foreach (int item in tmpWins)
            {
                File.AppendAllText("Wins.txt", item.ToString() + " | ");
                rtbWinners.AppendText(item.ToString() + " | ");
            }
        }

        private void btnWins_Click(object sender, EventArgs e)
        { 
            //Title
            File.AppendAllText("Wins.txt", Environment.NewLine + "Sorting by Wins" + Environment.NewLine);
            rtbWinners.AppendText(Environment.NewLine + "Sorting by Wins" + Environment.NewLine);

            //Sorting
            int[] tmpWins = wins;//Doesn't effect primary array
            string[] nameArray = names.ToArray();//array from names
            Array.Sort(tmpWins, nameArray);//sort with each other

            //output names
            foreach (var item in nameArray)
            {
                File.AppendAllText("Wins.txt", item + " | ");
                rtbWinners.AppendText(item + " | ");
            }

            //line
            File.AppendAllText("Wins.txt", Environment.NewLine);
            rtbWinners.AppendText(Environment.NewLine);

            //Other outs
            foreach (int item in tmpWins)
            {
                File.AppendAllText("Wins.txt", item.ToString() + " | ");
                rtbWinners.AppendText(item.ToString() + " | ");
            }
        }
    }
}
