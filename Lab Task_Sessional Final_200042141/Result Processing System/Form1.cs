namespace Result_Processing_System
{
    public partial class Form1 : Form
    {
        List<Students> students = new List<Students>();

        public Form1()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"C:\Users\Lenovo\Downloads\SWE4201MarkSheet.csv"))
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
                    attendanceLabel.Text = student.attendance;
                    quiz1Label.Text = student.quiz1;
                    quiz2Label.Text = student.quiz2;
                    quiz3Label.Text = student.quiz3;
                    quiz4Label.Text = student.quiz4;
                    quizTotalLabel.Text = Convert.ToString(student.calculateQuizTotal());
                    midLabel.Text = student.mid;
                    finalLabel.Text = student.final;
                    vivaLabel.Text = student.viva;
                    totalLabel.Text = Convert.ToString(student.calculateTotal());
                    percentageLabel.Text = Convert.ToString(student.calculatePercentage()) + "%";
                    gradeLabel.Text = student.calculateGrade();
                }
            }
        }
    }
}