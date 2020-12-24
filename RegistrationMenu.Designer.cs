namespace COMP1202_Assignment_1_GUI
{
    partial class RegistrationMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.rowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddRSVP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegistrations);
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrations";
            // 
            // dgvRegistrations
            // 
            this.dgvRegistrations.AllowUserToAddRows = false;
            this.dgvRegistrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowID,
            this.rowEvent,
            this.rowCustomer,
            this.rowDate});
            this.dgvRegistrations.Location = new System.Drawing.Point(12, 19);
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.RowHeadersVisible = false;
            this.dgvRegistrations.RowHeadersWidth = 51;
            this.dgvRegistrations.Size = new System.Drawing.Size(485, 376);
            this.dgvRegistrations.TabIndex = 1;
            // 
            // rowID
            // 
            this.rowID.HeaderText = "ID";
            this.rowID.Name = "rowID";
            this.rowID.ReadOnly = true;
            // 
            // rowEvent
            // 
            this.rowEvent.HeaderText = "Event";
            this.rowEvent.Name = "rowEvent";
            this.rowEvent.ReadOnly = true;
            // 
            // rowCustomer
            // 
            this.rowCustomer.HeaderText = "Customer";
            this.rowCustomer.Name = "rowCustomer";
            this.rowCustomer.ReadOnly = true;
            // 
            // rowDate
            // 
            this.rowDate.HeaderText = "Date";
            this.rowDate.Name = "rowDate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddRSVP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbEvents);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCustomers);
            this.groupBox2.Location = new System.Drawing.Point(12, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add RSVP";
            // 
            // btnAddRSVP
            // 
            this.btnAddRSVP.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddRSVP.Location = new System.Drawing.Point(392, 41);
            this.btnAddRSVP.Name = "btnAddRSVP";
            this.btnAddRSVP.Size = new System.Drawing.Size(87, 23);
            this.btnAddRSVP.TabIndex = 5;
            this.btnAddRSVP.Text = "Add RSVP";
            this.btnAddRSVP.UseVisualStyleBackColor = false;
            this.btnAddRSVP.Click += new System.EventHandler(this.btnAddRSVP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // cmbEvents
            // 
            this.cmbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbEvents.Location = new System.Drawing.Point(205, 43);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(172, 21);
            this.cmbEvents.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(12, 43);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(174, 21);
            this.cmbCustomers.TabIndex = 0;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 12);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(87, 23);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // RegistrationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationMenu";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistrationMenu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.Button btnAddRSVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDate;
        private System.Windows.Forms.ComboBox cmbEvents;
    }
}