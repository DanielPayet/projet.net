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
                    pict.Click += ( object sender, EventArgs e ) => clickOnPicture( sender, e, image );
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

        private void clickOnPicture( object sender, EventArgs e, Image image ) {
            PictureBox imageSender = sender as PictureBox;
            MouseEventArgs mouseEvent = e as MouseEventArgs;
            if ( imageSender != null ) {
                this.imageClicked = imageSender.ImageLocation;
                if ( mouseEvent.Button == MouseButtons.Left ) {
                    this.pictureRightView.Image = System.Drawing.Image.FromFile( imageClicked );
                    this.pictureRightView.ImageLocation = imageClicked;
                    this.pictureRightView.SizeMode = PictureBoxSizeMode.Zoom;
                    this.listeTagsImage.Items.Clear( );
                    if ( image.getTags( ).Count( ) == 0 ) {
                        this.listeTagsImage.Items.Add( "Aucun tag sur cette image" );
                    } else {
                        image.getTags( ).ForEach( ( tag ) => this.listeTagsImage.Items.Add( tag.getName( ) ) );
                    }

                    this.addTag.Click += ( object send, EventArgs ev ) => Console.WriteLine( ShowTagDialog( image ) );
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
                this.update_view( );
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

        // Handles the local tags process
        private void toolStripButtonTags_Click( object sender, EventArgs e ) {
            new Tags( ).Show( );
        }
        private void ajouterUnTagToolStripMenuItem_Click( object sender, EventArgs e ) {
            new addTagToPicture( ).Show( );
        }

        private List<Tag> ShowTagDialog( Image image ) {
            List<Tag> nouvelleListe = new List<Tag>( );
            Form prompt = new Form( );
            prompt.Width = 800;
            prompt.Height = 600;

            TableLayoutPanel panel = new System.Windows.Forms.TableLayoutPanel( );
            panel.ColumnCount = 1;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.RowCount = 2;
            panel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 80F ) );
            panel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.AutoSize ) );

            TableLayoutPanel panelDown = new System.Windows.Forms.TableLayoutPanel( );
            panelDown.ColumnCount = 2;
            panelDown.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            panelDown.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDown.RowCount = 1;

            ListBox tagGlobal = new ListBox( );
            tagGlobal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tagGlobal.Dock = System.Windows.Forms.DockStyle.Fill;

            GroupBox legendeTagGlobal = new GroupBox( );
            legendeTagGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            legendeTagGlobal.Text = "Tags globaux";

            ListBox tagImageAModifier = new ListBox( );
            tagImageAModifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tagImageAModifier.Dock = System.Windows.Forms.DockStyle.Fill;

            GroupBox legendeTagsImage = new GroupBox( );
            legendeTagsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            legendeTagsImage.Text = "Tags de l'image";

            Button confirmation = new Button( ) { Text = "Valider" };
            confirmation.Dock = System.Windows.Forms.DockStyle.Right;
            confirmation.Click += ( sender, e ) => { prompt.Close( ); };
            prompt.Controls.Add( panel );
            panel.Controls.Add( panelDown, 0, 0 );
            panel.Controls.Add( confirmation, 0, 1 );
            panelDown.Controls.Add( legendeTagGlobal, 0, 0 );
            panelDown.Controls.Add( legendeTagsImage, 1, 0 );
            legendeTagGlobal.Controls.Add( tagGlobal );
            legendeTagsImage.Controls.Add( tagImageAModifier );

            Base.getInstance( ).getGlobalTags( ).ForEach( tag => tagGlobal.Items.Add( tag.getName( ) ) );
            image.getTags( ).ForEach( tag => tagImageAModifier.Items.Add( tag.getName( ) ) );
            if ( image.getTags( ).Count( ) == 0 ) {
                tagImageAModifier.Enabled = false;
                tagImageAModifier.Items.Add( "Aucun tag dans cette image" );
            }

            prompt.ShowDialog( );
            return getNewList( tagImageAModifier.Items );
        }

        private List<Tag> getNewList( ListBox.ObjectCollection items ) {
            List<Tag> tags = new List<model.Tag>( );
            foreach ( var _iterator in items ) {
                tags.Add( new model.Tag( _iterator.ToString( ) ) );

            }
            return tags;
        }
    }
}
