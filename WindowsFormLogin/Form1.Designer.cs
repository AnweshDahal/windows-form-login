﻿
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
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOfBirthBTP = new System.Windows.Forms.DateTimePicker();
            this.AddressLBL = new System.Windows.Forms.Label();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PhoneNumberLBL = new System.Windows.Forms.Label();
            this.PhoneNumberTB = new System.Windows.Forms.TextBox();
            this.RegisterBTN = new System.Windows.Forms.Button();
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
            this.UsernameTB.Location = new System.Drawing.Point(129, 51);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(227, 22);
            this.UsernameTB.TabIndex = 2;
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLBL.Location = new System.Drawing.Point(14, 90);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(62, 15);
            this.PasswordLBL.TabIndex = 3;
            this.PasswordLBL.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTB.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(129, 87);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '●';
            this.PasswordTB.Size = new System.Drawing.Size(227, 22);
            this.PasswordTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date Of Birth";
            // 
            // DateOfBirthBTP
            // 
            this.DateOfBirthBTP.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthBTP.Location = new System.Drawing.Point(129, 121);
            this.DateOfBirthBTP.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DateOfBirthBTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthBTP.Name = "DateOfBirthBTP";
            this.DateOfBirthBTP.Size = new System.Drawing.Size(227, 22);
            this.DateOfBirthBTP.TabIndex = 6;
            // 
            // AddressLBL
            // 
            this.AddressLBL.AutoSize = true;
            this.AddressLBL.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLBL.Location = new System.Drawing.Point(15, 158);
            this.AddressLBL.Name = "AddressLBL";
            this.AddressLBL.Size = new System.Drawing.Size(52, 15);
            this.AddressLBL.TabIndex = 7;
            this.AddressLBL.Text = "Address";
            // 
            // AddressTB
            // 
            this.AddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTB.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTB.Location = new System.Drawing.Point(129, 156);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(227, 52);
            this.AddressTB.TabIndex = 8;
            // 
            // PhoneNumberLBL
            // 
            this.PhoneNumberLBL.AutoSize = true;
            this.PhoneNumberLBL.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLBL.Location = new System.Drawing.Point(15, 226);
            this.PhoneNumberLBL.Name = "PhoneNumberLBL";
            this.PhoneNumberLBL.Size = new System.Drawing.Size(90, 15);
            this.PhoneNumberLBL.TabIndex = 9;
            this.PhoneNumberLBL.Text = "Phone Number";
            // 
            // PhoneNumberTB
            // 
            this.PhoneNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberTB.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTB.Location = new System.Drawing.Point(129, 224);
            this.PhoneNumberTB.Name = "PhoneNumberTB";
            this.PhoneNumberTB.Size = new System.Drawing.Size(227, 22);
            this.PhoneNumberTB.TabIndex = 10;
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(202)))), ((int)(((byte)(252)))));
            this.RegisterBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(101)))), ((int)(((byte)(208)))));
            this.RegisterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBTN.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(127)))));
            this.RegisterBTN.Location = new System.Drawing.Point(18, 264);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(338, 36);
            this.RegisterBTN.TabIndex = 11;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.PhoneNumberTB);
            this.Controls.Add(this.PhoneNumberLBL);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.AddressLBL);
            this.Controls.Add(this.DateOfBirthBTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.PasswordLBL);
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
        private System.Windows.Forms.Label PasswordLBL;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateOfBirthBTP;
        private System.Windows.Forms.Label AddressLBL;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label PhoneNumberLBL;
        private System.Windows.Forms.TextBox PhoneNumberTB;
        private System.Windows.Forms.Button RegisterBTN;
    }
}

