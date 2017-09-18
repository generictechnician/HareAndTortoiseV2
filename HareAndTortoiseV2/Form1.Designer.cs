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
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "The Hare And The Tortoise";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDistance.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDistance.Location = new System.Drawing.Point(12, 61);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(86, 18);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Race Distance:";
            // 
            // numDistance
            // 
            this.numDistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDistance.Location = new System.Drawing.Point(104, 59);
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
            this.btnRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRace.Location = new System.Drawing.Point(218, 235);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(96, 54);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblOut
            // 
            this.lblOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOut.Location = new System.Drawing.Point(17, 235);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(186, 54);
            this.lblOut.TabIndex = 12;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(294, 105);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // numMinSpeed
            // 
            this.numMinSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMinSpeed.Location = new System.Drawing.Point(104, 86);
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
            this.lblMinSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMinSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMinSpeed.Location = new System.Drawing.Point(12, 88);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(86, 18);
            this.lblMinSpeed.TabIndex = 14;
            this.lblMinSpeed.Text = "Minimum Speed:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.numMinSpeed);
            this.Controls.Add(this.lblMinSpeed);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 340);
            this.Name = "Form";
            this.Text = "The Hare And The Tortoise Racing";
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSpeed)).EndInit();
            this.ResumeLayout(false);

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
    }
}

