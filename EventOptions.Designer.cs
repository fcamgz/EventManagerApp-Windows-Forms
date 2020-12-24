namespace COMP1202_Assignment_1_GUI
{
    partial class EventOptions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMaxAttendees = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtEventVenue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMaxAttendees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAttendees)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudMaxAttendees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddEvent);
            this.groupBox1.Controls.Add(this.dtpEventDate);
            this.groupBox1.Controls.Add(this.txtEventVenue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEventName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // nudMaxAttendees
            // 
            this.nudMaxAttendees.Location = new System.Drawing.Point(436, 31);
            this.nudMaxAttendees.Name = "nudMaxAttendees";
            this.nudMaxAttendees.Size = new System.Drawing.Size(211, 20);
            this.nudMaxAttendees.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Attendees";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(672, 31);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(118, 49);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(436, 61);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(211, 20);
            this.dtpEventDate.TabIndex = 4;
            // 
            // txtEventVenue
            // 
            this.txtEventVenue.Location = new System.Drawing.Point(57, 64);
            this.txtEventVenue.Name = "txtEventVenue";
            this.txtEventVenue.Size = new System.Drawing.Size(203, 20);
            this.txtEventVenue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Venue";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(57, 31);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(203, 20);
            this.txtEventName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEvents);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 371);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View events";
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.eventName,
            this.Venue,
            this.Date,
            this.Attendees,
            this.columnMaxAttendees,
            this.Delete});
            this.dgvEvents.Location = new System.Drawing.Point(0, 28);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.Size = new System.Drawing.Size(806, 343);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // eventName
            // 
            this.eventName.HeaderText = "Name";
            this.eventName.Name = "eventName";
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Attendees
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Attendees.DefaultCellStyle = dataGridViewCellStyle3;
            this.Attendees.HeaderText = "Attendees";
            this.Attendees.Name = "Attendees";
            // 
            // columnMaxAttendees
            // 
            this.columnMaxAttendees.HeaderText = "Max Attendees";
            this.columnMaxAttendees.Name = "columnMaxAttendees";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 12);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(116, 23);
            this.btnBackToMenu.TabIndex = 5;
            this.btnBackToMenu.Text = "Back to Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click_1);
            // 
            // EventOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 556);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventOptions";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAttendees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtEventVenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaxAttendees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaxAttendees;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}