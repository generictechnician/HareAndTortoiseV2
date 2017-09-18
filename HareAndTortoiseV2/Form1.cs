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

        public Form()
        {
            InitializeComponent();
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            //Variables
            int distance = 0;
            int MinSpeed = 0;

            //In



            distance = (int)numDistance.Value;
            MinSpeed = (int)numMinSpeed.Value;

            Race.Go(distance, MinSpeed);
        }
    }
}