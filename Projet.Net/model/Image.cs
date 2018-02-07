using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageFile = System.Drawing.Image;

namespace Projet.Net.model {
    class Image {
        private int id;
        private String path;

        private List<Tag> tags = new List<Tag>();

        public Image(int id, String path) {
            this.id = id;
            this.path = path;
        }

        public Image(int id, String path, List<Tag> tags) {
            this.id = id;
            this.path = path;
            foreach(Tag tag in tags) {
                this.tag(tag);
            }
        }

        public ImageFile getImageFile() {
            return ImageFile.FromFile(Base.workspacePath + this.path);
        }

        public int getId() {
            return this.id;
        }

        public String getPath() {
            return this.path;
        }

        public bool hasTag(Tag tag) {
            return this.tags.Contains(tag);
        }

        public bool hasTags(List<Tag> tags) {
            foreach(Tag tag in tags) {
                if (!this.hasTag(tag)) {
                    return false;
                }
            }
            return true;
        }

        public void tag(List<Tag> tags) {
            foreach(Tag tag in tags) {
                this.tag(tag);
            }
        }

        public void tag(Tag tag) {
            if (!this.hasTag(tag)) {
                this.tags.Add(tag);
            }
        }

        public void unTag(Tag tag) {
            this.tags.Remove(tag);
        }

        public void replaceTag(Tag tag, Tag newTag) {
            if (this.tags.Contains(tag)) {
                this.tag(newTag);
                this.unTag(tag);
            }
        }

        public List<Tag> getTags() {
            return this.tags;
        }
    }
}
