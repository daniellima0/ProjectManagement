namespace ProjectManagement.APP
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            startDateTimePicker = new DateTimePicker();
            managerNameTextBox = new TextBox();
            finishDateTimePicker = new DateTimePicker();
            summaryTextBox = new TextBox();
            projectNameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            statusComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 67);
            label1.Name = "label1";
            label1.Size = new Size(168, 17);
            label1.TabIndex = 0;
            label1.Text = "Fill in the following fields";
            label1.Click += label1_Click;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Anchor = AnchorStyles.None;
            startDateTimePicker.Location = new Point(262, 241);
            startDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(320, 27);
            startDateTimePicker.TabIndex = 3;
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            // 
            // managerNameTextBox
            // 
            managerNameTextBox.Anchor = AnchorStyles.None;
            managerNameTextBox.Location = new Point(262, 174);
            managerNameTextBox.Margin = new Padding(3, 4, 3, 4);
            managerNameTextBox.Multiline = true;
            managerNameTextBox.Name = "managerNameTextBox";
            managerNameTextBox.Size = new Size(320, 32);
            managerNameTextBox.TabIndex = 2;
            managerNameTextBox.TextChanged += managerNameTextBox_TextChanged;
            managerNameTextBox.Validating += managerNameTextBox_Validating;
            // 
            // finishDateTimePicker
            // 
            finishDateTimePicker.Anchor = AnchorStyles.None;
            finishDateTimePicker.Location = new Point(262, 305);
            finishDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            finishDateTimePicker.Name = "finishDateTimePicker";
            finishDateTimePicker.Size = new Size(320, 27);
            finishDateTimePicker.TabIndex = 4;
            finishDateTimePicker.ValueChanged += finishDateTimePicker_ValueChanged;
            finishDateTimePicker.Validating += finishDateTimePicker_Validating;
            // 
            // summaryTextBox
            // 
            summaryTextBox.Anchor = AnchorStyles.None;
            summaryTextBox.Location = new Point(262, 366);
            summaryTextBox.Margin = new Padding(3, 4, 3, 4);
            summaryTextBox.Multiline = true;
            summaryTextBox.Name = "summaryTextBox";
            summaryTextBox.Size = new Size(320, 103);
            summaryTextBox.TabIndex = 5;
            summaryTextBox.TextChanged += summaryTextBox_TextChanged;
            summaryTextBox.Validating += summaryTextBox_Validating;
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.Anchor = AnchorStyles.None;
            projectNameTextBox.Location = new Point(262, 110);
            projectNameTextBox.Margin = new Padding(3, 4, 3, 4);
            projectNameTextBox.Multiline = true;
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.Size = new Size(320, 32);
            projectNameTextBox.TabIndex = 1;
            projectNameTextBox.TextChanged += projectNameTextBox_TextChanged;
            projectNameTextBox.Validating += projectNameTextBox_Validating;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(142, 244);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 10;
            label2.Text = "Start Date";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(142, 308);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 11;
            label3.Text = "Finish Date";
            label3.Click += label3_Click;
            // 
            // statusComboBox
            // 
            statusComboBox.Anchor = AnchorStyles.None;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "not started", "in progress", "completed" });
            statusComboBox.Location = new Point(262, 506);
            statusComboBox.Margin = new Padding(3, 4, 3, 4);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(320, 28);
            statusComboBox.TabIndex = 6;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            statusComboBox.Validating += statusComboBox_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(142, 116);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 13;
            label4.Text = "Project Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(142, 180);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 14;
            label5.Text = "Manager Name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(142, 372);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 15;
            label6.Text = "Summary";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(142, 509);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 16;
            label7.Text = "Status";
            label7.Click += label7_Click;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.None;
            okButton.BackColor = Color.SlateBlue;
            okButton.FlatStyle = FlatStyle.Popup;
            okButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            okButton.Location = new Point(449, 581);
            okButton.Name = "okButton";
            okButton.Size = new Size(134, 29);
            okButton.TabIndex = 8;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.BackColor = Color.SlateBlue;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.Location = new Point(262, 581);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(134, 29);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click_1;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(725, 676);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(statusComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(projectNameTextBox);
            Controls.Add(startDateTimePicker);
            Controls.Add(finishDateTimePicker);
            Controls.Add(summaryTextBox);
            Controls.Add(managerNameTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "New Project";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker startDateTimePicker;
        private TextBox managerNameTextBox;
        private DateTimePicker finishDateTimePicker;
        private TextBox summaryTextBox;
        private TextBox projectNameTextBox;
        private Label label2;
        private Label label3;
        private ComboBox statusComboBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button okButton;
        private Button cancelButton;
        private ErrorProvider errorProvider;
    }
}