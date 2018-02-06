using Projet.Net.model;
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
    public partial class AppWindow : Form
    {
        public AppWindow()
        {
            InitializeComponent();
            InitializeTags();
        }

        private void InitializeTags() {
            foreach ( Tag tag in Base.getInstance( ).tags ) {
                tags.Items.Add( tag.getName() );
            }
        }

        private void leftAppButton_Click( object sender, EventArgs e ) {
            Application.Exit( );
        }

        private void eraseTagSearch_Click( object sender, EventArgs e ) {
            tagSearch.Text = "";
        }

        private void tagSearch_TextChanged( object sender, EventArgs e ) {
            Console.WriteLine( tagSearch.Text );
        }
    }
}
