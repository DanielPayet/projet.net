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

namespace Projet.Net {
    public partial class AppWindow: Form {
        public AppWindow() {
            InitializeComponent( );
            InitializeTags( );
        }

        private void InitializeTags() {
            updateTagsView( Base.getInstance( ).tags );
        }

        private void leftAppButton_Click( object sender, EventArgs e ) {
            Application.Exit( );
        }

        private void eraseTagSearch_Click( object sender, EventArgs e ) {
            tagSearch.Text = "";
        }

        private void tagSearch_TextChanged( object sender, EventArgs e ) {
            if ( tagSearch.Text.Trim( ) != "" ) {
                filtrerTags( tagSearch.Text );
            } else {
                updateTagsView( Base.getInstance( ).tags );
            }
        }

        private void tags_SelectedIndexChanged( object sender, EventArgs e ) {
            tagSearch.Text = tags.SelectedItem.ToString( );
        }


        /**
         * Fonctions utiles
         */
        private void updateTagsView( List<Tag> tagsItems ) {
            tags.Items.Clear( );
            foreach ( Tag tag in tagsItems ) {
                tags.Items.Add( tag.getName( ).Trim());
            }
        }

        private void filtrerTags( string expression ) {
            List<Tag> listeTags = Base.getInstance( ).tags;
            List<Tag> tagFiltrer = listeTags.Where( tag => tag.getName( ).Contains( expression.Trim() ) ).ToList( );
            updateTagsView( tagFiltrer );
        }

    }
}
