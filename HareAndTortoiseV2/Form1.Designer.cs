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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numMinSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.characterGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSpeed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(12, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "The Hare And The Tortoise";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistance
            // 
            this.lblDistance.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDistance.Location = new System.Drawing.Point(84, 76);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(86, 18);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Race Distance:";
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(176, 74);
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
            this.btnRace.Location = new System.Drawing.Point(218, 236);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(96, 54);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(20, 236);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(192, 54);
            this.lblOut.TabIndex = 12;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(294, 105);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // numMinSpeed
            // 
            this.numMinSpeed.Location = new System.Drawing.Point(176, 100);
            this.numMinSpeed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinSpeed.Name = "numMinSpeed";
            this.numMinSpeed.Size = new System.Drawing.Size(62, 20);
            this.numMinSpeed.TabIndex = 15;
            this.numMinSpeed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMinSpeed.Location = new System.Drawing.Point(84, 102);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(86, 18);
            this.lblMinSpeed.TabIndex = 14;
            this.lblMinSpeed.Text = "Minimum Speed:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterGeneratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // characterGeneratorToolStripMenuItem
            // 
            this.characterGeneratorToolStripMenuItem.Name = "characterGeneratorToolStripMenuItem";
            this.characterGeneratorToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.characterGeneratorToolStripMenuItem.Text = "Character Generator";
            this.characterGeneratorToolStripMenuItem.Click += new System.EventHandler(this.charactorGeneratorToolStripMenuItem_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 299);
            this.Controls.Add(this.numMinSpeed);
            this.Controls.Add(this.lblMinSpeed);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "The Hare And The Tortoise Racing";
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSpeed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numMinSpeed;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem characterGeneratorToolStripMenuItem;
    }
}

