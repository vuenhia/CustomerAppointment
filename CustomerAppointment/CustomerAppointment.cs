// Nhia Vue
// Final Project
// 10/10/23
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace CustomerAppointment
{
    public partial class CustomerAppointment : Form
    {
        public CustomerAppointment()
        {
            InitializeComponent();
            // Allows cust to pick time 
            dateTimePicker.ShowUpDown = true;

        }
        // Global Variables
        private BindingList<AppointmentInformation> custList = new BindingList<AppointmentInformation>();
        private AppointmentInformation custObject = new AppointmentInformation();
        int custLastNumber;

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Variables
            int age;
            bool isAge;
            DateTime selectedDate = dateTimePicker.Value;
            DateTime currentDate = DateTime.Now;
            string selectedDoctor = "";
            string doctorYearlyCheckup = "Dr.Otto";
            string doctorDental = "Dr.White";
            string doctorSurgeon = "Dr.Johnson";

            isAge = int.TryParse(this.ageTextBox.Text, out age);

            // Validations
            if ((this.nameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                MessageBox.Show("Please enter in a name.");
                nameTextBox.Focus();
                return;
            }
            else if (selectedDate < currentDate)
            {
                MessageBox.Show("Appointments must be made a day ahead of time so we can prepare.");
                dateTimePicker.Focus();
                return;
            }
            else if (DuplicateAppointment(selectedDate, selectedDate))
            {
                MessageBox.Show("An appointment at the same time already exists for this date. Please choose a different time.");
                return;
            }
            else if (reasonComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please pick a reason for appointment.");
                reasonComboBox.Focus();
                return;
            }
            else if (isAge == false)
            {
                MessageBox.Show("Please enter in a number.");
                ageTextBox.Focus();
                return;
            }
            else if ((this.phoneTextBox.Text ?? string.Empty) == (string.Empty ?? string.Empty))
            {
                MessageBox.Show("Please enter in a phone number");
                phoneTextBox.Focus();
                return;
            }

            if (reasonComboBox.SelectedIndex == 0) // Dental
            {
                selectedDoctor = doctorDental;
            }
            else if (reasonComboBox.SelectedIndex == 1) // Surgery
            {
                selectedDoctor = doctorSurgeon;
            }
            else if (reasonComboBox.SelectedIndex == 2) // Yearly Checkup
            {
                selectedDoctor = doctorYearlyCheckup;
            }

            // Assign variables values
            custLastNumber++;
            custObject.CustID = custLastNumber.ToString();
            custObject.Name = nameTextBox.Text;
            custObject.AppDate = selectedDate;
            custObject.DateMade = currentDate;
            custObject.Reason = reasonComboBox.Text;
            custObject.Phone = phoneTextBox.Text;
            custObject.Doctor = selectedDoctor;
            custObject.Age = age;
            custList.Add(custObject);

            // Insert Customer
            InsertCustomer();
            ClearLabels();


        }

        // Check to see if someone has made an appointment with the same time
        private bool DuplicateAppointment(DateTime selectedDate, DateTime selectedTime)
        {
            // Loop through the list of appointments to check for duplicates
            foreach (var existingAppointment in custList)
            {
                if (existingAppointment.AppDate.Date == selectedDate.Date && existingAppointment.AppDate.TimeOfDay == selectedTime.TimeOfDay)
                {
                    return true; // Duplicate appointment found
                }
            }
            return false; // No duplicate appointments found
        }



        // Delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                // Get the selected cust object
                AppointmentInformation selectedCustObject = (AppointmentInformation)listBox.SelectedItem;

                DialogResult result = MessageBox.Show("Delete?", "Conformation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if ( result == DialogResult.Yes)
                {
                    // Remove the cust from the BindingList
                    custList.Remove(selectedCustObject);

                    // Delete the cust from the database
                    DeleteCustomer(selectedCustObject);

                    // Clear the labels
                    ClearLabels();
                }
            }
            else
            {
                MessageBox.Show("Please select a cust to delete.");
            }
        }
        // Edit button
        private void editButton_Click(object sender, EventArgs e)
        {
            string selectedDoctor;
            string doctorYearlyCheckup = "Dr.Otto";
            string doctorDental = "Dr.White";
            string doctorSurgeon = "Dr.Johnson";

            if (listBox.SelectedIndex >= 0)
            {
                // Get the selected cust object
                AppointmentInformation selectedCustObject = (AppointmentInformation)listBox.SelectedItem;

                // Check if the selectedCustObject is not null
                if (selectedCustObject != null)
                {
                    // Update the cust information with the edited values
                    selectedCustObject.Name = nameTextBox.Text;
                    selectedCustObject.AppDate = dateTimePicker.Value;
                    selectedCustObject.Reason = reasonComboBox.Text;

                    // Update customer doctor based on what reason they pick
                    if (reasonComboBox.SelectedIndex == 0) // Dental
                    {
                        selectedDoctor = doctorDental;
                        selectedCustObject.Doctor = selectedDoctor;
                    }
                    else if (reasonComboBox.SelectedIndex == 1) // Surgery
                    {
                        selectedDoctor = doctorSurgeon;
                        selectedCustObject.Doctor = selectedDoctor;
                    }
                    else if (reasonComboBox.SelectedIndex == 2) // Yearly Checkup
                    {
                        selectedDoctor = doctorYearlyCheckup;
                        selectedCustObject.Doctor = selectedDoctor;
                    }
                    selectedCustObject.Phone = phoneTextBox.Text;
                    selectedCustObject.Age = int.Parse(ageTextBox.Text);

                    // Update customer in the database
                    UpdateCustomer(selectedCustObject);

                    // Refresh the ListBox
                    listBox.DataSource = null;
                    listBox.DataSource = custList;
                    listBox.DisplayMember = "Name";

                    displayResults(); // Display the edited customer's information
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }


        // On load
        private void CustomerAppointment_Load(object sender, EventArgs e)
        {
            this.reasonComboBox.Items.Add("Dental");
            this.reasonComboBox.Items.Add("Surgery");
            this.reasonComboBox.Items.Add("Yearly Checkup");

            listBox.DataSource = custList;
            listBox.DisplayMember = "Name";

            Reload_Customer();
            displayResults();


        }
        // Connect datetimepicker and calendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker.Value = monthCalendar1.SelectionRange.Start;



        }

        // Display results
        private void displayResults()
        {
            if (listBox.SelectedItem != null)
            {
                AppointmentInformation selectedCustObject = (AppointmentInformation)listBox.SelectedItem;
                nameOutputLabel.Text = selectedCustObject.Name;
                dateOutputLabel.Text = selectedCustObject.AppDate.ToString();
                reasonOutputLabel.Text = selectedCustObject.Reason;
                doctorOutputLabel.Text = selectedCustObject.Doctor;
                phoneOutputLabel.Text = selectedCustObject.Phone;
                appointmentMadeOutputLabel.Text = selectedCustObject.DateMade.ToString();
                ageOutputLabel.Text = selectedCustObject.Age.ToString();

                nameTextBox.Text = selectedCustObject.Name;
                reasonComboBox.Text = selectedCustObject.Reason;
                ageTextBox.Text = selectedCustObject.Age.ToString();
                phoneTextBox.Text = selectedCustObject.Phone.ToString();
                dateTimePicker.Value = selectedCustObject.AppDate;
            }
            else
            {
                ClearLabels();
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearLabels();
        }

        // Display when listbox is clicked
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayResults();
        }
        // Clear labels
        private void ClearLabels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Clear();
                }

            }
            nameTextBox.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            reasonComboBox.SelectedIndex = -1;
            phoneTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
        }

        // Open Database (All Database Codes Below)
        private SqlConnection OpenDBConnection()
        {
            // Path to bin/debug folder
            string path = Application.StartupPath;
            int pathLength = path.Length;

            // Point to project folder
            path = path.Substring(0, pathLength - 25);

            // Create connection to database
            string connection = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + path + "Customer.mdf";

            // Create connection object to database
            var dbConnection = new System.Data.SqlClient.SqlConnection(connection);

            // Open database
            dbConnection.Open();
            return dbConnection;
        }

        // Insert customer
        private void InsertCustomer()
        {
            var connection = OpenDBConnection();
            string SQL = "Insert into Customer_Table (Name,AppDate,Reason,Phone,Doctor,DateMade,Age) values (@Name,@AppDate,@Reason,@Phone,@Doctor,@DateMade,@Age)";

            // Command
            var insertCommand = new SqlCommand(SQL, connection);

            // Populate
            insertCommand.Parameters.AddWithValue("Name", custList.Last().Name);
            insertCommand.Parameters.AddWithValue("AppDate", custList.Last().AppDate);
            insertCommand.Parameters.AddWithValue("Reason", custList.Last().Reason);
            insertCommand.Parameters.AddWithValue("Phone", custList.Last().Phone);
            insertCommand.Parameters.AddWithValue("Doctor", custList.Last().Doctor);
            insertCommand.Parameters.AddWithValue("DateMade", custList.Last().DateMade);
            insertCommand.Parameters.AddWithValue("Age", custList.Last().Age);


            int intRowsAffected = insertCommand.ExecuteNonQuery();
            if (intRowsAffected == 1)
            {
                MessageBox.Show("Register for appointment complete!");
            }
            else
            {
                MessageBox.Show("Failed to insert");
            }

        }
        // Update customer
        private void UpdateCustomer(AppointmentInformation custObject)
        {
            var connection = OpenDBConnection();
            string SQL = "UPDATE Customer_Table SET Name = @Name, AppDate = @AppDate, Reason = @Reason, Phone = @Phone, Doctor = @Doctor, DateMade = @DateMade, Age = @Age WHERE CustId = @CustID";

            var updateCommand = new SqlCommand(SQL, connection);

            // Populate parameters

            updateCommand.Parameters.AddWithValue("@CustID", custObject.CustID);
            updateCommand.Parameters.AddWithValue("@Name", custObject.Name);
            updateCommand.Parameters.AddWithValue("@AppDate", custObject.AppDate);
            updateCommand.Parameters.AddWithValue("@Reason", custObject.Reason);
            updateCommand.Parameters.AddWithValue("@Phone", custObject.Phone);
            updateCommand.Parameters.AddWithValue("@Doctor", custObject.Doctor);
            updateCommand.Parameters.AddWithValue("@DateMade", custObject.DateMade);
            updateCommand.Parameters.AddWithValue("@Age", custObject.Age);




            int intRowsAffected = updateCommand.ExecuteNonQuery();
            if (intRowsAffected == 1)
            {
                MessageBox.Show("Update successfully");
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        // Delete Customer
        private void DeleteCustomer(AppointmentInformation custObject)
        {
            var connection = OpenDBConnection();
            string SQL = "DELETE FROM Customer_Table WHERE CustID = @CustID";

            var deleteCommand = new SqlCommand(SQL, connection);

            // Populate parameters
            deleteCommand.Parameters.AddWithValue("@CustID", custObject.CustID);

            int rowsAffected = deleteCommand.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                MessageBox.Show("Customer was deleted");
            }
            else
            {
                MessageBox.Show("Could not delete Customer");
            }
        }

        // Reload Customer
        private void Reload_Customer()
        {
            var connection = OpenDBConnection();
            listBox.ClearSelected();

            var selectCommand = new SqlCommand("Select * from Customer_Table;", connection);

            var reader = selectCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var storedCustObject = new AppointmentInformation();
                    storedCustObject.CustID = reader["CustID"].ToString();
                    storedCustObject.Name = reader["Name"].ToString();
                    storedCustObject.AppDate = reader.GetDateTime(reader.GetOrdinal("AppDate"));
                    storedCustObject.Reason = reader["Reason"].ToString();
                    storedCustObject.Phone = reader["Phone"].ToString();
                    storedCustObject.Doctor = reader["Doctor"].ToString();
                    storedCustObject.DateMade = reader.GetDateTime(reader.GetOrdinal("DateMade"));
                    storedCustObject.Age = int.Parse(reader["Age"].ToString());


                    // Update custLastNumber
                    if (int.Parse(storedCustObject.CustID) > custLastNumber)
                    {
                        custLastNumber = int.Parse(storedCustObject.CustID);

                    }

                    custList.Add(storedCustObject);


                }
            }
            // Close and dispose database
            connection.Close();
            connection.Dispose();
        }

        
    }
}