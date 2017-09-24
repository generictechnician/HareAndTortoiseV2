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

        public Form()
        {
            InitializeComponent();
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            //Variables
            int distance = 0;
            int MinSpeed = 0;

            List<string> names = new List<string>();//Create a names list to dynamically add to an array
            List<string> min = new List<string>();//As above but for Minimum speeds
            List<string> max = new List<string>();//As above but for Maximum speeds
            List<string> endurance = new List<string>();//as above but for Endurance
            IEnumerable<string> fileContents = File.ReadLines(fileName);//Get contents of file
            foreach (string i in fileContents)
            {
                if (i.Contains("name"))
                {
                    names.Add(i);//add name sections to list
                }
                else if (i.Contains("min"))
                {
                    min.Add(i);//add speed sections to list
                }
                else if (i.Contains("max"))
                {
                    max.Add(i);//add minspeed to list
                }
                else if (i.Contains("endurance"))
                {
                    endurance.Add(i);//add endurance sections to list
                }
                //Add to arrays TODO
            }
            

            distance = (int)numDistance.Value;//get the distance of the race from the user
            MinSpeed = (int)numMinSpeed.Value;//TEMP Get min speed, should be replaced TODO

            //Race.Go(distance, MinSpeed);//RACE!!! TODO MAKE WORK!!!
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