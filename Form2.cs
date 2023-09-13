using System;
using System.Threading;
using System.Windows.Forms;

namespace Project_MATH_QUIZ
{
    public partial class Form2 : Form
    {
        public Form2(string dificulty, int number_of_question, int time)
        {
            InitializeComponent();
            this.dificulty = dificulty;
            this.number_of_question = number_of_question;
            this.time = time;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblnumofq.Text = number_of_question.ToString();

            Set_up_question();
        }

        readonly string dificulty;
        int number_of_question;
        readonly int time;
        int ans;
        readonly Random rnd = new Random();
        Op op;
        int answered = 0;


        enum Op
        {
            add, sub , mul, div
        }


        private char Operator()
        {
            switch (op)
            {
                case Op.add:
                    return '+';
                case Op.sub:
                    return '-';
                case Op.mul:
                    return '*';
                case Op.div:
                    return '/';
                default:
                    return ' ';
            }
        }

        private void Q(byte l, byte u)
        {
            op = (Op)rnd.Next(0, 4);
            int a = rnd.Next(l, u), b = rnd.Next(l, u);
            lblquestoin.Text = a.ToString() + " " + Operator() + " " + b.ToString();

            if (op == Op.add)
                ans = a + b;
            else if (op == Op.sub)
                ans = a - b;
            else if (op == Op.mul)
                ans = a * b;
            else if (op == Op.div)
                ans = a / b;


        }

        private void Set_up_ans()
        {
            // can be better
            if(op == Op.add)
            {
                lblans1.Text = ans.ToString();
                lblans2.Text = (ans + 5).ToString();
                lblans3.Text = (ans - 3).ToString();
                lblans4.Text = (ans + 7 * 2).ToString();
            }
            else if (op == Op.sub)
            {
                lblans1.Text = (ans + 5).ToString();
                lblans2.Text = ans.ToString();
                lblans3.Text = (ans - 3).ToString();
                lblans4.Text = (ans + 4 * 2).ToString();
            }
            else if (op == Op.mul)
            {
                lblans1.Text = (ans + 5).ToString();
                lblans2.Text = (ans - 3).ToString();
                lblans3.Text = ans.ToString();
                lblans4.Text = (ans - 3 * 2).ToString();
            }
            else if (op == Op.div)
            {
                lblans1.Text = (ans + 6 * 2).ToString();
                lblans2.Text = (ans + 5).ToString();
                lblans3.Text = (ans - 3).ToString();
                lblans4.Text = ans.ToString();
            }

            lbltime.Text = time.ToString();

        }

        private void Set_up_question()
        {
            if (number_of_question-- == 0)
            {
                Refresh();
                Thread.Sleep(3000);
                this.Close();
            }
            switch (dificulty)
            {
                case "easy":
                    Q(1, 16);
                    break;
                case "medium":
                    Q(15, 41);
                    break;
                case "hard":
                    Q(40, 100);
                    break;

            }

            Set_up_ans();
        }

        private void Lblans1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(((Label)sender).Text) == ans)
            {
                lblstatus.Text = "sah";
                lblasnwered.Text = (++answered).ToString();
            }

            else
            {
                lblstatus.Text = "X";
            }

            Set_up_question();


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            int t = Convert.ToInt32(lbltime.Text);
            if(t-1 == 0)
            {
                lblstatus.Text = "X";
                Set_up_question();
            }
            else
                lbltime.Text = (--t).ToString();
        }
    }
}
