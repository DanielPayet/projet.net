namespace Projet.Net
{
    partial class Tags
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxLocalTags = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addLocalTag = new System.Windows.Forms.Button();
            this.deleteLocalTag = new System.Windows.Forms.Button();
            this.textBoxNewLocalTag = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLocalTags
            // 
            this.listBoxLocalTags.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxLocalTags.FormattingEnabled = true;
            this.listBoxLocalTags.Location = new System.Drawing.Point(0, 0);
            this.listBoxLocalTags.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxLocalTags.Name = "listBoxLocalTags";
            this.listBoxLocalTags.Size = new System.Drawing.Size(136, 256);
            this.listBoxLocalTags.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addLocalTag);
            this.flowLayoutPanel1.Controls.Add(this.deleteLocalTag);
            this.flowLayoutPanel1.Controls.Add(this.textBoxNewLocalTag);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 256);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // addLocalTag
            // 
            this.addLocalTag.Location = new System.Drawing.Point(3, 3);
            this.addLocalTag.Name = "addLocalTag";
            this.addLocalTag.Size = new System.Drawing.Size(40, 40);
            this.addLocalTag.TabIndex = 0;
            this.addLocalTag.Text = "+";
            this.addLocalTag.UseVisualStyleBackColor = true;
            this.addLocalTag.Click += new System.EventHandler(this.addLocalTag_Click);
            // 
            // deleteLocalTag
            // 
            this.deleteLocalTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteLocalTag.Location = new System.Drawing.Point(49, 3);
            this.deleteLocalTag.Name = "deleteLocalTag";
            this.deleteLocalTag.Size = new System.Drawing.Size(40, 40);
            this.deleteLocalTag.TabIndex = 0;
            this.deleteLocalTag.Text = "-";
            this.deleteLocalTag.UseVisualStyleBackColor = true;
            this.deleteLocalTag.Click += new System.EventHandler(this.deleteLocalTag_Click);
            // 
            // textBoxNewLocalTag
            // 
            this.textBoxNewLocalTag.Location = new System.Drawing.Point(3, 49);
            this.textBoxNewLocalTag.Multiline = true;
            this.textBoxNewLocalTag.Name = "textBoxNewLocalTag";
            this.textBoxNewLocalTag.Size = new System.Drawing.Size(85, 33);
            this.textBoxNewLocalTag.TabIndex = 1;
            // 
            // Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 256);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listBoxLocalTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tags";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.ListBox listBoxLocalTags;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button addLocalTag;
		private System.Windows.Forms.Button deleteLocalTag;
		private System.Windows.Forms.TextBox textBoxNewLocalTag;
	}
}