using System.Windows.Forms;
using Projet.Net.model;
using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppWindow));
            this.menuBar = new System.Windows.Forms.ToolStrip();
            this.EditionDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.importerDesImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.leftApp = new System.Windows.Forms.ToolStripButton();
            this.tagSearch = new System.Windows.Forms.TextBox();
            this.eraseTagSearch = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.ListBox();
            this.MosaiqueImages = new System.Windows.Forms.FlowLayoutPanel();
            this.importerImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuClickDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirDansLexplorateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTagSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.CenterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelDroit = new System.Windows.Forms.TableLayoutPanel();
            this.pictureRightView = new System.Windows.Forms.PictureBox();
            this.addTag = new System.Windows.Forms.Button();
            this.tagsImage = new System.Windows.Forms.GroupBox();
            this.listeTagsImage = new System.Windows.Forms.ListBox();
            this.PanelGauche = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutSearchTags = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBar.SuspendLayout();
            this.menuClickDroit.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.panelDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRightView)).BeginInit();
            this.tagsImage.SuspendLayout();
            this.PanelGauche.SuspendLayout();
            this.flowLayoutSearchTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditionDropDown,
            this.toolStripSeparator,
            this.leftApp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(934, 25);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "toolStrip1";
            // 
            // EditionDropDown
            // 
            this.EditionDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditionDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerDesImagesToolStripMenuItem,
            this.toolStripSeparator1,
            this.ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem,
            this.ouvrirUnWorkspaceToolStripMenuItem});
            this.EditionDropDown.Image = ((System.Drawing.Image)(resources.GetObject("EditionDropDown.Image")));
            this.EditionDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditionDropDown.Name = "EditionDropDown";
            this.EditionDropDown.Size = new System.Drawing.Size(57, 22);
            this.EditionDropDown.Text = "Edition";
            this.EditionDropDown.ToolTipText = "Edition";
            // 
            // importerDesImagesToolStripMenuItem
            // 
            this.importerDesImagesToolStripMenuItem.Name = "importerDesImagesToolStripMenuItem";
            this.importerDesImagesToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.importerDesImagesToolStripMenuItem.Text = "Importer des images";
            this.importerDesImagesToolStripMenuItem.ToolTipText = "Importer des images dans le dossier actuel";
            this.importerDesImagesToolStripMenuItem.Click += new System.EventHandler(this.importerDesImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(355, 6);
            // 
            // ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem
            // 
            this.ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem.Name = "ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem";
            this.ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem.Text = "Ouvrir le dossier de travail dans l\'explorateur Windows";
            this.ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem_Click);
            // 
            // ouvrirUnWorkspaceToolStripMenuItem
            // 
            this.ouvrirUnWorkspaceToolStripMenuItem.Name = "ouvrirUnWorkspaceToolStripMenuItem";
            this.ouvrirUnWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.ouvrirUnWorkspaceToolStripMenuItem.Text = "Ouvrir un dossier de travail";
            this.ouvrirUnWorkspaceToolStripMenuItem.ToolTipText = "Ouvrir un nouveau dossier de travail";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.tagSearch.Location = new System.Drawing.Point(3, 3);
            this.tagSearch.Name = "tagSearch";
            this.tagSearch.Size = new System.Drawing.Size(108, 20);
            this.tagSearch.TabIndex = 2;
            this.tagSearch.TextChanged += new System.EventHandler(this.tagSearch_TextChanged);
            // 
            // eraseTagSearch
            // 
            this.eraseTagSearch.Location = new System.Drawing.Point(117, 3);
            this.eraseTagSearch.Name = "eraseTagSearch";
            this.eraseTagSearch.Size = new System.Drawing.Size(28, 21);
            this.eraseTagSearch.TabIndex = 3;
            this.eraseTagSearch.Text = "X";
            this.eraseTagSearch.UseVisualStyleBackColor = true;
            this.eraseTagSearch.Click += new System.EventHandler(this.eraseTagSearch_Click);
            // 
            // tags
            // 
            this.tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tags.FormattingEnabled = true;
            this.tags.Location = new System.Drawing.Point(5, 41);
            this.tags.Margin = new System.Windows.Forms.Padding(5);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(147, 387);
            this.tags.TabIndex = 5;
            this.tags.SelectedIndexChanged += new System.EventHandler(this.tags_SelectedIndexChanged);
            // 
            // MosaiqueImages
            // 
            this.MosaiqueImages.AutoScroll = true;
            this.MosaiqueImages.AutoSize = true;
            this.MosaiqueImages.BackColor = System.Drawing.SystemColors.Window;
            this.MosaiqueImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MosaiqueImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MosaiqueImages.Location = new System.Drawing.Point(3, 39);
            this.MosaiqueImages.Name = "MosaiqueImages";
            this.MosaiqueImages.Size = new System.Drawing.Size(540, 391);
            this.MosaiqueImages.TabIndex = 6;
            // 
            // importerImageDialog
            // 
            this.importerImageDialog.FileName = "importerImageDialog";
            this.importerImageDialog.Filter = "Images (*.jpg)|*.jpg";
            this.importerImageDialog.Multiselect = true;
            this.importerImageDialog.Title = "Sélection des fichiers à copier dans le workspace";
            // 
            // menuClickDroit
            // 
            this.menuClickDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirDansLexplorateurToolStripMenuItem});
            this.menuClickDroit.Name = "menuClickDroit";
            this.menuClickDroit.Size = new System.Drawing.Size(280, 26);
            // 
            // ouvrirDansLexplorateurToolStripMenuItem
            // 
            this.ouvrirDansLexplorateurToolStripMenuItem.Name = "ouvrirDansLexplorateurToolStripMenuItem";
            this.ouvrirDansLexplorateurToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.ouvrirDansLexplorateurToolStripMenuItem.Text = "Ouvrir dans votre visualisateur d\'image";
            this.ouvrirDansLexplorateurToolStripMenuItem.Click += new System.EventHandler(this.ouvrirDansLexplorateurToolStripMenuItem_Click);
            // 
            // listTagSelected
            // 
            this.listTagSelected.BackColor = System.Drawing.SystemColors.Window;
            this.listTagSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTagSelected.Location = new System.Drawing.Point(3, 3);
            this.listTagSelected.Name = "listTagSelected";
            this.listTagSelected.Size = new System.Drawing.Size(540, 30);
            this.listTagSelected.TabIndex = 8;
            // 
            // CenterPanel
            // 
            this.CenterPanel.ColumnCount = 1;
            this.CenterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CenterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CenterPanel.Controls.Add(this.listTagSelected, 0, 0);
            this.CenterPanel.Controls.Add(this.MosaiqueImages, 0, 1);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(157, 25);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.RowCount = 2;
            this.CenterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.545034F));
            this.CenterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45496F));
            this.CenterPanel.Size = new System.Drawing.Size(546, 433);
            this.CenterPanel.TabIndex = 8;
            // 
            // panelDroit
            // 
            this.panelDroit.BackColor = System.Drawing.SystemColors.Window;
            this.panelDroit.ColumnCount = 1;
            this.panelDroit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDroit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDroit.Controls.Add(this.pictureRightView, 0, 0);
            this.panelDroit.Controls.Add(this.addTag, 0, 2);
            this.panelDroit.Controls.Add(this.tagsImage, 0, 1);
            this.panelDroit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDroit.Location = new System.Drawing.Point(703, 25);
            this.panelDroit.Name = "panelDroit";
            this.panelDroit.RowCount = 3;
            this.panelDroit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.33949F));
            this.panelDroit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.66051F));
            this.panelDroit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.panelDroit.Size = new System.Drawing.Size(231, 433);
            this.panelDroit.TabIndex = 9;
            this.panelDroit.Visible = false;
            // 
            // pictureRightView
            // 
            this.pictureRightView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureRightView.Location = new System.Drawing.Point(3, 3);
            this.pictureRightView.Name = "pictureRightView";
            this.pictureRightView.Size = new System.Drawing.Size(225, 153);
            this.pictureRightView.TabIndex = 0;
            this.pictureRightView.TabStop = false;
            // 
            // addTag
            // 
            this.addTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTag.Location = new System.Drawing.Point(3, 388);
            this.addTag.Name = "addTag";
            this.addTag.Size = new System.Drawing.Size(225, 42);
            this.addTag.TabIndex = 1;
            this.addTag.Text = "Gerer les tags de cette image";
            this.addTag.UseVisualStyleBackColor = true;
            // 
            // tagsImage
            // 
            this.tagsImage.Controls.Add(this.listeTagsImage);
            this.tagsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsImage.Location = new System.Drawing.Point(3, 162);
            this.tagsImage.Name = "tagsImage";
            this.tagsImage.Size = new System.Drawing.Size(225, 220);
            this.tagsImage.TabIndex = 2;
            this.tagsImage.TabStop = false;
            this.tagsImage.Text = "Tag de l\'image";
            // 
            // listeTagsImage
            // 
            this.listeTagsImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listeTagsImage.FormattingEnabled = true;
            this.listeTagsImage.Location = new System.Drawing.Point(3, 16);
            this.listeTagsImage.Name = "listeTagsImage";
            this.listeTagsImage.Size = new System.Drawing.Size(219, 195);
            this.listeTagsImage.TabIndex = 0;
            // 
            // PanelGauche
            // 
            this.PanelGauche.BackColor = System.Drawing.SystemColors.Window;
            this.PanelGauche.ColumnCount = 1;
            this.PanelGauche.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelGauche.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelGauche.Controls.Add(this.flowLayoutSearchTags, 0, 0);
            this.PanelGauche.Controls.Add(this.tags, 0, 1);
            this.PanelGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelGauche.Location = new System.Drawing.Point(0, 25);
            this.PanelGauche.Name = "PanelGauche";
            this.PanelGauche.RowCount = 2;
            this.PanelGauche.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.545034F));
            this.PanelGauche.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45496F));
            this.PanelGauche.Size = new System.Drawing.Size(157, 433);
            this.PanelGauche.TabIndex = 0;
            // 
            // flowLayoutSearchTags
            // 
            this.flowLayoutSearchTags.Controls.Add(this.tagSearch);
            this.flowLayoutSearchTags.Controls.Add(this.eraseTagSearch);
            this.flowLayoutSearchTags.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutSearchTags.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutSearchTags.Name = "flowLayoutSearchTags";
            this.flowLayoutSearchTags.Size = new System.Drawing.Size(151, 27);
            this.flowLayoutSearchTags.TabIndex = 0;
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(934, 458);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panelDroit);
            this.Controls.Add(this.PanelGauche);
            this.Controls.Add(this.menuBar);
            this.MinimumSize = new System.Drawing.Size(600, 39);
            this.Name = "AppWindow";
            this.Text = "Photo Tagger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.menuClickDroit.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.panelDroit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRightView)).EndInit();
            this.tagsImage.ResumeLayout(false);
            this.PanelGauche.ResumeLayout(false);
            this.flowLayoutSearchTags.ResumeLayout(false);
            this.flowLayoutSearchTags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuBar;
        private System.Windows.Forms.ToolStripButton leftApp;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripDropDownButton EditionDropDown;
        private ToolStripMenuItem ouvrirUnWorkspaceToolStripMenuItem;
        private ToolStripMenuItem importerDesImagesToolStripMenuItem;
        private TextBox tagSearch;
        private Button eraseTagSearch;
        private ListBox tags;
        private FlowLayoutPanel MosaiqueImages;
        private OpenFileDialog importerImageDialog;
        private ContextMenuStrip menuClickDroit;
        private ToolStripMenuItem ouvrirDansLexplorateurToolStripMenuItem;
        private ToolStripMenuItem ouvrirLeDossierDeTravailDansLexplorateurWindowsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private FlowLayoutPanel listTagSelected;
        private TableLayoutPanel CenterPanel;
        private TableLayoutPanel panelDroit;
        private PictureBox pictureRightView;
        private Button addTag;
        private GroupBox tagsImage;
        private ListBox listeTagsImage;
        private TableLayoutPanel PanelGauche;
        private FlowLayoutPanel flowLayoutSearchTags;
    }
}

