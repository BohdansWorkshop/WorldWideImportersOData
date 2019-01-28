namespace WinFormsClient.Forms
{
    partial class ucShowAllElements
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowAllElements));
            this.lvContent = new System.Windows.Forms.ListView();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvContent
            // 
            this.lvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvContent.FullRowSelect = true;
            this.lvContent.GridLines = true;
            this.lvContent.Location = new System.Drawing.Point(0, 0);
            this.lvContent.Margin = new System.Windows.Forms.Padding(2);
            this.lvContent.MultiSelect = false;
            this.lvContent.Name = "lvContent";
            this.lvContent.Size = new System.Drawing.Size(638, 370);
            this.lvContent.TabIndex = 0;
            this.lvContent.UseCompatibleStateImageBehavior = false;
            this.lvContent.View = System.Windows.Forms.View.Details;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbRemove,
            this.tsbEdit,
            this.tsbRefresh});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(638, 46);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tsbAdd.Size = new System.Drawing.Size(28, 43);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Padding = new System.Windows.Forms.Padding(2);
            this.tsbRemove.Size = new System.Drawing.Size(28, 43);
            this.tsbRemove.Text = "Delete";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(24, 43);
            this.tsbEdit.Text = "Edit";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(24, 43);
            this.tsbRefresh.Text = "Refresh";
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(0, 0);
            this.scContent.Margin = new System.Windows.Forms.Padding(2);
            this.scContent.Name = "scContent";
            this.scContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.toolStripMenu);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.lvContent);
            this.scContent.Size = new System.Drawing.Size(638, 419);
            this.scContent.SplitterDistance = 46;
            this.scContent.SplitterWidth = 3;
            this.scContent.TabIndex = 5;
            // 
            // ucShowAllElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scContent);
            this.Name = "ucShowAllElements";
            this.Size = new System.Drawing.Size(638, 419);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel1.PerformLayout();
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvContent;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.SplitContainer scContent;
    }
}
