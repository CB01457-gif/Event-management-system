namespace eventmanagement
{
    partial class ParticipantForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btnViewAllEvents = new System.Windows.Forms.Button();
            this.btnViewEnrolledEvents = new System.Windows.Forms.Button();
            this.txtEnrollEventId = new System.Windows.Forms.TextBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnUnenroll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.btnLogout_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(103, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User!";
            // 
            // dgvEvents
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvents.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEvents.EnableHeadersVisualStyles = false;
            this.dgvEvents.GridColor = System.Drawing.Color.LightGray;
            this.dgvEvents.Location = new System.Drawing.Point(310, 61);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 30;
            this.dgvEvents.Size = new System.Drawing.Size(868, 412);
            this.dgvEvents.TabIndex = 1;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // btnViewAllEvents
            // 
            this.btnViewAllEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnViewAllEvents.FlatAppearance.BorderSize = 0;
            this.btnViewAllEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllEvents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllEvents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewAllEvents.Location = new System.Drawing.Point(87, 204);
            this.btnViewAllEvents.Name = "btnViewAllEvents";
            this.btnViewAllEvents.Size = new System.Drawing.Size(150, 42);
            this.btnViewAllEvents.TabIndex = 2;
            this.btnViewAllEvents.Text = "View All Events";
            this.btnViewAllEvents.UseVisualStyleBackColor = false;
            this.btnViewAllEvents.Click += new System.EventHandler(this.btnViewAllEvents_Click);
            // 
            // btnViewEnrolledEvents
            // 
            this.btnViewEnrolledEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnViewEnrolledEvents.FlatAppearance.BorderSize = 0;
            this.btnViewEnrolledEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEnrolledEvents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEnrolledEvents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewEnrolledEvents.Location = new System.Drawing.Point(87, 295);
            this.btnViewEnrolledEvents.Name = "btnViewEnrolledEvents";
            this.btnViewEnrolledEvents.Size = new System.Drawing.Size(153, 40);
            this.btnViewEnrolledEvents.TabIndex = 3;
            this.btnViewEnrolledEvents.Text = "View Enrolled Events";
            this.btnViewEnrolledEvents.UseVisualStyleBackColor = false;
            this.btnViewEnrolledEvents.Click += new System.EventHandler(this.btnViewEnrolledEvents_Click);
            // 
            // txtEnrollEventId
            // 
            this.txtEnrollEventId.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollEventId.Location = new System.Drawing.Point(395, 546);
            this.txtEnrollEventId.Name = "txtEnrollEventId";
            this.txtEnrollEventId.Size = new System.Drawing.Size(120, 25);
            this.txtEnrollEventId.TabIndex = 4;
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnEnroll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnroll.Location = new System.Drawing.Point(395, 592);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(120, 49);
            this.btnEnroll.TabIndex = 5;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnUnenroll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnenroll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnenroll.Location = new System.Drawing.Point(548, 592);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(115, 49);
            this.btnUnenroll.TabIndex = 6;
            this.btnUnenroll.Text = "Unenroll";
            this.btnUnenroll.UseVisualStyleBackColor = false;
            this.btnUnenroll.Click += new System.EventHandler(this.btnUnenroll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnLogout_Click);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnViewAllEvents);
            this.panel1.Controls.Add(this.btnViewEnrolledEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 708);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eventmanagement.Properties.Resources.event_accepted_30px;
            this.pictureBox3.Location = new System.Drawing.Point(37, 295);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eventmanagement.Properties.Resources.event_accepted_tentatively_30px;
            this.pictureBox2.Location = new System.Drawing.Point(37, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eventmanagement.Properties.Resources.eventmanage_100px;
            this.pictureBox1.Location = new System.Drawing.Point(70, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 109);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(265, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 35);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Enroll/Unenroll Id";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout_Click.Location = new System.Drawing.Point(110, 538);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(111, 33);
            this.btnLogout_Click.TabIndex = 17;
            this.btnLogout_Click.Text = "Logout";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // ParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1275, 708);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUnenroll);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.txtEnrollEventId);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.lblWelcome);
            this.Name = "ParticipantForm";
            this.Text = "Participant Dashboard";
            this.Load += new System.EventHandler(this.ParticipantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.DataGridView dgvEvents; // Make sure this is public

        public System.Windows.Forms.TextBox txtEnrollEventId;
        public System.Windows.Forms.Button btnViewAllEvents;
        public System.Windows.Forms.Button btnViewEnrolledEvents;
        public System.Windows.Forms.Button btnEnroll;
        public System.Windows.Forms.Button btnUnenroll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogout_Click;
    }
}