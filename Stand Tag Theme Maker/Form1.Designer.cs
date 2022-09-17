namespace Stand_Tag_Theme_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tagThemeChanger1 = new Stand_Tag_Theme_Maker.TagThemeChanger();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.blinkButton1 = new Blink_UI_lib.BlinkButton();
            this.blinkPanel1 = new Blink_UI_lib.BlinkPanel();
            this.blinkPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1034, 524);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tagThemeChanger1
            // 
            this.tagThemeChanger1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagThemeChanger1.BackColor = System.Drawing.Color.Transparent;
            this.tagThemeChanger1.BorderRadius = 8;
            this.tagThemeChanger1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tagThemeChanger1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.tagThemeChanger1.ForeColor = System.Drawing.Color.White;
            this.tagThemeChanger1.Location = new System.Drawing.Point(1052, 12);
            this.tagThemeChanger1.Name = "tagThemeChanger1";
            this.tagThemeChanger1.Size = new System.Drawing.Size(261, 310);
            this.tagThemeChanger1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(255, 153);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Theme Presets";
            // 
            // blinkButton1
            // 
            this.blinkButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkButton1.Animated = false;
            this.blinkButton1.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton1.BorderRadius = 4;
            this.blinkButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blinkButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.blinkButton1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.blinkButton1.Location = new System.Drawing.Point(1052, 513);
            this.blinkButton1.Name = "blinkButton1";
            this.blinkButton1.Size = new System.Drawing.Size(261, 23);
            this.blinkButton1.TabIndex = 5;
            this.blinkButton1.Text = "Export PNGs";
            this.blinkButton1.Click += new System.EventHandler(this.blinkButton1_Click);
            // 
            // blinkPanel1
            // 
            this.blinkPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkPanel1.BackColor = System.Drawing.Color.Transparent;
            this.blinkPanel1.BorderRadius = 8;
            this.blinkPanel1.Controls.Add(this.label1);
            this.blinkPanel1.Controls.Add(this.flowLayoutPanel2);
            this.blinkPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.blinkPanel1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.blinkPanel1.InternalPanel.Location = new System.Drawing.Point(0, 0);
            this.blinkPanel1.InternalPanel.Name = "";
            this.blinkPanel1.InternalPanel.TabIndex = 0;
            this.blinkPanel1.Location = new System.Drawing.Point(1052, 328);
            this.blinkPanel1.Name = "blinkPanel1";
            this.blinkPanel1.Size = new System.Drawing.Size(261, 179);
            this.blinkPanel1.TabIndex = 6;
            this.blinkPanel1.Text = "blinkPanel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1325, 548);
            this.Controls.Add(this.blinkPanel1);
            this.Controls.Add(this.blinkButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tagThemeChanger1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stand Tag Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.blinkPanel1.ResumeLayout(false);
            this.blinkPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TagThemeChanger tagThemeChanger1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private Blink_UI_lib.BlinkButton blinkButton1;
        private Blink_UI_lib.BlinkPanel blinkPanel1;
    }
}

