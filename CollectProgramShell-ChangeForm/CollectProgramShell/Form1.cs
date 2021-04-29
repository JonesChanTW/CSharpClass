﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectProgramShell
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            Program.SetNewForm(FORM_NAMES.eFORM2);

        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Move(object sender, EventArgs e)
        {
            Program.SyncLocation();
        }
    }
}
