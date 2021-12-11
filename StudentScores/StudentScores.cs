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
    public partial class StudentScores : Form
    {
        //creates instences of the student class.
        public List<Student> students = new List<Student>();
        public Student tempStudent = new Student();

        public StudentScores()
        {
            InitializeComponent();

            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
             //created new form with settings
                Form addNewStudent = new AddNewStudent();
                NewFormSettings(addNewStudent);
            try
            {
                    //creates a dialogResult variable when the form is created
                    DialogResult dialogResult = addNewStudent.ShowDialog();
                if (addNewStudent.Tag != null)
                {
                    //if user hits ok then it will add the tag to the list box from AddNewStudent
                    if (dialogResult == DialogResult.OK)
                    {
                        //creates a new student object to hold all the info in.
                        Student newStudent = (Student)addNewStudent.Tag;

                        // adds the student to the list.
                        students.Add(newStudent);

                        if (newStudent != null)

                            //method to populate list.
                            ListStudents();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not add the new student.");

            }
        }

        //method to set the settings of my forms.
        private static void NewFormSettings(Form addNewStudent)
        {
            //style for my modal
            addNewStudent.FormBorderStyle = FormBorderStyle.FixedDialog;
            addNewStudent.ControlBox = false;
            addNewStudent.MinimizeBox = false;
            addNewStudent.MaximizeBox = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
                //find selected item assign to student
                Student student = (Student)lstbxStudentList.SelectedItem;

                //create new form and settings
                Form form2 = new UpdateStudentScores();
                NewFormSettings(form2);

            //sets tag from form to student.
                    form2.Tag = student;
            //try and catch to make sure  a selection is made.
            try
            {
                DialogResult dialogResult = form2.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    // inserts the NEW student information from the update form tag and inserts the student at the selected index for update.
                    lstbxStudentList.Items.Insert(lstbxStudentList.SelectedIndex, student);

                    //removes the student that was updated from the list. 
                    lstbxStudentList.Items.RemoveAt(lstbxStudentList.SelectedIndex);
                }

            }
            //make sure a selection is made.
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message, "You must make a selection first.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "please select a student.");
            }
            
        }

        private void ListStudents()
        {
            
                //clears the items in the list box.
                lstbxStudentList.Items.Clear();

                //for each statement to add the student to the list on the main form.
                foreach (var student in students)
                {
                    lstbxStudentList.Items.Add(student);
                }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes the form.
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //deletes the actual instance of the student that was selected instead of just the listbox selected item.
                Student delete = (Student)lstbxStudentList.SelectedItem;
                students.Remove(delete);

                //deletes the selected item. If not item is selected the button doesnt do anything.
                lstbxStudentList.Items.RemoveAt(lstbxStudentList.SelectedIndex);

            }
            //catches exception made if nothing is selected.
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to remove.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }

           


            
        }

        private void lstbxStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this is to populate the small textboxes at the bottom with the math that need to be done. 
            // if statement to make sure that there is something selected if there isnt this doesnt work. 
            if (lstbxStudentList.SelectedIndex != -1)
            {
                Student num = (Student)lstbxStudentList.SelectedItem;
                if (num.Scores.Count != 0)
                {
                    txtbxScoreTotal.Text = num.Scores.Sum().ToString();
                    txtbxScoreCount.Text = num.Scores.Count.ToString();
                    txtbxAverage.Text = num.Scores.Average().ToString();
                }
                   
            }
            else
            {
                txtbxScoreTotal.Clear();
                txtbxScoreCount.Clear();
                txtbxAverage.Clear();
            }
            

        }

        private void StudentScores_Load(object sender, EventArgs e)
        {
            //I know there is probably an easier way to do this but it looks neat and works. I figured this is what you meant by sample studetns.

            //creates new student object
            Student joel = new Student();
            //sets the name of the student
            joel.StudentName = "Joel Murach";
            // seths the scores for the student. 
            joel.Scores.Add(97);
            joel.Scores.Add(71);
            joel.Scores.Add(83);

            Student doug = new Student();
            doug.StudentName = "Doug Lowe";
            doug.Scores.Add(99);
            doug.Scores.Add(93);
            doug.Scores.Add(97);

            Student anne = new Student();
            anne.StudentName = "Anne Boehm";
            anne.Scores.Add(100);
            anne.Scores.Add(100);
            anne.Scores.Add(100);

            //adds all the students to the list.
            students.Add(joel);
            students.Add(doug);
            students.Add(anne);

            //Adds the list to the listbox.
            ListStudents(); 
        }
    }

}
