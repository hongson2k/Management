namespace GiaoDien
{
    partial class Edit_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_user_txt1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_in_EditUser = new System.Windows.Forms.DataGridView();
            this.pn_edit_user = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEditConPsw = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_confirm_addUser = new System.Windows.Forms.Label();
            this.txt_EditPsw = new System.Windows.Forms.TextBox();
            this.pnVienDuoi = new System.Windows.Forms.Panel();
            this.lb_psw_addUser = new System.Windows.Forms.Label();
            this.txtEdit_username = new System.Windows.Forms.TextBox();
            this.lb_username_add = new System.Windows.Forms.Label();
            this.btnReturn_InDrop = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEdit_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_EditUser)).BeginInit();
            this.pn_edit_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.list_user_txt1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(406, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 40);
            this.panel1.TabIndex = 25;
            // 
            // list_user_txt1
            // 
            this.list_user_txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.list_user_txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_user_txt1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_user_txt1.ForeColor = System.Drawing.Color.White;
            this.list_user_txt1.Location = new System.Drawing.Point(93, 8);
            this.list_user_txt1.Name = "list_user_txt1";
            this.list_user_txt1.Size = new System.Drawing.Size(100, 29);
            this.list_user_txt1.TabIndex = 10;
            this.list_user_txt1.Text = "Users List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_in_EditUser
            // 
            this.dgv_in_EditUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_in_EditUser.Location = new System.Drawing.Point(406, 80);
            this.dgv_in_EditUser.Name = "dgv_in_EditUser";
            this.dgv_in_EditUser.RowHeadersWidth = 51;
            this.dgv_in_EditUser.RowTemplate.Height = 24;
            this.dgv_in_EditUser.Size = new System.Drawing.Size(623, 430);
            this.dgv_in_EditUser.TabIndex = 24;
            this.dgv_in_EditUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_in_EditUser_CellDoubleClick);
            // 
            // pn_edit_user
            // 
            this.pn_edit_user.Controls.Add(this.label3);
            this.pn_edit_user.Controls.Add(this.label2);
            this.pn_edit_user.Controls.Add(this.label1);
            this.pn_edit_user.Controls.Add(this.panel2);
            this.pn_edit_user.Controls.Add(this.txtEditConPsw);
            this.pn_edit_user.Controls.Add(this.panel3);
            this.pn_edit_user.Controls.Add(this.lb_confirm_addUser);
            this.pn_edit_user.Controls.Add(this.txt_EditPsw);
            this.pn_edit_user.Controls.Add(this.pnVienDuoi);
            this.pn_edit_user.Controls.Add(this.lb_psw_addUser);
            this.pn_edit_user.Controls.Add(this.txtEdit_username);
            this.pn_edit_user.Controls.Add(this.lb_username_add);
            this.pn_edit_user.Location = new System.Drawing.Point(35, 80);
            this.pn_edit_user.Name = "pn_edit_user";
            this.pn_edit_user.Size = new System.Drawing.Size(290, 339);
            this.pn_edit_user.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(240, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(240, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(240, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(30, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 3);
            this.panel2.TabIndex = 8;
            // 
            // txtEditConPsw
            // 
            this.txtEditConPsw.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditConPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditConPsw.Location = new System.Drawing.Point(33, 240);
            this.txtEditConPsw.Name = "txtEditConPsw";
            this.txtEditConPsw.PasswordChar = '*';
            this.txtEditConPsw.Size = new System.Drawing.Size(193, 25);
            this.txtEditConPsw.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(30, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 3);
            this.panel3.TabIndex = 5;
            // 
            // lb_confirm_addUser
            // 
            this.lb_confirm_addUser.AutoSize = true;
            this.lb_confirm_addUser.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm_addUser.ForeColor = System.Drawing.Color.Crimson;
            this.lb_confirm_addUser.Location = new System.Drawing.Point(29, 203);
            this.lb_confirm_addUser.Name = "lb_confirm_addUser";
            this.lb_confirm_addUser.Size = new System.Drawing.Size(189, 23);
            this.lb_confirm_addUser.TabIndex = 6;
            this.lb_confirm_addUser.Text = "Confirm Password:";
            // 
            // txt_EditPsw
            // 
            this.txt_EditPsw.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EditPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EditPsw.Location = new System.Drawing.Point(33, 152);
            this.txt_EditPsw.Name = "txt_EditPsw";
            this.txt_EditPsw.PasswordChar = '*';
            this.txt_EditPsw.Size = new System.Drawing.Size(193, 25);
            this.txt_EditPsw.TabIndex = 4;
            // 
            // pnVienDuoi
            // 
            this.pnVienDuoi.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnVienDuoi.Location = new System.Drawing.Point(30, 78);
            this.pnVienDuoi.Name = "pnVienDuoi";
            this.pnVienDuoi.Size = new System.Drawing.Size(204, 3);
            this.pnVienDuoi.TabIndex = 2;
            // 
            // lb_psw_addUser
            // 
            this.lb_psw_addUser.AutoSize = true;
            this.lb_psw_addUser.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_psw_addUser.ForeColor = System.Drawing.Color.Crimson;
            this.lb_psw_addUser.Location = new System.Drawing.Point(31, 112);
            this.lb_psw_addUser.Name = "lb_psw_addUser";
            this.lb_psw_addUser.Size = new System.Drawing.Size(156, 23);
            this.lb_psw_addUser.TabIndex = 3;
            this.lb_psw_addUser.Text = "New Password:";
            // 
            // txtEdit_username
            // 
            this.txtEdit_username.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdit_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdit_username.Location = new System.Drawing.Point(33, 56);
            this.txtEdit_username.Name = "txtEdit_username";
            this.txtEdit_username.Size = new System.Drawing.Size(193, 25);
            this.txtEdit_username.TabIndex = 1;
            // 
            // lb_username_add
            // 
            this.lb_username_add.AutoSize = true;
            this.lb_username_add.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username_add.ForeColor = System.Drawing.Color.Crimson;
            this.lb_username_add.Location = new System.Drawing.Point(31, 30);
            this.lb_username_add.Name = "lb_username_add";
            this.lb_username_add.Size = new System.Drawing.Size(114, 23);
            this.lb_username_add.TabIndex = 0;
            this.lb_username_add.Text = "Username:";
            // 
            // btnReturn_InDrop
            // 
            this.btnReturn_InDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnReturn_InDrop.FlatAppearance.BorderSize = 0;
            this.btnReturn_InDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn_InDrop.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn_InDrop.Image")));
            this.btnReturn_InDrop.Location = new System.Drawing.Point(12, 12);
            this.btnReturn_InDrop.Name = "btnReturn_InDrop";
            this.btnReturn_InDrop.Size = new System.Drawing.Size(56, 42);
            this.btnReturn_InDrop.TabIndex = 27;
            this.btnReturn_InDrop.UseVisualStyleBackColor = false;
            this.btnReturn_InDrop.Click += new System.EventHandler(this.btnReturn_InDrop_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.Navy;
            this.btnEditCancel.FlatAppearance.BorderSize = 0;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.ForeColor = System.Drawing.Color.White;
            this.btnEditCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCancel.Image")));
            this.btnEditCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCancel.Location = new System.Drawing.Point(206, 441);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(126, 59);
            this.btnEditCancel.TabIndex = 29;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCancel.UseVisualStyleBackColor = false;
            // 
            // btnEdit_Save
            // 
            this.btnEdit_Save.BackColor = System.Drawing.Color.Brown;
            this.btnEdit_Save.FlatAppearance.BorderSize = 0;
            this.btnEdit_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Save.ForeColor = System.Drawing.Color.White;
            this.btnEdit_Save.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit_Save.Image")));
            this.btnEdit_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit_Save.Location = new System.Drawing.Point(35, 441);
            this.btnEdit_Save.Name = "btnEdit_Save";
            this.btnEdit_Save.Size = new System.Drawing.Size(116, 59);
            this.btnEdit_Save.TabIndex = 28;
            this.btnEdit_Save.Text = "Save";
            this.btnEdit_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit_Save.UseVisualStyleBackColor = false;
            this.btnEdit_Save.Click += new System.EventHandler(this.btnEdit_Save_Click);
            // 
            // Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 549);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEdit_Save);
            this.Controls.Add(this.btnReturn_InDrop);
            this.Controls.Add(this.pn_edit_user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_in_EditUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Edit_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_EditUser)).EndInit();
            this.pn_edit_user.ResumeLayout(false);
            this.pn_edit_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox list_user_txt1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_in_EditUser;
        private System.Windows.Forms.Panel pn_edit_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEditConPsw;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_confirm_addUser;
        private System.Windows.Forms.TextBox txt_EditPsw;
        private System.Windows.Forms.Panel pnVienDuoi;
        private System.Windows.Forms.Label lb_psw_addUser;
        private System.Windows.Forms.TextBox txtEdit_username;
        private System.Windows.Forms.Label lb_username_add;
        private System.Windows.Forms.Button btnReturn_InDrop;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEdit_Save;
    }
}