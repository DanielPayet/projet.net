using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Projet.Net.model {
    class Base {

        private static Base instance = new Base();

        private List<Image> images = new List<Image>();
        public List<Tag> tags = new List<Tag>();//TODO remmettre en privé

        private List<Tag> selectedTags = new List<Tag>();

        private Base() {}

        public static Base getInstance() {
            return Base.instance;
        }

        // -----------------------------------------------

        public bool tagExists(Tag tag) {
            foreach (Tag existingTag in this.tags) {
                if (existingTag.getName() == tag.getName()) {
                    return true;
                }
            }
            return false;
        }

        public void addTag(String name) {
            foreach(Tag tag in this.tags) {
                if (tag.getName() == name) {
                    return;
                }
            }
            this.tags.Add(new Tag(name));
        }

        public void replaceAnRemoveTag(Tag tag, Tag newTag) {
            foreach (Image image in this.images) {
                image.replaceTag(tag, newTag);
            }
            this.tags.Remove(tag);
        }

        public void selectTag(Tag tag) {
            if (!this.selectedTags.Contains(tag)) {
                this.selectedTags.Add(tag);
            }
        }

        public void deselectTag(Tag tag) {
            this.selectedTags.Remove(tag);
        }

        public List<Tag> getSelectedTags() {
            return this.selectedTags;
        }

        public List<Image> imagesWithTags() {
            if (this.images.Count != 0) {
                List<Image> imagesWithTags = new List<Image>();
                foreach (Image image in this.images) {
                    if (image.hasTags(this.selectedTags)) {
                        imagesWithTags.Add(image);
                    }
                }
                return imagesWithTags;
            }
            else {
                return this.images;
            }
        }

        public List<Tag> getNextTags() {
            List<Tag> nextTags = new List<Tag>();

            foreach(Image image in this.imagesWithTags()) {
                foreach(Tag tag in image.getTags()) {
                    if (!nextTags.Contains(tag)) {
                        nextTags.Add(tag);
                    }
                }
            }

            foreach(Tag tag in this.selectedTags) {
                nextTags.Remove(tag);
            }

            return nextTags;
        }

        public void loadWorkspace() {
            string contents = File.ReadAllText(@"test.txt");
            dynamic json = JsonConvert.DeserializeObject(contents);
            
            if (json.tags != null) {
                foreach (String tagName in json.tags) {
                    this.addTag(tagName);
                }
            }
         }

        public void refresh() {
            
        }


     }

}
