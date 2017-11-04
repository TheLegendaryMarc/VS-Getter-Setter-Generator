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
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            string var = txtvar.Text;
            string type = txttype.Text;

            if(var == null || type == null)
            {
                MessageBox.Show("Variable oder Typ nicht gesetzt oder falsch");
            }
            else
            {
                richoutput.Text = generate(var, type);
            }
        }

        private string generate(string var,string type)
        {
            return "public " + type + " get"+type+"(){return "+var+";} public void set"+var+"("+type+" p"+var+"){"+var+" = p"+var+";}";
        }
    }
}
