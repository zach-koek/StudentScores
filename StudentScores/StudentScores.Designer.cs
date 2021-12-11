
namespace StudentScores
{
    partial class StudentScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstbxStudentList = new System.Windows.Forms.ListBox();
            this.txtbxScoreTotal = new System.Windows.Forms.TextBox();
            this.txtbxScoreCount = new System.Windows.Forms.TextBox();
            this.txtbxAverage = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Score total:";
            // 
            // lstbxStudentList
            // 
            this.lstbxStudentList.FormattingEnabled = true;
            this.lstbxStudentList.ItemHeight = 15;
            this.lstbxStudentList.Location = new System.Drawing.Point(12, 31);
            this.lstbxStudentList.Name = "lstbxStudentList";
            this.lstbxStudentList.Size = new System.Drawing.Size(301, 169);
            this.lstbxStudentList.TabIndex = 4;
            this.lstbxStudentList.SelectedIndexChanged += new System.EventHandler(this.lstbxStudentList_SelectedIndexChanged);
            // 
            // txtbxScoreTotal
            // 
            this.txtbxScoreTotal.Location = new System.Drawing.Point(272, 213);
            this.txtbxScoreTotal.Name = "txtbxScoreTotal";
            this.txtbxScoreTotal.ReadOnly = true;
            this.txtbxScoreTotal.Size = new System.Drawing.Size(41, 23);
            this.txtbxScoreTotal.TabIndex = 5;
            // 
            // txtbxScoreCount
            // 
            this.txtbxScoreCount.Location = new System.Drawing.Point(272, 242);
            this.txtbxScoreCount.Name = "txtbxScoreCount";
            this.txtbxScoreCount.ReadOnly = true;
            this.txtbxScoreCount.Size = new System.Drawing.Size(41, 23);
            this.txtbxScoreCount.TabIndex = 6;
            // 
            // txtbxAverage
            // 
            this.txtbxAverage.Location = new System.Drawing.Point(272, 271);
            this.txtbxAverage.Name = "txtbxAverage";
            this.txtbxAverage.ReadOnly = true;
            this.txtbxAverage.Size = new System.Drawing.Size(41, 23);
            this.txtbxAverage.TabIndex = 7;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(331, 49);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(85, 27);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add &New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(331, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 27);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "&Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(331, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(331, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 303);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtbxAverage);
            this.Controls.Add(this.txtbxScoreCount);
            this.Controls.Add(this.txtbxScoreTotal);
            this.Controls.Add(this.lstbxStudentList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StudentScores";
            this.Text = "Student Scores:";
            this.Load += new System.EventHandler(this.StudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstbxStudentList;
        private System.Windows.Forms.TextBox txtbxScoreTotal;
        private System.Windows.Forms.TextBox txtbxScoreCount;
        private System.Windows.Forms.TextBox txtbxAverage;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

