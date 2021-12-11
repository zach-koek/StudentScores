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
    public partial class UpdateScores : Form
    {
        public List<Student> students = new List<Student>();
        public Student tempStudent = new Student();
        public UpdateScores()
        {
            InitializeComponent();
        }

        private void btnUpdateUpdateScoreModel_Click(object sender, EventArgs e)
        {
            //catching exceptions
            try
            { //converts the text in the txtbox to a int then stores it in the tag.
                int updateScore = (int)Convert.ToInt32(txtbxScoreUpdateScoreModel.Text);

                if (updateScore > -1 & updateScore < 101)
                {
                    this.Tag = updateScore;
                    
                }
                else
                {
                    MessageBox.Show("Score must be between 0 - 100 ");
                    txtbxScoreUpdateScoreModel.Clear();
                }


            }
            //catches the exception of leaving the text box blank.
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message, "Please only use numbers to update score.");
            }
            //catches all other exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Only use numbers");
            }
            
            
        }
    }
}
