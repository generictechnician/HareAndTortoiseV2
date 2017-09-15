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
            this.lblHMin = new System.Windows.Forms.Label();
            this.numHMin = new System.Windows.Forms.NumericUpDown();
            this.numHMax = new System.Windows.Forms.NumericUpDown();
            this.lblHMax = new System.Windows.Forms.Label();
            this.numTMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numTMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTMin)).BeginInit();
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
            this.lblDistance.Location = new System.Drawing.Point(12, 62);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(123, 18);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distance";
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(141, 60);
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
            // lblHMin
            // 
            this.lblHMin.Location = new System.Drawing.Point(12, 85);
            this.lblHMin.Name = "lblHMin";
            this.lblHMin.Size = new System.Drawing.Size(123, 23);
            this.lblHMin.TabIndex = 3;
            this.lblHMin.Text = "Hare Minimum Speed";
            // 
            // numHMin
            // 
            this.numHMin.Location = new System.Drawing.Point(141, 86);
            this.numHMin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numHMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHMin.Name = "numHMin";
            this.numHMin.Size = new System.Drawing.Size(62, 20);
            this.numHMin.TabIndex = 4;
            this.numHMin.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numHMax
            // 
            this.numHMax.Location = new System.Drawing.Point(141, 112);
            this.numHMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numHMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHMax.Name = "numHMax";
            this.numHMax.Size = new System.Drawing.Size(62, 20);
            this.numHMax.TabIndex = 6;
            this.numHMax.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblHMax
            // 
            this.lblHMax.Location = new System.Drawing.Point(12, 111);
            this.lblHMax.Name = "lblHMax";
            this.lblHMax.Size = new System.Drawing.Size(123, 21);
            this.lblHMax.TabIndex = 5;
            this.lblHMax.Text = "Hare Maximum Speed";
            // 
            // numTMax
            // 
            this.numTMax.Location = new System.Drawing.Point(141, 161);
            this.numTMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTMax.Name = "numTMax";
            this.numTMax.Size = new System.Drawing.Size(62, 20);
            this.numTMax.TabIndex = 10;
            this.numTMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tortoise Maximum Speed";
            // 
            // numTMin
            // 
            this.numTMin.Location = new System.Drawing.Point(141, 135);
            this.numTMin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTMin.Name = "numTMin";
            this.numTMin.Size = new System.Drawing.Size(62, 20);
            this.numTMin.TabIndex = 8;
            this.numTMin.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tortoise Minimum Speed";
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(226, 195);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(96, 54);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(17, 195);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(186, 54);
            this.lblOut.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.numTMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numHMax);
            this.Controls.Add(this.lblHMax);
            this.Controls.Add(this.numHMin);
            this.Controls.Add(this.lblHMin);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form";
            this.Text = "The Hare And The Tortoise Racing";
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.Label lblHMin;
        private System.Windows.Forms.NumericUpDown numHMin;
        private System.Windows.Forms.NumericUpDown numHMax;
        private System.Windows.Forms.Label lblHMax;
        private System.Windows.Forms.NumericUpDown numTMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblOut;
    }
}

