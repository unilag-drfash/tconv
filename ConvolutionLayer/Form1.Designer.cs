namespace ConvolutionLayer
{
	partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identityOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxBlurOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poolingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convolutionToolStripMenuItem,
            this.poolingToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identityOperationToolStripMenuItem,
            this.edgeDetectionOperationToolStripMenuItem,
            this.sharpenOperationToolStripMenuItem,
            this.boxBlurOperationToolStripMenuItem});
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            // 
            // identityOperationToolStripMenuItem
            // 
            this.identityOperationToolStripMenuItem.Name = "identityOperationToolStripMenuItem";
            this.identityOperationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.identityOperationToolStripMenuItem.Text = "identity operation";
            this.identityOperationToolStripMenuItem.Click += new System.EventHandler(this.IdentityOperationToolStripMenuItem_Click);
            // 
            // edgeDetectionOperationToolStripMenuItem
            // 
            this.edgeDetectionOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.type1ToolStripMenuItem,
            this.type2ToolStripMenuItem,
            this.type3ToolStripMenuItem});
            this.edgeDetectionOperationToolStripMenuItem.Name = "edgeDetectionOperationToolStripMenuItem";
            this.edgeDetectionOperationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.edgeDetectionOperationToolStripMenuItem.Text = "edge detection operation";
            this.edgeDetectionOperationToolStripMenuItem.Click += new System.EventHandler(this.EdgeDetectionOperationToolStripMenuItem_Click);
            // 
            // type1ToolStripMenuItem
            // 
            this.type1ToolStripMenuItem.Name = "type1ToolStripMenuItem";
            this.type1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.type1ToolStripMenuItem.Text = "Type 1";
            this.type1ToolStripMenuItem.Click += new System.EventHandler(this.Type1ToolStripMenuItem_Click);
            // 
            // type2ToolStripMenuItem
            // 
            this.type2ToolStripMenuItem.Name = "type2ToolStripMenuItem";
            this.type2ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.type2ToolStripMenuItem.Text = "Type 2";
            this.type2ToolStripMenuItem.Click += new System.EventHandler(this.Type2ToolStripMenuItem_Click);
            // 
            // type3ToolStripMenuItem
            // 
            this.type3ToolStripMenuItem.Name = "type3ToolStripMenuItem";
            this.type3ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.type3ToolStripMenuItem.Text = "Type 3";
            this.type3ToolStripMenuItem.Click += new System.EventHandler(this.Type3ToolStripMenuItem_Click);
            // 
            // sharpenOperationToolStripMenuItem
            // 
            this.sharpenOperationToolStripMenuItem.Name = "sharpenOperationToolStripMenuItem";
            this.sharpenOperationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.sharpenOperationToolStripMenuItem.Text = "sharpen operation";
            this.sharpenOperationToolStripMenuItem.Click += new System.EventHandler(this.SharpenOperationToolStripMenuItem_Click);
            // 
            // boxBlurOperationToolStripMenuItem
            // 
            this.boxBlurOperationToolStripMenuItem.Name = "boxBlurOperationToolStripMenuItem";
            this.boxBlurOperationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.boxBlurOperationToolStripMenuItem.Text = "box blur operation";
            this.boxBlurOperationToolStripMenuItem.Click += new System.EventHandler(this.BoxBlurOperationToolStripMenuItem_Click);
            // 
            // poolingToolStripMenuItem
            // 
            this.poolingToolStripMenuItem.Name = "poolingToolStripMenuItem";
            this.poolingToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.poolingToolStripMenuItem.Text = "Pooling";
            this.poolingToolStripMenuItem.Click += new System.EventHandler(this.PoolingToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 278);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(626, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(538, 278);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identityOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxBlurOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poolingToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}