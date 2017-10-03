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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWinnerFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWinnerFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
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
            this.btnRace.Location = new System.Drawing.Point(218, 349);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(96, 54);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(20, 349);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(192, 54);
            this.lblOut.TabIndex = 12;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbRace
            // 
            this.rtbRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRace.Location = new System.Drawing.Point(17, 112);
            this.rtbRace.MaxLength = 35565;
            this.rtbRace.Name = "rtbRace";
            this.rtbRace.ReadOnly = true;
            this.rtbRace.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbRace.Size = new System.Drawing.Size(297, 222);
            this.rtbRace.TabIndex = 13;
            this.rtbRace.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWinnerFileToolStripMenuItem,
            this.openWinnerFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fileToolStripMenuItem.Text = "Winners";
            // 
            // newWinnerFileToolStripMenuItem
            // 
            this.newWinnerFileToolStripMenuItem.Name = "newWinnerFileToolStripMenuItem";
            this.newWinnerFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newWinnerFileToolStripMenuItem.Text = "New Winner File";
            this.newWinnerFileToolStripMenuItem.Click += new System.EventHandler(this.newWinnerFileToolStripMenuItem_Click);
            // 
            // openWinnerFileToolStripMenuItem
            // 
            this.openWinnerFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.winsToolStripMenuItem});
            this.openWinnerFileToolStripMenuItem.Name = "openWinnerFileToolStripMenuItem";
            this.openWinnerFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openWinnerFileToolStripMenuItem.Text = "Open Winner File";
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.aZToolStripMenuItem.Text = "A to Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // winsToolStripMenuItem
            // 
            this.winsToolStripMenuItem.Name = "winsToolStripMenuItem";
            this.winsToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.winsToolStripMenuItem.Text = "Wins";
            this.winsToolStripMenuItem.Click += new System.EventHandler(this.winsToolStripMenuItem_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 415);
            this.Controls.Add(this.rtbRace);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 454);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 454);
            this.Name = "Form";
            this.Text = "The Hare And The Tortoise Racing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
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
        private System.Windows.Forms.RichTextBox rtbRace;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWinnerFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWinnerFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winsToolStripMenuItem;
    }
}

