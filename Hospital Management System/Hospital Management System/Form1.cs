using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>();
        List<Appointment> appts = new List<Appointment>();
        List<Admitted> admits = new List<Admitted>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            string name = DoctorNameTextbox.Text;
            int id = Convert.ToInt32(DoctorIdTextbox.Text);
            string specialization = SpecializationTextbox.Text;
            string degree = DegreeTextbox.Text;
            string branch = BranchTextbox.Text;

            Doctor dummy_doc = new Doctor(name, id, specialization, degree, branch);

            doctors.Add(dummy_doc);

            ApptDocDropdownBox.Items.Add(dummy_doc.name);

            MessageBox.Show("Doctor has been added successfully.");
        }

        private void ClearDoctorButton_Click(object sender, EventArgs e)
        {
            DoctorNameTextbox.Text = String.Empty;
            DoctorIdTextbox.Text = String.Empty;
            SpecializationTextbox.Text = String.Empty;
            DegreeTextbox.Text = String.Empty;
            BranchTextbox.Text = String.Empty;

            MessageBox.Show("Cleared successfully.");
        }

        private void AddApptButton_Click(object sender, EventArgs e)
        {
            string name = ApptPatientNameTextbox.Text;
            int id = Convert.ToInt32(ApptIdTextbox.Text);
            string age = ApptAgeTextbox.Text;
            string date = ApptDateTextbox.Text;
            string time = TimeTextbox.Text;
            string doctor = ApptDocDropdownBox.SelectedItem.ToString();
            string docname = "";

            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctor == doctors[i].name)
                {
                    docname = doctors[i].name;
                }
            }

            Appointment dummy = new Appointment(name, id, age, date, time, doctor, docname);

            appts.Add(dummy);

            MessageBox.Show("Appointment has been made successfully.");
        }

        private void ClearApptButton_Click(object sender, EventArgs e)
        {
            ApptPatientNameTextbox.Text = String.Empty;
            ApptIdTextbox.Text = String.Empty;
            ApptAgeTextbox.Text = String.Empty;
            ApptDateTextbox.Text = String.Empty;
            TimeTextbox.Text = String.Empty;
            ApptDocDropdownBox.Text = String.Empty;

            MessageBox.Show("Cleared successfully.");
        }

        private void AddAdmittedButton_Click(object sender, EventArgs e)
        {
            string name = AdmittedPatientNameTextbox.Text;
            int id = Convert.ToInt32(AdmittedIdTextbox.Text);
            string age = AdmittedAgeTextbox.Text;
            string roomno = RoomNoTextbox.Text;

            Admitted dummy = new Admitted(name, id, age, roomno);

            admits.Add(dummy);

            MessageBox.Show("Patient has been admitted successfully.");
        }

        private void ClearAdmittedButton_Click(object sender, EventArgs e)
        {
            AdmittedPatientNameTextbox.Text = String.Empty;
            AdmittedIdTextbox.Text = String.Empty;
            AdmittedAgeTextbox.Text = String.Empty;
            RoomNoTextbox.Text = String.Empty;

            MessageBox.Show("Cleared successfully.");
        }

        private void ShowDoctorsListButton_Click(object sender, EventArgs e)
        {
            DoctorsList.Items.Clear();
            for (int i = 0; i < doctors.Count; i++)
            {
                DoctorsList.Items.Add(doctors[i].getInfo());
            }
        }

        private void ShowAppointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentsList.Items.Clear();
            for (int i = 0; i < appts.Count; i++)
            {
                AppointmentsList.Items.Add(appts[i].getInfo());
            }
        }

        private void ShowAdmittedPatientsButton_Click(object sender, EventArgs e)
        {
            AdmittedPatientsList.Items.Clear();
            for (int i = 0; i < admits.Count; i++)
            {
                AdmittedPatientsList.Items.Add(admits[i].getInfo());
            }
        }

        private void ReleasePatientButton_Click(object sender, EventArgs e)
        {
            int releaseid = Convert.ToInt32(ReleaseIdTextbox.Text);

            for(int i = 0; i < admits.Count; i++)
            {
                if(releaseid == admits[i].id)
                {
                    admits.Remove(admits[i]);
                }
            }

            MessageBox.Show("Patient has been released.");
        }
    }
}
