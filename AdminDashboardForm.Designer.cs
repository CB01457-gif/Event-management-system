namespace eventmanagement
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;

        // New buttons
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnOrganizers;
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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnOrganizers = new System.Windows.Forms.Button();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAdmin.EnableHeadersVisualStyles = false;
            this.dataGridViewAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewAdmin.Location = new System.Drawing.Point(328, 41);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 30;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(750, 332);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(416, 442);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 22);
            this.txtId.TabIndex = 1;
            this.txtId.UseWaitCursor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(640, 442);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(898, 442);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(407, 512);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(180, 22);
            this.txtNic.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(640, 512);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(909, 512);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnAddAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.Location = new System.Drawing.Point(440, 575);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(115, 36);
            this.btnAddAdmin.TabIndex = 7;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(690, 575);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateAdmin.TabIndex = 8;
            this.btnUpdateAdmin.Text = "Update";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(946, 575);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(112, 36);
            this.btnDeleteAdmin.TabIndex = 9;
            this.btnDeleteAdmin.Text = "Delete";
            this.btnDeleteAdmin.UseVisualStyleBackColor = false;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnParticipants.FlatAppearance.BorderSize = 0;
            this.btnParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipants.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnParticipants.Location = new System.Drawing.Point(91, 156);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(124, 30);
            this.btnParticipants.TabIndex = 10;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.UseVisualStyleBackColor = false;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnOrganizers
            // 
            this.btnOrganizers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnOrganizers.FlatAppearance.BorderSize = 0;
            this.btnOrganizers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizers.ForeColor = System.Drawing.Color.White;
            this.btnOrganizers.Location = new System.Drawing.Point(91, 237);
            this.btnOrganizers.Name = "btnOrganizers";
            this.btnOrganizers.Size = new System.Drawing.Size(124, 30);
            this.btnOrganizers.TabIndex = 12;
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
            this.btnEvents.Location = new System.Drawing.Point(100, 328);
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
            this.btnBookings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookings.Location = new System.Drawing.Point(100, 438);
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
            this.panel1.Controls.Add(this.btnOrganizers);
            this.panel1.Controls.Add(this.btnEvents);
            this.panel1.Controls.Add(this.btnBookings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 618);
            this.panel1.TabIndex = 15;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout_Click.Location = new System.Drawing.Point(91, 542);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(111, 33);
            this.btnLogout_Click.TabIndex = 20;
            this.btnLogout_Click.Text = "Logout";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::eventmanagement.Properties.Resources.registration_30px1;
            this.pictureBox5.Location = new System.Drawing.Point(43, 424);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 44);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eventmanagement.Properties.Resources.event_accepted_30px2;
            this.pictureBox4.Location = new System.Drawing.Point(43, 328);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 45);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eventmanagement.Properties.Resources.planning_skill_30px2;
            this.pictureBox3.Location = new System.Drawing.Point(43, 237);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 43);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eventmanagement.Properties.Resources.conference_foreground_selected_30px2;
            this.pictureBox2.Location = new System.Drawing.Point(43, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eventmanagement.Properties.Resources.eventmanage_100px4;
            this.pictureBox1.Location = new System.Drawing.Point(60, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 103);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(909, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(905, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(898, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email";
            // 
            // AdminDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1158, 618);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.btnUpdateAdmin);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Name = "AdminDashboardForm";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnLogout_Click;
    }
}
