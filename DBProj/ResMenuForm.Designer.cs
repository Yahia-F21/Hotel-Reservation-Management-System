namespace DBProj
{
    partial class ResMenuForm
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
            this.btnGoCreateRes = new System.Windows.Forms.Button();
            this.btnGoUpdateCheckout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoCreateRes
            // 
            this.btnGoCreateRes.Location = new System.Drawing.Point(424, 179);
            this.btnGoCreateRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoCreateRes.Name = "btnGoCreateRes";
            this.btnGoCreateRes.Size = new System.Drawing.Size(201, 35);
            this.btnGoCreateRes.TabIndex = 0;
            this.btnGoCreateRes.Text = "Create Reservation";
            this.btnGoCreateRes.UseVisualStyleBackColor = true;
            this.btnGoCreateRes.Click += new System.EventHandler(this.btnGoCreateRes_Click);
            // 
            // btnGoUpdateCheckout
            // 
            this.btnGoUpdateCheckout.Location = new System.Drawing.Point(424, 288);
            this.btnGoUpdateCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoUpdateCheckout.Name = "btnGoUpdateCheckout";
            this.btnGoUpdateCheckout.Size = new System.Drawing.Size(201, 35);
            this.btnGoUpdateCheckout.TabIndex = 1;
            this.btnGoUpdateCheckout.Text = "Update Checkout";
            this.btnGoUpdateCheckout.UseVisualStyleBackColor = true;
            this.btnGoUpdateCheckout.Click += new System.EventHandler(this.btnGoUpdateCheckout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 429);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservation Management";
            // 
            // ResMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGoUpdateCheckout);
            this.Controls.Add(this.btnGoCreateRes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResMenuForm";
            this.Text = "ResMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoCreateRes;
        private System.Windows.Forms.Button btnGoUpdateCheckout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}