namespace LibraryTest
{
    partial class FrmBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooks));
            this.lblComBookLib = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblYearPub = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.txtYearPub = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Button();
            this.txtNumRecords = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.toolTipLibrary = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComBookLib
            // 
            this.lblComBookLib.AutoSize = true;
            this.lblComBookLib.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblComBookLib.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComBookLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComBookLib.ForeColor = System.Drawing.Color.Teal;
            this.lblComBookLib.Location = new System.Drawing.Point(202, 25);
            this.lblComBookLib.Name = "lblComBookLib";
            this.lblComBookLib.Size = new System.Drawing.Size(272, 48);
            this.lblComBookLib.TabIndex = 0;
            this.lblComBookLib.Text = "BookSwapper";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(88, 112);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(38, 16);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(88, 148);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(88, 186);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(89, 225);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(89, 262);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(63, 16);
            this.lblPublisher.TabIndex = 5;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblYearPub
            // 
            this.lblYearPub.AutoSize = true;
            this.lblYearPub.Location = new System.Drawing.Point(88, 296);
            this.lblYearPub.Name = "lblYearPub";
            this.lblYearPub.Size = new System.Drawing.Size(99, 16);
            this.lblYearPub.TabIndex = 6;
            this.lblYearPub.Text = "Year Published";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(202, 106);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(305, 22);
            this.txtISBN.TabIndex = 7;
            this.txtISBN.Text = "000-0-00-000000-0";
            this.toolTipLibrary.SetToolTip(this.txtISBN, "An ISBN is a 13 digit International Standard Book Number.");
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(202, 183);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(305, 22);
            this.txtTitle.TabIndex = 8;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(202, 219);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(305, 22);
            this.txtGenre.TabIndex = 9;
            // 
            // txtPub
            // 
            this.txtPub.Location = new System.Drawing.Point(202, 256);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(305, 22);
            this.txtPub.TabIndex = 10;
            this.toolTipLibrary.SetToolTip(this.txtPub, "Surname, First Name");
            // 
            // txtYearPub
            // 
            this.txtYearPub.Location = new System.Drawing.Point(202, 290);
            this.txtYearPub.Name = "txtYearPub";
            this.txtYearPub.Size = new System.Drawing.Size(305, 22);
            this.txtYearPub.TabIndex = 11;
            this.toolTipLibrary.SetToolTip(this.txtYearPub, "Please Enter as a whole Number.");
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(202, 142);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(305, 22);
            this.txtAuthor.TabIndex = 12;
            this.toolTipLibrary.SetToolTip(this.txtAuthor, "Surname, First Name");
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(538, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(538, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(538, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(538, 218);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(538, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(538, 289);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(94, 23);
            this.lblExit.TabIndex = 18;
            this.lblExit.Text = "&Exit";
            this.lblExit.UseVisualStyleBackColor = true;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // txtNumRecords
            // 
            this.txtNumRecords.Location = new System.Drawing.Point(304, 397);
            this.txtNumRecords.Name = "txtNumRecords";
            this.txtNumRecords.Size = new System.Drawing.Size(109, 22);
            this.txtNumRecords.TabIndex = 19;
            this.txtNumRecords.Text = "1 of 15";
            this.txtNumRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumRecords.TextChanged += new System.EventHandler(this.txtNumRecords_TextChanged);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(529, 396);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(94, 23);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(429, 396);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 23);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next  >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(192, 396);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 23);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(91, 396);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 23);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(89, 329);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(56, 16);
            this.lblAvailable.TabIndex = 24;
            this.lblAvailable.Text = "Availale";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(202, 329);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(18, 17);
            this.chkAvailable.TabIndex = 25;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // toolTipLibrary
            // 
            this.toolTipLibrary.AutomaticDelay = 250;
            this.toolTipLibrary.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.txtNumRecords);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtYearPub);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblYearPub);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblComBookLib);
            this.Name = "FrmBooks";
            this.Text = "Library Form1";
            this.Load += new System.EventHandler(this.Frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComBookLib;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblYearPub;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.TextBox txtYearPub;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button lblExit;
        private System.Windows.Forms.TextBox txtNumRecords;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.ToolTip toolTipLibrary;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

