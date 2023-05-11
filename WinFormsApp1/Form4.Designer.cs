namespace ProjectManagement.APP
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            deleteButton = new Button();
            refreshButton = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.BackColor = SystemColors.ActiveCaption;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(47, 34);
            listView1.Name = "listView1";
            listView1.Size = new Size(965, 535);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Project Name";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Manager Name";
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Start Date";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Finish Date";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 100;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.SlateBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1078, 194);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.SlateBlue;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(1078, 282);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(125, 38);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.None;
            refreshButton.BackColor = Color.SlateBlue;
            refreshButton.FlatStyle = FlatStyle.Popup;
            refreshButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            refreshButton.Location = new Point(1078, 370);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(125, 38);
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1259, 602);
            Controls.Add(refreshButton);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Controls.Add(listView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
        private Button deleteButton;
        private Button refreshButton;
    }
}