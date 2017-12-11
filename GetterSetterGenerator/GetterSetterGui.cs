using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetterSetterGenerator
{
    public partial class GetterSetterGui : Form
    {
        public GetterSetterGui()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            string var = txtvar.Text;
            string type = selecttype.Text;

            if (var == null || type == null)
            {
                MessageBox.Show("Bitte überprüfen sie ihre Eingaben");
            }
            else
            {
                System.Windows.Forms.Clipboard.SetText(generate(var, type));
                this.Close();
                label4.Visible = true;
            }
        }

        private string generate(string var, string type)
        {
                return "private " + type + " " + var + ";" + Environment.NewLine +"public " + type + " get" + var + "()" + Environment.NewLine + "  {" + Environment.NewLine + "     return " + var + ";" + Environment.NewLine + "   }" + Environment.NewLine + "public void set" + var + "(" + type + " p" + var + ")" + Environment.NewLine + "   {" + Environment.NewLine + var + " = p" + var + ";" + Environment.NewLine + "   }";
        }
    }
}
