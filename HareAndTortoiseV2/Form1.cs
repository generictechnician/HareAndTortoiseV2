using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareAndTortoiseV2
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Program Wide Vars and Consts
        int hWins = 0;
        int tWins = 0;

        const string hText = "Hare Wins: ";
        const string tText = "Tortoise Wins: ";

        public Form()
        {
            InitializeComponent();
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            //Variables
            int distance = 0;
            int restInc;
            int restStart;
            //tortoise
            int tMinSpeed = 0;
            int tMaxSpeed = 0;
            //hare
            int hMinSpeed = 0;
            int hMaxSpeed = 0;

            //In
            //TODO FIX THIS 
            ErrorCheck.Num((int)numDistance.Value, 100, 1000, out distance);
            ErrorCheck.CompareNum((int)numTMin.Value, (int)numTMax.Value, 1, 20, out tMinSpeed, out tMaxSpeed);
            ErrorCheck.CompareNum((int)numHMin.Value, (int)numHMax.Value, 1, 20, out hMinSpeed, out hMaxSpeed);
            ErrorCheck.Num((int)numHRestInc.Value, 1, 25, out restInc);
            ErrorCheck.Num((int)numHRestBase.Value, 1, 100, out restStart);

            Race.Go(distance, tMinSpeed, tMaxSpeed, hMinSpeed, hMaxSpeed, restInc, restStart);

            do
            {

            } while (Globals.winner == "");
            lblOut.Text = Globals.winner;

        }
    }
}