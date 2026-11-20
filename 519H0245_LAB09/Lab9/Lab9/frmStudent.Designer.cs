namespace Lab9
{
    partial class frmStudent
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
            label1 = new Label();
            txtSID = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtHometown = new TextBox();
            label4 = new Label();
            txtDOB = new TextBox();
            label5 = new Label();
            txtGPA = new TextBox();
            bAdd = new Button();
            bEdit = new Button();
            bDel = new Button();
            bSave = new Button();
            grd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // txtSID
            // 
            txtSID.Location = new Point(95, 12);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(180, 23);
            txtSID.TabIndex = 1;
            txtSID.KeyUp += txtSID_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(348, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 23);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 43);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Hometown";
            // 
            // txtHometown
            // 
            txtHometown.Location = new Point(95, 41);
            txtHometown.Name = "txtHometown";
            txtHometown.Size = new Size(180, 23);
            txtHometown.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 45);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "DOB";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(348, 43);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(210, 23);
            txtDOB.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 72);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 0;
            label5.Text = "GPA";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(95, 70);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(180, 23);
            txtGPA.TabIndex = 1;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(15, 102);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(116, 33);
            bAdd.TabIndex = 2;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(137, 102);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(116, 33);
            bEdit.TabIndex = 2;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            // 
            // bDel
            // 
            bDel.Location = new Point(259, 102);
            bDel.Name = "bDel";
            bDel.Size = new Size(116, 33);
            bDel.TabIndex = 2;
            bDel.Text = "Delete";
            bDel.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            bSave.Location = new Point(381, 102);
            bSave.Name = "bSave";
            bSave.Size = new Size(116, 33);
            bSave.TabIndex = 2;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(12, 143);
            grd.Name = "grd";
            grd.Size = new Size(539, 355);
            grd.TabIndex = 3;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 511);
            Controls.Add(grd);
            Controls.Add(bSave);
            Controls.Add(bDel);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtDOB);
            Controls.Add(label4);
            Controls.Add(txtGPA);
            Controls.Add(label5);
            Controls.Add(txtHometown);
            Controls.Add(label3);
            Controls.Add(txtSID);
            Controls.Add(label1);
            Name = "frmStudent";
            Text = "Internship management";
            Load += frmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSID;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtHometown;
        private Label label4;
        private TextBox txtDOB;
        private Label label5;
        private TextBox txtGPA;
        private Button bAdd;
        private Button bEdit;
        private Button bDel;
        private Button bSave;
        private DataGridView grd;
    }
}
