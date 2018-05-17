using Projet.Net.model;
using System;
using System.Windows.Forms;

namespace Projet.Net {
    public partial class addTagToPicture: Form {
        private AppWindow main;
        private Image image;
        public addTagToPicture() {
            InitializeComponent( );
            updateLocalTagList( );
        }

        public addTagToPicture( AppWindow main, Image image ) {
            this.main = main;
            this.image = image;
            InitializeComponent( );
            updateLocalTagList( );
        }

        // Behavior of the button to add
        private void buttonAddTagToPicture_Click( object sender, EventArgs e ) {
            if ( listBoxLocalTags.SelectedItem != null ) {
                Tag tag = new Tag( this.listBoxLocalTags.SelectedItem as string );
                this.image.tag( tag );
                this.main.mettreAJourImage( this.image.getTags( ) );
                this.Close( );
            }
        }

        // Update the visual of the local list in Tags.cs
        private void updateLocalTagList() {
            listBoxLocalTags.BeginUpdate( );
            listBoxLocalTags.Items.Clear( );
            foreach ( Tag tag in Base.getInstance( ).getLocalTags( ) )
                listBoxLocalTags.Items.Add( tag.getName( ).Trim( ) );
            listBoxLocalTags.EndUpdate( );
        }

        private void listBoxLocalTags_SelectedIndexChanged( object sender, EventArgs e ) {
            this.buttonAddTagToPicture.Enabled = true;
        }
    }
}
