namespace EmployeesDatabase
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
            txtFirstName = new TextBox();
            txtSurname = new TextBox();
            txtJobTitle = new TextBox();
            txtDepartment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnAddNew = new Button();
            btnUdate = new Button();
            btnDelete = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(167, 59);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.Text = "ty";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(514, 59);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 1;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(167, 155);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(125, 27);
            txtJobTitle.TabIndex = 2;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(514, 145);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(125, 27);
            txtDepartment.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 62);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 58);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 148);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 158);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Job Title ";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DarkGray;
            btnNext.Location = new Point(255, 230);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 51);
            btnNext.TabIndex = 8;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.DarkGray;
            btnPrevious.Location = new Point(146, 234);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(103, 48);
            btnPrevious.TabIndex = 9;
            btnPrevious.Text = "PREVIOUS";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.DarkGray;
            btnLast.Location = new Point(352, 232);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(122, 50);
            btnLast.TabIndex = 10;
            btnLast.Text = "LAST RECORD";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.DarkGray;
            btnFirst.Location = new Point(19, 230);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(121, 51);
            btnFirst.TabIndex = 11;
            btnFirst.Text = "FIRST RECORD";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkTurquoise;
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(709, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 51);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkTurquoise;
            btnSave.Enabled = false;
            btnSave.Location = new Point(706, 117);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 51);
            btnSave.TabIndex = 13;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.DarkTurquoise;
            btnAddNew.Location = new Point(706, 47);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(114, 51);
            btnAddNew.TabIndex = 14;
            btnAddNew.Text = "ADD NEW";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUdate
            // 
            btnUdate.BackColor = Color.DarkTurquoise;
            btnUdate.Location = new Point(709, 256);
            btnUdate.Name = "btnUdate";
            btnUdate.Size = new Size(116, 51);
            btnUdate.TabIndex = 15;
            btnUdate.Text = "UPDATE";
            btnUdate.UseVisualStyleBackColor = false;
            btnUdate.Click += btnUdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(709, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 51);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Location = new Point(352, 421);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 17;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnUdate);
            Controls.Add(btnAddNew);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnFirst);
            Controls.Add(btnLast);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartment);
            Controls.Add(txtJobTitle);
            Controls.Add(txtSurname);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtSurname;
        private TextBox txtJobTitle;
        private TextBox txtDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnFirst;
        private Button btnCancel;
        private Button btnSave;
        private Button btnAddNew;
        private Button btnUdate;
        private Button btnDelete;
        private Label label5;
    }
}
