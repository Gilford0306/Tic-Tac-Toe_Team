using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Team
{
    public partial class Form1 : Form
    {
        int posX, posY, step;
        bool turn = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Restart_Game(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Began_Game();
        }
        private void Main_Menu(object sender, System.EventArgs e)
        {
            posX = -40;
            posY = 60;
            step = 0;
            this.Controls.Clear();
            this.Controls.Add(Start);
            this.Controls.Add(Exist);
        }
        private void Pre_Load_Field(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Field[i] = new Button();
                Field[i].Name = $"index_{i}";
                Field[i].Width = 100;
                Field[i].Height = 100;
                Field[i].BackColor = Color.FromArgb(255, 255, 255);
                Field[i].Font = new Font("Comic Sans MS", 25);
                Field[i].Location = new Point(posX += 100, posY);
                if ((i + 1) % 3 == 0)
                {
                    posY += 100;
                    posX = -40;
                }
            }
            Field[0].Click += Click_Button_Field1;
            Field[1].Click += Click_Button_Field2;
            Field[2].Click += Click_Button_Field3;
            Field[3].Click += Click_Button_Field4;
            Field[4].Click += Click_Button_Field5;
            Field[5].Click += Click_Button_Field6;
            Field[6].Click += Click_Button_Field7;
            Field[7].Click += Click_Button_Field8;
            Field[8].Click += Click_Button_Field9;
        }
        private void Click_Button_Field1(object sender, System.EventArgs e)
        {
            Turn_Click(Field[0]);
        }
        private void Click_Button_Field2(object sender, System.EventArgs e)
        {
            Turn_Click(Field[1]);
        }
        private void Click_Button_Field3(object sender, System.EventArgs e)
        {
            Turn_Click(Field[2]);
        }
        private void Click_Button_Field4(object sender, System.EventArgs e)
        {
            Turn_Click(Field[3]);
        }
        private void Click_Button_Field5(object sender, System.EventArgs e)
        {
            Turn_Click(Field[4]);
        }
        private void Click_Button_Field6(object sender, System.EventArgs e)
        {
            Turn_Click(Field[5]);
        }
        private void Click_Button_Field7(object sender, System.EventArgs e)
        {
            Turn_Click(Field[6]);
        }
        private void Click_Button_Field8(object sender, System.EventArgs e)
        {
            Turn_Click(Field[7]);
        }
        private void Click_Button_Field9(object sender, System.EventArgs e)
        {
            Turn_Click(Field[8]);
        }

        private void Began_Game()
        {
            turn = true;
            PlayerTurn.Text = "X turn";
            for (int i = 0; i < 9; i++)
            {
                if (Field[i].Enabled == false && Field[i].Text != null)
                {
                    Field[i].Enabled = true;
                    Field[i].Text = null;
                }
                this.Controls.Add(Field[i]);
            }
            this.Controls.Add(PlayerTurn);
            this.Controls.Add(BackToMenu);
        }
        private void Turn_Click(Button btn)
        {
            if (turn)
            {
                step++;
                btn.Text = "X";
                if (Check_Win_X())
                {
                    PlayerTurn.Text = "X win!!!";
                    End_Game();
                }
                else if (step == 9)
                    PlayerTurn.Text = "Friendship!!!☺";
                else
                    PlayerTurn.Text = "O turn";
                turn = false;
            }
            else
            {
                step++;
                btn.Text = "O";
                if (Check_Win_O())
                {
                    PlayerTurn.Text = "O win!!!";
                    End_Game();
                }
                else if (step == 9)
                    PlayerTurn.Text = "Friendship!!!☺";
                else
                    PlayerTurn.Text = "X turn";
                turn = true;
            }
            btn.Enabled = false;
        }
        public void End_Game()
        {
            if (Field[0].Enabled == true)
                Field[0].Enabled = false;
            if (Field[1].Enabled == true)
                Field[1].Enabled = false;
            if (Field[2].Enabled == true)
                Field[2].Enabled = false;
            if (Field[3].Enabled == true)
                Field[3].Enabled = false;
            if (Field[4].Enabled == true)
                Field[4].Enabled = false;
            if (Field[5].Enabled == true)
                Field[5].Enabled = false;
            if (Field[6].Enabled == true)
                Field[6].Enabled = false;
            if (Field[7].Enabled == true)
                Field[7].Enabled = false;
            if (Field[8].Enabled == true)
                Field[8].Enabled = false;
        }
        public bool Check_Win_X()
        {
            if (Field[0].Text == "X" && Field[1].Text == "X" && Field[2].Text == "X")
                return true;
            else if (Field[3].Text == "X" && Field[4].Text == "X" && Field[5].Text == "X")
                return true;
            else if (Field[6].Text == "X" && Field[7].Text == "X" && Field[8].Text == "X")
                return true;
            else if (Field[0].Text == "X" && Field[3].Text == "X" && Field[6].Text == "X")
                return true;
            else if (Field[1].Text == "X" && Field[4].Text == "X" && Field[7].Text == "X")
                return true;
            else if (Field[2].Text == "X" && Field[5].Text == "X" && Field[8].Text == "X")
                return true;
            else if (Field[0].Text == "X" && Field[4].Text == "X" && Field[8].Text == "X")
                return true;
            else if (Field[2].Text == "X" && Field[4].Text == "X" && Field[6].Text == "X")
                return true;
            return false;
        }
        public bool Check_Win_O()
        {
            if (Field[0].Text == "O" && Field[1].Text == "O" && Field[2].Text == "O")
                return true;
            else if (Field[3].Text == "O" && Field[4].Text == "O" && Field[5].Text == "O")
                return true;
            else if (Field[6].Text == "O" && Field[7].Text == "O" && Field[8].Text == "O")
                return true;
            else if (Field[0].Text == "O" && Field[3].Text == "O" && Field[6].Text == "O")
                return true;
            else if (Field[1].Text == "O" && Field[4].Text == "O" && Field[7].Text == "O")
                return true;
            else if (Field[2].Text == "O" && Field[5].Text == "O" && Field[8].Text == "O")
                return true;
            else if (Field[0].Text == "O" && Field[4].Text == "O" && Field[8].Text == "O")
                return true;
            else if (Field[2].Text == "O" && Field[4].Text == "O" && Field[6].Text == "O")
                return true;
            return false;
        }
    }
}
