using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_language_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bn");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    break;
                case 3:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hi");
                    break;
            }

            int temp = comboBox1.SelectedIndex;
            this.Controls.Clear();
            InitializeComponent(temp);
      



        }
    }
}
