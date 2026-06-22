namespace DBProj
{
    partial class UpdateCheckoutForm
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
            this.txtUpdResID = new System.Windows.Forms.TextBox();
            this.txtCheckoutGuestID = new System.Windows.Forms.TextBox();
            this.txtCheckoutPayMethod = new System.Windows.Forms.TextBox();
            this.dtpNewCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateResDate = new System.Windows.Forms.Button();
            this.btnSubmitCheckout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUpdResID
            // 
            this.txtUpdResID.Location = new System.Drawing.Point(203, 128);
            this.txtUpdResID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdResID.Name = "txtUpdResID";
            this.txtUpdResID.Size = new System.Drawing.Size(148, 26);
            this.txtUpdResID.TabIndex = 0;
            // 
            // txtCheckoutGuestID
            // 
            this.txtCheckoutGuestID.Location = new System.Drawing.Point(261, 237);
            this.txtCheckoutGuestID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckoutGuestID.Name = "txtCheckoutGuestID";
            this.txtCheckoutGuestID.Size = new System.Drawing.Size(148, 26);
            this.txtCheckoutGuestID.TabIndex = 1;
            // 
            // txtCheckoutPayMethod
            // 
            this.txtCheckoutPayMethod.Location = new System.Drawing.Point(261, 350);
            this.txtCheckoutPayMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckoutPayMethod.Name = "txtCheckoutPayMethod";
            this.txtCheckoutPayMethod.Size = new System.Drawing.Size(148, 26);
            this.txtCheckoutPayMethod.TabIndex = 2;
            // 
            // dtpNewCheckOut
            // 
            this.dtpNewCheckOut.Location = new System.Drawing.Point(778, 243);
            this.dtpNewCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNewCheckOut.Name = "dtpNewCheckOut";
            this.dtpNewCheckOut.Size = new System.Drawing.Size(298, 26);
            this.dtpNewCheckOut.TabIndex = 3;
            // 
            // btnUpdateResDate
            // 
            this.btnUpdateResDate.Location = new System.Drawing.Point(814, 301);
            this.btnUpdateResDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateResDate.Name = "btnUpdateResDate";
            this.btnUpdateResDate.Size = new System.Drawing.Size(242, 35);
            this.btnUpdateResDate.TabIndex = 4;
            this.btnUpdateResDate.Text = "Update Checkout date";
            this.btnUpdateResDate.UseVisualStyleBackColor = true;
            this.btnUpdateResDate.Click += new System.EventHandler(this.btnUpdateResDate_Click);
            // 
            // btnSubmitCheckout
            // 
            this.btnSubmitCheckout.Location = new System.Drawing.Point(102, 445);
            this.btnSubmitCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitCheckout.Name = "btnSubmitCheckout";
            this.btnSubmitCheckout.Size = new System.Drawing.Size(206, 35);
            this.btnSubmitCheckout.TabIndex = 5;
            this.btnSubmitCheckout.Text = "Sumbit Checkout";
            this.btnSubmitCheckout.UseVisualStyleBackColor = true;
            this.btnSubmitCheckout.Click += new System.EventHandler(this.btnSubmitCheckout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 643);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Res ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Checkout Guest ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Check out PayMethod";
            // 
            // UpdateCheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmitCheckout);
            this.Controls.Add(this.btnUpdateResDate);
            this.Controls.Add(this.dtpNewCheckOut);
            this.Controls.Add(this.txtCheckoutPayMethod);
            this.Controls.Add(this.txtCheckoutGuestID);
            this.Controls.Add(this.txtUpdResID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateCheckoutForm";
            this.Text = "UpdateCheckoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdResID;
        private System.Windows.Forms.TextBox txtCheckoutGuestID;
        private System.Windows.Forms.TextBox txtCheckoutPayMethod;
        private System.Windows.Forms.DateTimePicker dtpNewCheckOut;
        private System.Windows.Forms.Button btnUpdateResDate;
        private System.Windows.Forms.Button btnSubmitCheckout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}