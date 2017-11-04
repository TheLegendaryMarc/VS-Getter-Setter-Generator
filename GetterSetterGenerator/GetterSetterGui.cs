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
            string access = selectaccess.Text;

            if (var == null || type == null || access == null)
            {
                MessageBox.Show("Bitte überprüfen sie ihre Eingaben");
            }
            else
            {
                //Clipboard.SetData(generate(var, type, access), TextDataFormat.Html);
                richoutput.Text = generate(var, type, access);
            }
        }

        private string generate(string var, string type, string access)
        {
            return access + " " + type + " get" + type + "()" + Environment.NewLine + "  {" + Environment.NewLine + "     return " + var + ";" + Environment.NewLine + "   }" + Environment.NewLine + " " + access + " void set" + var + "(" + type + " p" + var + ")" + Environment.NewLine + "   {" + Environment.NewLine + var + " = p" + var + ";" + Environment.NewLine + "   }";
        }
    }
}
