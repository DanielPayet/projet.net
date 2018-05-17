namespace Projet.Net {
	partial class addTagToPicture {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.listBoxLocalTags = new System.Windows.Forms.ListBox();
            this.buttonAddTagToPicture = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLocalTags
            // 
            this.listBoxLocalTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLocalTags.FormattingEnabled = true;
            this.listBoxLocalTags.Location = new System.Drawing.Point(0, 0);
            this.listBoxLocalTags.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxLocalTags.Name = "listBoxLocalTags";
            this.listBoxLocalTags.ScrollAlwaysVisible = true;
            this.listBoxLocalTags.Size = new System.Drawing.Size(202, 282);
            this.listBoxLocalTags.TabIndex = 7;
            this.listBoxLocalTags.SelectedIndexChanged += new System.EventHandler(this.listBoxLocalTags_SelectedIndexChanged);
            // 
            // buttonAddTagToPicture
            // 
            this.buttonAddTagToPicture.Enabled = false;
            this.buttonAddTagToPicture.Location = new System.Drawing.Point(3, 3);
            this.buttonAddTagToPicture.Name = "buttonAddTagToPicture";
            this.buttonAddTagToPicture.Size = new System.Drawing.Size(197, 54);
            this.buttonAddTagToPicture.TabIndex = 0;
            this.buttonAddTagToPicture.Text = "Ajouter à la photo";
            this.buttonAddTagToPicture.UseVisualStyleBackColor = true;
            this.buttonAddTagToPicture.Click += new System.EventHandler(this.buttonAddTagToPicture_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonAddTagToPicture);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 60);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // addTagToPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 282);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listBoxLocalTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addTagToPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un tag à la photo";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxLocalTags;
		private System.Windows.Forms.Button buttonAddTagToPicture;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}