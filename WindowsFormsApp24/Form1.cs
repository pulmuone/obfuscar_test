using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public string UserName = "gwise";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();

            label1.Text = class1.UserID;

            ClassLibrary2.Class1 class2 = new ClassLibrary2.Class1();

            label2.Text = class2.UserID;
        }
    }
}
