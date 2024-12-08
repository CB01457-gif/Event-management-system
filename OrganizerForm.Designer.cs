using System.Windows.Forms;

namespace eventmanagement
{
    partial class OrganizerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewCreatedEvents;
        private System.Windows.Forms.Button btnViewParticipants;
        private System.Windows.Forms.DataGridView dgvCreatedEvents;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtMaxParticipants;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnDeleteEvent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewCreatedEvents = new System.Windows.Forms.Button();
            this.btnViewParticipants = new System.Windows.Forms.Button();
            this.dgvCreatedEvents = new System.Windows.Forms.DataGridView();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtMaxParticipants = new System.Windows.Forms.TextBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout_Click = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatedEvents)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(16, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(142, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, {Organizer}!";
            // 
            // btnViewCreatedEvents
            // 
            this.btnViewCreatedEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnViewCreatedEvents.FlatAppearance.BorderSize = 0;
            this.btnViewCreatedEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCreatedEvents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCreatedEvents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewCreatedEvents.Location = new System.Drawing.Point(54, 170);
            this.btnViewCreatedEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewCreatedEvents.Name = "btnViewCreatedEvents";
            this.btnViewCreatedEvents.Size = new System.Drawing.Size(160, 37);
            this.btnViewCreatedEvents.TabIndex = 1;
            this.btnViewCreatedEvents.Text = "View Created Events";
            this.btnViewCreatedEvents.UseVisualStyleBackColor = false;
            this.btnViewCreatedEvents.Click += new System.EventHandler(this.btnViewCreatedEvents_Click);
            // 
            // btnViewParticipants
            // 
            this.btnViewParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnViewParticipants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewParticipants.FlatAppearance.BorderSize = 0;
            this.btnViewParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewParticipants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewParticipants.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewParticipants.Location = new System.Drawing.Point(79, 245);
            this.btnViewParticipants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewParticipants.Name = "btnViewParticipants";
            this.btnViewParticipants.Size = new System.Drawing.Size(160, 28);
            this.btnViewParticipants.TabIndex = 2;
            this.btnViewParticipants.Text = "View Participants";
            this.btnViewParticipants.UseVisualStyleBackColor = false;
            this.btnViewParticipants.Click += new System.EventHandler(this.btnViewParticipants_Click);
            // 
            // dgvCreatedEvents
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreatedEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreatedEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreatedEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreatedEvents.EnableHeadersVisualStyles = false;
            this.dgvCreatedEvents.GridColor = System.Drawing.Color.LightGray;
            this.dgvCreatedEvents.Location = new System.Drawing.Point(279, 32);
            this.dgvCreatedEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCreatedEvents.Name = "dgvCreatedEvents";
            this.dgvCreatedEvents.RowHeadersWidth = 51;
            this.dgvCreatedEvents.RowTemplate.Height = 30;
            this.dgvCreatedEvents.Size = new System.Drawing.Size(754, 306);
            this.dgvCreatedEvents.TabIndex = 3;
            this.dgvCreatedEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreatedEvents_CellContentClick);
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(279, 388);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(159, 22);
            this.txtEventName.TabIndex = 4;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(520, 388);
            this.txtEventType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(159, 22);
            this.txtEventType.TabIndex = 5;
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(704, 388);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(159, 22);
            this.txtVenue.TabIndex = 6;
            // 
            // txtMaxParticipants
            // 
            this.txtMaxParticipants.Location = new System.Drawing.Point(906, 388);
            this.txtMaxParticipants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaxParticipants.Name = "txtMaxParticipants";
            this.txtMaxParticipants.Size = new System.Drawing.Size(159, 22);
            this.txtMaxParticipants.TabIndex = 7;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(279, 465);
            this.dtpEventDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(219, 22);
            this.dtpEventDate.TabIndex = 8;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(520, 465);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(162, 22);
            this.dtpStartTime.TabIndex = 9;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(716, 465);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(159, 22);
            this.dtpEndTime.TabIndex = 10;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnCreateEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.ForeColor = System.Drawing.Color.White;
            this.btnCreateEvent.Location = new System.Drawing.Point(279, 543);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(167, 45);
            this.btnCreateEvent.TabIndex = 11;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnUpdateEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEvent.Location = new System.Drawing.Point(520, 543);
            this.btnUpdateEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(162, 45);
            this.btnUpdateEvent.TabIndex = 12;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnDeleteEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEvent.Location = new System.Drawing.Point(753, 543);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(162, 45);
            this.btnDeleteEvent.TabIndex = 13;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnLogout_Click);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnViewCreatedEvents);
            this.panel1.Controls.Add(this.btnViewParticipants);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 681);
            this.panel1.TabIndex = 14;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout_Click.Location = new System.Drawing.Point(79, 445);
            this.btnLogout_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(99, 26);
            this.btnLogout_Click.TabIndex = 8;
            this.btnLogout_Click.Text = "Logout";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eventmanagement.Properties.Resources.eventmanage_100px2;
            this.pictureBox3.Location = new System.Drawing.Point(58, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 110);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eventmanagement.Properties.Resources.conference_foreground_selected_30px1;
            this.pictureBox2.Location = new System.Drawing.Point(29, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eventmanagement.Properties.Resources.event_accepted_tentatively_30px1;
            this.pictureBox1.Location = new System.Drawing.Point(29, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Event name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Event type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Event venue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(902, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "maximum participants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Event date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Start time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(754, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "End time";
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 681);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.txtMaxParticipants);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.dgvCreatedEvents);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrganizerForm";
            this.Text = "Organizer Dashboard";
            this.Load += new System.EventHandler(this.OrganizerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreatedEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Button btnLogout_Click;
    }
}
