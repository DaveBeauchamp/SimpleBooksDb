namespace BooksSingleTableDb
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBookEditID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.btnBookNew = new System.Windows.Forms.Button();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.btnAuthorNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAddEditStatus = new System.Windows.Forms.Label();
            this.btnBookFirst = new System.Windows.Forms.Button();
            this.btnBookLast = new System.Windows.Forms.Button();
            this.btnAuthorFirst = new System.Windows.Forms.Button();
            this.btnAuthorLast = new System.Windows.Forms.Button();
            this.btnBookPrev = new System.Windows.Forms.Button();
            this.btnBookNext = new System.Windows.Forms.Button();
            this.btnAuthorPrevious = new System.Windows.Forms.Button();
            this.btnAuthorNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(195, 12);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.Size = new System.Drawing.Size(352, 305);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBookList_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book ID:";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(98, 75);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(13, 13);
            this.lblBookId.TabIndex = 3;
            this.lblBookId.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Book Genre:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(98, 98);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(0, 13);
            this.lblBookTitle.TabIndex = 6;
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Location = new System.Drawing.Point(98, 120);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(0, 13);
            this.lblBookGenre.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Author:";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(98, 142);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(0, 13);
            this.lblBookAuthor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add && Edit Books";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Author:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Book Genre:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Book Title:";
            // 
            // lblBookEditID
            // 
            this.lblBookEditID.AutoSize = true;
            this.lblBookEditID.Location = new System.Drawing.Point(98, 373);
            this.lblBookEditID.Name = "lblBookEditID";
            this.lblBookEditID.Size = new System.Drawing.Size(13, 13);
            this.lblBookEditID.TabIndex = 23;
            this.lblBookEditID.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 373);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Book ID:";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(101, 393);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(121, 20);
            this.txtBookTitle.TabIndex = 27;
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.Location = new System.Drawing.Point(101, 415);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(121, 20);
            this.txtBookGenre.TabIndex = 28;
            // 
            // cboAuthor
            // 
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(101, 437);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(121, 21);
            this.cboAuthor.TabIndex = 29;
            this.cboAuthor.Click += new System.EventHandler(this.cboAuthor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Add && Edit Authors";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(386, 373);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(13, 13);
            this.lblAuthorID.TabIndex = 32;
            this.lblAuthorID.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Author ID:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(389, 393);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(121, 20);
            this.txtAuthorName.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Author Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 31);
            this.label10.TabIndex = 35;
            this.label10.Text = "Navigation";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(20, 206);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 36;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(101, 206);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 37;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(20, 235);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 38;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(101, 235);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 39;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(15, 477);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(75, 23);
            this.btnBookSave.TabIndex = 40;
            this.btnBookSave.Text = "Save Book";
            this.btnBookSave.UseVisualStyleBackColor = true;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // btnBookNew
            // 
            this.btnBookNew.Location = new System.Drawing.Point(101, 477);
            this.btnBookNew.Name = "btnBookNew";
            this.btnBookNew.Size = new System.Drawing.Size(75, 23);
            this.btnBookNew.TabIndex = 41;
            this.btnBookNew.Text = "New Book";
            this.btnBookNew.UseVisualStyleBackColor = true;
            this.btnBookNew.Click += new System.EventHandler(this.btnBookNew_Click);
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.Location = new System.Drawing.Point(303, 418);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorSave.TabIndex = 42;
            this.btnAuthorSave.Text = "Save Author";
            this.btnAuthorSave.UseVisualStyleBackColor = true;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAuthorSave_Click);
            // 
            // btnAuthorNew
            // 
            this.btnAuthorNew.Location = new System.Drawing.Point(389, 419);
            this.btnAuthorNew.Name = "btnAuthorNew";
            this.btnAuthorNew.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorNew.TabIndex = 43;
            this.btnAuthorNew.Text = "New Author";
            this.btnAuthorNew.UseVisualStyleBackColor = true;
            this.btnAuthorNew.Click += new System.EventHandler(this.btnAuthorNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear Book";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(20, 294);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 23);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Add/Edit Status:";
            // 
            // lblAddEditStatus
            // 
            this.lblAddEditStatus.AutoSize = true;
            this.lblAddEditStatus.Location = new System.Drawing.Point(391, 540);
            this.lblAddEditStatus.Name = "lblAddEditStatus";
            this.lblAddEditStatus.Size = new System.Drawing.Size(0, 13);
            this.lblAddEditStatus.TabIndex = 47;
            // 
            // btnBookFirst
            // 
            this.btnBookFirst.Location = new System.Drawing.Point(15, 506);
            this.btnBookFirst.Name = "btnBookFirst";
            this.btnBookFirst.Size = new System.Drawing.Size(75, 23);
            this.btnBookFirst.TabIndex = 49;
            this.btnBookFirst.Text = "First Book";
            this.btnBookFirst.UseVisualStyleBackColor = true;
            this.btnBookFirst.Click += new System.EventHandler(this.btnBookFirst_Click);
            // 
            // btnBookLast
            // 
            this.btnBookLast.Location = new System.Drawing.Point(101, 506);
            this.btnBookLast.Name = "btnBookLast";
            this.btnBookLast.Size = new System.Drawing.Size(75, 23);
            this.btnBookLast.TabIndex = 50;
            this.btnBookLast.Text = "Last Book";
            this.btnBookLast.UseVisualStyleBackColor = true;
            this.btnBookLast.Click += new System.EventHandler(this.btnBookLast_Click);
            // 
            // btnAuthorFirst
            // 
            this.btnAuthorFirst.Location = new System.Drawing.Point(303, 447);
            this.btnAuthorFirst.Name = "btnAuthorFirst";
            this.btnAuthorFirst.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorFirst.TabIndex = 51;
            this.btnAuthorFirst.Text = "First Author";
            this.btnAuthorFirst.UseVisualStyleBackColor = true;
            this.btnAuthorFirst.Click += new System.EventHandler(this.btnAuthorFirst_Click);
            // 
            // btnAuthorLast
            // 
            this.btnAuthorLast.Location = new System.Drawing.Point(389, 448);
            this.btnAuthorLast.Name = "btnAuthorLast";
            this.btnAuthorLast.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorLast.TabIndex = 52;
            this.btnAuthorLast.Text = "Last Author";
            this.btnAuthorLast.UseVisualStyleBackColor = true;
            this.btnAuthorLast.Click += new System.EventHandler(this.btnAuthorLast_Click);
            // 
            // btnBookPrev
            // 
            this.btnBookPrev.Location = new System.Drawing.Point(15, 535);
            this.btnBookPrev.Name = "btnBookPrev";
            this.btnBookPrev.Size = new System.Drawing.Size(75, 23);
            this.btnBookPrev.TabIndex = 53;
            this.btnBookPrev.Text = "Prev Book";
            this.btnBookPrev.UseVisualStyleBackColor = true;
            this.btnBookPrev.Click += new System.EventHandler(this.btnBookPrev_Click);
            // 
            // btnBookNext
            // 
            this.btnBookNext.Location = new System.Drawing.Point(101, 535);
            this.btnBookNext.Name = "btnBookNext";
            this.btnBookNext.Size = new System.Drawing.Size(75, 23);
            this.btnBookNext.TabIndex = 54;
            this.btnBookNext.Text = "Next Book";
            this.btnBookNext.UseVisualStyleBackColor = true;
            this.btnBookNext.Click += new System.EventHandler(this.btnBookNext_Click);
            // 
            // btnAuthorPrevious
            // 
            this.btnAuthorPrevious.Location = new System.Drawing.Point(303, 476);
            this.btnAuthorPrevious.Name = "btnAuthorPrevious";
            this.btnAuthorPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorPrevious.TabIndex = 55;
            this.btnAuthorPrevious.Text = "Prev Author";
            this.btnAuthorPrevious.UseVisualStyleBackColor = true;
            this.btnAuthorPrevious.Click += new System.EventHandler(this.btnAuthorPrevious_Click);
            // 
            // btnAuthorNext
            // 
            this.btnAuthorNext.Location = new System.Drawing.Point(389, 477);
            this.btnAuthorNext.Name = "btnAuthorNext";
            this.btnAuthorNext.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorNext.TabIndex = 56;
            this.btnAuthorNext.Text = "Next Author";
            this.btnAuthorNext.UseVisualStyleBackColor = true;
            this.btnAuthorNext.Click += new System.EventHandler(this.btnAuthorNext_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 562);
            this.Controls.Add(this.btnAuthorNext);
            this.Controls.Add(this.btnAuthorPrevious);
            this.Controls.Add(this.btnBookNext);
            this.Controls.Add(this.btnBookPrev);
            this.Controls.Add(this.btnAuthorLast);
            this.Controls.Add(this.btnAuthorFirst);
            this.Controls.Add(this.btnBookLast);
            this.Controls.Add(this.btnBookFirst);
            this.Controls.Add(this.lblAddEditStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAuthorNew);
            this.Controls.Add(this.btnAuthorSave);
            this.Controls.Add(this.btnBookNew);
            this.Controls.Add(this.btnBookSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboAuthor);
            this.Controls.Add(this.txtBookGenre);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblBookEditID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBookGenre);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBookList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Books db";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBookEditID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Button btnBookNew;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.Button btnAuthorNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAddEditStatus;
        private System.Windows.Forms.Button btnBookFirst;
        private System.Windows.Forms.Button btnBookLast;
        private System.Windows.Forms.Button btnAuthorFirst;
        private System.Windows.Forms.Button btnAuthorLast;
        private System.Windows.Forms.Button btnBookPrev;
        private System.Windows.Forms.Button btnBookNext;
        private System.Windows.Forms.Button btnAuthorPrevious;
        private System.Windows.Forms.Button btnAuthorNext;
    }
}

