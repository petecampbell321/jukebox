namespace DSA2
{
    partial class frmJuke
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
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.lblTracks = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtTracks = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.lblContents = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.add = new System.Windows.Forms.TabPage();
            this.remove = new System.Windows.Forms.TabPage();
            this.cbToRemove = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPopSelect = new System.Windows.Forms.Button();
            this.peek = new System.Windows.Forms.TabPage();
            this.lblPeek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeek = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.TabPage();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.add.SuspendLayout();
            this.remove.SuspendLayout();
            this.peek.SuspendLayout();
            this.find.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(18, 16);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(70, 13);
            this.lblAlbumName.TabIndex = 0;
            this.lblAlbumName.Text = "Album Name:";
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(147, 16);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(64, 13);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Artist Name:";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(21, 33);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(100, 20);
            this.txtAlbumName.TabIndex = 2;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(150, 33);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(100, 20);
            this.txtArtistName.TabIndex = 3;
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.Location = new System.Drawing.Point(21, 71);
            this.lblTracks.Name = "lblTracks";
            this.lblTracks.Size = new System.Drawing.Size(95, 13);
            this.lblTracks.TabIndex = 4;
            this.lblTracks.Text = "Number of Tracks:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(147, 71);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(94, 13);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration of Album:";
            // 
            // txtTracks
            // 
            this.txtTracks.Location = new System.Drawing.Point(24, 87);
            this.txtTracks.Name = "txtTracks";
            this.txtTracks.Size = new System.Drawing.Size(100, 20);
            this.txtTracks.TabIndex = 6;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(150, 87);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 7;
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.Location = new System.Drawing.Point(24, 130);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(226, 43);
            this.btnPush.TabIndex = 8;
            this.btnPush.Text = "Add";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContents.Location = new System.Drawing.Point(25, 36);
            this.lblContents.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(203, 30);
            this.lblContents.TabIndex = 10;
            this.lblContents.Text = "There are no records on the spindle...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblContents);
            this.groupBox2.Location = new System.Drawing.Point(22, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 316);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contents";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.add);
            this.tabControl1.Controls.Add(this.remove);
            this.tabControl1.Controls.Add(this.peek);
            this.tabControl1.Controls.Add(this.find);
            this.tabControl1.Location = new System.Drawing.Point(22, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 214);
            this.tabControl1.TabIndex = 13;
            // 
            // add
            // 
            this.add.Controls.Add(this.btnPush);
            this.add.Controls.Add(this.lblAlbumName);
            this.add.Controls.Add(this.lblTracks);
            this.add.Controls.Add(this.txtDuration);
            this.add.Controls.Add(this.txtArtistName);
            this.add.Controls.Add(this.lblArtistName);
            this.add.Controls.Add(this.lblDuration);
            this.add.Controls.Add(this.txtTracks);
            this.add.Controls.Add(this.txtAlbumName);
            this.add.Location = new System.Drawing.Point(4, 22);
            this.add.Name = "add";
            this.add.Padding = new System.Windows.Forms.Padding(3);
            this.add.Size = new System.Drawing.Size(274, 188);
            this.add.TabIndex = 0;
            this.add.Text = "Add Record";
            this.add.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Controls.Add(this.cbToRemove);
            this.remove.Controls.Add(this.label3);
            this.remove.Controls.Add(this.btnPopSelect);
            this.remove.Location = new System.Drawing.Point(4, 22);
            this.remove.Name = "remove";
            this.remove.Padding = new System.Windows.Forms.Padding(3);
            this.remove.Size = new System.Drawing.Size(274, 188);
            this.remove.TabIndex = 1;
            this.remove.Text = "Remove Record";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // cbToRemove
            // 
            this.cbToRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToRemove.FormattingEnabled = true;
            this.cbToRemove.Location = new System.Drawing.Point(24, 63);
            this.cbToRemove.MaxDropDownItems = 11;
            this.cbToRemove.Name = "cbToRemove";
            this.cbToRemove.Size = new System.Drawing.Size(226, 21);
            this.cbToRemove.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remove a SPECIFIC record from \r\nthe spindle:";
            // 
            // btnPopSelect
            // 
            this.btnPopSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopSelect.Location = new System.Drawing.Point(24, 107);
            this.btnPopSelect.Name = "btnPopSelect";
            this.btnPopSelect.Size = new System.Drawing.Size(226, 43);
            this.btnPopSelect.TabIndex = 10;
            this.btnPopSelect.TabStop = false;
            this.btnPopSelect.Text = "Remove Selected Record";
            this.btnPopSelect.UseVisualStyleBackColor = true;
            this.btnPopSelect.Click += new System.EventHandler(this.btnPopSelect_Click);
            // 
            // peek
            // 
            this.peek.Controls.Add(this.lblPeek);
            this.peek.Controls.Add(this.label1);
            this.peek.Controls.Add(this.btnPeek);
            this.peek.Location = new System.Drawing.Point(4, 22);
            this.peek.Name = "peek";
            this.peek.Size = new System.Drawing.Size(274, 188);
            this.peek.TabIndex = 2;
            this.peek.Text = "Peek Top";
            this.peek.UseVisualStyleBackColor = true;
            // 
            // lblPeek
            // 
            this.lblPeek.AutoSize = true;
            this.lblPeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeek.Location = new System.Drawing.Point(24, 139);
            this.lblPeek.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblPeek.Name = "lblPeek";
            this.lblPeek.Size = new System.Drawing.Size(0, 16);
            this.lblPeek.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "What record is at the top of the \r\nspindle?";
            // 
            // btnPeek
            // 
            this.btnPeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.Location = new System.Drawing.Point(24, 74);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(226, 43);
            this.btnPeek.TabIndex = 12;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // find
            // 
            this.find.Controls.Add(this.lblPlaying);
            this.find.Controls.Add(this.btnFind);
            this.find.Controls.Add(this.txtSearch);
            this.find.Controls.Add(this.label2);
            this.find.Location = new System.Drawing.Point(4, 22);
            this.find.Name = "find";
            this.find.Padding = new System.Windows.Forms.Padding(3);
            this.find.Size = new System.Drawing.Size(274, 188);
            this.find.TabIndex = 3;
            this.find.Text = "Play";
            this.find.UseVisualStyleBackColor = true;
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaying.Location = new System.Drawing.Point(24, 126);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(163, 16);
            this.lblPlaying.TabIndex = 13;
            this.lblPlaying.Text = "Nothing currently playing...";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(24, 60);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(226, 43);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Play!";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search for an album to play:";
            // 
            // frmJuke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(326, 585);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmJuke";
            this.Text = "Jukebox";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.remove.ResumeLayout(false);
            this.remove.PerformLayout();
            this.peek.ResumeLayout(false);
            this.peek.PerformLayout();
            this.find.ResumeLayout(false);
            this.find.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label lblTracks;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtTracks;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage add;
        private System.Windows.Forms.TabPage remove;
        private System.Windows.Forms.TabPage peek;
        private System.Windows.Forms.Label lblPeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.TabPage find;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPopSelect;
        private System.Windows.Forms.ComboBox cbToRemove;
        private System.Windows.Forms.Label lblPlaying;
    }
}

