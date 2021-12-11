
namespace StudentScores
{
    partial class UpdateScores
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
            this.btnUpdateUpdateScoreModel = new System.Windows.Forms.Button();
            this.btnCancelUpdateScoreModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxScoreUpdateScoreModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateUpdateScoreModel
            // 
            this.btnUpdateUpdateScoreModel.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnUpdateUpdateScoreModel.Location = new System.Drawing.Point(12, 65);
            this.btnUpdateUpdateScoreModel.Name = "btnUpdateUpdateScoreModel";
            this.btnUpdateUpdateScoreModel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUpdateScoreModel.TabIndex = 0;
            this.btnUpdateUpdateScoreModel.Text = "Update";
            this.btnUpdateUpdateScoreModel.UseVisualStyleBackColor = true;
            this.btnUpdateUpdateScoreModel.Click += new System.EventHandler(this.btnUpdateUpdateScoreModel_Click);
            // 
            // btnCancelUpdateScoreModel
            // 
            this.btnCancelUpdateScoreModel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUpdateScoreModel.Location = new System.Drawing.Point(103, 65);
            this.btnCancelUpdateScoreModel.Name = "btnCancelUpdateScoreModel";
            this.btnCancelUpdateScoreModel.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdateScoreModel.TabIndex = 1;
            this.btnCancelUpdateScoreModel.Text = "Cancel";
            this.btnCancelUpdateScoreModel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // txtbxScoreUpdateScoreModel
            // 
            this.txtbxScoreUpdateScoreModel.Location = new System.Drawing.Point(65, 21);
            this.txtbxScoreUpdateScoreModel.Name = "txtbxScoreUpdateScoreModel";
            this.txtbxScoreUpdateScoreModel.Size = new System.Drawing.Size(72, 23);
            this.txtbxScoreUpdateScoreModel.TabIndex = 3;
            // 
            // UpdateScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 108);
            this.Controls.Add(this.txtbxScoreUpdateScoreModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelUpdateScoreModel);
            this.Controls.Add(this.btnUpdateUpdateScoreModel);
            this.Name = "UpdateScores";
            this.Text = "Update Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateUpdateScoreModel;
        private System.Windows.Forms.Button btnCancelUpdateScoreModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxScoreUpdateScoreModel;
    }
}