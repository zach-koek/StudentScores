
namespace StudentScores
{
    partial class AddScore
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
            this.txtbxScoreAddScoreModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelAddScoreModel = new System.Windows.Forms.Button();
            this.btnUpdateAddScoreModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxScoreAddScoreModel
            // 
            this.txtbxScoreAddScoreModel.Location = new System.Drawing.Point(77, 23);
            this.txtbxScoreAddScoreModel.Name = "txtbxScoreAddScoreModel";
            this.txtbxScoreAddScoreModel.Size = new System.Drawing.Size(72, 23);
            this.txtbxScoreAddScoreModel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score:";
            // 
            // btnCancelAddScoreModel
            // 
            this.btnCancelAddScoreModel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddScoreModel.Location = new System.Drawing.Point(115, 67);
            this.btnCancelAddScoreModel.Name = "btnCancelAddScoreModel";
            this.btnCancelAddScoreModel.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddScoreModel.TabIndex = 5;
            this.btnCancelAddScoreModel.Text = "Cancel";
            this.btnCancelAddScoreModel.UseVisualStyleBackColor = true;
            this.btnCancelAddScoreModel.Click += new System.EventHandler(this.btnCancelAddScoreModel_Click);
            // 
            // btnUpdateAddScoreModel
            // 
            this.btnUpdateAddScoreModel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdateAddScoreModel.Location = new System.Drawing.Point(24, 67);
            this.btnUpdateAddScoreModel.Name = "btnUpdateAddScoreModel";
            this.btnUpdateAddScoreModel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAddScoreModel.TabIndex = 4;
            this.btnUpdateAddScoreModel.Text = "Add";
            this.btnUpdateAddScoreModel.UseVisualStyleBackColor = true;
            this.btnUpdateAddScoreModel.Click += new System.EventHandler(this.btnUpdateAddScoreModel_Click);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 106);
            this.Controls.Add(this.txtbxScoreAddScoreModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelAddScoreModel);
            this.Controls.Add(this.btnUpdateAddScoreModel);
            this.Name = "AddScore";
            this.Text = "Add Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxScoreAddScoreModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelAddScoreModel;
        private System.Windows.Forms.Button btnUpdateAddScoreModel;
    }
}