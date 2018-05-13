using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Projet.Net.model {
    class Base {

        public static String workspacePath;

        private static Base instance = new Base( );

        private List<Image> images = new List<Image>( );
        private List<Tag> tags = new List<Tag>( );

        private List<Tag> selectedTags = new List<Tag>( );

        private Base() { }

        public static Base getInstance() {
            return Base.instance;
        }

        // Tag manipulation --------------------------------------------------------

        public bool tagExists( Tag tag ) {
            foreach ( Tag existingTag in this.tags ) {
                if ( existingTag.getName( ) == tag.getName( ) ) {
                    return true;
                }
            }
            return false;
        }

        public void addTag( String name ) {
            foreach ( Tag tag in this.tags ) {
                if ( tag.getName( ) == name ) {
                    return;
                }
            }
            Tag tmpTag = new Tag( name );
            if ( !tagExists( tmpTag ) ) {
                this.tags.Add( new Tag( name ) );
            }
        }

        public void replaceAnRemoveTag( Tag tag, Tag newTag ) {
            foreach ( Image image in this.images ) {
                image.replaceTag( tag, newTag );
            }
            this.tags.Remove( tag );
        }

        public void selectTag( Tag tag ) {
            if ( !tag.inList( this.selectedTags ) ) {
                this.selectedTags.Add( tag );
            }
        }

        public void deselectTag( Tag tag ) {
            this.selectedTags = tag.removeFrom( this.selectedTags );
        }

        public List<Tag> getSelectedTags() {
            return this.selectedTags;
        }

        public List<Tag> getNextTags() {
            List<Tag> nextTags = new List<Tag>( );

            foreach ( Image image in this.imagesWithTags( ) ) {
                foreach ( Tag tag in image.getTags( ) ) {
                    if ( !tag.inList( nextTags ) && !tag.inList( this.selectedTags ) ) {
                        nextTags.Add( tag );
                    }
                }
            }

            return nextTags;
        }

        // Image manipulation --------------------------------------------------------

        public List<Image> imagesWithTags() {
            if ( this.images.Count != 0 ) {
                List<Image> imagesWithTags = new List<Image>( );
                foreach ( Image image in this.images ) {
                    if ( image.hasTags( this.selectedTags ) ) {
                        imagesWithTags.Add( image );
                    }
                }
                return imagesWithTags;
            } else {
                return this.images;
            }
        }

        private Image createImage( String path ) {
            foreach ( Image image in this.images ) {
                if ( image.getPath( ) == path ) {
                    return image;
                }
            }

            Image newImage = new Image( this.images.Count + 1, path );
            this.images.Add( newImage );

            return newImage;
        }

        public void importImage( string[] imagesFullFilePath ) {
            foreach ( string imageFullFilePath in imagesFullFilePath ) {
                string imageName = this.generateImageName( imageFullFilePath );
                if ( !workspacePath.Equals( Path.GetDirectoryName( imageFullFilePath ) + Path.DirectorySeparatorChar ) ) {
                    this.copieImageToWorkspace( imageFullFilePath, imageName );
                }
                Image image = this.createImage( imageName );
                //Tag readsTags = readTag( nouvellesImages )
                //image.tag( readsTags ); TODO
                //this.addTag(readsTag);
            }
            this.saveImagesToWorkSpace( );
        }
        // Load and Save functions --------------------------------------------------------

        private void initWorkspaceDir() {
            String appName = "noNameApp";

            // Gives the path of the Documents folder on the computer
            Base.workspacePath = System.Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments ) + "\\" + appName + "\\";

            // I guess we could create the folder if it's not there on loading the appWindow ?
            Directory.CreateDirectory( Base.workspacePath );
            // Then create the non existing .json

            if ( !File.Exists( Base.workspacePath + "workspace.json" ) ) {
                File.Create( Base.workspacePath + "workspace.json" ).Close( );
                String defaultWorkspace = "{'tags':[],'images':[] }";
                TextWriter writer = null;
                try {
                    dynamic json = JsonConvert.DeserializeObject( defaultWorkspace );
                    dynamic contentsToWriteToFile = JsonConvert.SerializeObject( json, Formatting.Indented );
                    writer = new StreamWriter( Base.workspacePath + "workspace.json", false );
                    writer.Write( contentsToWriteToFile );
                } catch ( Exception e ) {
                    Console.WriteLine( "Erreur d'écriture dans le workspace" + e.Message );
                } finally {
                    if ( writer != null )
                        writer.Close( );
                }
            }
        }

        public void loadWorkspace() {
            this.initWorkspaceDir( );
            try {
                string contents = File.ReadAllText( Base.workspacePath + "workspace.json" );
                dynamic json = JsonConvert.DeserializeObject( contents );

                if ( json.tags != null ) {
                    foreach ( String tagName in json.tags ) {
                        this.addTag( tagName );
                    }
                }

                if ( json.images != null ) {
                    foreach ( dynamic imageStruct in json.images ) {
                        if ( imageStruct.path != null ) {

                            List<Tag> tags = new List<Tag>( );
                            if ( imageStruct.tags != null ) {
                                List<String> tagNames = new List<String>( );
                                foreach ( String tagName in imageStruct.tags ) {
                                    if ( !tagNames.Contains( tagName ) ) {
                                        tagNames.Add( tagName );
                                    }
                                }
                                foreach ( String tagName in tagNames ) {
                                    this.addTag( tagName );
                                    tags.Add( new Tag( tagName ) );
                                }
                            }

                            Image image = this.createImage( ( String )imageStruct.path );
                            image.tag( tags );
                        }
                    }
                }
            } catch ( Exception e ) {
                Console.WriteLine( e.Message );
            }
        }

        public void saveWorkspace() {

        }

        private void copieImageToWorkspace( string path, string newName ) {
            File.Copy( path, workspacePath + newName );
        }

        private string generateImageName( string path ) {
            return Path.GetFileNameWithoutExtension( path ) + "_" + DateTime.UtcNow.ToBinary( ) + Path.GetExtension( path );
        }

        private void saveImagesToWorkSpace() {
            string tempJson = "[";

            foreach ( Image image in this.images ) {
                tempJson += "{ 'path' : '" + image.getPath( ) + "'," +
                              "'tags' : [" + String.Join( ",", image.getTags( ).ConvertAll<String>( tag => "\"" + tag.getName( ) + "\"" ) ) + "]},";
            }
            tempJson = tempJson.Substring( 0, tempJson.Length - 1 );

            tempJson += "]";

            string contents = File.ReadAllText( Base.workspacePath + "workspace.json" );
            dynamic json = JsonConvert.DeserializeObject( contents );
            json.images = JsonConvert.DeserializeObject( tempJson );
            TextWriter writer = null;
            try {
                dynamic contentsToWriteToFile = JsonConvert.SerializeObject( json, Formatting.Indented );
                writer = new StreamWriter( workspacePath + "workspace.json", false );
                writer.Write( contentsToWriteToFile );
            } finally {
                if ( writer != null )
                    writer.Close( );
            }
        }

    } // End Base Class
}
