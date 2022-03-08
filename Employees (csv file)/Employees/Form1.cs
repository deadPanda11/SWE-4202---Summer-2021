using System.IO;

namespace Employees
{
    public partial class Form1 : Form
    {

        List<Employees> employeesList = new List<Employees>();
        public Form1()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"C:\Users\Lenovo\Downloads\employees.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Employees dummy = new Employees();

                    dummy.id = values[0];
                    dummy.firstName = values[1];
                    dummy.lastName = values[2];
                    dummy.email = values[3];
                    dummy.phoneNumber = values[4];
                    dummy.hireDate = values[5];
                    dummy.jobId = values[6];
                    dummy.salary = values[7];
                    dummy.commission = values[8];
                    dummy.managerId = values[9];
                    dummy.departmentId = values[10];

                    employeesList.Add(dummy);

                    EmployeesList.Items.Clear();

                    foreach (Employees employee in employeesList)
                    {
                        EmployeesList.Items.Add(employee.getInfo());
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string id = IdTextbox.Text;
            string time = DateTime.Now.ToString();
            bool errorExist = true;
            foreach(Employees employee in employeesList)
            {
                if(id == employee.id)
                {
                    errorExist = false;

                    NameLabel.Text = employee.firstName + " " + employee.lastName;
                    IdLabel.Text = employee.id;
                    PhoneNoLabel.Text = employee.phoneNumber;
                    Salarylabel.Text = employee.salary;
                    break;
                }
            }
            string path = @"C:\Users\Lenovo\Downloads\log.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(id + " ");
                sw.WriteLine(time + " ");
                
                if(!errorExist)
                {
                    foreach (Employees employee in employeesList)
                    {
                        if (id == employee.id)
                        {
                            sw.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.id + " " + employee.phoneNumber + " " + employee.salary);
                        }
                    }
                }
            }
        }
    }
}