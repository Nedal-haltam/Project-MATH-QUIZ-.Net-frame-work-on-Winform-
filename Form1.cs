using System;
using System.Windows.Forms;

namespace Project_MATH_QUIZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool Valid_settings()
        {
            return cbdificulty.SelectedItem != null && nudnumberofq.Value != 0 && nudtimer.Value != 0;
        }

        
        private void Btnstart_Click(object sender, EventArgs e)
        {
            if(Valid_settings())
            {
                Form2 form2 = new Form2(cbdificulty.SelectedItem.ToString(), (int)nudnumberofq.Value, (int)nudtimer.Value);
                form2.Show();
            }

            else
                MessageBox.Show("Invalid quiz settings" , "revise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }
    }
}
