namespace ProjectManagement.APP
{
    partial class Form3
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
            deleteTextBox = new TextBox();
            deleteButton = new Button();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // deleteTextBox
            // 
            deleteTextBox.Location = new Point(322, 200);
            deleteTextBox.Name = "deleteTextBox";
            deleteTextBox.Size = new Size(156, 27);
            deleteTextBox.TabIndex = 0;
            deleteTextBox.Validating += deleteTextBox_Validating;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(420, 251);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 177);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 2;
            label1.Text = "Insert an id to delete";
            // 
            // button1
            // 
            button1.Location = new Point(286, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(deleteTextBox);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox deleteTextBox;
        private Button deleteButton;
        private ErrorProvider errorProvider;
        private Label label1;
        private Button button1;
    }
}