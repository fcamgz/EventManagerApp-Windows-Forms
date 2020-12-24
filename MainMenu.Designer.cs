namespace COMP1202_Assignment_1_GUI
{
    partial class MainMenu
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
            this.btnCustomerOptions = new System.Windows.Forms.Button();
            this.btnEventOptions = new System.Windows.Forms.Button();
            this.btnRSVP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerOptions
            // 
            this.btnCustomerOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerOptions.Location = new System.Drawing.Point(11, 146);
            this.btnCustomerOptions.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerOptions.Name = "btnCustomerOptions";
            this.btnCustomerOptions.Size = new System.Drawing.Size(150, 42);
            this.btnCustomerOptions.TabIndex = 1;
            this.btnCustomerOptions.Text = "Customer";
            this.btnCustomerOptions.UseVisualStyleBackColor = true;
            this.btnCustomerOptions.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEventOptions
            // 
            this.btnEventOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventOptions.Location = new System.Drawing.Point(196, 146);
            this.btnEventOptions.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventOptions.Name = "btnEventOptions";
            this.btnEventOptions.Size = new System.Drawing.Size(146, 42);
            this.btnEventOptions.TabIndex = 2;
            this.btnEventOptions.Text = "Event";
            this.btnEventOptions.UseVisualStyleBackColor = true;
            this.btnEventOptions.Click += new System.EventHandler(this.btnEventOptions_Click);
            // 
            // btnRSVP
            // 
            this.btnRSVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSVP.Location = new System.Drawing.Point(11, 206);
            this.btnRSVP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRSVP.Name = "btnRSVP";
            this.btnRSVP.Size = new System.Drawing.Size(150, 38);
            this.btnRSVP.TabIndex = 3;
            this.btnRSVP.Text = "RSVP";
            this.btnRSVP.UseVisualStyleBackColor = true;
            this.btnRSVP.Click += new System.EventHandler(this.btnRSVP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(196, 206);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contact Manager App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome to";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRSVP);
            this.Controls.Add(this.btnEventOptions);
            this.Controls.Add(this.btnCustomerOptions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCustomerOptions;
        private System.Windows.Forms.Button btnEventOptions;
        private System.Windows.Forms.Button btnRSVP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

