using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Projet.Net.model {
    class Base {

        private static Base instance = new Base();

        private List<Image> images = new List<Image>();
        private List<Tag> tags = new List<Tag>();

        private List<Tag> selectedTags = new List<Tag>();

        private Base() {}

        public static Base getInstance() {
            return Base.instance;
        }

        // -----------------------------------------------

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
            List<Image> imagesWithTags = new List<Image>();
            foreach (Image image in this.images) {
                if (image.hasTags(this.selectedTags)) {
                    imagesWithTags.Add(image);
                }
            }
            return imagesWithTags;
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

            foreach (String tag in json.tags) {
                Console.WriteLine(tag);
            }

        }
     }



}
