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

        List<string> names = new List<string>();//Create a names list
        List<int> min = new List<int>();//As above but for Minimum speeds
        List<int> max = new List<int>();//As above but for Maximum speeds
        List<int> endurance = new List<int>();//as above but for Endurance

        public Form()
        {
            InitializeComponent();
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            //Variables
            int distance = 0;
            int text = 0;//for text handling

            IEnumerable<string> fileContents = File.ReadLines(fileName);//Get contents of file
            foreach (string i in fileContents)
            {
                //ERROR CHECKING HERE NEEDS!!!!
                if (i.Contains("name"))
                {
                    names.Add(i.Substring(6));//add name sections to list
                }
                else if (i.Contains("min"))
                {
                    text = Int16.Parse(i.Substring(5));//get text as a number
                    min.Add(text);//add speed sections to list
                }
                else if (i.Contains("max"))
                {
                    text = Int16.Parse(i.Substring(5));// get text as a number
                    max.Add(text);//add minspeed to list
                }
                else if (i.Contains("endurance"))
                {
                    text = Int16.Parse(i.Substring(11));//get text as a number
                    endurance.Add(text);//add endurance sections to list
                }
                //Add to arrays TODO
            }
            

            distance = (int)numDistance.Value;//get the distance of the race from the user

            Race(distance);//RACE
        }

        private void Race(int distance)
        {
            int noOfRacers = names.Count;
            int movement = 0;
            bool winner = false;
            Random random = new Random();
            int[] location = new int[noOfRacers];

            //Process
            while (winner == false)
            {
                for (int i = 0; i < noOfRacers; i++)
                {
                    if (endurance[i] != 0)
                    {
                        movement = random.Next(min[i], max[i]);
                        location[i] += movement;
                        endurance[i] -= movement;
                    }
                    else
                    {
                        endurance[i] += (min[i] * 3);
                    }
                    if (location[i] == distance)
                    {
                        winner = true;
                        lblOut.Text = names[i];
                    }

                    
                }
            }
        }

        private void charactorGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("CharacterGenerator.exe");//Open character creator program
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process p in System.Diagnostics.Process.GetProcessesByName("CharacterGenerator"))//Ensure that the Character gernerator program closes
            {
                try
                {
                    p.Kill();
                }
                catch (InvalidOperationException){}// Closed
            }
        }
    }
}