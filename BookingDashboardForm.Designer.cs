namespace eventmanagement
{
    partial class BookingDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.TextBox txtParticipantId;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnOrganizers;
        private System.Windows.Forms.Button btnEvents;

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
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.txtParticipantId = new System.Windows.Forms.TextBox();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnOrganizers = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookings
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookings.EnableHeadersVisualStyles = false;
            this.dataGridViewBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewBookings.Location = new System.Drawing.Point(275, 37);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersWidth = 51;
            this.dataGridViewBookings.RowTemplate.Height = 30;
            this.dataGridViewBookings.Size = new System.Drawing.Size(717, 340);
            this.dataGridViewBookings.TabIndex = 0;
            this.dataGridViewBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookings_CellClick);
            this.dataGridViewBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookings_CellContentClick_1);
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(313, 446);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(180, 22);
            this.txtBookingId.TabIndex = 1;
            // 
            // txtParticipantId
            // 
            this.txtParticipantId.Location = new System.Drawing.Point(539, 446);
            this.txtParticipantId.Name = "txtParticipantId";
            this.txtParticipantId.Size = new System.Drawing.Size(180, 22);
            this.txtParticipantId.TabIndex = 2;
            // 
            // txtEventId
            // 
            this.txtEventId.Location = new System.Drawing.Point(773, 446);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(180, 22);
            this.txtEventId.TabIndex = 3;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnAddBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddBooking.Location = new System.Drawing.Point(359, 514);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(109, 42);
            this.btnAddBooking.TabIndex = 4;
            this.btnAddBooking.Text = "Add";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnUpdateBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBooking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateBooking.Location = new System.Drawing.Point(572, 514);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(112, 42);
            this.btnUpdateBooking.TabIndex = 5;
            this.btnUpdateBooking.Text = "Update";
            this.btnUpdateBooking.UseVisualStyleBackColor = false;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnDeleteBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBooking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteBooking.Location = new System.Drawing.Point(808, 514);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(108, 42);
            this.btnDeleteBooking.TabIndex = 6;
            this.btnDeleteBooking.Text = "Delete";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnParticipants.FlatAppearance.BorderSize = 0;
            this.btnParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipants.ForeColor = System.Drawing.SystemColors.Control;
            this.btnParticipants.Location = new System.Drawing.Point(61, 151);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(124, 30);
            this.btnParticipants.TabIndex = 7;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.UseVisualStyleBackColor = false;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmins.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmins.Location = new System.Drawing.Point(70, 228);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(100, 30);
            this.btnAdmins.TabIndex = 8;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = true;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnOrganizers
            // 
            this.btnOrganizers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnOrganizers.FlatAppearance.BorderSize = 0;
            this.btnOrganizers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrganizers.Location = new System.Drawing.Point(70, 307);
            this.btnOrganizers.Name = "btnOrganizers";
            this.btnOrganizers.Size = new System.Drawing.Size(100, 30);
            this.btnOrganizers.TabIndex = 9;
            this.btnOrganizers.Text = "Organizers";
            this.btnOrganizers.UseVisualStyleBackColor = false;
            this.btnOrganizers.Click += new System.EventHandler(this.btnOrganizers_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEvents.Location = new System.Drawing.Point(70, 388);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(100, 30);
            this.btnEvents.TabIndex = 10;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
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
            this.panel1.Controls.Add(this.btnEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 618);
            this.panel1.TabIndex = 12;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout_Click.Location = new System.Drawing.Point(74, 504);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(111, 33);
            this.btnLogout_Click.TabIndex = 16;
            this.btnLogout_Click.Text = "Logout";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::eventmanagement.Properties.Resources.event_accepted_30px3;
            this.pictureBox5.Location = new System.Drawing.Point(25, 384);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 50);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eventmanagement.Properties.Resources.planning_skill_30px3;
            this.pictureBox4.Location = new System.Drawing.Point(25, 307);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 50);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eventmanagement.Properties.Resources.administrator_male_30px1;
            this.pictureBox3.Location = new System.Drawing.Point(25, 228);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eventmanagement.Properties.Resources.conference_foreground_selected_30px3;
            this.pictureBox2.Location = new System.Drawing.Point(25, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 50);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eventmanagement.Properties.Resources.eventmanage_100px5;
            this.pictureBox1.Location = new System.Drawing.Point(61, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 105);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Booking Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Participant Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(782, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Event Id";
            // 
            // BookingDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1158, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewBookings);
            this.Controls.Add(this.txtBookingId);
            this.Controls.Add(this.txtParticipantId);
            this.Controls.Add(this.txtEventId);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.btnDeleteBooking);
            this.Name = "BookingDashboardForm";
            this.Text = "Booking Dashboard";
            this.Load += new System.EventHandler(this.BookingDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnLogout_Click;
    }
}
