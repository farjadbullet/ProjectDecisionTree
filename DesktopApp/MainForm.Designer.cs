namespace DesktopApp
{
    partial class MainForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.CartTree = new Telerik.WinControls.UI.RadTreeView();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.OriginalDataPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.DecisionTreePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.OriginalDataGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CartTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.OriginalDataPage.SuspendLayout();
            this.DecisionTreePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalDataGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CartTree
            // 
            this.CartTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartTree.Location = new System.Drawing.Point(0, 0);
            this.CartTree.Name = "CartTree";
            this.CartTree.Size = new System.Drawing.Size(782, 532);
            this.CartTree.SpacingBetweenNodes = -1;
            this.CartTree.TabIndex = 0;
            this.CartTree.Text = "radTreeView1";
            this.CartTree.ThemeName = "VisualStudio2012Dark";
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.OriginalDataPage);
            this.radPageView1.Controls.Add(this.DecisionTreePage);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.OriginalDataPage;
            this.radPageView1.Size = new System.Drawing.Size(792, 567);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.Scroll;
            // 
            // OriginalDataPage
            // 
            this.OriginalDataPage.Controls.Add(this.OriginalDataGridView);
            this.OriginalDataPage.ItemSize = new System.Drawing.SizeF(78F, 24F);
            this.OriginalDataPage.Location = new System.Drawing.Point(5, 30);
            this.OriginalDataPage.Name = "OriginalDataPage";
            this.OriginalDataPage.Size = new System.Drawing.Size(782, 532);
            this.OriginalDataPage.Text = "Original Data";
            // 
            // DecisionTreePage
            // 
            this.DecisionTreePage.Controls.Add(this.CartTree);
            this.DecisionTreePage.ItemSize = new System.Drawing.SizeF(79F, 24F);
            this.DecisionTreePage.Location = new System.Drawing.Point(5, 30);
            this.DecisionTreePage.Name = "DecisionTreePage";
            this.DecisionTreePage.Size = new System.Drawing.Size(782, 532);
            this.DecisionTreePage.Text = "Decision Tree";
            // 
            // OriginalDataGridView
            // 
            this.OriginalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalDataGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.OriginalDataGridView.MasterTemplate.AllowAddNewRow = false;
            this.OriginalDataGridView.MasterTemplate.AllowColumnReorder = false;
            this.OriginalDataGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.OriginalDataGridView.Name = "OriginalDataGridView";
            this.OriginalDataGridView.ReadOnly = true;
            this.OriginalDataGridView.Size = new System.Drawing.Size(782, 532);
            this.OriginalDataGridView.TabIndex = 1;
            this.OriginalDataGridView.ThemeName = "VisualStudio2012Dark";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 567);
            this.Controls.Add(this.radPageView1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project CART";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.CartTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.OriginalDataPage.ResumeLayout(false);
            this.DecisionTreePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalDataGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView CartTree;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage OriginalDataPage;
        private Telerik.WinControls.UI.RadPageViewPage DecisionTreePage;
        private Telerik.WinControls.UI.RadGridView OriginalDataGridView;
    }
}