using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        const int MAX_NUMS = 6;
        private Label[] lblNuum = new Label[MAX_NUMS];
        public Form1()
        {
            InitializeComponent();

            lblNuum[0] = lblNum1;
            lblNuum[1] = lblNum2;
            lblNuum[2] = lblNum3;
            lblNuum[3] = lblNum4;
            lblNuum[4] = lblNum5;
            lblNuum[5] = lblNum6;
        }

        private void btnGetNums_Click(object sender, EventArgs e)
        {
            int[] nums = new int[6];
            int iGets = 0;
            Random rnd = new Random();
            bool hasSame = false;


            for (; iGets < MAX_NUMS;)
            {
                hasSame = false;
                nums[iGets] = rnd.Next(1, 50);
                for (int i = 0; i < iGets; i++)
                {
                    if (nums[i] == nums[iGets])
                    {
                        hasSame = true;
                        break;
                    }
                }
                if (!hasSame)
                {
                    iGets++;
                }
            }

            for (int i = 0; i < MAX_NUMS; i++)
            {
                lblNuum[i].Text = "" + nums[i];
            }
        }
    }
}
