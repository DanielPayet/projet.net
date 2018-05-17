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
        private Image imageClicked = null;

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
                    pict.Click += ( object sender, EventArgs e ) => clickOnPicture( sender, e, image );
                    this.MosaiqueImages.Controls.Add( pict );
                } catch ( Exception e ) {
                    Console.Error.WriteLine( e.Message );
                    MessageBox.Show( "Une erreur lors du chargement des images est survenu" );
                }
            } );
        }

        public void render() {
            this.updateTagsView( );
            this.updateSelectedTag( );
            this.InitializeImage( );
            if ( this.imageClicked != null ) {
                this.updateTagsImage( );
            }
        }

        public void mettreAJourImage( List<Tag> tags ) {
            Base.getInstance( ).getImages( ).Find( ( image ) => image.getId( ) == this.imageClicked.getId( ) ).tag( tags );
            this.render( );
            Base.getInstance( ).updateWorkspace( );
        }

        public void updateTagsImage() {
            this.listeTagsImage.Items.Clear( );
            if ( imageClicked.getTags( ).Count( ) == 0 ) {
                this.listeTagsImage.Items.Add( "Aucun tag sur cette image" );
            } else {
                imageClicked.getTags( ).ForEach( ( tag ) => this.listeTagsImage.Items.Add( tag.getName( ) ) );
            }
        }

        private void clickOnPicture( object sender, EventArgs e, Image image ) {
            PictureBox imageSender = sender as PictureBox;
            MouseEventArgs mouseEvent = e as MouseEventArgs;
            if ( imageSender != null ) {
                this.imageClicked = image;
                if ( mouseEvent.Button == MouseButtons.Left ) {
                    this.pictureRightView.Image = System.Drawing.Image.FromFile( Base.workspacePath + image.getPath( ) );
                    this.pictureRightView.ImageLocation = Base.workspacePath + image.getPath( );
                    this.pictureRightView.SizeMode = PictureBoxSizeMode.Zoom;
                    updateTagsImage( );
                    this.addTag.Click += ( object send, EventArgs ev ) => new addTagToPicture( this, image ).Show( );
                    this.panelDroit.Visible = true;
                } else if ( mouseEvent.Button == MouseButtons.Right ) {
                    menuClickDroit.Show( Cursor.Position );
                }
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
                Base.getInstance( ).selectTag( new Tag( tags.SelectedItem.ToString( ) ) );
                this.render( );
            }
        }

        private void updateSelectedTag() {
            this.listTagSelected.Controls.Clear( );
            List<Tag> tags = Base.getInstance( ).getSelectedTags( );
            tags.ForEach( ( tag ) => {
                Label textTag = new Label( );
                textTag.Text = tag.getName( ) + " ✖";
                textTag.Click += new System.EventHandler( ( object sender, EventArgs e ) => {
                    Label label = sender as Label;
                    Base.getInstance( ).deselectTag( new Tag( label.Text.Substring( 0, label.Text.Length - 2 ) ) );
                    this.render( );
                } );
                this.listTagSelected.Controls.Add( textTag );
            } );
        }

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
            Process.Start( Base.workspacePath + imageClicked.getPath( ) );
        }

        private void ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem_Click( object sender, EventArgs e ) {
            Process.Start( Base.workspacePath );
        }

        // Handles the local tags process
        private void toolStripButtonTags_Click( object sender, EventArgs e ) {
            new Tags( this ).Show( );
        }
        private void ajouterUnTagToolStripMenuItem_Click( object sender, EventArgs e ) {
            new addTagToPicture( this, this.imageClicked ).Show( );
        }
    }
}
