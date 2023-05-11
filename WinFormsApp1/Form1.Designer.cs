namespace ProjectManagement.APP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            deleteButton = new Button();
            listButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.SlateBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(894, 249);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(247, 50);
            button1.TabIndex = 1;
            button1.Text = "New Project";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.SlateBlue;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(894, 423);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(247, 50);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // listButton
            // 
            listButton.Anchor = AnchorStyles.None;
            listButton.BackColor = Color.SlateBlue;
            listButton.FlatStyle = FlatStyle.Popup;
            listButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listButton.Location = new Point(894, 336);
            listButton.Name = "listButton";
            listButton.Size = new Size(247, 50);
            listButton.TabIndex = 5;
            listButton.Text = "All Projects";
            listButton.UseVisualStyleBackColor = false;
            listButton.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(101, 20);
            label1.Name = "label1";
            label1.Size = new Size(605, 50);
            label1.TabIndex = 6;
            label1.Text = "Welcome to Project Management\r\n";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1243, 620);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(listButton);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Project Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button deleteButton;
        private Button listButton;
        private Label label1;
        private PictureBox pictureBox1;
    }
}