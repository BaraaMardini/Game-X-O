using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using لعبة__X______O.Properties;

namespace لعبة__X______O
{
    public partial class Form1 : Form
    {
        static public  int  PB11 = 0;
        int  PB12 = 0;
        int  PB13 = 0;
        int  PB14 = 0;
        int  PB15 = 0;
        int  PB16 = 0;
        int  PB17 = 0;
        int  PB18 = 0;
        int  PB19 = 0;
        int  X = 1;
        char PB111;
        char PB112;
        char PB113;
        char PB114;
        char PB115;
        char PB116;
        char PB117;
        char PB118;
        char PB119;

                


        public Form1()
        {
            InitializeComponent();
        }


         void CheakThePlayerIsWin()
        {
            if(PB111=='X'&&PB112=='X'&&PB113=='X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;
            }
            if (PB111 == 'X' && PB115 == 'X' && PB119 == 'X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;
            }

            if (PB111 == 'X' && PB114 == 'X' && PB117 == 'X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;
            }

            if (PB112== 'X' && PB115 == 'X' && PB118 == 'X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;
            }
            if (PB113 == 'X' && PB115 == 'X' && PB117 == 'X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;
            }
            if (PB113 == 'X' && PB116 == 'X' && PB119 == 'X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;
            }
            if (PB114 == 'X' && PB115 == 'X' && PB116 == 'X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }
            if (PB117 == 'X' && PB118 == 'X' && PB119 == 'X')
            {
                label5.Text = "Player1";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }



            //VDBDFBDFB
            if (PB111 == 'O' && PB112 == 'O' && PB113 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }
            if (PB111 == 'O' && PB115 == 'O' && PB119 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }

            if (PB111 == 'O' && PB114 == 'O' && PB117 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }

            if (PB112 == 'O' && PB115 == 'O' && PB118 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }
            if (PB113 == 'O' && PB115 == 'O' && PB117 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }
            if (PB113 == 'O' && PB116 == 'O' && PB119 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }
            if (PB114 == 'O' && PB115 == 'O' && PB116 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;

            }
            if (PB117 == 'O' && PB118 == 'O' && PB119 == 'O')
            {
                label5.Text = "Player2";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
                return;
            }
            else
            {
                label5.Text = "No One";
            }







        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PB1_Click(object sender, EventArgs e)
        {
            if (PB11 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB11++;
            X++;

            if (X % 2 != 0)
            {
                PB1.Image = Resources.O;
                PB111 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB1.Image = Resources.X;
                PB111 = 'X';
                label3.Text = "Player2";
            }

            CheakThePlayerIsWin();


        }

        private void PB2_Click(object sender, EventArgs e)
        {
            if (PB12 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB12++;


            X++;

            if (X % 2 != 0) {
                PB2.Image = Resources.O;
                PB112 = 'O'; 
                label3.Text = "Player1";
            }

            else
            {

                PB2.Image = Resources.X;
                PB112 = 'X';
                label3.Text = "Player2";
            }


            CheakThePlayerIsWin();
        }

        private void PB3_Click(object sender, EventArgs e)
        {

            if (PB13 == 1 )
            {
                MessageBox.Show("Worng Choise","Worng",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              
            }
            PB13++;


            X++;

            if (X % 2 != 0)
            {
                PB3.Image = Resources.O;
                PB113 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB3.Image = Resources.X;
                PB113 = 'X';
                label3.Text = "Player2";
            }

            CheakThePlayerIsWin();


        }

        private void PB4_Click(object sender, EventArgs e)
        {

            if (PB14 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB14++;


            X++;

            if (X % 2 != 0)
            {
                PB4.Image = Resources.O;
                PB114 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB4.Image = Resources.X;
                PB114= 'X';
                label3.Text = "Player2";
            }
            CheakThePlayerIsWin();


        }

        private void PB5_Click(object sender, EventArgs e)
        {

            if (PB15 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB15++;


            X++;

            if (X % 2 != 0)
            {
                PB5.Image = Resources.O;
                PB115 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB5.Image = Resources.X;
                PB115 = 'X';
                label3.Text = "Player2";
            }
            CheakThePlayerIsWin();
        }

        private void PB6_Click(object sender, EventArgs e)
        {



            if (PB16 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB16++;


            X++;

            if (X % 2 != 0)
            {
                PB6.Image = Resources.O;
                PB116 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB6.Image = Resources.X;
                PB116 = 'X'; 
                label3.Text = "Player2";
            }

            CheakThePlayerIsWin();
        }

        private void PB7_Click(object sender, EventArgs e)
        {




            if (PB17 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB17++;


            X++;

            if (X % 2 != 0)
            {
                PB7.Image = Resources.O;
                PB117 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB7.Image = Resources.X;
                PB117 = 'X';
                label3.Text = "Player2";
            }
            CheakThePlayerIsWin();
        }

        private void PB8_Click(object sender, EventArgs e)
        {


            if (PB18 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB18++;


            X++;

            if (X % 2 != 0)
            {
                PB8.Image = Resources.O;
                PB118 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB8.Image = Resources.X;
                PB118 = 'X';
                label3.Text = "Player2";
            }
            CheakThePlayerIsWin();
        }

        private void PB9_Click(object sender, EventArgs e)
        {

            if (PB19 == 1)
            {
                MessageBox.Show("Worng Choise", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            PB19++;
           

            X++;

            if (X % 2 != 0)
            {
                PB9.Image = Resources.O;
                PB119 = 'O';
                label3.Text = "Player1";
            }

            else
            {

                PB9.Image = Resources.X;
                PB119 = 'X';
                label3.Text = "Player2";
            }
            CheakThePlayerIsWin();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PB11 = 0;
            PB12 = 0;
            PB13 = 0;
            PB14 = 0;
            PB15 = 0;
            PB16 = 0;
            PB17 = 0;
            PB18 = 0;
            PB19 = 0;
            X = 1;
            PB1.Image= Resources.question_mark_96;
            PB2.Image= Resources.question_mark_96;
            PB3.Image= Resources.question_mark_96;
            PB4.Image = Resources.question_mark_96;
            PB5.Image = Resources.question_mark_96;
            PB6.Image = Resources.question_mark_96;
            PB7.Image = Resources.question_mark_96;
            PB8.Image = Resources.question_mark_96;
            PB9.Image = Resources.question_mark_96;
            PB1.Enabled = true ;
            PB2.Enabled = true ;
            PB3.Enabled = true ;
            PB4.Enabled = true ;
            PB5.Enabled = true ;
            PB6.Enabled = true ;
            PB7.Enabled = true ;
            PB8.Enabled = true ;
            PB9.Enabled = true;
            label3.Text = "Player1";
            label5.Text = "In Progress";

            PB111 = 'd';

            PB112 = 'd';
            PB113 = 'd';
            PB114 = 'd';
            PB115 = 'd';
            PB116 = 'd';
            PB117 = 'd';
            PB118 = 'd';
            PB119 = 'd';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
