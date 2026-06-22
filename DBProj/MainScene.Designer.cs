namespace DBProj
{
    partial class MainScene
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
            this.btnGoRoom = new System.Windows.Forms.Button();
            this.btnGoRes = new System.Windows.Forms.Button();
            this.btnGoGuest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoRoom
            // 
            this.btnGoRoom.Location = new System.Drawing.Point(274, 231);
            this.btnGoRoom.Name = "btnGoRoom";
            this.btnGoRoom.Size = new System.Drawing.Size(207, 29);
            this.btnGoRoom.TabIndex = 1;
            this.btnGoRoom.Text = "Room Management";
            this.btnGoRoom.UseVisualStyleBackColor = true;
            this.btnGoRoom.Click += new System.EventHandler(this.btnGoRoom_Click);
            // 
            // btnGoRes
            // 
            this.btnGoRes.Location = new System.Drawing.Point(274, 278);
            this.btnGoRes.Name = "btnGoRes";
            this.btnGoRes.Size = new System.Drawing.Size(207, 32);
            this.btnGoRes.TabIndex = 2;
            this.btnGoRes.Text = "Reservation Management";
            this.btnGoRes.UseVisualStyleBackColor = true;
            this.btnGoRes.Click += new System.EventHandler(this.btnGoRes_Click_1);
            // 
            // btnGoGuest
            // 
            this.btnGoGuest.Location = new System.Drawing.Point(274, 178);
            this.btnGoGuest.Name = "btnGoGuest";
            this.btnGoGuest.Size = new System.Drawing.Size(207, 32);
            this.btnGoGuest.TabIndex = 3;
            this.btnGoGuest.Text = "Guest Management";
            this.btnGoGuest.UseVisualStyleBackColor = true;
            this.btnGoGuest.Click += new System.EventHandler(this.btnGoGuest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Hotel Management system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoGuest);
            this.Controls.Add(this.btnGoRes);
            this.Controls.Add(this.btnGoRoom);
            this.Name = "MainScene";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGoRoom;
        private System.Windows.Forms.Button btnGoRes;
        private System.Windows.Forms.Button btnGoGuest;
        private System.Windows.Forms.Label label1;
    }
}

