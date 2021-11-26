
namespace WindowsFormLogin
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
            this.RegisterUserLBL = new System.Windows.Forms.Label();
            this.UsernameLBL = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterUserLBL
            // 
            this.RegisterUserLBL.AutoSize = true;
            this.RegisterUserLBL.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUserLBL.Location = new System.Drawing.Point(13, 13);
            this.RegisterUserLBL.Name = "RegisterUserLBL";
            this.RegisterUserLBL.Size = new System.Drawing.Size(135, 23);
            this.RegisterUserLBL.TabIndex = 0;
            this.RegisterUserLBL.Text = "Register User";
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.AutoSize = true;
            this.UsernameLBL.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLBL.Location = new System.Drawing.Point(15, 53);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(64, 15);
            this.UsernameLBL.TabIndex = 1;
            this.UsernameLBL.Text = "Username";
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.Color.White;
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTB.Font = new System.Drawing.Font("Inter", 9F);
            this.UsernameTB.Location = new System.Drawing.Point(100, 51);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(227, 22);
            this.UsernameTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.UsernameLBL);
            this.Controls.Add(this.RegisterUserLBL);
            this.Name = "Form1";
            this.Text = "User Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterUserLBL;
        private System.Windows.Forms.Label UsernameLBL;
        private System.Windows.Forms.TextBox UsernameTB;
    }
}

