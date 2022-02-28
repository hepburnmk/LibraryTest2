namespace LibraryTest
{
    partial class frmSearch
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
            this.grbSelectValues = new System.Windows.Forms.GroupBox();
            this.lblHome = new System.Windows.Forms.Button();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Avaliable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grbSelectValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSelectValues
            // 
            this.grbSelectValues.Controls.Add(this.lblHome);
            this.grbSelectValues.Controls.Add(this.lblCriteria);
            this.grbSelectValues.Controls.Add(this.textBox1);
            this.grbSelectValues.Controls.Add(this.btnSearch);
            this.grbSelectValues.Controls.Add(this.btnClose);
            this.grbSelectValues.Controls.Add(this.cboOperator);
            this.grbSelectValues.Controls.Add(this.lblValue);
            this.grbSelectValues.Location = new System.Drawing.Point(24, 29);
            this.grbSelectValues.Name = "grbSelectValues";
            this.grbSelectValues.Size = new System.Drawing.Size(739, 133);
            this.grbSelectValues.TabIndex = 0;
            this.grbSelectValues.TabStop = false;
            this.grbSelectValues.Text = "Keywords:";
            this.grbSelectValues.Enter += new System.EventHandler(this.grbSelectValues_Enter);
            // 
            // lblHome
            // 
            this.lblHome.Location = new System.Drawing.Point(603, 98);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(75, 23);
            this.lblHome.TabIndex = 11;
            this.lblHome.Text = "Home";
            this.lblHome.UseVisualStyleBackColor = true;
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Location = new System.Drawing.Point(340, 9);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(72, 16);
            this.lblCriteria.TabIndex = 10;
            this.lblCriteria.Text = "Search By:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 22);
            this.textBox1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(603, 69);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "ISBN",
            "Title",
            "Author",
            "Year Published",
            "Genre",
            "Publisher",
            "Edition",
            "Language",
            "Age ",
            "Page Count ",
            "Synopsis"});
            this.cboOperator.Location = new System.Drawing.Point(340, 40);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(219, 24);
            this.cboOperator.TabIndex = 5;
            this.cboOperator.SelectedIndexChanged += new System.EventHandler(this.cboOperator_SelectedIndexChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(412, 43);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(42, 16);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Value";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(890, 65);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(361, 29);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(49, 16);
            this.lblField.TabIndex = 1;
            this.lblField.Text = "Criteria";
            this.lblField.Click += new System.EventHandler(this.lblField_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(905, 9);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(60, 16);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "Operator";
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(844, 32);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 24);
            this.cboField.TabIndex = 1;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.Genre,
            this.Publisher,
            this.YearPublished,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Avaliable});
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 125;
            // 
            // Genre
            // 
            this.Genre.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Genre.Width = 125;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 6;
            this.Publisher.Name = "Publisher";
            this.Publisher.Width = 125;
            // 
            // YearPublished
            // 
            this.YearPublished.HeaderText = "Year Published";
            this.YearPublished.MinimumWidth = 6;
            this.YearPublished.Name = "YearPublished";
            this.YearPublished.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edition";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Language";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Age";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pages";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Synopsis";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Avaliable
            // 
            this.Avaliable.HeaderText = "Available";
            this.Avaliable.MinimumWidth = 6;
            this.Avaliable.Name = "Avaliable";
            this.Avaliable.Width = 125;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 380);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total Records";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbSelectValues);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.lblOperator);
            this.Name = "frmSearch";
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.grbSelectValues.ResumeLayout(false);
            this.grbSelectValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSelectValues;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox textBoxFilterValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button lblHome;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Avaliable;
    }
}