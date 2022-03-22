namespace Result_Processing_System
{
    public partial class Form1 : Form
    {
        List<Students> students = new List<Students>();

        public Form1()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"C:\Users\Lenovo\Downloads\MarkSheet.csv"))
            {
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Students dummy = new Students();

                    dummy.id = values[0];
                    dummy.name = values[1];
                    dummy.attendance = values[2];
                    dummy.quiz1 = values[3];
                    dummy.quiz2 = values[4];
                    dummy.quiz3 = values[5];
                    dummy.quiz4 = values[6];
                    dummy.mid = values[7];
                    dummy.final = values[8];
                    dummy.viva = values[9];

                    students.Add(dummy);

                    InfoListbox.Items.Clear();

                    foreach (Students student in students)
                    {
                        InfoListbox.Items.Add(student.getInfo());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idTextbox.Text;

            foreach(Students student in students)
            {
                if(id == student.id)
                {
                    int quizTotal = Convert.ToInt32(student.quiz1) + Convert.ToInt32(student.quiz2) + Convert.ToInt32(student.quiz3);
                    double total = Convert.ToInt32(student.attendance) + Convert.ToInt32(student.mid) + Convert.ToInt32(student.final) + Convert.ToInt32(student.viva) + quizTotal;
                    double percentage = (total / 3);
                    string grade = "";

                    if (percentage < 40)
                        grade = "F";
                    else if (percentage < 45 && percentage >= 40)
                        grade = "D";
                    else if (percentage < 50 && percentage >= 45)
                        grade = "C";
                    else if (percentage < 55 && percentage >= 50)
                        grade = "C+";
                    else if (percentage < 60 && percentage >= 55)
                        grade = "B-";
                    else if (percentage < 65 && percentage >= 60)
                        grade = "B";
                    else if (percentage < 70 && percentage >= 65)
                        grade = "B+";
                    else if (percentage < 75 && percentage >= 70)
                        grade = "A-";
                    else if (percentage < 80 && percentage >= 75)
                        grade = "A";
                    else
                        grade = "A+";

                    attendanceLabel.Text = student.attendance;
                    quiz1Label.Text = student.quiz1;
                    quiz2Label.Text = student.quiz2;
                    quiz3Label.Text = student.quiz3;
                    quiz4Label.Text = student.quiz4;
                    quizTotalLabel.Text = Convert.ToString(quizTotal);
                    midLabel.Text = student.mid;
                    finalLabel.Text = student.final;
                    vivaLabel.Text = student.viva;
                    totalLabel.Text = Convert.ToString(total);
                    percentageLabel.Text = Convert.ToString(percentage) + "%";
                    gradeLabel.Text = grade;
                }
            }
        }
    }
}