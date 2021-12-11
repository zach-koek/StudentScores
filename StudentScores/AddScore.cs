using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{

    public partial class AddScore : Form
    {
        Student tempStudent = new Student();
        public AddScore()
        {
            InitializeComponent();
        }

        private void btnUpdateAddScoreModel_Click(object sender, EventArgs e)
        {
            // catching the exceptions hopefully.

            try
            {
                //converts whats in the textbox to a int.
                int score = Convert.ToInt32(txtbxScoreAddScoreModel.Text);

                if (score > -1 & score < 101)
                {
                    //sets the results of above to tag to use in the other from.
                    this.Tag = score;

                }
                else
                {
                    MessageBox.Show("Score must be between 0 - 100 ");
                    
                    txtbxScoreAddScoreModel.Clear();
                }
                
            }
            //if you dont put anything in the box.
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message, "Please only use numbers to update score.");
            }
            //all other exceptions I couldnt remember.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please only use numbers.");
            }
           
        }

        private void btnCancelAddScoreModel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
