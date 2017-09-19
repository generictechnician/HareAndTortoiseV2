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

        string fileName = "characters.info";

        public Form()
        {
            InitializeComponent();
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            //Variables
            int distance = 0;
            int MinSpeed = 0;
            int charPos = 0;
            int inString = 0;

            //In
            IEnumerable<string> fileContents = File.ReadLines(fileName);

            foreach (string i in fileContents)
            {
                for (int c = 1; c < 3; c++)
                {
                    charPos = i.IndexOf(">");
                    //inString = //GET RIGHT CHARACTERS TODO STRING MANIPULATION ?????????????????
                }
            }


            distance = (int)numDistance.Value;
            MinSpeed = (int)numMinSpeed.Value;

            //Race.Go(distance, MinSpeed);
        }

        private void charactorGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("CharacterGenerator.exe");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process p in System.Diagnostics.Process.GetProcessesByName("CharacterGenerator"))
            {
                try
                {
                    p.Kill();
                }
                catch (InvalidOperationException)// invalidException)
                {

                }
            }
        }
    }
}