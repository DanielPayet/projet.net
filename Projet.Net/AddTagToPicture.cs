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

namespace Projet.Net {
	public partial class addTagToPicture : Form {
		public addTagToPicture() {
			InitializeComponent();
			updateLocalTagList();
		}

		// Behavior of the button to add
		private void buttonAddTagToPicture_Click(object sender, EventArgs e) {
			if (listBoxLocalTags.SelectedItem != null) {// Check if something is selected
				Tag tag = (sender as Tag);
				// Mmmhh something here :o ?
				this.Close();
			}
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
