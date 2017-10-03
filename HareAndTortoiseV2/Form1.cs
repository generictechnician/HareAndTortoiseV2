using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace HareAndTortoiseV2
{
    public partial class lists
    {
        public static 
    }

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

        public void Form1_Load(object sender, EventArgs e)//Get file info on application Load
        {
            var characters = new List<Tuple<string, int, int, int>> { };
            int text = 0;//for text handling
            if (File.Exists(fileName))
            {
                IEnumerable<string> fileContents = File.ReadLines(fileName);//Get contents of file
                foreach (string i in fileContents)
                {
                    //ERROR CHECKING HERE NEEDS!!!!
                    if (i.Contains("name"))
                    {
                        try
                        {
                            names.Add(i.Substring(6));//add name sections to list, remove "<name>"
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    else if (i.Contains("minS"))
                    {
                        text = Int16.Parse(i.Substring(6));//get text as a number, remove "<minS>"
                        min.Add(text);//add speed sections to list
                    }
                    else if (i.Contains("maxS"))
                    {
                        text = Int16.Parse(i.Substring(6));// get text as a number, remove "<maxS>"
                        max.Add(text);//add minspeed to list
                    }
                    else if (i.Contains("endu"))
                    {
                        text = Int16.Parse(i.Substring(6));//get text as a number, remove "<endu>"
                        endurance.Add(text);//add endurance sections to list                     }
                    }

                }
            }
            else
            {
                toLoad = false;
                string message = "No file found, Please create one using the Character Generator program. " + Environment.NewLine + "The program will close when you try to Race.";
                const string title = "Error! File not found";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            noOfRacers = names.Count;
            wins = new int[noOfRacers];
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            
            lblOut.Text = "";//clear output box
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
                    //Give an Error message and give up.
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
            //Define vars and arrays, Randoms.
            int movement = 0;
            int roundNo = 1;
            bool winner = false;
            Random random = new Random();
            int[] location = new int[noOfRacers];

            //Process
            while (winner == false)//not got a winner
            {
                rtbRace.SelectionAlignment = HorizontalAlignment.Center;
                rtbRace.AppendText(Environment.NewLine + "Round " + roundNo + Environment.NewLine);//Give user some info.
                for (int i = 0; i < noOfRacers; i++)//cycle all racers
                {

                    if (endurance[i] > 0)//can they move?
                    {
                        movement = random.Next(min[i], max[i]);//move random amount
                        location[i] += movement;//add to location
                        endurance[i] -= movement;//take from endurance
                        
                    }
                    else
                    {
                        endurance[i] += (min[i] * 3);//increase endurance
                    }
                    if (location[i] >= distance)//has someone got past the line
                    {
                        winner = true;//exit loop
                        lblOut.Text = "The winner is the " + names[i] + "!";//give info to user
                        wins[i]++;//add 1 to win score
                    }
                    rtbRace.AppendText(names[i] + ": " + location[i] + Environment.NewLine);
                }
                roundNo++;//iteration of round no.
            }
        }

        private void newWinnerFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO NEW FILES
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SORTING WINS
        }

        private void winsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //List.Sort(names, wins); MAKE WORK
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //write all text to a file on close
            File.WriteAllText("wins.info", "");
            for (int i = 0; i < noOfRacers; i++)
            {
                File.AppendAllText("wins.info", names[i].ToString() + ":" + wins[i].ToString() + Environment.NewLine);
            }
        }
    }
}