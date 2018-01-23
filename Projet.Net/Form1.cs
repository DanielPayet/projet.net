using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the control the Button control is located in. In this case a GroupBox.
            Control control = button1.Parent;
            // Set the text and backcolor of the parent control.
            control.Text = "My Groupbox";
            control.BackColor = Color.Blue;
            // Get the form that the Button control is contained within.
            Form myForm = button1.FindForm();
            // Set the text and color of the form containing the Button.
            myForm.Text = "The Form of My Control";
            myForm.BackColor = Color.Red;
        }
    }
}
