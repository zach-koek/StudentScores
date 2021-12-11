
namespace StudentScores
{
    partial class UpdateStudentScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbxScoresUpdateScore = new System.Windows.Forms.ListBox();
            this.txtbxNameUpdateScore = new System.Windows.Forms.TextBox();
            this.btnRemoveUpdateScore = new System.Windows.Forms.Button();
            this.btnUpdateUpdateScore = new System.Windows.Forms.Button();
            this.btnAddUpdateScore = new System.Windows.Forms.Button();
            this.btnOkUpdateScore = new System.Windows.Forms.Button();
            this.btnCancelUpdateScore = new System.Windows.Forms.Button();
            this.btnClearScoresUpdateScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scores:";
            // 
            // lstbxScoresUpdateScore
            // 
            this.lstbxScoresUpdateScore.FormattingEnabled = true;
            this.lstbxScoresUpdateScore.ItemHeight = 15;
            this.lstbxScoresUpdateScore.Location = new System.Drawing.Point(56, 44);
            this.lstbxScoresUpdateScore.Name = "lstbxScoresUpdateScore";
            this.lstbxScoresUpdateScore.Size = new System.Drawing.Size(134, 124);
            this.lstbxScoresUpdateScore.TabIndex = 2;
            // 
            // txtbxNameUpdateScore
            // 
            this.txtbxNameUpdateScore.Location = new System.Drawing.Point(56, 6);
            this.txtbxNameUpdateScore.Name = "txtbxNameUpdateScore";
            this.txtbxNameUpdateScore.ReadOnly = true;
            this.txtbxNameUpdateScore.Size = new System.Drawing.Size(231, 23);
            this.txtbxNameUpdateScore.TabIndex = 3;
            // 
            // btnRemoveUpdateScore
            // 
            this.btnRemoveUpdateScore.Location = new System.Drawing.Point(212, 109);
            this.btnRemoveUpdateScore.Name = "btnRemoveUpdateScore";
            this.btnRemoveUpdateScore.Size = new System.Drawing.Size(83, 27);
            this.btnRemoveUpdateScore.TabIndex = 4;
            this.btnRemoveUpdateScore.Text = "Remove";
            this.btnRemoveUpdateScore.UseVisualStyleBackColor = true;
            this.btnRemoveUpdateScore.Click += new System.EventHandler(this.btnRemoveUpdateScore_Click);
            // 
            // btnUpdateUpdateScore
            // 
            this.btnUpdateUpdateScore.Location = new System.Drawing.Point(212, 76);
            this.btnUpdateUpdateScore.Name = "btnUpdateUpdateScore";
            this.btnUpdateUpdateScore.Size = new System.Drawing.Size(83, 27);
            this.btnUpdateUpdateScore.TabIndex = 5;
            this.btnUpdateUpdateScore.Text = "Update";
            this.btnUpdateUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateUpdateScore.Click += new System.EventHandler(this.btnUpdateUpdateScore_Click);
            // 
            // btnAddUpdateScore
            // 
            this.btnAddUpdateScore.Location = new System.Drawing.Point(212, 43);
            this.btnAddUpdateScore.Name = "btnAddUpdateScore";
            this.btnAddUpdateScore.Size = new System.Drawing.Size(83, 27);
            this.btnAddUpdateScore.TabIndex = 6;
            this.btnAddUpdateScore.Text = "Add";
            this.btnAddUpdateScore.UseVisualStyleBackColor = true;
            this.btnAddUpdateScore.Click += new System.EventHandler(this.btnAddUpdateScore_Click);
            // 
            // btnOkUpdateScore
            // 
            this.btnOkUpdateScore.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkUpdateScore.Location = new System.Drawing.Point(130, 218);
            this.btnOkUpdateScore.Name = "btnOkUpdateScore";
            this.btnOkUpdateScore.Size = new System.Drawing.Size(75, 27);
            this.btnOkUpdateScore.TabIndex = 7;
            this.btnOkUpdateScore.Text = "OK";
            this.btnOkUpdateScore.UseVisualStyleBackColor = true;
            this.btnOkUpdateScore.Click += new System.EventHandler(this.btnOkUpdateScore_Click);
            // 
            // btnCancelUpdateScore
            // 
            this.btnCancelUpdateScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUpdateScore.Location = new System.Drawing.Point(220, 217);
            this.btnCancelUpdateScore.Name = "btnCancelUpdateScore";
            this.btnCancelUpdateScore.Size = new System.Drawing.Size(75, 27);
            this.btnCancelUpdateScore.TabIndex = 8;
            this.btnCancelUpdateScore.Text = "Cancel";
            this.btnCancelUpdateScore.UseVisualStyleBackColor = true;
            // 
            // btnClearScoresUpdateScore
            // 
            this.btnClearScoresUpdateScore.Location = new System.Drawing.Point(212, 142);
            this.btnClearScoresUpdateScore.Name = "btnClearScoresUpdateScore";
            this.btnClearScoresUpdateScore.Size = new System.Drawing.Size(83, 29);
            this.btnClearScoresUpdateScore.TabIndex = 9;
            this.btnClearScoresUpdateScore.Text = "Clear Scores";
            this.btnClearScoresUpdateScore.UseVisualStyleBackColor = true;
            this.btnClearScoresUpdateScore.Click += new System.EventHandler(this.btnClearScoresUpdateScore_Click);
            // 
            // UpdateStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 260);
            this.Controls.Add(this.btnClearScoresUpdateScore);
            this.Controls.Add(this.btnCancelUpdateScore);
            this.Controls.Add(this.btnOkUpdateScore);
            this.Controls.Add(this.btnAddUpdateScore);
            this.Controls.Add(this.btnUpdateUpdateScore);
            this.Controls.Add(this.btnRemoveUpdateScore);
            this.Controls.Add(this.txtbxNameUpdateScore);
            this.Controls.Add(this.lstbxScoresUpdateScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateStudentScores";
            this.Text = "Update Student Scores";
            this.Load += new System.EventHandler(this.UpdateStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbxScoresUpdateScore;
        private System.Windows.Forms.TextBox txtbxNameUpdateScore;
        private System.Windows.Forms.Button btnRemoveUpdateScore;
        private System.Windows.Forms.Button btnUpdateUpdateScore;
        private System.Windows.Forms.Button btnAddUpdateScore;
        private System.Windows.Forms.Button btnOkUpdateScore;
        private System.Windows.Forms.Button btnCancelUpdateScore;
        private System.Windows.Forms.Button btnClearScoresUpdateScore;
    }
}