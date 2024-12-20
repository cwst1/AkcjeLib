namespace VehicleServiceApp
{
    partial class Form1
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
            RegistrationNumberTextBox = new TextBox();
            BrandTextBox = new TextBox();
            ModelTextBox = new TextBox();
            YearTextBox = new TextBox();
            MileageTextBox = new TextBox();
            AddVehicleButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            VehicleListBox = new ListBox();
            CheckServiceButton = new Button();
            AddServiceButton = new Button();
            ShowHistoryButton = new Button();
            HistoryListBox = new ListBox();
            ServiceTasksListBox = new ListBox();
            MileageServTextBox = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            EditVehicleButton_Click = new Button();
            SearchVehicleButton_Click = new Button();
            RegistrationSearchTextBox = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationNumberTextBox
            // 
            RegistrationNumberTextBox.Location = new Point(6, 41);
            RegistrationNumberTextBox.Name = "RegistrationNumberTextBox";
            RegistrationNumberTextBox.Size = new Size(125, 27);
            RegistrationNumberTextBox.TabIndex = 0;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(6, 94);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(125, 27);
            BrandTextBox.TabIndex = 1;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(6, 147);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(125, 27);
            ModelTextBox.TabIndex = 2;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(6, 200);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 3;
            // 
            // MileageTextBox
            // 
            MileageTextBox.Location = new Point(6, 253);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(125, 27);
            MileageTextBox.TabIndex = 4;
            // 
            // AddVehicleButton
            // 
            AddVehicleButton.Location = new Point(6, 286);
            AddVehicleButton.Name = "AddVehicleButton";
            AddVehicleButton.Size = new Size(125, 35);
            AddVehicleButton.TabIndex = 5;
            AddVehicleButton.Text = "Add CAR";
            AddVehicleButton.UseVisualStyleBackColor = true;
            AddVehicleButton.Click += AddVehicleButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 6;
            label1.Text = "Number plate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 7;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 8;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 177);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 9;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 230);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 10;
            label5.Text = "Odometer";
            // 
            // VehicleListBox
            // 
            VehicleListBox.FormattingEnabled = true;
            VehicleListBox.Location = new Point(6, 22);
            VehicleListBox.Name = "VehicleListBox";
            VehicleListBox.Size = new Size(311, 104);
            VehicleListBox.TabIndex = 11;
            VehicleListBox.SelectedIndexChanged += ShowHistoryButton_Click;
            // 
            // CheckServiceButton
            // 
            CheckServiceButton.Location = new Point(6, 132);
            CheckServiceButton.Name = "CheckServiceButton";
            CheckServiceButton.Size = new Size(311, 29);
            CheckServiceButton.TabIndex = 12;
            CheckServiceButton.Text = "CHECK SERVICE";
            CheckServiceButton.UseVisualStyleBackColor = true;
            CheckServiceButton.Click += CheckServiceButton_Click;
            // 
            // AddServiceButton
            // 
            AddServiceButton.Location = new Point(207, 256);
            AddServiceButton.Name = "AddServiceButton";
            AddServiceButton.Size = new Size(110, 29);
            AddServiceButton.TabIndex = 15;
            AddServiceButton.Text = "ADD SERVICE";
            AddServiceButton.UseVisualStyleBackColor = true;
            AddServiceButton.Click += AddServiceButton_Click;
            // 
            // ShowHistoryButton
            // 
            ShowHistoryButton.Location = new Point(6, 334);
            ShowHistoryButton.Name = "ShowHistoryButton";
            ShowHistoryButton.Size = new Size(425, 29);
            ShowHistoryButton.TabIndex = 16;
            ShowHistoryButton.Text = "SHOW SERVICE HISTORY";
            ShowHistoryButton.UseVisualStyleBackColor = true;
            ShowHistoryButton.Click += ShowHistoryButton_Click;
            // 
            // HistoryListBox
            // 
            HistoryListBox.FormattingEnabled = true;
            HistoryListBox.Location = new Point(6, 56);
            HistoryListBox.Name = "HistoryListBox";
            HistoryListBox.Size = new Size(425, 264);
            HistoryListBox.TabIndex = 17;
            // 
            // ServiceTasksListBox
            // 
            ServiceTasksListBox.FormattingEnabled = true;
            ServiceTasksListBox.Location = new Point(6, 167);
            ServiceTasksListBox.Name = "ServiceTasksListBox";
            ServiceTasksListBox.Size = new Size(311, 84);
            ServiceTasksListBox.TabIndex = 18;
            // 
            // MileageServTextBox
            // 
            MileageServTextBox.Location = new Point(50, 256);
            MileageServTextBox.Name = "MileageServTextBox";
            MileageServTextBox.Size = new Size(151, 27);
            MileageServTextBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 259);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 20;
            label6.Text = "Odo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 16);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 24;
            label7.Text = "Today is";
            // 
            // EditVehicleButton_Click
            // 
            EditVehicleButton_Click.Location = new Point(6, 325);
            EditVehicleButton_Click.Name = "EditVehicleButton_Click";
            EditVehicleButton_Click.Size = new Size(125, 36);
            EditVehicleButton_Click.TabIndex = 25;
            EditVehicleButton_Click.Text = "Edit CAR";
            EditVehicleButton_Click.UseVisualStyleBackColor = true;
            EditVehicleButton_Click.Click += EditVehicleButton_Click_Click;
            // 
            // SearchVehicleButton_Click
            // 
            SearchVehicleButton_Click.Location = new Point(224, 25);
            SearchVehicleButton_Click.Name = "SearchVehicleButton_Click";
            SearchVehicleButton_Click.Size = new Size(94, 29);
            SearchVehicleButton_Click.TabIndex = 26;
            SearchVehicleButton_Click.Text = "Search";
            SearchVehicleButton_Click.UseVisualStyleBackColor = true;
            SearchVehicleButton_Click.Click += SearchVehicleButton_Click_Click;
            // 
            // RegistrationSearchTextBox
            // 
            RegistrationSearchTextBox.Location = new Point(108, 26);
            RegistrationSearchTextBox.Name = "RegistrationSearchTextBox";
            RegistrationSearchTextBox.Size = new Size(110, 27);
            RegistrationSearchTextBox.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 29);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 28;
            label8.Text = "Plate number";
            label8.Click += label8_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(RegistrationNumberTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BrandTextBox);
            groupBox1.Controls.Add(EditVehicleButton_Click);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ModelTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(YearTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(MileageTextBox);
            groupBox1.Controls.Add(AddVehicleButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 371);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(RegistrationSearchTextBox);
            groupBox2.Controls.Add(SearchVehicleButton_Click);
            groupBox2.Location = new Point(159, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 72);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(VehicleListBox);
            groupBox3.Controls.Add(CheckServiceButton);
            groupBox3.Controls.Add(ServiceTasksListBox);
            groupBox3.Controls.Add(AddServiceButton);
            groupBox3.Controls.Add(MileageServTextBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(161, 90);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(327, 293);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(HistoryListBox);
            groupBox4.Controls.Add(ShowHistoryButton);
            groupBox4.Controls.Add(dateTimePicker1);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(494, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(437, 371);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 399);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "ASO Magic";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox RegistrationNumberTextBox;
        private TextBox BrandTextBox;
        private TextBox ModelTextBox;
        private TextBox YearTextBox;
        private TextBox MileageTextBox;
        private Button AddVehicleButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox VehicleListBox;
        private Button CheckServiceButton;
        private Button AddServiceButton;
        private Button ShowHistoryButton;
        private ListBox HistoryListBox;
        private ListBox ServiceTasksListBox;
        private TextBox MileageServTextBox;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button EditVehicleButton_Click;
        private Button SearchVehicleButton_Click;
        private TextBox RegistrationSearchTextBox;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
