using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Net.model {
    class Tag{

        private String name;

        public Tag(String name) {
            this.name = name;
        }

        public String getName() {
            return this.name;
        }

        public void rename(String name) {
            if (Base.getInstance().tagExists(new Tag(name))) {
                Base.getInstance().replaceAnRemoveTag(this, new Tag(name));
            }
            else {
                this.name = name;
            }
        }
    }
}
