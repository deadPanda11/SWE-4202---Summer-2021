using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course_Enrollment
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Professional> professionals = new List<Professional>();
        List<Course> courses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddParticipantButton_Click_1(object sender, EventArgs e)
        {
            string name = ParticipantNameBox.Text;
            int reg = Convert.ToInt32(RegNoBox.Text);
            string contact = ContactNoBox.Text;
            string email = EmailBox.Text;
            double fee = 0;
            string level;

            bool student_check = StudentRadioButton.Checked;
            bool pro_check = ProfessionalRadioButton.Checked;

            bool beginner_check = BeginnerRadioButton.Checked;
            bool intermediate_check = IntermediateRadioButton.Checked;
            bool advanced_check = AdvancedRadioButton.Checked;

            if (beginner_check == true)
            {
                level = BeginnerRadioButton.Text;
            }
            else if (intermediate_check == true)
            {
                level = IntermediateRadioButton.Text;
            }
            else if (advanced_check == true)
            {
                level = AdvancedRadioButton.Text;
            }
            else
            {
                level = BeginnerRadioButton.Text;
            }

            if (student_check == true)
            {
                Student dummy_student = new Student(name, reg, contact, email, level, fee);

                students.Add(dummy_student);

                SelectStudentComboBox.Items.Add(dummy_student.name);
                SelectStudentBox2.Items.Add(dummy_student.name);

                MessageBox.Show("Student has been added successfully.");
            }

            if (pro_check == true)
            {
                Professional dummy_pro = new Professional(name, reg, contact, email, level, fee);

                professionals.Add(dummy_pro);

                SelectStudentComboBox.Items.Add(dummy_pro.name);
                SelectStudentBox2.Items.Add(dummy_pro.name);

                MessageBox.Show("Professional has been added successfully.");
            }
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            string title = CourseTitleBox.Text;
            double coursefee = Convert.ToDouble(CourseFeeBox.Text);
            string level;

            bool beginner_check = BeginnerRadioButton2.Checked;
            bool intermediate_check = IntermediateRadioButton2.Checked;
            bool advanced_check = AdvancedRadioButton2.Checked;

            if (beginner_check == true)
            {
                level = BeginnerRadioButton2.Text;
            }
            else if (intermediate_check == true)
            {
                level = IntermediateRadioButton2.Text;
            }
            else if (advanced_check == true)
            {
                level = AdvancedRadioButton2.Text;
            }
            else
            {
                level = BeginnerRadioButton2.Text;
            }

            Course dummy_course = new Course(title, level, coursefee);

            courses.Add(dummy_course);

            SelectCourseComboBox.Items.Add(dummy_course.title);

            MessageBox.Show("Course has been added successfully.");
        }

        private void PayAndEnrollButton_Click(object sender, EventArgs e)
        {
            string selected_student = SelectStudentComboBox.SelectedItem.ToString();
            string selected_course = SelectCourseComboBox.SelectedItem.ToString();

            bool error_exists = true;

            foreach(Student student in students)
            {
                if (student.name == selected_student)
                {
                    foreach(Course course in courses)
                    {
                        if((course.title == selected_course) && (student.level == course.level))
                        {
                            error_exists = false;
                            student.Enroll(course.title);
                            CourseFeeLabel.Text = Convert.ToString(student.getFee(course.coursefee));
                        }
                    }
                }
            }

            foreach (Professional professional in professionals)
            {
                if (professional.name == selected_student)
                {
                    foreach (Course course in courses)
                    {
                        if ((course.title == selected_course) && (professional.level == course.level))
                        {
                            error_exists = false;
                            professional.Enroll(course.title);
                            CourseFeeLabel.Text = Convert.ToString(professional.getFee(course.coursefee));
                        }
                    }
                }
            }

            if (error_exists == true)
            {
                MessageBox.Show("Level does not match.");
            }
        }

        private void ShowEnrolledCoursesButton_Click(object sender, EventArgs e)
        {
            EnrolledCoursesList.Items.Clear();

            string selected_student = SelectStudentBox2.SelectedItem.ToString();

            foreach(Student student in students)
            {
                if(selected_student == student.name)
                {
                    EnrolledCoursesList.Items.Add(student.EnrolledCourses());
                }
            }

            foreach(Professional professional in professionals)
            {
                if(selected_student == professional.name)
                {
                    EnrolledCoursesList.Items.Add(professional.EnrolledCourses());
                }
            }
        }
    }
}

        
