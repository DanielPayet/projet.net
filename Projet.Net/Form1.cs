using Projet.Net.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.Net {
    public partial class AppWindow: Form {
        private string imageClicked = null;

        public AppWindow() {
            InitializeComponent( );
            InitializeTags( );
            InitializeImage( );
        }

        private void InitializeTags() {
            updateTagsView( Base.getInstance( ).getNextTags( ) );
        }

        private void InitializeImage() {
            this.MosaiqueImages.Controls.Clear( );
            List<model.Image> images = Base.getInstance( ).imagesWithTags( );
            images.ForEach( ( image ) => {
                PictureBox pict = new PictureBox( );
                pict.Image = System.Drawing.Image.FromFile( Base.workspacePath + image.getPath( ) );
                pict.ImageLocation = Base.workspacePath + image.getPath( );
                pict.SizeMode = PictureBoxSizeMode.Zoom;
                pict.Width = 150;
                pict.Height = 150;
                pict.Click += Pict_Click;
                this.MosaiqueImages.Controls.Add( pict );
            } );
        }

        private void Pict_Click(object sender, EventArgs e ) {
            PictureBox image = sender as PictureBox;
            if ( image != null ) {
                this.imageClicked = image.ImageLocation;
                menuClickDroit.Show( Cursor.Position );
            }
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
                updateTagsView( Base.getInstance( ).getNextTags( ) );
            }
        }

        private void tags_SelectedIndexChanged( object sender, EventArgs e ) {

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
            List<Tag> listeTags = Base.getInstance( ).getNextTags( );
            List<Tag> tagFiltrer = listeTags.Where( tag => tag.getName( ).ToLower( ).Contains( expression.Trim( ).ToLower( ) ) ).ToList( );
            updateTagsView( tagFiltrer );
        }

        private void importerDesImagesToolStripMenuItem_Click( object sender, EventArgs e ) {
            DialogResult result = importerImageDialog.ShowDialog( );
            if ( result == DialogResult.OK ) {
                string[] files = importerImageDialog.FileNames;
                try {
                    Base.getInstance( ).importImage( files );
                    this.InitializeImage( );
                } catch ( IOException error ) {
                    Console.WriteLine( error );
                }
            }
        }

        private void ouvrirDansLexplorateurToolStripMenuItem_Click( object sender, EventArgs e ) {
            Process.Start( this.imageClicked );
        }

        private void ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem_Click( object sender, EventArgs e ) {
            Process.Start( Base.workspacePath );
        }
    }
}
