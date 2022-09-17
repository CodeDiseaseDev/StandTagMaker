namespace Stand_Tag_Theme_Maker
{
    partial class TagThemeChanger
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.blinkCheckbox2 = new Blink_UI_lib.BlinkCheckbox();
            this.blinkSlider3 = new Blink_UI_lib.BlinkSlider();
            this.blinkSlider2 = new Blink_UI_lib.BlinkSlider();
            this.blinkSlider1 = new Blink_UI_lib.BlinkSlider();
            this.label8 = new System.Windows.Forms.Label();
            this.blinkButton1 = new Blink_UI_lib.BlinkButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag Padding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tag Corner Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tag Background";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(96, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 15);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(94, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 15);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tag Foreground";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tag Scale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rainbow Tags";
            // 
            // blinkCheckbox2
            // 
            this.blinkCheckbox2.Animated = false;
            this.blinkCheckbox2.AutoSize = true;
            this.blinkCheckbox2.BackColor = System.Drawing.Color.Transparent;
            this.blinkCheckbox2.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.blinkCheckbox2.Checked = false;
            this.blinkCheckbox2.CheckedColor = System.Drawing.Color.Black;
            this.blinkCheckbox2.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkCheckbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkCheckbox2.Location = new System.Drawing.Point(187, 130);
            this.blinkCheckbox2.Margin = new System.Windows.Forms.Padding(5);
            this.blinkCheckbox2.Name = "blinkCheckbox2";
            this.blinkCheckbox2.Size = new System.Drawing.Size(69, 18);
            this.blinkCheckbox2.TabIndex = 13;
            this.blinkCheckbox2.Text = "Enabled";
            this.blinkCheckbox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blinkCheckbox2_MouseUp);
            // 
            // blinkSlider3
            // 
            this.blinkSlider3.BackColor = System.Drawing.Color.Black;
            this.blinkSlider3.DangerRange = 100;
            this.blinkSlider3.DangerRangeColor = System.Drawing.Color.Empty;
            this.blinkSlider3.DefaultValue = 20;
            this.blinkSlider3.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blinkSlider3.Location = new System.Drawing.Point(67, 105);
            this.blinkSlider3.Margin = new System.Windows.Forms.Padding(5);
            this.blinkSlider3.MaxValue = 100;
            this.blinkSlider3.MinValue = 0;
            this.blinkSlider3.Name = "blinkSlider3";
            this.blinkSlider3.RenderDangerRange = false;
            this.blinkSlider3.Size = new System.Drawing.Size(189, 15);
            this.blinkSlider3.TabIndex = 8;
            this.blinkSlider3.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.blinkSlider3.Value = 20;
            this.blinkSlider3.OnDragFinish += new Blink_UI_lib.BlinkSlider.ValueChangedEventHandler(this.blinkSlider3_OnDragFinish);
            // 
            // blinkSlider2
            // 
            this.blinkSlider2.BackColor = System.Drawing.Color.Black;
            this.blinkSlider2.DangerRange = 100;
            this.blinkSlider2.DangerRangeColor = System.Drawing.Color.Empty;
            this.blinkSlider2.DefaultValue = 50;
            this.blinkSlider2.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blinkSlider2.Location = new System.Drawing.Point(107, 30);
            this.blinkSlider2.Margin = new System.Windows.Forms.Padding(5);
            this.blinkSlider2.MaxValue = 8;
            this.blinkSlider2.MinValue = 0;
            this.blinkSlider2.Name = "blinkSlider2";
            this.blinkSlider2.RenderDangerRange = false;
            this.blinkSlider2.Size = new System.Drawing.Size(149, 15);
            this.blinkSlider2.TabIndex = 2;
            this.blinkSlider2.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.blinkSlider2.Value = 3;
            this.blinkSlider2.OnDragFinish += new Blink_UI_lib.BlinkSlider.ValueChangedEventHandler(this.blinkSlider2_OnDragFinish);
            // 
            // blinkSlider1
            // 
            this.blinkSlider1.BackColor = System.Drawing.Color.Black;
            this.blinkSlider1.DangerRange = 100;
            this.blinkSlider1.DangerRangeColor = System.Drawing.Color.Empty;
            this.blinkSlider1.DefaultValue = 50;
            this.blinkSlider1.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.blinkSlider1.Location = new System.Drawing.Point(75, 5);
            this.blinkSlider1.Margin = new System.Windows.Forms.Padding(5);
            this.blinkSlider1.MaxValue = 8;
            this.blinkSlider1.MinValue = 0;
            this.blinkSlider1.Name = "blinkSlider1";
            this.blinkSlider1.RenderDangerRange = false;
            this.blinkSlider1.Size = new System.Drawing.Size(181, 15);
            this.blinkSlider1.TabIndex = 0;
            this.blinkSlider1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.blinkSlider1.Value = 3;
            this.blinkSlider1.OnValueChanged += new Blink_UI_lib.BlinkSlider.ValueChangedEventHandler(this.blinkSlider1_OnValueChanged);
            this.blinkSlider1.OnDragFinish += new Blink_UI_lib.BlinkSlider.ValueChangedEventHandler(this.blinkSlider1_OnDragFinish);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Font (FontName)";
            // 
            // blinkButton1
            // 
            this.blinkButton1.Animated = false;
            this.blinkButton1.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton1.BorderRadius = 4;
            this.blinkButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.blinkButton1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.blinkButton1.Location = new System.Drawing.Point(156, 155);
            this.blinkButton1.Name = "blinkButton1";
            this.blinkButton1.Size = new System.Drawing.Size(100, 17);
            this.blinkButton1.TabIndex = 15;
            this.blinkButton1.Text = "Change Font";
            this.blinkButton1.Click += new System.EventHandler(this.blinkButton1_Click);
            // 
            // TagThemeChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.blinkButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.blinkCheckbox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.blinkSlider3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blinkSlider2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blinkSlider1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TagThemeChanger";
            this.Size = new System.Drawing.Size(261, 392);
            this.Load += new System.EventHandler(this.TagThemeChanger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Blink_UI_lib.BlinkSlider blinkSlider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Blink_UI_lib.BlinkSlider blinkSlider2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Blink_UI_lib.BlinkSlider blinkSlider3;
        private Blink_UI_lib.BlinkCheckbox blinkCheckbox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Blink_UI_lib.BlinkButton blinkButton1;
    }
}
