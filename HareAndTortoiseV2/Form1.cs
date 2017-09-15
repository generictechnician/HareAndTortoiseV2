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

        private void btnRace_Click(object sender, EventArgs e)
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
            distance = ErrorCheck.Num(numDistance., 100, 1000);
            ErrorCheck.CompareNum(tbTSpeedMin.Text, tbTSpeedMax.Text, 1, 20, out tMinSpeed, out tMaxSpeed);
            ErrorCheck.CompareNum(tbHSpeedMin.Text, tbHSpeedMax.Text, 1, 20, out hMinSpeed, out hMaxSpeed);
            restInc = ErrorCheck(tbHRestIncrease.Text, 1, 25);
            restStart = ErrorCheck(tbHRestBase.Text, 1, 100);

            if (distance == 0 || tMinSpeed == 0 || tMaxSpeed == 0 || hMinSpeed == 0 || hMaxSpeed == 0 || restInc == 0 || restStart == 0)
            {
                lblOut.Text = "One or more textbox has invalid text. Please fill in all boxes and ensure minimum speeds are lower than maximum speeds";
            }
            else
            {
                Race(distance, tMinSpeed, tMaxSpeed, hMinSpeed, hMaxSpeed, restInc, restStart);
            }
        }
    }
}