namespace Project_MATH_QUIZ
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudnumberofq = new System.Windows.Forms.NumericUpDown();
            this.nudtimer = new System.Windows.Forms.NumericUpDown();
            this.cbdificulty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumberofq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(459, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Time";
            // 
            // nudnumberofq
            // 
            this.nudnumberofq.BackColor = System.Drawing.Color.RosyBrown;
            this.nudnumberofq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudnumberofq.Location = new System.Drawing.Point(516, 308);
            this.nudnumberofq.Name = "nudnumberofq";
            this.nudnumberofq.Size = new System.Drawing.Size(153, 36);
            this.nudnumberofq.TabIndex = 2;
            // 
            // nudtimer
            // 
            this.nudtimer.BackColor = System.Drawing.Color.RosyBrown;
            this.nudtimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudtimer.Location = new System.Drawing.Point(936, 210);
            this.nudtimer.Name = "nudtimer";
            this.nudtimer.Size = new System.Drawing.Size(153, 36);
            this.nudtimer.TabIndex = 3;
            // 
            // cbdificulty
            // 
            this.cbdificulty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbdificulty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbdificulty.DropDownHeight = 150;
            this.cbdificulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdificulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdificulty.FormattingEnabled = true;
            this.cbdificulty.IntegralHeight = false;
            this.cbdificulty.Items.AddRange(new object[] {
            "easy",
            "medium",
            "hard"});
            this.cbdificulty.Location = new System.Drawing.Point(516, 209);
            this.cbdificulty.Name = "cbdificulty";
            this.cbdificulty.Size = new System.Drawing.Size(153, 37);
            this.cbdificulty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "dificulty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "number of question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time/question";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(411, 496);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(139, 57);
            this.btnstart.TabIndex = 8;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1322, 706);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbdificulty);
            this.Controls.Add(this.nudtimer);
            this.Controls.Add(this.nudnumberofq);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudnumberofq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudnumberofq;
        private System.Windows.Forms.NumericUpDown nudtimer;
        private System.Windows.Forms.ComboBox cbdificulty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnstart;
    }
}

