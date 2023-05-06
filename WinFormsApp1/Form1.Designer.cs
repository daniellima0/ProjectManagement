namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            newButton = new Button();
            listButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // newButton
            // 
            resources.ApplyResources(newButton, "newButton");
            newButton.BackColor = Color.FromArgb(168, 208, 219);
            newButton.FlatAppearance.BorderColor = Color.Black;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.ForeColor = Color.Black;
            newButton.Name = "newButton";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += button1_Click;
            // 
            // listButton
            // 
            resources.ApplyResources(listButton, "listButton");
            listButton.Name = "listButton";
            listButton.UseVisualStyleBackColor = true;
            listButton.Click += listButton_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(228, 146, 115);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 69, 112);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listButton);
            Controls.Add(newButton);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newButton;
        private Button listButton;
        private Label label1;
        private Label label2;
    }
}