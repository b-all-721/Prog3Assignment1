namespace Assignment1
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
            this.btnManageSubs = new System.Windows.Forms.Button();
            this.btnPublishNot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageSubs
            // 
            this.btnManageSubs.Location = new System.Drawing.Point(36, 43);
            this.btnManageSubs.Name = "btnManageSubs";
            this.btnManageSubs.Size = new System.Drawing.Size(143, 26);
            this.btnManageSubs.TabIndex = 0;
            this.btnManageSubs.Text = "Manage Subscription";
            this.btnManageSubs.UseVisualStyleBackColor = true;
            this.btnManageSubs.Click += new System.EventHandler(this.btnManageSubs_Click);
            // 
            // btnPublishNot
            // 
            this.btnPublishNot.Location = new System.Drawing.Point(199, 45);
            this.btnPublishNot.Name = "btnPublishNot";
            this.btnPublishNot.Size = new System.Drawing.Size(145, 24);
            this.btnPublishNot.TabIndex = 1;
            this.btnPublishNot.Text = "Publish Notification";
            this.btnPublishNot.UseVisualStyleBackColor = true;
            this.btnPublishNot.Click += new System.EventHandler(this.btnPublishNot_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 122);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublishNot);
            this.Controls.Add(this.btnManageSubs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageSubs;
        private System.Windows.Forms.Button btnPublishNot;
        private System.Windows.Forms.Button btnExit;
    }
}

