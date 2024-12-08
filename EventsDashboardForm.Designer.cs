namespace eventmanagement
{
    partial class EventDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtMaxParticipants;
        private System.Windows.Forms.TextBox txtOrganizerId;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnOrganizers;
        private System.Windows.Forms.Button btnBookings;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtMaxParticipants = new System.Windows.Forms.TextBox();
            this.txtOrganizerId = new System.Windows.Forms.TextBox();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnOrganizers = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout_Click = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEvents.EnableHeadersVisualStyles = false;
            this.dataGridViewEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewEvents.Location = new System.Drawing.Point(235, 21);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 51;
            this.dataGridViewEvents.RowTemplate.Height = 30;
            this.dataGridViewEvents.Size = new System.Drawing.Size(899, 388);
            this.dataGridViewEvents.TabIndex = 0;
            this.dataGridViewEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvents_CellClick);
            this.dataGridViewEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvents_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(220, 444);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(420, 444);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(631, 444);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(180, 22);
            this.txtEventType.TabIndex = 3;
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(220, 502);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(180, 22);
            this.txtVenue.TabIndex = 4;
            // 
            // txtMaxParticipants
            // 
            this.txtMaxParticipants.Location = new System.Drawing.Point(420, 502);
            this.txtMaxParticipants.Name = "txtMaxParticipants";
            this.txtMaxParticipants.Size = new System.Drawing.Size(180, 22);
            this.txtMaxParticipants.TabIndex = 5;
            // 
            // txtOrganizerId
            // 
            this.txtOrganizerId.Location = new System.Drawing.Point(631, 502);
            this.txtOrganizerId.Name = "txtOrganizerId";
            this.txtOrganizerId.Size = new System.Drawing.Size(180, 22);
            this.txtOrganizerId.TabIndex = 6;
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(830, 440);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(160, 22);
            this.txtEventDate.TabIndex = 7;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(830, 502);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(160, 22);
            this.txtStartTime.TabIndex = 8;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(830, 566);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(160, 22);
            this.txtEndTime.TabIndex = 9;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnAddEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEvent.Location = new System.Drawing.Point(256, 566);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(100, 42);
            this.btnAddEvent.TabIndex = 10;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnUpdateEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateEvent.Location = new System.Drawing.Point(444, 566);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(109, 42);
            this.btnUpdateEvent.TabIndex = 11;
            this.btnUpdateEvent.Text = "Update";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnDeleteEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteEvent.Location = new System.Drawing.Point(644, 566);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteEvent.TabIndex = 12;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnParticipants.FlatAppearance.BorderSize = 0;
            this.btnParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnParticipants.Location = new System.Drawing.Point(61, 158);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(125, 30);
            this.btnParticipants.TabIndex = 13;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.UseVisualStyleBackColor = false;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmins.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdmins.Location = new System.Drawing.Point(61, 236);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(100, 30);
            this.btnAdmins.TabIndex = 14;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnOrganizers
            // 
            this.btnOrganizers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnOrganizers.FlatAppearance.BorderSize = 0;
            this.btnOrganizers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrganizers.Location = new System.Drawing.Point(61, 322);
            this.btnOrganizers.Name = "btnOrganizers";
            this.btnOrganizers.Size = new System.Drawing.Size(125, 30);
            this.btnOrganizers.TabIndex = 15;
            this.btnOrganizers.Text = "Organizers";
            this.btnOrganizers.UseVisualStyleBackColor = false;
            this.btnOrganizers.Click += new System.EventHandler(this.btnOrganizers_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookings.Location = new System.Drawing.Point(61, 411);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(100, 30);
            this.btnBookings.TabIndex = 17;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnLogout_Click);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnParticipants);
            this.panel1.Controls.Add(this.btnAdmins);
            this.panel1.Controls.Add(this.btnOrganizers);
            this.panel1.Controls.Add(this.btnBookings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 618);
            this.panel1.TabIndex = 18;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout_Click.Location = new System.Drawing.Point(61, 520);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(111, 33);
            this.btnLogout_Click.TabIndex = 23;
            this.btnLogout_Click.Text = "Logout";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::eventmanagement.Properties.Resources.registration_30px3;
            this.pictureBox5.Location = new System.Drawing.Point(13, 411);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 46);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eventmanagement.Properties.Resources.planning_skill_30px4;
            this.pictureBox4.Location = new System.Drawing.Point(13, 322);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 50);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eventmanagement.Properties.Resources.administrator_male_30px3;
            this.pictureBox3.Location = new System.Drawing.Point(13, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 43);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eventmanagement.Properties.Resources.conference_foreground_selected_30px5;
            this.pictureBox2.Location = new System.Drawing.Point(13, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 50);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eventmanagement.Properties.Resources.eventmanage_100px7;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 95);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Event Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(830, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Venue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Max participents";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Organizer Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(834, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Start time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(840, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "End time";
            // 
            // EventDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1158, 618);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtMaxParticipants);
            this.Controls.Add(this.txtOrganizerId);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnDeleteEvent);
            this.Name = "EventDashboardForm";
            this.Text = "Event Dashboard";
            this.Load += new System.EventHandler(this.EventDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnLogout_Click;
    }
}
