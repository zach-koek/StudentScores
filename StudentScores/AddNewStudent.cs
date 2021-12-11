using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class AddNewStudent : Form
    {
        
        Student tempStudent = new Student();
        public AddNewStudent()
        {
            InitializeComponent();


        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            //clears the textbox and the scores from the student.
            txtbxScores.Clear();
            tempStudent.Scores.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //I believe this is the best way to validate if the string in the text box is only letters and spaces. 
            string text = txtbxAddNewName.Text;
        try
            {
                //this if statement is to check to see if the textbox that is supposed to have a name is it is not empty.
                if (text != "") 
                {
                    //checks to see if the text is letters and spaces.
                    if (text.All(i => char.IsLetter(i) || char.IsWhiteSpace(i)))
                    {
                        //if it is then the student name is assigned what the text is and its put in the tag to be used in another form.
                        tempStudent.StudentName = txtbxAddNewName.Text;
                        this.Tag = tempStudent;
                    }
                    else
                    {
                        //warning if you dont put letters.
                        MessageBox.Show("Only Use letters and spaces for name.");
                        txtbxAddNewName.Clear();

                    }
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please only enter letters and spaces into the text box.");
            }
            catch (Exception)
            {
                MessageBox.Show("Some Error has occured. Please try again.");
            }



        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
           

            
                try
                {
                //read the text from the text box and assings it to var.
                int score = Convert.ToInt32(txtbxAddNewScore.Text);

                //validates to make sure the score is between 0 and 100
                if (score > -1  & score < 101)
                {
                    
                    // add score to the new students list of scores
                    tempStudent.Scores.Add(score);

                    //temp variable to brint out the results
                    string result = string.Join(" ", tempStudent.Scores);

                    //prints results to txtbox
                    txtbxScores.Text = result;

                    //clears textbox after button is clicked
                    txtbxAddNewScore.Clear();
                }
                else
                {
                    MessageBox.Show("Score must be between 0 - 100 ");
                    txtbxAddNewScore.Clear();
                }

                }
                //must be numbers.
                catch (FormatException fe)
                {
                    MessageBox.Show(fe.Message, "Please only use numbers!");
                    txtbxAddNewScore.Clear();
                }
                //all other exceptions.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error has occured");
                }

           
           

        }

    }
}
