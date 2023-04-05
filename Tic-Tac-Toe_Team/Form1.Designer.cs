using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Team
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Tic-Tac-Toe";
            this.ShowIcon = false;

            this.MaximumSize = new Size(750, 450);
            this.Width = 750;
            this.Height = 450;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(189, 149, 121);
            this.Location = new Point(0, 0);

            this.Load += Main_Menu;
            this.Load += Pre_Load_Field;

            //
            //  Button start game
            //
            Start = new Button();
            Start.Font = new Font("Comic Sans MS", 25);
            Start.Width = 150;
            Start.Height = 50;
            Start.Location = new Point(290, 90);
            Start.Text = "Start";
            Start.FlatAppearance.BorderSize = 0;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Click += Start_Restart_Game;



            //
            //  Button close game
            //
            Exist = new Button();
            Exist.Font = new Font("Comic Sans MS", 25);
            Exist.Width = 150;
            Exist.Height = 50;
            Exist.Location = new Point(290, 165);
            Exist.Text = "Exist";
            Exist.FlatAppearance.BorderSize = 0;
            Exist.FlatStyle = FlatStyle.Flat;
            Exist.Click += (s, e) => { this.Close(); };



            //
            // Label turn players
            //
            PlayerTurn = new Label();
            PlayerTurn.Width = 330;
            PlayerTurn.Height = 50;
            PlayerTurn.Text = "X turn";
            PlayerTurn.BackColor = Color.FromArgb(189, 149, 121);
            PlayerTurn.BorderStyle = BorderStyle.None;
            PlayerTurn.Font = new Font("Comic Sans MS", 30);
            PlayerTurn.Location = new Point(420, 130);



            //
            //  Button back to main menu
            //
            BackToMenu = new Button();
            BackToMenu.Font = new Font("Comic Sans MS", 25);
            BackToMenu.Width = 250;
            BackToMenu.Height = 50;
            BackToMenu.FlatAppearance.BorderSize = 0;
            BackToMenu.FlatStyle = FlatStyle.Flat;
            BackToMenu.Text = "Back to menu";
            BackToMenu.Location = new Point(400, 290);
            BackToMenu.Click += Main_Menu;

        }
        Button Start;
        Button Exist;
        Button BackToMenu;
        Button[] Field = new Button[9];
        Label PlayerTurn;
        #endregion
    }
}

