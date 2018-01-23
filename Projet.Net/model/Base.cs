using System;
using System.Drawing;

namespace Projet.Net {
    public class Base {

        private static Base instance = new Base();

        private Base() {}

        public static Base getInstance() {
            return instance;
        }

        public void addNameTag(String name) {
            // TODO
        }

        public void addImage(Image img) {
            // TODO
        }

        public void tagImage(int imageId) {
            // TODO
        }

        public void tagTag(int tag, String name) {
            // TODO
        }

        public void removeTag(int tag) {
            // TODO
        }

        public void renameTagName(int tagName, String name) {
            // TODO
        }

        public void photoWithTags(int[] tags) {
            // TODO
        }

     }
}
