using System.Drawing;

namespace eventmanagement
{
    partial class ParticipantDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.TextBox txtParticipantId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.Button btnUpdateParticipant;
        private System.Windows.Forms.Button btnDeleteParticipant;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnBookings;
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
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.txtParticipantId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.btnUpdateParticipant = new System.Windows.Forms.Button();
            this.btnDeleteParticipant = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnOrganizers = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParticipants
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParticipants.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewParticipants.EnableHeadersVisualStyles = false;
            this.dataGridViewParticipants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewParticipants.Location = new System.Drawing.Point(304, 39);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowTemplate.Height = 30;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(757, 346);
            this.dataGridViewParticipants.TabIndex = 0;
            this.dataGridViewParticipants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParticipants_CellClick);
            this.dataGridViewParticipants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParticipants_CellContentClick);
            // 
            // txtParticipantId
            // 
            this.txtParticipantId.Location = new System.Drawing.Point(365, 421);
            this.txtParticipantId.Name = "txtParticipantId";
            this.txtParticipantId.ReadOnly = true;
            this.txtParticipantId.Size = new System.Drawing.Size(180, 22);
            this.txtParticipantId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(624, 421);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(365, 504);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(624, 495);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(180, 22);
            this.txtNic.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(862, 421);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(862, 495);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnAddParticipant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParticipant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddParticipant.Location = new System.Drawing.Point(397, 551);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(115, 40);
            this.btnAddParticipant.TabIndex = 7;
            this.btnAddParticipant.Text = "Add";
            this.btnAddParticipant.UseVisualStyleBackColor = false;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // btnUpdateParticipant
            // 
            this.btnUpdateParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnUpdateParticipant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateParticipant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateParticipant.Location = new System.Drawing.Point(651, 551);
            this.btnUpdateParticipant.Name = "btnUpdateParticipant";
            this.btnUpdateParticipant.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateParticipant.TabIndex = 8;
            this.btnUpdateParticipant.Text = "Update";
            this.btnUpdateParticipant.UseVisualStyleBackColor = false;
            this.btnUpdateParticipant.Click += new System.EventHandler(this.btnUpdateParticipant_Click);
            // 
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnDeleteParticipant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteParticipant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteParticipant.Location = new System.Drawing.Point(894, 551);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(99, 40);
            this.btnDeleteParticipant.TabIndex = 9;
            this.btnDeleteParticipant.Text = "Delete";
            this.btnDeleteParticipant.UseVisualStyleBackColor = false;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmins.ForeColor = System.Drawing.Color.White;
            this.btnAdmins.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmins.Location = new System.Drawing.Point(82, 154);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(104, 33);
            this.btnAdmins.TabIndex = 11;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnBookings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookings.Location = new System.Drawing.Point(82, 247);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(117, 30);
            this.btnBookings.TabIndex = 12;
            this.btnBookings.Text = " Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnOrganizers
            // 
            this.btnOrganizers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnOrganizers.FlatAppearance.BorderSize = 0;
            this.btnOrganizers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrganizers.Location = new System.Drawing.Point(50, 334);
            this.btnOrganizers.Name = "btnOrganizers";
            this.btnOrganizers.Size = new System.Drawing.Size(178, 30);
            this.btnOrganizers.TabIndex = 13;
            this.btnOrganizers.Text = " Organizers";
            this.btnOrganizers.UseVisualStyleBackColor = false;
            this.btnOrganizers.Click += new System.EventHandler(this.btnOrganizers_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEvents.Location = new System.Drawing.Point(82, 424);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(89, 30);
            this.btnEvents.TabIndex = 14;
            this.btnEvents.Text = " Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
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
            this.panel1.Controls.Add(this.btnAdmins);
            this.panel1.Controls.Add(this.btnBookings);
            this.panel1.Controls.Add(this.btnOrganizers);
            this.panel1.Controls.Add(this.btnEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 618);
            this.panel1.TabIndex = 15;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout_Click.Location = new System.Drawing.Point(82, 517);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(111, 33);
            this.btnLogout_Click.TabIndex = 20;
            this.btnLogout_Click.Text = "Logout";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::eventmanagement.Properties.Resources.eventmanage_100px3;
            this.pictureBox5.Location = new System.Drawing.Point(50, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 100);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eventmanagement.Properties.Resources.event_accepted_tentatively_30px2;
            this.pictureBox4.Location = new System.Drawing.Point(30, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eventmanagement.Properties.Resources.planning_skill_30px1;
            this.pictureBox3.Location = new System.Drawing.Point(29, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eventmanagement.Properties.Resources.registration_30px;
            this.pictureBox2.Location = new System.Drawing.Point(30, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eventmanagement.Properties.Resources.administrator_male_30px;
            this.pictureBox1.Location = new System.Drawing.Point(30, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(872, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(872, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password";
            // 
            // ParticipantDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1158, 618);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewParticipants);
            this.Controls.Add(this.txtParticipantId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAddParticipant);
            this.Controls.Add(this.btnUpdateParticipant);
            this.Controls.Add(this.btnDeleteParticipant);
            this.Name = "ParticipantDashboardForm";
            this.Text = "Participant Management";
            this.Load += new System.EventHandler(this.ParticipantDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout_Click;
    }
}
