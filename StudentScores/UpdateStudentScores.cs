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
    public partial class UpdateStudentScores : Form
    {
        //creates instences of the student class.
        public List<Student> students = new List<Student>();
        public Student tempStudent = new Student();
        public UpdateStudentScores()
        {
            InitializeComponent();
        }


        private void btnAddUpdateScore_Click(object sender, EventArgs e)
        {

            //created new form with settings
            Form addScore = new AddScore();
            NewFormSettings(addScore);

            //creates a dialogResult variable when the form is created
            DialogResult dialogResult = addScore.ShowDialog();

            //if user hits ok then it will add the tag to the list box
            if (dialogResult == DialogResult.OK)
            {
                //try statement to make sure that the tag is only numbers. **this may be redundent**
                try
                {
                    if (addScore.Tag != null)
                    {
                        int newStudent = (int)addScore.Tag;
                        Convert.ToInt32(newStudent);
                        lstbxScoresUpdateScore.Items.Add(newStudent);
                    }

                }
                //only numbers allowed
                catch (NullReferenceException ne)
                {
                    MessageBox.Show(ne.Message, "Please only use numbers to update score.");
                }
                //all other exceptions.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error has occured!");
                }


            }



        }

        private void btnUpdateUpdateScore_Click(object sender, EventArgs e)
        {



            if (lstbxScoresUpdateScore.SelectedItem != null)
            {
                //variable to get the selected item that needs to be changed.
                int item = (int)lstbxScoresUpdateScore.SelectedItem;

                try
                {
                    //new form
                    Form upDate = new UpdateScores();
                    NewFormSettings(upDate);

                    //creates a dialogResult variable when the form is created
                    DialogResult dialogResult1 = upDate.ShowDialog();


                    //if user hits ok then it will replace the score.
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        //this will insert the score at the selected index.
                        lstbxScoresUpdateScore.Items.Insert(lstbxScoresUpdateScore.SelectedIndex, upDate.Tag);

                        //this wil remove the selected itemimediately after the new one is inserted.
                        lstbxScoresUpdateScore.Items.RemoveAt(lstbxScoresUpdateScore.SelectedIndex);

                    }

                    else
                    {
                        MessageBox.Show("Please make a selection!");
                    }

                }
                //a selection must be made.
                catch (NullReferenceException ne)
                {
                    MessageBox.Show(ne.Message, "Please make a selection to update score.");
                }
                //all other exceptions.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error has occured!");
                }

            }
        }


        // this is so I dont have to add the settings to every modal.
        private static void NewFormSettings(Form addNewStudent)
        {

            addNewStudent.FormBorderStyle = FormBorderStyle.FixedDialog;
            addNewStudent.ControlBox = false;
            addNewStudent.MinimizeBox = false;
            addNewStudent.MaximizeBox = false;
        }

        private void UpdateStudentScores_Load(object sender, EventArgs e)
        {

            //upon loading the form it takes the tag and uses it to insert the name into the textbox.
            tempStudent = (Student)this.Tag;

            if (tempStudent != null)
            {
                try
                {
                    //takes the name from the student selected and places it in the txtbox.
                    txtbxNameUpdateScore.Text = tempStudent.StudentName;

                    //adds scores to the tempStudent
                    foreach (int item in tempStudent.Scores)
                    {
                        lstbxScoresUpdateScore.Items.Add(item);
                    }
                }
                catch (NullReferenceException ne)
                {
                    MessageBox.Show(ne.Message, "You need to select a student!");
                }

            }
            else
            {
                MessageBox.Show("You need to pick a Student to update.");
                this.Close();
            }

        }


        private void btnOkUpdateScore_Click(object sender, EventArgs e)
        {
            //clears the scores.
            tempStudent.Scores.Clear();
            //adds the scores back.
            foreach (int item in lstbxScoresUpdateScore.Items)
            {
                tempStudent.Scores.Add(item);
            }

            //takes all the information from the form and packages it up to be used in a different form.
            tempStudent.StudentName = txtbxNameUpdateScore.Text;

            this.Tag = tempStudent;

        }

        private void btnClearScoresUpdateScore_Click(object sender, EventArgs e)
        {
            //clears the score list.
            lstbxScoresUpdateScore.Items.Clear();

        }

        private void btnRemoveUpdateScore_Click(object sender, EventArgs e)
        {
            //try and catch so that if the remove button is clicked before a student is selected the program wont crash.
            try
            {
                lstbxScoresUpdateScore.Items.RemoveAt(lstbxScoresUpdateScore.SelectedIndex);

            }
            //catches exception made if nothing is selected.
            catch (ArgumentOutOfRangeException aoe)
            {
                MessageBox.Show(aoe.Message, "Please select something to remove.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured");
            }



        }

    }

}