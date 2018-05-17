using Projet.Net.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.Net
{
    public partial class Tags : Form
    {
        private AppWindow main;
        public Tags(AppWindow main)
        {
            this.main = main;
            InitializeComponent();
			updateLocalTagList();
		}

		// Add a tag from the textBox text
		private void addLocalTag_Click(object sender, EventArgs e) {
			if(this.textBoxNewLocalTag.Text.Trim() != "" && this.textBoxNewLocalTag.Text.Trim() != " ")
			Base.getInstance().addLocalTag(this.textBoxNewLocalTag.Text.Trim());
			this.saveLocalChanges();
			this.updateLocalTagList();
			this.textBoxNewLocalTag.Text = "";
		}

		// Delete the specific selected tag
		private void deleteLocalTag_Click(object sender, EventArgs e) {
			String toRemove = this.listBoxLocalTags.GetItemText(listBoxLocalTags.SelectedItem);
			Base.getInstance().removeLocalTag(toRemove); // Doesn't work ... #TODO
			this.saveLocalChanges();
			this.updateLocalTagList();
		}

		// Saves the local changes
		public void saveLocalChanges() {
            Base.getInstance( ).updateWorkspace( );
            this.main.render( );
		}

		// Update the visual of the local list in Tags.cs
		private void updateLocalTagList() {
			listBoxLocalTags.BeginUpdate();
			listBoxLocalTags.Items.Clear();
			foreach (Tag tag in Base.getInstance().getLocalTags())
				listBoxLocalTags.Items.Add(tag.getName().Trim());
			listBoxLocalTags.EndUpdate();
		}
	}
}
