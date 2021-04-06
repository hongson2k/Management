namespace GiaoDien
{
    partial class Grant_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grant_User));
            this.btnReturn_InGrant = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_user_txt1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.pnVienDuoi = new System.Windows.Forms.Panel();
            this.txt_edit_nameuser = new System.Windows.Forms.TextBox();
            this.lb_username_drop = new System.Windows.Forms.Label();
            this.dgv_in_EditUser = new System.Windows.Forms.DataGridView();
            this.btnGrant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_EditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn_InGrant
            // 
            this.btnReturn_InGrant.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReturn_InGrant.FlatAppearance.BorderSize = 0;
            this.btnReturn_InGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn_InGrant.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn_InGrant.Image")));
            this.btnReturn_InGrant.Location = new System.Drawing.Point(12, 12);
            this.btnReturn_InGrant.Name = "btnReturn_InGrant";
            this.btnReturn_InGrant.Size = new System.Drawing.Size(56, 42);
            this.btnReturn_InGrant.TabIndex = 24;
            this.btnReturn_InGrant.UseVisualStyleBackColor = false;
            this.btnReturn_InGrant.Click += new System.EventHandler(this.btnReturn_InGrant_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.list_user_txt1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(602, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 40);
            this.panel1.TabIndex = 23;
            // 
            // list_user_txt1
            // 
            this.list_user_txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.list_user_txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_user_txt1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_user_txt1.ForeColor = System.Drawing.Color.White;
            this.list_user_txt1.Location = new System.Drawing.Point(93, 8);
            this.list_user_txt1.Name = "list_user_txt1";
            this.list_user_txt1.Size = new System.Drawing.Size(238, 29);
            this.list_user_txt1.TabIndex = 10;
            this.list_user_txt1.Text = "User privilege list";
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
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Navy;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelEdit.Image")));
            this.btnCancelEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelEdit.Location = new System.Drawing.Point(423, 234);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(123, 48);
            this.btnCancelEdit.TabIndex = 22;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Brown;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(423, 63);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(123, 48);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // pnVienDuoi
            // 
            this.pnVienDuoi.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnVienDuoi.Location = new System.Drawing.Point(70, 195);
            this.pnVienDuoi.Name = "pnVienDuoi";
            this.pnVienDuoi.Size = new System.Drawing.Size(204, 3);
            this.pnVienDuoi.TabIndex = 20;
            // 
            // txt_edit_nameuser
            // 
            this.txt_edit_nameuser.BackColor = System.Drawing.SystemColors.Window;
            this.txt_edit_nameuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_edit_nameuser.Location = new System.Drawing.Point(73, 173);
            this.txt_edit_nameuser.Name = "txt_edit_nameuser";
            this.txt_edit_nameuser.Size = new System.Drawing.Size(193, 25);
            this.txt_edit_nameuser.TabIndex = 19;
            // 
            // lb_username_drop
            // 
            this.lb_username_drop.AutoSize = true;
            this.lb_username_drop.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username_drop.ForeColor = System.Drawing.Color.Crimson;
            this.lb_username_drop.Location = new System.Drawing.Point(71, 147);
            this.lb_username_drop.Name = "lb_username_drop";
            this.lb_username_drop.Size = new System.Drawing.Size(114, 23);
            this.lb_username_drop.TabIndex = 18;
            this.lb_username_drop.Text = "Username:";
            // 
            // dgv_in_EditUser
            // 
            this.dgv_in_EditUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_in_EditUser.Location = new System.Drawing.Point(602, 63);
            this.dgv_in_EditUser.Name = "dgv_in_EditUser";
            this.dgv_in_EditUser.RowHeadersWidth = 51;
            this.dgv_in_EditUser.RowTemplate.Height = 24;
            this.dgv_in_EditUser.Size = new System.Drawing.Size(623, 430);
            this.dgv_in_EditUser.TabIndex = 17;
            this.dgv_in_EditUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_in_EditUser_CellContentClick);
            this.dgv_in_EditUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_in_EditUser_CellDoubleClick);
            // 
            // btnGrant
            // 
            this.btnGrant.BackColor = System.Drawing.Color.Coral;
            this.btnGrant.FlatAppearance.BorderSize = 0;
            this.btnGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrant.ForeColor = System.Drawing.Color.White;
            this.btnGrant.Image = ((System.Drawing.Image)(resources.GetObject("btnGrant.Image")));
            this.btnGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrant.Location = new System.Drawing.Point(366, 143);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(180, 55);
            this.btnGrant.TabIndex = 25;
            this.btnGrant.Text = "Grant Roles";
            this.btnGrant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrant.UseVisualStyleBackColor = false;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // Grant_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 528);
            this.Controls.Add(this.btnGrant);
            this.Controls.Add(this.btnReturn_InGrant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.pnVienDuoi);
            this.Controls.Add(this.txt_edit_nameuser);
            this.Controls.Add(this.lb_username_drop);
            this.Controls.Add(this.dgv_in_EditUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grant_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_view";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_EditUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn_InGrant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox list_user_txt1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel pnVienDuoi;
        private System.Windows.Forms.TextBox txt_edit_nameuser;
        private System.Windows.Forms.Label lb_username_drop;
        private System.Windows.Forms.DataGridView dgv_in_EditUser;
        private System.Windows.Forms.Button btnGrant;
    }
}