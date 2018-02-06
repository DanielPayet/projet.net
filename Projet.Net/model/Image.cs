using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Net.model {
    class Image {
        private int id;
        public String name;
        public Image image;

        private List<Tag> tags = new List<Tag>();

        public Image(int id, String name, Image image) {
            this.id = id;
            this.name = name;
            this.image = image;
        }

        public int getId() {
            return this.id;
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
