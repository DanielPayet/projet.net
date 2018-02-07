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
            InitializeImage( );
        }

        private void InitializeTags() {
            updateTagsView( Base.getInstance( ).getNextTags() );
        }

        private void InitializeImage() {
            List<model.Image> images = Base.getInstance( ).imagesWithTags( );
            images.ForEach( ( image ) => {
                PictureBox pict = new PictureBox( );
                pict.Image = System.Drawing.Image.FromFile( Base.workspacePath + image.getPath( ) );
                pict.SizeMode = PictureBoxSizeMode.Zoom;
                pict.Width = 150;
                pict.Height = 150;
                this.MosaiqueImages.Controls.Add( pict );
            } );
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
                updateTagsView( Base.getInstance( ).getNextTags() );
            }
        }

        private void tags_SelectedIndexChanged( object sender, EventArgs e ) {
            //tags.SelectedItem.ToString( );
        }

        /**
         * Fonctions utiles
         */
        private void updateTagsView( List<Tag> tagsItems ) {
            tags.Items.Clear( );
            foreach ( Tag tag in tagsItems ) {
                tags.Items.Add( tag.getName( ).Trim( ) );
            }
        }

        private void filtrerTags( string expression ) {
            List<Tag> listeTags = Base.getInstance( ).getNextTags();
            List<Tag> tagFiltrer = listeTags.Where( tag => tag.getName( ).ToLower().Contains( expression.Trim( ).ToLower() ) ).ToList( );
            updateTagsView( tagFiltrer );
        }
    }
}
