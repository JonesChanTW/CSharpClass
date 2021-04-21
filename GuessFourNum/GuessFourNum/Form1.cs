using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessFourNum
{
    
    public partial class Form1 : Form
    {
        const int MAX_NUMBERS = 4;

        int[] iNums = new int[MAX_NUMBERS];
        int iGuessCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateFourNumbers()
        {
            int iCnt = 0;
            Random rnd = new Random();
            bool isSame = false;

            do
            {
                isSame = false;
                iNums[iCnt] = rnd.Next(0, 10);
                for (int i = 0; i < iCnt && !isSame; i++)
                {
                    isSame = iNums[iCnt] == iNums[i];
                }
                if (!isSame)
                {
                    iCnt++;
                }
            }
            while (iCnt < MAX_NUMBERS);

            this.ShowHint();
        }

        private void ShowHint()
        {
            string strHint = "";

            strHint += iNums[0];

            for (int i = 1; i < MAX_NUMBERS; i++)
            {
                strHint += ", " + iNums[i];
            }

            lblHint.Text = strHint;
        }

        private void onLoad(object sender, EventArgs e)
        {
            this.InitialGame();
        }

        private void InitialGame()
        {
            lblErrorMsg.Visible = false;
            //lblErrorMsg.Enabled = false;
            this.CreateFourNumbers();
            this.ClearInput();
            btnGuess.Enabled = false;
            btnNewRound.Enabled = false;
            btnNewRound.Visible = false;
            btnGuess.Enabled = true;
            btnGuess.Visible = true;
        }
        private void ClearInput()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            this.ActiveControl = textBox1;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int iTmpNum = 0;

            if(((TextBox)sender).Text.Length <= 0)
            {
                ///沒有東西被輸入 不用判斷了
                return;
            }
            if (!int.TryParse(((TextBox)sender).Text, out iTmpNum))
            {
                ///輸入的不是數字
                ((TextBox)sender).Text = "";
                MessageBox.Show("僅接受個位數字輸入");
            }
            if(iTmpNum > 9)
            {
                ///輸入的不是個位數字
                ((TextBox)sender).Text = "";
                MessageBox.Show("僅接受個位數字輸入");
            }
            lblErrorMsg.Visible = false;
            ///檢查是否符合輸入條件以此決定是否打開按鈕
            this.CheckCanEnableButton();
        }

        private void CheckCanEnableButton()
        {
            bool bEnable = true;
            int iTmpNum = 0;


            bEnable &= int.TryParse(textBox1.Text, out iTmpNum);
            bEnable &= (iTmpNum <= 9);
            bEnable &= int.TryParse(textBox2.Text, out iTmpNum);
            bEnable &= (iTmpNum <= 9);
            bEnable &= int.TryParse(textBox3.Text, out iTmpNum);
            bEnable &= (iTmpNum <= 9);
            bEnable &= int.TryParse(textBox4.Text, out iTmpNum);
            bEnable &= (iTmpNum <= 9);

            btnGuess.Enabled = bEnable;
        }

        private void onGuessClick(object sender, EventArgs e)
        {
            int[] iUserInput = new int[MAX_NUMBERS];
            int iSameSpace = 0, iSameNum = 0;

            ///能進到這裡前面該檢查的應該都檢查過了,這些都是合法輸入,只要確定是否重複就好
            int.TryParse(textBox1.Text, out iUserInput[0]);
            int.TryParse(textBox2.Text, out iUserInput[1]);
            int.TryParse(textBox3.Text, out iUserInput[2]);
            int.TryParse(textBox4.Text, out iUserInput[3]);


            ///輸入重複檢查
            for(int i = 0; i < MAX_NUMBERS; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(iUserInput[i] == iUserInput[j])
                    {
                        lblErrorMsg.Text = "輸入的數字有重複,請重新確認";
                        lblErrorMsg.Visible = true;
                        return;
                    }
                }
            }

            ///結果判斷
            for (int i = 0; i < MAX_NUMBERS; i++)
            {
                for (int j = 0; j < MAX_NUMBERS; j++)
                {
                    if (iNums[i] == iUserInput[j])
                    {
                        if(i == j)
                        {
                            iSameSpace++;
                        }
                        else
                        {
                            iSameNum++;
                        }
                        break;
                    }
                }
            }

            iGuessCount++;
            
            if (iSameSpace == MAX_NUMBERS)
            {
                lblGuessResult.Text = iSameSpace + "A" + iSameNum + "B, 恭喜答對,一共猜了" + iGuessCount + "次";
                btnNewRound.Enabled = true;
                btnNewRound.Visible = true;
                btnGuess.Enabled = false;
                btnGuess.Visible = false;
            }
            else
            {
                lblGuessResult.Text = iSameSpace + "A" + iSameNum + "B";
                this.ClearInput();
            }
        }

        private void onNewRoundClick(object sender, EventArgs e)
        {
            this.InitialGame();
        }
    }
}
