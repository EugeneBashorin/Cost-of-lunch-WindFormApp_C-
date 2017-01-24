namespace CostOfLunch
{
    partial class Form1
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
            this.numberOfPeopleValue = new System.Windows.Forms.NumericUpDown();
            this.elementName = new System.Windows.Forms.Label();
            this.DecorationBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.elementCostName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.decorBirthday = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleValue)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfPeopleValue
            // 
            this.numberOfPeopleValue.Location = new System.Drawing.Point(44, 25);
            this.numberOfPeopleValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfPeopleValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleValue.Name = "numberOfPeopleValue";
            this.numberOfPeopleValue.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeopleValue.TabIndex = 0;
            this.numberOfPeopleValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // elementName
            // 
            this.elementName.AutoSize = true;
            this.elementName.Location = new System.Drawing.Point(41, 9);
            this.elementName.Name = "elementName";
            this.elementName.Size = new System.Drawing.Size(92, 13);
            this.elementName.TabIndex = 2;
            this.elementName.Text = "Number of People";
            // 
            // DecorationBox
            // 
            this.DecorationBox.AutoSize = true;
            this.DecorationBox.Checked = true;
            this.DecorationBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DecorationBox.Location = new System.Drawing.Point(44, 51);
            this.DecorationBox.Name = "DecorationBox";
            this.DecorationBox.Size = new System.Drawing.Size(115, 17);
            this.DecorationBox.TabIndex = 3;
            this.DecorationBox.Text = "Fancy Decorations";
            this.DecorationBox.UseVisualStyleBackColor = true;
            this.DecorationBox.CheckedChanged += new System.EventHandler(this.DecorationBox_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(44, 74);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(92, 17);
            this.healthyBox.TabIndex = 4;
            this.healthyBox.Text = "Healthy Menu";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(67, 153);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 5;
            // 
            // elementCostName
            // 
            this.elementCostName.AutoSize = true;
            this.elementCostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementCostName.Location = new System.Drawing.Point(3, 156);
            this.elementCostName.Name = "elementCostName";
            this.elementCostName.Size = new System.Drawing.Size(51, 20);
            this.elementCostName.TabIndex = 6;
            this.elementCostName.Text = "Cost:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(213, 217);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Controls.Add(this.elementCostName);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.elementName);
            this.tabPage1.Controls.Add(this.DecorationBox);
            this.tabPage1.Controls.Add(this.numberOfPeopleValue);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(205, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.decorBirthday);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(205, 191);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(7, 118);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(191, 20);
            this.cakeWriting.TabIndex = 21;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(102, 99);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 20;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cake Writing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cost:";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(67, 153);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(100, 23);
            this.birthdayCost.TabIndex = 17;
            // 
            // decorBirthday
            // 
            this.decorBirthday.AutoSize = true;
            this.decorBirthday.Checked = true;
            this.decorBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decorBirthday.Location = new System.Drawing.Point(44, 51);
            this.decorBirthday.Name = "decorBirthday";
            this.decorBirthday.Size = new System.Drawing.Size(115, 17);
            this.decorBirthday.TabIndex = 15;
            this.decorBirthday.Text = "Fancy Decorations";
            this.decorBirthday.UseVisualStyleBackColor = true;
            this.decorBirthday.CheckedChanged += new System.EventHandler(this.decorBirthday_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of People";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(44, 25);
            this.numberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 0;
            this.numberBirthday.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 213);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party planner";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleValue)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberOfPeopleValue;
        private System.Windows.Forms.Label elementName;
        private System.Windows.Forms.CheckBox DecorationBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label elementCostName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.CheckBox decorBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.TextBox cakeWriting;
    }
}

