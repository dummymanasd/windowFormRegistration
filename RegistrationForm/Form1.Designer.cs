namespace RegistrationForm
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
            this.userRegisterLabel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRegisterLabel
            // 
            this.userRegisterLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterLabel.Location = new System.Drawing.Point(48, 20);
            this.userRegisterLabel.Name = "userRegisterLabel";
            this.userRegisterLabel.Size = new System.Drawing.Size(364, 43);
            this.userRegisterLabel.TabIndex = 0;
            this.userRegisterLabel.Text = "User Registration Form";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(492, 84);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(100, 23);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Email";
            // 
            // lblBday
            // 
            this.lblBday.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBday.Location = new System.Drawing.Point(48, 200);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(100, 23);
            this.lblBday.TabIndex = 3;
            this.lblBday.Text = "Birthday";
            // 
            // lblSex
            // 
            this.lblSex.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(2, 13);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 23);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "Gender";
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(48, 310);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(131, 23);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(492, 310);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(131, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // rbMale
            // 
            this.rbMale.Location = new System.Drawing.Point(11, 58);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(104, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(132, 58);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(104, 24);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.rbFemale);
            this.groupBoxSex.Controls.Add(this.rbMale);
            this.groupBoxSex.Controls.Add(this.lblSex);
            this.groupBoxSex.Location = new System.Drawing.Point(490, 187);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(279, 107);
            this.groupBoxSex.TabIndex = 9;
            this.groupBoxSex.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(811, 424);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 56);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clicked);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 117);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(315, 51);
            this.tbName.TabIndex = 11;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(490, 117);
            this.tbMail.Multiline = true;
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(315, 51);
            this.tbMail.TabIndex = 12;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(53, 357);
            this.tbNumber.Multiline = true;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(315, 51);
            this.tbNumber.TabIndex = 13;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(490, 357);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(315, 51);
            this.tbAddress.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.userRegisterLabel);
            this.Name = "Form1";
            this.Text = "User Registration Form";
            this.groupBoxSex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.TextBox tbMail;

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.Button btnSubmit;

        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.Label userRegisterLabel;
        private System.Windows.Forms.Label lblName;

        #endregion
    }
}