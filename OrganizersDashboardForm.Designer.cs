namespace eventmanagement
{
    partial class OrganizerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrganizers;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddOrganizer;
        private System.Windows.Forms.Button btnUpdateOrganizer;
        private System.Windows.Forms.Button btnDeleteOrganizer;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnEvents;
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
            this.dataGridViewOrganizers = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddOrganizer = new System.Windows.Forms.Button();
            this.btnUpdateOrganizer = new System.Windows.Forms.Button();
            this.btnDeleteOrganizer = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
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
            this.Nic = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrganizers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewOrganizers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrganizers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrganizers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrganizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrganizers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrganizers.EnableHeadersVisualStyles = false;
            this.dataGridViewOrganizers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewOrganizers.Location = new System.Drawing.Point(270, 20);
            this.dataGridViewOrganizers.Name = "dataGridViewOrganizers";
            this.dataGridViewOrganizers.RowHeadersWidth = 51;
            this.dataGridViewOrganizers.RowTemplate.Height = 30;
            this.dataGridViewOrganizers.Size = new System.Drawing.Size(793, 298);
            this.dataGridViewOrganizers.TabIndex = 0;
            this.dataGridViewOrganizers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrganizers_CellClick);
            this.dataGridViewOrganizers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrganizers_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(290, 374);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(513, 374);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(290, 473);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(529, 473);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(180, 22);
            this.txtNic.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(761, 374);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(773, 473);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // btnAddOrganizer
            // 
            this.btnAddOrganizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnAddOrganizer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganizer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddOrganizer.Location = new System.Drawing.Point(558, 531);
            this.btnAddOrganizer.Name = "btnAddOrganizer";
            this.btnAddOrganizer.Size = new System.Drawing.Size(113, 42);
            this.btnAddOrganizer.TabIndex = 7;
            this.btnAddOrganizer.Text = "Add";
            this.btnAddOrganizer.UseVisualStyleBackColor = false;
            this.btnAddOrganizer.Click += new System.EventHandler(this.btnAddOrganizer_Click);
            // 
            // btnUpdateOrganizer
            // 
            this.btnUpdateOrganizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnUpdateOrganizer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrganizer.ForeColor = System.Drawing.Color.Snow;
            this.btnUpdateOrganizer.Location = new System.Drawing.Point(330, 531);
            this.btnUpdateOrganizer.Name = "btnUpdateOrganizer";
            this.btnUpdateOrganizer.Size = new System.Drawing.Size(119, 42);
            this.btnUpdateOrganizer.TabIndex = 8;
            this.btnUpdateOrganizer.Text = "Update";
            this.btnUpdateOrganizer.UseVisualStyleBackColor = false;
            this.btnUpdateOrganizer.Click += new System.EventHandler(this.btnUpdateOrganizer_Click);
            // 
            // btnDeleteOrganizer
            // 
            this.btnDeleteOrganizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnDeleteOrganizer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrganizer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteOrganizer.Location = new System.Drawing.Point(799, 531);
            this.btnDeleteOrganizer.Name = "btnDeleteOrganizer";
            this.btnDeleteOrganizer.Size = new System.Drawing.Size(109, 42);
            this.btnDeleteOrganizer.TabIndex = 9;
            this.btnDeleteOrganizer.Text = "Delete";
            this.btnDeleteOrganizer.UseVisualStyleBackColor = false;
            this.btnDeleteOrganizer.Click += new System.EventHandler(this.btnDeleteOrganizer_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnParticipants.FlatAppearance.BorderSize = 0;
            this.btnParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnParticipants.Location = new System.Drawing.Point(63, 147);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(131, 30);
            this.btnParticipants.TabIndex = 10;
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
            this.btnAdmins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmins.Location = new System.Drawing.Point(69, 421);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(100, 30);
            this.btnAdmins.TabIndex = 11;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEvents.Location = new System.Drawing.Point(63, 237);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(100, 30);
            this.btnEvents.TabIndex = 13;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookings.Location = new System.Drawing.Point(63, 336);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(100, 30);
            this.btnBookings.TabIndex = 14;
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
            this.panel1.Controls.Add(this.btnEvents);
            this.panel1.Controls.Add(this.btnBookings);
            this.panel1.Controls.Add(this.btnAdmins);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 618);
            this.panel1.TabIndex = 15;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout_Click.Location = new System.Drawing.Point(75, 540);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(111, 33);
            this.btnLogout_Click.TabIndex = 20;
            this.btnLogout_Click.Text = "Logout";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::eventmanagement.Properties.Resources.administrator_male_30px2;
            this.pictureBox5.Location = new System.Drawing.Point(24, 421);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 50);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eventmanagement.Properties.Resources.registration_30px2;
            this.pictureBox4.Location = new System.Drawing.Point(24, 336);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 30);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eventmanagement.Properties.Resources.event_accepted_30px4;
            this.pictureBox3.Location = new System.Drawing.Point(24, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 40);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eventmanagement.Properties.Resources.conference_foreground_selected_30px4;
            this.pictureBox2.Location = new System.Drawing.Point(24, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 41);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eventmanagement.Properties.Resources.eventmanage_100px6;
            this.pictureBox1.Location = new System.Drawing.Point(63, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 110);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // Nic
            // 
            this.Nic.AutoSize = true;
            this.Nic.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nic.Location = new System.Drawing.Point(526, 427);
            this.Nic.Name = "Nic";
            this.Nic.Size = new System.Drawing.Size(34, 20);
            this.Nic.TabIndex = 20;
            this.Nic.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(772, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password";
            // 
            // OrganizerDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1158, 618);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Nic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewOrganizers);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAddOrganizer);
            this.Controls.Add(this.btnUpdateOrganizer);
            this.Controls.Add(this.btnDeleteOrganizer);
            this.Name = "OrganizerDashboardForm";
            this.Text = "Organizer Dashboard";
            this.Load += new System.EventHandler(this.OrganizerDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizers)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Nic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout_Click;
    }
}
