namespace GiaoDien
{
    partial class Add_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User));
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.pn_add_user = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConPsw = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_confirm_addUser = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.pnVienDuoi = new System.Windows.Forms.Panel();
            this.lb_psw_addUser = new System.Windows.Forms.Label();
            this.txtUsname = new System.Windows.Forms.TextBox();
            this.lb_username_add = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_add_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.Brown;
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Image")));
            this.btnSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUser.Location = new System.Drawing.Point(117, 410);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(116, 59);
            this.btnSaveUser.TabIndex = 0;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.BackColor = System.Drawing.Color.Navy;
            this.btnCancelUser.FlatAppearance.BorderSize = 0;
            this.btnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUser.ForeColor = System.Drawing.Color.White;
            this.btnCancelUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelUser.Image")));
            this.btnCancelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelUser.Location = new System.Drawing.Point(288, 410);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(126, 59);
            this.btnCancelUser.TabIndex = 1;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelUser.UseVisualStyleBackColor = false;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // pn_add_user
            // 
            this.pn_add_user.Controls.Add(this.label3);
            this.pn_add_user.Controls.Add(this.label2);
            this.pn_add_user.Controls.Add(this.label1);
            this.pn_add_user.Controls.Add(this.panel2);
            this.pn_add_user.Controls.Add(this.txtConPsw);
            this.pn_add_user.Controls.Add(this.panel1);
            this.pn_add_user.Controls.Add(this.lb_confirm_addUser);
            this.pn_add_user.Controls.Add(this.txtPsw);
            this.pn_add_user.Controls.Add(this.pnVienDuoi);
            this.pn_add_user.Controls.Add(this.lb_psw_addUser);
            this.pn_add_user.Controls.Add(this.txtUsname);
            this.pn_add_user.Controls.Add(this.lb_username_add);
            this.pn_add_user.Location = new System.Drawing.Point(12, 50);
            this.pn_add_user.Name = "pn_add_user";
            this.pn_add_user.Size = new System.Drawing.Size(506, 339);
            this.pn_add_user.TabIndex = 2;
            this.pn_add_user.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_add_user_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(363, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(363, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(363, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(153, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 3);
            this.panel2.TabIndex = 8;
            // 
            // txtConPsw
            // 
            this.txtConPsw.BackColor = System.Drawing.SystemColors.Window;
            this.txtConPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPsw.Location = new System.Drawing.Point(156, 252);
            this.txtConPsw.Name = "txtConPsw";
            this.txtConPsw.PasswordChar = '*';
            this.txtConPsw.Size = new System.Drawing.Size(193, 25);
            this.txtConPsw.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(153, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 3);
            this.panel1.TabIndex = 5;
            // 
            // lb_confirm_addUser
            // 
            this.lb_confirm_addUser.AutoSize = true;
            this.lb_confirm_addUser.ForeColor = System.Drawing.Color.Crimson;
            this.lb_confirm_addUser.Location = new System.Drawing.Point(152, 215);
            this.lb_confirm_addUser.Name = "lb_confirm_addUser";
            this.lb_confirm_addUser.Size = new System.Drawing.Size(189, 23);
            this.lb_confirm_addUser.TabIndex = 6;
            this.lb_confirm_addUser.Text = "Confirm Password:";
            // 
            // txtPsw
            // 
            this.txtPsw.BackColor = System.Drawing.SystemColors.Window;
            this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPsw.Location = new System.Drawing.Point(156, 164);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(193, 25);
            this.txtPsw.TabIndex = 4;
            this.txtPsw.TextChanged += new System.EventHandler(this.txt_psw_add_user_TextChanged);
            // 
            // pnVienDuoi
            // 
            this.pnVienDuoi.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnVienDuoi.Location = new System.Drawing.Point(153, 90);
            this.pnVienDuoi.Name = "pnVienDuoi";
            this.pnVienDuoi.Size = new System.Drawing.Size(204, 3);
            this.pnVienDuoi.TabIndex = 2;
            // 
            // lb_psw_addUser
            // 
            this.lb_psw_addUser.AutoSize = true;
            this.lb_psw_addUser.ForeColor = System.Drawing.Color.Crimson;
            this.lb_psw_addUser.Location = new System.Drawing.Point(154, 124);
            this.lb_psw_addUser.Name = "lb_psw_addUser";
            this.lb_psw_addUser.Size = new System.Drawing.Size(106, 23);
            this.lb_psw_addUser.TabIndex = 3;
            this.lb_psw_addUser.Text = "Password:";
            // 
            // txtUsname
            // 
            this.txtUsname.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsname.Location = new System.Drawing.Point(156, 68);
            this.txtUsname.Name = "txtUsname";
            this.txtUsname.Size = new System.Drawing.Size(193, 25);
            this.txtUsname.TabIndex = 1;
            // 
            // lb_username_add
            // 
            this.lb_username_add.AutoSize = true;
            this.lb_username_add.ForeColor = System.Drawing.Color.Crimson;
            this.lb_username_add.Location = new System.Drawing.Point(154, 42);
            this.lb_username_add.Name = "lb_username_add";
            this.lb_username_add.Size = new System.Drawing.Size(114, 23);
            this.lb_username_add.TabIndex = 0;
            this.lb_username_add.Text = "Username:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 42);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pn_add_user);
            this.Controls.Add(this.btnCancelUser);
            this.Controls.Add(this.btnSaveUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_User";
            this.pn_add_user.ResumeLayout(false);
            this.pn_add_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.Panel pn_add_user;
        private System.Windows.Forms.Label lb_username_add;
        private System.Windows.Forms.Panel pnVienDuoi;
        private System.Windows.Forms.TextBox txtUsname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label lb_psw_addUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConPsw;
        private System.Windows.Forms.Label lb_confirm_addUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}