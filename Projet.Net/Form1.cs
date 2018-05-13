using Projet.Net.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            updateTagsView( );
        }

        private void InitializeImage() {
            this.MosaiqueImages.Controls.Clear( );
            List<model.Image> images = Base.getInstance( ).imagesWithTags( );
            images.ForEach( ( image ) => {
                try {
                    PictureBox pict = new PictureBox( );
                    pict.Image = System.Drawing.Image.FromFile( Base.workspacePath + image.getPath( ) );
                    pict.ImageLocation = Base.workspacePath + image.getPath( );
                    pict.SizeMode = PictureBoxSizeMode.Zoom;
                    pict.Width = 150;
                    pict.Height = 150;
                    pict.Click += Pict_Click;
                    this.MosaiqueImages.Controls.Add( pict );
                } catch ( Exception e ) {
                    Console.Error.WriteLine( e.Message );
                    MessageBox.Show( "Une erreur lors du chargement des images est survenu" );
                }
            } );
        }

        private void update_view() {
            this.updateTagsView( );
            this.updateSelectedTag( );
            this.InitializeImage( );
        }

        private void Pict_Click( object sender, EventArgs e ) {
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
            if ( Base.getInstance( ).getNextTags( ).Count != 0 ) {
                if ( tagSearch.Text.Trim( ) != "" ) {
                    filtrerTags( tagSearch.Text );
                } else {
                    updateTagsView( );
                }
            }
        }

        private void tags_SelectedIndexChanged( object sender, EventArgs e ) {
            if ( Base.getInstance( ).getNextTags( ).Count != 0 && tags.SelectedItem != null ) {
                Base.getInstance( ).selectTag( new Tag(tags.SelectedItem.ToString()) );
                this.update_view( );
            }
        }

        private void updateSelectedTag() {
            this.listTagSelected.Controls.Clear( );
            List<Tag> tags = Base.getInstance( ).getSelectedTags( );
            tags.ForEach( ( tag ) => {
                Label textTag = new Label( );
                textTag.Text = tag.getName( ) + " ✖";
                textTag.Click += new System.EventHandler( (object sender, EventArgs e) => {
                    Label label = sender as Label;
                    Base.getInstance( ).deselectTag( new Tag(label.Text.Substring( 0, label.Text.Length - 2)));
                    this.update_view( );
                } );
                this.listTagSelected.Controls.Add( textTag );
            } );
        }

        /**
         * Fonctions utiles
         */
        private void updateTagsView() {
            List<Tag> tagsItems = Base.getInstance( ).getNextTags( );
            tags.BeginUpdate( );
            tags.Items.Clear( );
            if ( tagsItems.Count( ) == 0 ) {
                tags.Items.Add( "Aucun tag trouvé" );
            } else {
                foreach ( Tag tag in tagsItems ) {
                    tags.Items.Add( tag.getName( ).Trim( ) );
                }
            }
            tags.EndUpdate( );
        }

        private void updateTagsView( List<Tag> tagsItems ) {
            tags.BeginUpdate( );
            tags.Items.Clear( );
            if ( tagsItems.Count( ) == 0 ) {
                tags.Items.Add( "Aucun tag trouvé" );
            } else {
                foreach ( Tag tag in tagsItems ) {
                    tags.Items.Add( tag.getName( ).Trim( ) );
                }
            }
            tags.EndUpdate( );
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
