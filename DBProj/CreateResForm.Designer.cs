namespace DBProj
{
    partial class CreateResForm
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
            this.txtResFName = new System.Windows.Forms.TextBox();
            this.txtResLName = new System.Windows.Forms.TextBox();
            this.txtResPhone = new System.Windows.Forms.TextBox();
            this.txtResEmail = new System.Windows.Forms.TextBox();
            this.txtResRoomID = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitCreateRes = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResFName
            // 
            this.txtResFName.Location = new System.Drawing.Point(55, 85);
            this.txtResFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResFName.Name = "txtResFName";
            this.txtResFName.Size = new System.Drawing.Size(112, 26);
            this.txtResFName.TabIndex = 0;
            this.txtResFName.TextChanged += new System.EventHandler(this.txtResFName_TextChanged);
            // 
            // txtResLName
            // 
            this.txtResLName.Location = new System.Drawing.Point(249, 85);
            this.txtResLName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResLName.Name = "txtResLName";
            this.txtResLName.Size = new System.Drawing.Size(112, 26);
            this.txtResLName.TabIndex = 1;
            // 
            // txtResPhone
            // 
            this.txtResPhone.Location = new System.Drawing.Point(652, 85);
            this.txtResPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResPhone.Name = "txtResPhone";
            this.txtResPhone.Size = new System.Drawing.Size(182, 26);
            this.txtResPhone.TabIndex = 2;
            // 
            // txtResEmail
            // 
            this.txtResEmail.Location = new System.Drawing.Point(652, 207);
            this.txtResEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResEmail.Name = "txtResEmail";
            this.txtResEmail.Size = new System.Drawing.Size(182, 26);
            this.txtResEmail.TabIndex = 3;
            // 
            // txtResRoomID
            // 
            this.txtResRoomID.Location = new System.Drawing.Point(437, 85);
            this.txtResRoomID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResRoomID.Name = "txtResRoomID";
            this.txtResRoomID.Size = new System.Drawing.Size(118, 26);
            this.txtResRoomID.TabIndex = 4;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(3, 222);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(224, 26);
            this.dtpCheckIn.TabIndex = 5;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(320, 222);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(224, 26);
            this.dtpCheckOut.TabIndex = 6;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnSubmitCreateRes
            // 
            this.btnSubmitCreateRes.Location = new System.Drawing.Point(413, 376);
            this.btnSubmitCreateRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitCreateRes.Name = "btnSubmitCreateRes";
            this.btnSubmitCreateRes.Size = new System.Drawing.Size(84, 29);
            this.btnSubmitCreateRes.TabIndex = 7;
            this.btnSubmitCreateRes.Text = "Add";
            this.btnSubmitCreateRes.UseVisualStyleBackColor = true;
            this.btnSubmitCreateRes.Click += new System.EventHandler(this.btnSubmitCreateRes_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 520);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 29);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CheckOut Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "CheckIn Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(714, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "RoomID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lname";
            // 
            // CreateResForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmitCreateRes);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtResRoomID);
            this.Controls.Add(this.txtResEmail);
            this.Controls.Add(this.txtResPhone);
            this.Controls.Add(this.txtResLName);
            this.Controls.Add(this.txtResFName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateResForm";
            this.Text = "CreateResForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResFName;
        private System.Windows.Forms.TextBox txtResLName;
        private System.Windows.Forms.TextBox txtResPhone;
        private System.Windows.Forms.TextBox txtResEmail;
        private System.Windows.Forms.TextBox txtResRoomID;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnSubmitCreateRes;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}