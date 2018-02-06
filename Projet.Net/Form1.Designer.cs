namespace Projet.Net
{
    partial class AppWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppWindow));
            this.menuBar = new System.Windows.Forms.ToolStrip();
            this.leftApp = new System.Windows.Forms.ToolStripButton();
            this.tagSearch = new System.Windows.Forms.TextBox();
            this.eraseTagSearch = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.ListBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftApp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(901, 25);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "toolStrip1";
            // 
            // leftApp
            // 
            this.leftApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.leftApp.Image = ((System.Drawing.Image)(resources.GetObject("leftApp.Image")));
            this.leftApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftApp.Name = "leftApp";
            this.leftApp.Size = new System.Drawing.Size(48, 22);
            this.leftApp.Text = "Quitter";
            this.leftApp.Click += new System.EventHandler(this.leftAppButton_Click);
            // 
            // tagSearch
            // 
            this.tagSearch.Location = new System.Drawing.Point(12, 29);
            this.tagSearch.Name = "tagSearch";
            this.tagSearch.Size = new System.Drawing.Size(180, 20);
            this.tagSearch.TabIndex = 2;
            this.tagSearch.Text = "Rechercher un tag...";
            this.tagSearch.TextChanged += new System.EventHandler(this.tagSearch_TextChanged);
            // 
            // eraseTagSearch
            // 
            this.eraseTagSearch.Location = new System.Drawing.Point(198, 28);
            this.eraseTagSearch.Name = "eraseTagSearch";
            this.eraseTagSearch.Size = new System.Drawing.Size(28, 21);
            this.eraseTagSearch.TabIndex = 3;
            this.eraseTagSearch.Text = "X";
            this.eraseTagSearch.UseVisualStyleBackColor = true;
            this.eraseTagSearch.Click += new System.EventHandler(this.eraseTagSearch_Click);
            // 
            // tags
            // 
            this.tags.FormattingEnabled = true;
            this.tags.Location = new System.Drawing.Point(12, 57);
            this.tags.Margin = new System.Windows.Forms.Padding(5);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(214, 355);
            this.tags.TabIndex = 5;
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(901, 426);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.eraseTagSearch);
            this.Controls.Add(this.tagSearch);
            this.Controls.Add(this.menuBar);
            this.Name = "AppWindow";
            this.Text = "Sac à caca";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuBar;
        private System.Windows.Forms.ToolStripButton leftApp;
        private System.Windows.Forms.TextBox tagSearch;
        private System.Windows.Forms.Button eraseTagSearch;
        private System.Windows.Forms.ListBox tags;
    }
}

