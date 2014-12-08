namespace PhotoGallery
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbImage = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.bioLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.gpLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.gsLabel = new System.Windows.Forms.Label();
            this.goalsLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.assistLabel = new System.Windows.Forms.Label();
            this.shotsLabel = new System.Windows.Forms.Label();
            this.sogLabel = new System.Windows.Forms.Label();
            this.gpTextBox = new System.Windows.Forms.TextBox();
            this.gsTextBox = new System.Windows.Forms.TextBox();
            this.goalsTextBox = new System.Windows.Forms.TextBox();
            this.assistTextBox = new System.Windows.Forms.TextBox();
            this.shotsTextBox = new System.Windows.Forms.TextBox();
            this.sogTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbImage
            // 
            this.cmbImage.FormattingEnabled = true;
            this.cmbImage.Location = new System.Drawing.Point(12, 91);
            this.cmbImage.Name = "cmbImage";
            this.cmbImage.Size = new System.Drawing.Size(184, 21);
            this.cmbImage.TabIndex = 1;
            this.cmbImage.SelectionChangeCommitted += new System.EventHandler(this.cmbImage_SelectionChangeCommitted);
            this.cmbImage.SelectedIndexChanged += new System.EventHandler(this.cmbImage_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(239, 303);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(186, 20);
            this.txtYear.TabIndex = 2;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(8, 46);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(75, 13);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "Player Names:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhotoGallery.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(11, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 211);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // bioTextBox
            // 
            this.bioTextBox.Location = new System.Drawing.Point(239, 86);
            this.bioTextBox.Multiline = true;
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.Size = new System.Drawing.Size(178, 198);
            this.bioTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "University of Pittsburgh-Bradford Men\'s Soccer";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 520);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(380, 520);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bioLabel
            // 
            this.bioLabel.AutoSize = true;
            this.bioLabel.Location = new System.Drawing.Point(236, 63);
            this.bioLabel.Name = "bioLabel";
            this.bioLabel.Size = new System.Drawing.Size(57, 13);
            this.bioLabel.TabIndex = 9;
            this.bioLabel.Text = "Biography:";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLabel.Location = new System.Drawing.Point(235, 326);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(90, 24);
            this.statsLabel.TabIndex = 10;
            this.statsLabel.Text = "Statistics";
            // 
            // gpLabel
            // 
            this.gpLabel.AutoSize = true;
            this.gpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLabel.Location = new System.Drawing.Point(227, 357);
            this.gpLabel.Name = "gpLabel";
            this.gpLabel.Size = new System.Drawing.Size(120, 13);
            this.gpLabel.TabIndex = 11;
            this.gpLabel.Text = "Games Played (GP):";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(299, 520);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // gsLabel
            // 
            this.gsLabel.AutoSize = true;
            this.gsLabel.Location = new System.Drawing.Point(243, 383);
            this.gsLabel.Name = "gsLabel";
            this.gsLabel.Size = new System.Drawing.Size(104, 13);
            this.gsLabel.TabIndex = 13;
            this.gsLabel.Text = "Games Started (GS):";
            // 
            // goalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.Location = new System.Drawing.Point(310, 461);
            this.goalsLabel.Name = "goalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(37, 13);
            this.goalsLabel.TabIndex = 14;
            this.goalsLabel.Text = "Goals:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(236, 287);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 15;
            this.yearLabel.Text = "Year:";
            // 
            // assistLabel
            // 
            this.assistLabel.AutoSize = true;
            this.assistLabel.Location = new System.Drawing.Point(310, 487);
            this.assistLabel.Name = "assistLabel";
            this.assistLabel.Size = new System.Drawing.Size(37, 13);
            this.assistLabel.TabIndex = 16;
            this.assistLabel.Text = "Assist:";
            // 
            // shotsLabel
            // 
            this.shotsLabel.AutoSize = true;
            this.shotsLabel.Location = new System.Drawing.Point(310, 435);
            this.shotsLabel.Name = "shotsLabel";
            this.shotsLabel.Size = new System.Drawing.Size(37, 13);
            this.shotsLabel.TabIndex = 17;
            this.shotsLabel.Text = "Shots:";
            // 
            // sogLabel
            // 
            this.sogLabel.AutoSize = true;
            this.sogLabel.Location = new System.Drawing.Point(236, 409);
            this.sogLabel.Name = "sogLabel";
            this.sogLabel.Size = new System.Drawing.Size(111, 13);
            this.sogLabel.TabIndex = 18;
            this.sogLabel.Text = "Shots On Goal (SOG):";
            // 
            // gpTextBox
            // 
            this.gpTextBox.Location = new System.Drawing.Point(371, 350);
            this.gpTextBox.Name = "gpTextBox";
            this.gpTextBox.Size = new System.Drawing.Size(46, 20);
            this.gpTextBox.TabIndex = 19;
            // 
            // gsTextBox
            // 
            this.gsTextBox.Location = new System.Drawing.Point(371, 376);
            this.gsTextBox.Name = "gsTextBox";
            this.gsTextBox.Size = new System.Drawing.Size(60, 20);
            this.gsTextBox.TabIndex = 20;
            // 
            // goalsTextBox
            // 
            this.goalsTextBox.Location = new System.Drawing.Point(371, 402);
            this.goalsTextBox.Name = "goalsTextBox";
            this.goalsTextBox.Size = new System.Drawing.Size(68, 20);
            this.goalsTextBox.TabIndex = 21;
            // 
            // assistTextBox
            // 
            this.assistTextBox.Location = new System.Drawing.Point(371, 428);
            this.assistTextBox.Name = "assistTextBox";
            this.assistTextBox.Size = new System.Drawing.Size(68, 20);
            this.assistTextBox.TabIndex = 22;
            // 
            // shotsTextBox
            // 
            this.shotsTextBox.Location = new System.Drawing.Point(371, 454);
            this.shotsTextBox.Name = "shotsTextBox";
            this.shotsTextBox.Size = new System.Drawing.Size(68, 20);
            this.shotsTextBox.TabIndex = 23;
            // 
            // sogTextBox
            // 
            this.sogTextBox.Location = new System.Drawing.Point(371, 480);
            this.sogTextBox.Name = "sogTextBox";
            this.sogTextBox.Size = new System.Drawing.Size(53, 20);
            this.sogTextBox.TabIndex = 24;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(11, 62);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 25;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 558);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sogTextBox);
            this.Controls.Add(this.shotsTextBox);
            this.Controls.Add(this.assistTextBox);
            this.Controls.Add(this.goalsTextBox);
            this.Controls.Add(this.gsTextBox);
            this.Controls.Add(this.gpTextBox);
            this.Controls.Add(this.sogLabel);
            this.Controls.Add(this.shotsLabel);
            this.Controls.Add(this.assistLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.goalsLabel);
            this.Controls.Add(this.gsLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.gpLabel);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.bioLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bioTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmbImage);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "UPB Mens Soccer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbImage;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox bioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label bioLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label gpLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label gsLabel;
        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label assistLabel;
        private System.Windows.Forms.Label shotsLabel;
        private System.Windows.Forms.Label sogLabel;
        private System.Windows.Forms.TextBox gpTextBox;
        private System.Windows.Forms.TextBox gsTextBox;
        private System.Windows.Forms.TextBox goalsTextBox;
        private System.Windows.Forms.TextBox assistTextBox;
        private System.Windows.Forms.TextBox shotsTextBox;
        private System.Windows.Forms.TextBox sogTextBox;
        private System.Windows.Forms.Button search;
    }
}

