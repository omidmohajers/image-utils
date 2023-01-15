
namespace PA.ImageUtils.Win
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
            this.toolsMenu = new System.Windows.Forms.ToolStrip();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.destpicturebox = new System.Windows.Forms.PictureBox();
            this.sourcePicturebox = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.srayscaleButton = new System.Windows.Forms.ToolStripButton();
            this.colorfulButton = new System.Windows.Forms.ToolStripButton();
            this.zoomButton = new System.Windows.Forms.ToolStripButton();
            this.markAreaButton = new System.Windows.Forms.ToolStripButton();
            this.dominantColorButton = new System.Windows.Forms.ToolStripButton();
            this.toolsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsMenu
            // 
            this.toolsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadButton,
            this.saveButton,
            this.srayscaleButton,
            this.colorfulButton,
            this.zoomButton,
            this.markAreaButton,
            this.dominantColorButton});
            this.toolsMenu.Location = new System.Drawing.Point(0, 0);
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolsMenu.Size = new System.Drawing.Size(891, 54);
            this.toolsMenu.TabIndex = 1;
            this.toolsMenu.Text = "Tools Menu";
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(225, 497);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(384, 100);
            this.colorPanel.TabIndex = 4;
            // 
            // destpicturebox
            // 
            this.destpicturebox.Location = new System.Drawing.Point(447, 57);
            this.destpicturebox.Name = "destpicturebox";
            this.destpicturebox.Size = new System.Drawing.Size(429, 421);
            this.destpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.destpicturebox.TabIndex = 3;
            this.destpicturebox.TabStop = false;
            // 
            // sourcePicturebox
            // 
            this.sourcePicturebox.Cursor = System.Windows.Forms.Cursors.Default;
            this.sourcePicturebox.Image = global::PA.ImageUtils.Win.Properties.Resources.devil_may_cry_5;
            this.sourcePicturebox.Location = new System.Drawing.Point(12, 57);
            this.sourcePicturebox.Name = "sourcePicturebox";
            this.sourcePicturebox.Size = new System.Drawing.Size(429, 421);
            this.sourcePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sourcePicturebox.TabIndex = 2;
            this.sourcePicturebox.TabStop = false;
            this.sourcePicturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sourcePicturebox_MouseMove);
            // 
            // loadButton
            // 
            this.loadButton.Image = global::PA.ImageUtils.Win.Properties.Resources.folder;
            this.loadButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(73, 51);
            this.loadButton.Text = "Load Image";
            this.loadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::PA.ImageUtils.Win.Properties.Resources.save;
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(71, 51);
            this.saveButton.Text = "Save Image";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // srayscaleButton
            // 
            this.srayscaleButton.Image = global::PA.ImageUtils.Win.Properties.Resources.magic_wand;
            this.srayscaleButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.srayscaleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.srayscaleButton.Name = "srayscaleButton";
            this.srayscaleButton.Size = new System.Drawing.Size(99, 51);
            this.srayscaleButton.Text = "Make Grayescale";
            this.srayscaleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.srayscaleButton.Click += new System.EventHandler(this.srayscaleButton_Click);
            // 
            // colorfulButton
            // 
            this.colorfulButton.Image = global::PA.ImageUtils.Win.Properties.Resources.palette;
            this.colorfulButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.colorfulButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorfulButton.Name = "colorfulButton";
            this.colorfulButton.Size = new System.Drawing.Size(86, 51);
            this.colorfulButton.Text = "Make Colorful";
            this.colorfulButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.colorfulButton.Click += new System.EventHandler(this.colorfulButton_Click);
            // 
            // zoomButton
            // 
            this.zoomButton.Image = global::PA.ImageUtils.Win.Properties.Resources.zoom_in;
            this.zoomButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(43, 51);
            this.zoomButton.Text = "Zoom";
            this.zoomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            // 
            // markAreaButton
            // 
            this.markAreaButton.Image = global::PA.ImageUtils.Win.Properties.Resources.puzzle;
            this.markAreaButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.markAreaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.markAreaButton.Name = "markAreaButton";
            this.markAreaButton.Size = new System.Drawing.Size(65, 51);
            this.markAreaButton.Text = "Mark Area";
            this.markAreaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.markAreaButton.Click += new System.EventHandler(this.markAreaButton_Click);
            // 
            // dominantColorButton
            // 
            this.dominantColorButton.Image = global::PA.ImageUtils.Win.Properties.Resources.paint_brush;
            this.dominantColorButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dominantColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dominantColorButton.Name = "dominantColorButton";
            this.dominantColorButton.Size = new System.Drawing.Size(117, 51);
            this.dominantColorButton.Text = "Get Dominant Color";
            this.dominantColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dominantColorButton.Click += new System.EventHandler(this.dominantColorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 639);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.destpicturebox);
            this.Controls.Add(this.sourcePicturebox);
            this.Controls.Add(this.toolsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Test ImageUtils";
            this.toolsMenu.ResumeLayout(false);
            this.toolsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolsMenu;
        private System.Windows.Forms.ToolStripButton loadButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton srayscaleButton;
        private System.Windows.Forms.ToolStripButton colorfulButton;
        private System.Windows.Forms.ToolStripButton zoomButton;
        private System.Windows.Forms.ToolStripButton markAreaButton;
        private System.Windows.Forms.ToolStripButton dominantColorButton;
        private System.Windows.Forms.PictureBox sourcePicturebox;
        private System.Windows.Forms.PictureBox destpicturebox;
        private System.Windows.Forms.Panel colorPanel;
    }
}

