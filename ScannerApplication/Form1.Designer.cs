namespace JustTimber
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
            this.ctlJobID = new System.Windows.Forms.TextBox();
            this.ctlWorker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlUpdateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlJobID
            // 
            this.ctlJobID.Location = new System.Drawing.Point(59, 14);
            this.ctlJobID.Name = "ctlJobID";
            this.ctlJobID.Size = new System.Drawing.Size(304, 20);
            this.ctlJobID.TabIndex = 0;
            // 
            // ctlWorker
            // 
            this.ctlWorker.Location = new System.Drawing.Point(59, 41);
            this.ctlWorker.Name = "ctlWorker";
            this.ctlWorker.Size = new System.Drawing.Size(304, 20);
            this.ctlWorker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Worker";
            // 
            // ctlStatus
            // 
            this.ctlStatus.FormattingEnabled = true;
            this.ctlStatus.Location = new System.Drawing.Point(59, 67);
            this.ctlStatus.Name = "ctlStatus";
            this.ctlStatus.Size = new System.Drawing.Size(121, 21);
            this.ctlStatus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // ctlUpdateButton
            // 
            this.ctlUpdateButton.Location = new System.Drawing.Point(288, 99);
            this.ctlUpdateButton.Name = "ctlUpdateButton";
            this.ctlUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.ctlUpdateButton.TabIndex = 6;
            this.ctlUpdateButton.Text = "Update";
            this.ctlUpdateButton.UseVisualStyleBackColor = true;
            this.ctlUpdateButton.Click += new System.EventHandler(this.ctlUpdateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlUpdateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctlStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlWorker);
            this.Controls.Add(this.ctlJobID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctlJobID;
        private System.Windows.Forms.TextBox ctlWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ctlStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ctlUpdateButton;
        private System.Windows.Forms.Button button1;
    }
}

