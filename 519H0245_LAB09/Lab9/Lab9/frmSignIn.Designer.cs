namespace GUI
{
    partial class frmSignIn
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
            txtPass = new TextBox();
            label3 = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            bSignIn = new Button();
            bCancel = new Button();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(81, 41);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(180, 23);
            txtPass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 43);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(81, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(180, 23);
            txtUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // bSignIn
            // 
            bSignIn.Location = new Point(8, 80);
            bSignIn.Name = "bSignIn";
            bSignIn.Size = new Size(106, 34);
            bSignIn.TabIndex = 2;
            bSignIn.Text = "Sign In";
            bSignIn.UseVisualStyleBackColor = true;
            bSignIn.Click += bSignIn_Click;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(155, 80);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(106, 34);
            bCancel.TabIndex = 3;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 128);
            Controls.Add(bCancel);
            Controls.Add(bSignIn);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Name = "frmSignIn";
            Text = "Sign in";
            Load += frmSignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private Label label3;
        private TextBox txtUser;
        private Label label1;
        private Button bSignIn;
        private Button bCancel;
    }
}