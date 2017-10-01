using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace HareAndTortoiseV2
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Program Wide Vars and Consts
        string fileName = "characters.info";//Default will be changed by user at later date... TODO
        int noOfRacers = 0;
        int[] wins = new int[0];

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

            IEnumerable<string> fileContents = File.ReadLines(fileName);//Get contents of file
            foreach (string i in fileContents)
            {
                //ERROR CHECKING HERE NEEDS!!!!
                if (i.Contains("name"))
                {
                    names.Add(i.Substring(6));//add name sections to list, remove "<name>"
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
                    endurance.Add(text);//add endurance sections to list

                }

            }
            noOfRacers = names.Count;
            wins = new int[noOfRacers];
        }

        public void btnRace_Click(object sender, EventArgs e)
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
                //Clear file and give message
            }
        }

        private void Race(int distance)
        {
            
            int movement = 0;
            bool winner = false;
            Random random = new Random();
            int[] location = new int[noOfRacers];

            //Process
            while (winner == false)
            {
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
                        winner = true;
                        lblOut.Text = names[i];
                        wins[i]++;
                    }
                }
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
            File.WriteAllText("wins.info", "");
            for (int i = 0; i < noOfRacers; i++)
            {
                File.AppendAllText("wins.info", names[i].ToString() + ":" + wins[i].ToString() + Environment.NewLine);
            }
        }
    }
}