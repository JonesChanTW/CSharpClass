using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CollectProgramShell
{
    enum FORM_NAMES:int
    {
        eMAIN_MENU,
        eFORM2,
    }
    static class Program
    {
        static private Point oAppLocation;
        static private Form oCurrentForm = null;
        static private Dictionary<FORM_NAMES, Form> oProgramForms = new Dictionary<FORM_NAMES, Form>();
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>\
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            oProgramForms.Add(FORM_NAMES.eMAIN_MENU, new MainMenu());
            oProgramForms.Add(FORM_NAMES.eFORM2, new Form2());

            oCurrentForm = oProgramForms[FORM_NAMES.eMAIN_MENU];
            oProgramForms[FORM_NAMES.eMAIN_MENU].Show();
            oAppLocation = oProgramForms[FORM_NAMES.eMAIN_MENU].Location;

            foreach (KeyValuePair<FORM_NAMES, Form> pair in oProgramForms)
            {
                if (!pair.Value.Equals(oCurrentForm))
                {
                    pair.Value.Opacity = 0;
                    pair.Value.Show();
                    pair.Value.Location = oAppLocation;
                    pair.Value.Hide();
                    pair.Value.Opacity = 255;
                }
            }
            Application.Run();
        }

        static public void SyncLocation()
        {
            oAppLocation = oCurrentForm.Location;
            foreach (KeyValuePair<FORM_NAMES, Form> pair in oProgramForms)
            {
                if (!pair.Value.Equals(oCurrentForm))
                {
                    pair.Value.Opacity = 0;
                    pair.Value.Show();
                    pair.Value.Location = oAppLocation;
                    pair.Value.Hide();
                    pair.Value.Opacity = 255;
                }
            }
            //*/
        }

        static public void SetNewForm(FORM_NAMES eForm)
        {
            if(oProgramForms.ContainsKey(eForm))
            {
                if(oProgramForms[eForm] != null)
                {
                    oProgramForms[eForm].Show();
                    oCurrentForm.Hide();
                    oCurrentForm = oProgramForms[eForm];
                }
            }
        }

    }
}
