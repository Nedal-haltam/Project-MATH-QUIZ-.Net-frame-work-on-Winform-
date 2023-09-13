namespace Project_MATH_QUIZ
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.lblquestoin = new System.Windows.Forms.Label();
            this.lblans1 = new System.Windows.Forms.Label();
            this.lblans2 = new System.Windows.Forms.Label();
            this.lblans3 = new System.Windows.Forms.Label();
            this.lblans4 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblasnwered = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnumofq = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(455, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 101);
            this.label5.TabIndex = 10;
            this.label5.Text = "Math Time";
            // 
            // lblquestoin
            // 
            this.lblquestoin.AutoSize = true;
            this.lblquestoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestoin.Location = new System.Drawing.Point(457, 181);
            this.lblquestoin.Name = "lblquestoin";
            this.lblquestoin.Size = new System.Drawing.Size(323, 85);
            this.lblquestoin.TabIndex = 11;
            this.lblquestoin.Text = "question";
            // 
            // lblans1
            // 
            this.lblans1.AutoSize = true;
            this.lblans1.BackColor = System.Drawing.Color.LightGray;
            this.lblans1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblans1.Location = new System.Drawing.Point(212, 345);
            this.lblans1.Name = "lblans1";
            this.lblans1.Size = new System.Drawing.Size(280, 85);
            this.lblans1.TabIndex = 12;
            this.lblans1.Text = "answer";
            this.lblans1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lblans1_MouseClick);
            // 
            // lblans2
            // 
            this.lblans2.AutoSize = true;
            this.lblans2.BackColor = System.Drawing.Color.LightGray;
            this.lblans2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblans2.Location = new System.Drawing.Point(735, 345);
            this.lblans2.Name = "lblans2";
            this.lblans2.Size = new System.Drawing.Size(280, 85);
            this.lblans2.TabIndex = 13;
            this.lblans2.Text = "answer";
            this.lblans2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lblans1_MouseClick);
            // 
            // lblans3
            // 
            this.lblans3.AutoSize = true;
            this.lblans3.BackColor = System.Drawing.Color.LightGray;
            this.lblans3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblans3.Location = new System.Drawing.Point(212, 497);
            this.lblans3.Name = "lblans3";
            this.lblans3.Size = new System.Drawing.Size(280, 85);
            this.lblans3.TabIndex = 14;
            this.lblans3.Text = "answer";
            this.lblans3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lblans1_MouseClick);
            // 
            // lblans4
            // 
            this.lblans4.AutoSize = true;
            this.lblans4.BackColor = System.Drawing.Color.LightGray;
            this.lblans4.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblans4.Location = new System.Drawing.Point(735, 497);
            this.lblans4.Name = "lblans4";
            this.lblans4.Size = new System.Drawing.Size(280, 85);
            this.lblans4.TabIndex = 15;
            this.lblans4.Text = "answer";
            this.lblans4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lblans1_MouseClick);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(148, 181);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 85);
            this.lblstatus.TabIndex = 16;
            // 
            // lblasnwered
            // 
            this.lblasnwered.AutoSize = true;
            this.lblasnwered.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasnwered.Location = new System.Drawing.Point(56, 64);
            this.lblasnwered.Name = "lblasnwered";
            this.lblasnwered.Size = new System.Drawing.Size(79, 85);
            this.lblasnwered.TabIndex = 17;
            this.lblasnwered.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 85);
            this.label2.TabIndex = 18;
            this.label2.Text = "/";
            // 
            // lblnumofq
            // 
            this.lblnumofq.AutoSize = true;
            this.lblnumofq.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumofq.Location = new System.Drawing.Point(282, 64);
            this.lblnumofq.Name = "lblnumofq";
            this.lblnumofq.Size = new System.Drawing.Size(79, 85);
            this.lblnumofq.TabIndex = 19;
            this.lblnumofq.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(1114, 64);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(79, 85);
            this.lbltime.TabIndex = 20;
            this.lbltime.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1321, 738);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblnumofq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblasnwered);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblans4);
            this.Controls.Add(this.lblans3);
            this.Controls.Add(this.lblans2);
            this.Controls.Add(this.lblans1);
            this.Controls.Add(this.lblquestoin);
            this.Controls.Add(this.label5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblquestoin;
        private System.Windows.Forms.Label lblans1;
        private System.Windows.Forms.Label lblans2;
        private System.Windows.Forms.Label lblans3;
        private System.Windows.Forms.Label lblans4;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblasnwered;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnumofq;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
    }
}