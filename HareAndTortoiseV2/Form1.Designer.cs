namespace HareAndTortoiseV2
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.rtbRace = new System.Windows.Forms.RichTextBox();
            this.lblOutFileInfo = new System.Windows.Forms.Label();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnWins = new System.Windows.Forms.Button();
            this.rtbWinners = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "The Hare And The Tortoise";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistance
            // 
            this.lblDistance.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDistance.Location = new System.Drawing.Point(79, 47);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(86, 18);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Race Distance:";
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(171, 45);
            this.numDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(62, 20);
            this.numDistance.TabIndex = 2;
            this.numDistance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(14, 292);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(297, 54);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(14, 235);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(297, 54);
            this.lblOut.TabIndex = 12;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbRace
            // 
            this.rtbRace.Location = new System.Drawing.Point(17, 71);
            this.rtbRace.Name = "rtbRace";
            this.rtbRace.ReadOnly = true;
            this.rtbRace.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbRace.Size = new System.Drawing.Size(297, 161);
            this.rtbRace.TabIndex = 13;
            this.rtbRace.Text = "";
            // 
            // lblOutFileInfo
            // 
            this.lblOutFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutFileInfo.Location = new System.Drawing.Point(14, 367);
            this.lblOutFileInfo.Name = "lblOutFileInfo";
            this.lblOutFileInfo.Size = new System.Drawing.Size(297, 35);
            this.lblOutFileInfo.TabIndex = 14;
            this.lblOutFileInfo.Text = "How should the winners be sorted?";
            this.lblOutFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAZ
            // 
            this.btnAZ.Location = new System.Drawing.Point(17, 405);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(145, 33);
            this.btnAZ.TabIndex = 15;
            this.btnAZ.Text = "A to Z";
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnWins
            // 
            this.btnWins.Location = new System.Drawing.Point(168, 405);
            this.btnWins.Name = "btnWins";
            this.btnWins.Size = new System.Drawing.Size(143, 33);
            this.btnWins.TabIndex = 16;
            this.btnWins.Text = "Number of Wins";
            this.btnWins.UseVisualStyleBackColor = true;
            this.btnWins.Click += new System.EventHandler(this.btnWins_Click);
            // 
            // rtbWinners
            // 
            this.rtbWinners.Location = new System.Drawing.Point(17, 451);
            this.rtbWinners.Name = "rtbWinners";
            this.rtbWinners.ReadOnly = true;
            this.rtbWinners.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbWinners.Size = new System.Drawing.Size(294, 138);
            this.rtbWinners.TabIndex = 17;
            this.rtbWinners.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 601);
            this.Controls.Add(this.rtbWinners);
            this.Controls.Add(this.btnWins);
            this.Controls.Add(this.btnAZ);
            this.Controls.Add(this.lblOutFileInfo);
            this.Controls.Add(this.rtbRace);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "The Hare And The Tortoise Racing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.RichTextBox rtbRace;
        private System.Windows.Forms.Label lblOutFileInfo;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnWins;
        private System.Windows.Forms.RichTextBox rtbWinners;
    }
}

