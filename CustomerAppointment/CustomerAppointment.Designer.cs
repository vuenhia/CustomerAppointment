namespace CustomerAppointment
{
    partial class CustomerAppointment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            dateLabel = new Label();
            reasonLabel = new Label();
            phoneLabel = new Label();
            dateTimePicker = new DateTimePicker();
            custInfoGroupBox = new GroupBox();
            ageTextBox = new TextBox();
            ageLabel = new Label();
            deleteButton = new Button();
            editButton = new Button();
            submitButton = new Button();
            reasonComboBox = new ComboBox();
            phoneTextBox = new TextBox();
            nameTextBox = new TextBox();
            customerScheduleGroupBox = new GroupBox();
            ageOutputLabel = new Label();
            custAgeLabel = new Label();
            appointmentMadeOutputLabel = new Label();
            currentDateLabel = new Label();
            dateOutputLabel = new Label();
            appDateLabel = new Label();
            listBox = new ListBox();
            phoneOutputLabel = new Label();
            doctorOutputLabel = new Label();
            reasonOutputLabel = new Label();
            nameOutputLabel = new Label();
            appPhoneLabel = new Label();
            docLabel = new Label();
            appReasonLabel = new Label();
            appNameLabel = new Label();
            monthCalendar1 = new MonthCalendar();
            clearButton = new Button();
            custInfoGroupBox.SuspendLayout();
            customerScheduleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(6, 30);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(91, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(6, 98);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(58, 26);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            reasonLabel.Location = new Point(6, 162);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(79, 26);
            reasonLabel.TabIndex = 2;
            reasonLabel.Text = "Reason:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(6, 252);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(72, 26);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Phone:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.Location = new Point(103, 100);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 2;
            // 
            // custInfoGroupBox
            // 
            custInfoGroupBox.BackColor = SystemColors.Info;
            custInfoGroupBox.Controls.Add(clearButton);
            custInfoGroupBox.Controls.Add(ageTextBox);
            custInfoGroupBox.Controls.Add(ageLabel);
            custInfoGroupBox.Controls.Add(deleteButton);
            custInfoGroupBox.Controls.Add(editButton);
            custInfoGroupBox.Controls.Add(submitButton);
            custInfoGroupBox.Controls.Add(reasonComboBox);
            custInfoGroupBox.Controls.Add(phoneTextBox);
            custInfoGroupBox.Controls.Add(nameTextBox);
            custInfoGroupBox.Controls.Add(nameLabel);
            custInfoGroupBox.Controls.Add(dateTimePicker);
            custInfoGroupBox.Controls.Add(dateLabel);
            custInfoGroupBox.Controls.Add(phoneLabel);
            custInfoGroupBox.Controls.Add(reasonLabel);
            custInfoGroupBox.Location = new Point(37, 25);
            custInfoGroupBox.Name = "custInfoGroupBox";
            custInfoGroupBox.Size = new Size(327, 470);
            custInfoGroupBox.TabIndex = 5;
            custInfoGroupBox.TabStop = false;
            custInfoGroupBox.Text = "Customer Info";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(103, 210);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(200, 23);
            ageTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.Location = new Point(6, 205);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(50, 26);
            ageLabel.TabIndex = 8;
            ageLabel.Text = "Age:";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(158, 295);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(146, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(45, 356);
            editButton.Name = "editButton";
            editButton.Size = new Size(97, 23);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(10, 295);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(132, 23);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // reasonComboBox
            // 
            reasonComboBox.FormattingEnabled = true;
            reasonComboBox.Location = new Point(104, 165);
            reasonComboBox.Name = "reasonComboBox";
            reasonComboBox.Size = new Size(200, 23);
            reasonComboBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(104, 255);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(200, 23);
            phoneTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(103, 30);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 23);
            nameTextBox.TabIndex = 1;
            // 
            // customerScheduleGroupBox
            // 
            customerScheduleGroupBox.BackColor = SystemColors.ButtonShadow;
            customerScheduleGroupBox.Controls.Add(ageOutputLabel);
            customerScheduleGroupBox.Controls.Add(custAgeLabel);
            customerScheduleGroupBox.Controls.Add(appointmentMadeOutputLabel);
            customerScheduleGroupBox.Controls.Add(currentDateLabel);
            customerScheduleGroupBox.Controls.Add(dateOutputLabel);
            customerScheduleGroupBox.Controls.Add(appDateLabel);
            customerScheduleGroupBox.Controls.Add(listBox);
            customerScheduleGroupBox.Controls.Add(phoneOutputLabel);
            customerScheduleGroupBox.Controls.Add(doctorOutputLabel);
            customerScheduleGroupBox.Controls.Add(reasonOutputLabel);
            customerScheduleGroupBox.Controls.Add(nameOutputLabel);
            customerScheduleGroupBox.Controls.Add(appPhoneLabel);
            customerScheduleGroupBox.Controls.Add(docLabel);
            customerScheduleGroupBox.Controls.Add(appReasonLabel);
            customerScheduleGroupBox.Controls.Add(appNameLabel);
            customerScheduleGroupBox.Controls.Add(monthCalendar1);
            customerScheduleGroupBox.Location = new Point(387, 27);
            customerScheduleGroupBox.Name = "customerScheduleGroupBox";
            customerScheduleGroupBox.Size = new Size(379, 468);
            customerScheduleGroupBox.TabIndex = 7;
            customerScheduleGroupBox.TabStop = false;
            customerScheduleGroupBox.Text = "Customer Schedule:";
            // 
            // ageOutputLabel
            // 
            ageOutputLabel.AutoSize = true;
            ageOutputLabel.Location = new Point(182, 269);
            ageOutputLabel.Name = "ageOutputLabel";
            ageOutputLabel.Size = new Size(12, 15);
            ageOutputLabel.TabIndex = 15;
            ageOutputLabel.Text = "*";
            // 
            // custAgeLabel
            // 
            custAgeLabel.AutoSize = true;
            custAgeLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            custAgeLabel.Location = new Point(30, 266);
            custAgeLabel.Name = "custAgeLabel";
            custAgeLabel.Size = new Size(38, 19);
            custAgeLabel.TabIndex = 14;
            custAgeLabel.Text = "Age:";
            // 
            // appointmentMadeOutputLabel
            // 
            appointmentMadeOutputLabel.AutoSize = true;
            appointmentMadeOutputLabel.Location = new Point(182, 136);
            appointmentMadeOutputLabel.Name = "appointmentMadeOutputLabel";
            appointmentMadeOutputLabel.Size = new Size(12, 15);
            appointmentMadeOutputLabel.TabIndex = 13;
            appointmentMadeOutputLabel.Text = "*";
            // 
            // currentDateLabel
            // 
            currentDateLabel.AutoSize = true;
            currentDateLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            currentDateLabel.Location = new Point(30, 132);
            currentDateLabel.Name = "currentDateLabel";
            currentDateLabel.Size = new Size(137, 19);
            currentDateLabel.TabIndex = 12;
            currentDateLabel.Text = "Appointment Made:";
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.AutoSize = true;
            dateOutputLabel.Location = new Point(182, 91);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(12, 15);
            dateOutputLabel.TabIndex = 11;
            dateOutputLabel.Text = "*";
            // 
            // appDateLabel
            // 
            appDateLabel.AutoSize = true;
            appDateLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appDateLabel.Location = new Point(30, 87);
            appDateLabel.Name = "appDateLabel";
            appDateLabel.Size = new Size(131, 19);
            appDateLabel.TabIndex = 10;
            appDateLabel.Text = "Appointment Date:";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(251, 302);
            listBox.Name = "listBox";
            listBox.Size = new Size(120, 154);
            listBox.TabIndex = 9;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // phoneOutputLabel
            // 
            phoneOutputLabel.AutoSize = true;
            phoneOutputLabel.Location = new Point(182, 239);
            phoneOutputLabel.Name = "phoneOutputLabel";
            phoneOutputLabel.Size = new Size(12, 15);
            phoneOutputLabel.TabIndex = 8;
            phoneOutputLabel.Text = "*";
            // 
            // doctorOutputLabel
            // 
            doctorOutputLabel.AutoSize = true;
            doctorOutputLabel.Location = new Point(182, 203);
            doctorOutputLabel.Name = "doctorOutputLabel";
            doctorOutputLabel.Size = new Size(12, 15);
            doctorOutputLabel.TabIndex = 7;
            doctorOutputLabel.Text = "*";
            // 
            // reasonOutputLabel
            // 
            reasonOutputLabel.AutoSize = true;
            reasonOutputLabel.Location = new Point(182, 171);
            reasonOutputLabel.Name = "reasonOutputLabel";
            reasonOutputLabel.Size = new Size(12, 15);
            reasonOutputLabel.TabIndex = 6;
            reasonOutputLabel.Text = "*";
            // 
            // nameOutputLabel
            // 
            nameOutputLabel.AutoSize = true;
            nameOutputLabel.Location = new Point(182, 49);
            nameOutputLabel.Name = "nameOutputLabel";
            nameOutputLabel.Size = new Size(12, 15);
            nameOutputLabel.TabIndex = 5;
            nameOutputLabel.Text = "*";
            // 
            // appPhoneLabel
            // 
            appPhoneLabel.AutoSize = true;
            appPhoneLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appPhoneLabel.Location = new Point(30, 236);
            appPhoneLabel.Name = "appPhoneLabel";
            appPhoneLabel.Size = new Size(53, 19);
            appPhoneLabel.TabIndex = 4;
            appPhoneLabel.Text = "Phone:";
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            docLabel.Location = new Point(30, 203);
            docLabel.Name = "docLabel";
            docLabel.Size = new Size(56, 19);
            docLabel.TabIndex = 3;
            docLabel.Text = "Doctor:";
            // 
            // appReasonLabel
            // 
            appReasonLabel.AutoSize = true;
            appReasonLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appReasonLabel.Location = new Point(30, 168);
            appReasonLabel.Name = "appReasonLabel";
            appReasonLabel.Size = new Size(61, 19);
            appReasonLabel.TabIndex = 2;
            appReasonLabel.Text = "Reason:";
            // 
            // appNameLabel
            // 
            appNameLabel.AutoSize = true;
            appNameLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appNameLabel.Location = new Point(30, 45);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(51, 19);
            appNameLabel.TabIndex = 1;
            appNameLabel.Text = "Name:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 294);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(158, 356);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(97, 23);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // CustomerAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(customerScheduleGroupBox);
            Controls.Add(custInfoGroupBox);
            Name = "CustomerAppointment";
            Text = "Customer Appointment";
            Load += CustomerAppointment_Load;
            custInfoGroupBox.ResumeLayout(false);
            custInfoGroupBox.PerformLayout();
            customerScheduleGroupBox.ResumeLayout(false);
            customerScheduleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label nameLabel;
        private Label dateLabel;
        private Label reasonLabel;
        private Label phoneLabel;
        private DateTimePicker dateTimePicker;
        private GroupBox custInfoGroupBox;
        private GroupBox customerScheduleGroupBox;
        private Button deleteButton;
        private Button editButton;
        private Button submitButton;
        private ComboBox reasonComboBox;
        private TextBox phoneTextBox;
        private TextBox nameTextBox;
        private Label appNameLabel;
        private MonthCalendar monthCalendar1;
        private Label appReasonLabel;
        private Label nameOutputLabel;
        private Label appPhoneLabel;
        private Label docLabel;
        private Label phoneOutputLabel;
        private Label doctorOutputLabel;
        private Label reasonOutputLabel;
        private ListBox listBox;
        private Label appDateLabel;
        private Label dateOutputLabel;
        private Label appointmentMadeOutputLabel;
        private Label currentDateLabel;
        private TextBox ageTextBox;
        private Label ageLabel;
        private Label ageOutputLabel;
        private Label custAgeLabel;
        private Button clearButton;
    }
}