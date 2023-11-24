using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script
{
    public partial class Form1 : Form
    {
        public Form1(Dictionary<string, float> dicionarioCheck)
        {
            InitializeComponent();

            foreach (var check in dicionarioCheck)
            {
                ////////////////////////////////////////////
                ////////////////////////////////////////////
                ///    valores corretos               //////
                ///    check.Value == 1               //////
                ///    Cor verde                      //////
                ////////////////////////////////////////////
                ////////////////////////////////////////////
                if (check.Value == 1)
                {
                    if (check.Key == "check1")
                    {
                        //Nome de cada painel que você arrastou e criou
                        // Aqui defini como sendo "panel1_Check1 //
                        panel1_Check1.BackColor = Color.Green;
                    }

                    else if (check.Key == "check2")
                    {
                        panel2_Check2.BackColor = Color.Green;
                    }

                    else if (check.Key == "check3")
                    {
                        panel3_Check3.BackColor = Color.Green;
                    }

                    else
                    { }

                }

                ////////////////////////////////////////////
                ////////////////////////////////////////////
                ///    valores incorretos             //////
                ///    check.Value == 0               //////
                ///    Cor Vermelha                   //////
                ////////////////////////////////////////////
                ////////////////////////////////////////////
                else if (check.Value == 0)
                {
                    if (check.Key == "check1")
                    {
                        panel1_Check1.BackColor = Color.Red;
                    }

                    else if (check.Key == "check2")
                    {
                        panel2_Check2.BackColor = Color.Red;
                    }

                    else if (check.Key == "check3")
                    {
                        panel3_Check3.BackColor = Color.Red;
                    }
                    else
                    { }
                }
                else
                { }

            }
        }

    }
}
