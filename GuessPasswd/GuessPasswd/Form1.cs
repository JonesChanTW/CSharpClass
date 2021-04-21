using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessPasswd
{
    public partial class Form1 : Form
    {
        const int MIN_NUM = 1;
        const int MAX_NUM = 100;
        const bool GAME_START = true;

        private Byte iNum = 0;
        private int iLeft = MIN_NUM, iRight = MAX_NUM;
        private int iGuestCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblGuessResult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitialGame();
        }

        private void InitialGame()
        {
            Random rnd = new Random();


            this.ClearInput();
            iNum = (Byte)rnd.Next(MIN_NUM, MAX_NUM+1);
            iLeft = MIN_NUM;
            iRight = MAX_NUM;
            txtInput.Text = "";
            lblGuessResult.Text = "";
            btnAgain.Enabled = !GAME_START;
            btnAgain.Visible = !GAME_START;
            btnGuess.Enabled = GAME_START;
            btnGuess.Visible = GAME_START;
            iGuestCount = 0;
        }

        private void ClearInput()
        {
            txtInput.Text = "";
            
            this.ActiveControl = txtInput;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            this.InitialGame();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int iUserInput = 0;


            if (txtInput.Text.Length <= 0)
            {
                MessageBox.Show("請輸入點東西吧!!!");
            }
            if(!int.TryParse(txtInput.Text, out iUserInput))
            {
                MessageBox.Show("只准輸入數字");
            }
            if(iUserInput > iRight || iUserInput < iLeft)
            {
                lblGuessResult.Text = "答案只能在" + iLeft + "~" + iRight + "之間";
            }
            iGuestCount++;
            if (iNum == iUserInput)
            {
                lblGuessResult.Text = "恭喜答對,一共猜了" + iGuestCount + "次";
                this.GameFinish();
                return;
            }
            if(iUserInput > iNum)
            {
                if(iUserInput < iRight)
                {
                    iRight = iUserInput;
                }
            }

            if(iUserInput < iNum)
            {
                if(iUserInput > iLeft)
                {
                    iLeft = iUserInput;
                }
            }


            lblGuessResult.Text = "錯誤-答案只能在" + iLeft + "~" + iRight + "之間";
            this.ActiveControl = txtInput;
            txtInput.SelectAll();
        }

        private void GameFinish()
        {
            btnAgain.Enabled = GAME_START;
            btnAgain.Visible = GAME_START;
            btnGuess.Enabled = !GAME_START;
            btnGuess.Visible = !GAME_START;
        }
    }
}
