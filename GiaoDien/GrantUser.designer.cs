﻿namespace GiaoDien
{
    partial class GrantUser
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
            this.components = new System.ComponentModel.Container();
            this.tabGrantRole = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonGrant = new System.Windows.Forms.Button();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.tabSystemPrivileges = new System.Windows.Forms.TabPage();
            this.dgvSysPri = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGrantSelect = new System.Windows.Forms.Button();
            this.buttonGrantUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.dgvCol = new System.Windows.Forms.DataGridView();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.buttonApply = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabGrantRole.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabSystemPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysPri)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGrantRole
            // 
            this.tabGrantRole.Controls.Add(this.tabPage3);
            this.tabGrantRole.Controls.Add(this.tabSystemPrivileges);
            this.tabGrantRole.Controls.Add(this.tabPage1);
            this.tabGrantRole.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGrantRole.Location = new System.Drawing.Point(0, 3);
            this.tabGrantRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGrantRole.Name = "tabGrantRole";
            this.tabGrantRole.SelectedIndex = 0;
            this.tabGrantRole.Size = new System.Drawing.Size(1509, 609);
            this.tabGrantRole.TabIndex = 0;
            this.tabGrantRole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabGrantRole_MouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonGrant);
            this.tabPage3.Controls.Add(this.dgvRole);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1605, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grant Roles";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // buttonGrant
            // 
            this.buttonGrant.Location = new System.Drawing.Point(158, 565);
            this.buttonGrant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGrant.Name = "buttonGrant";
            this.buttonGrant.Size = new System.Drawing.Size(112, 33);
            this.buttonGrant.TabIndex = 1;
            this.buttonGrant.Text = "Granted";
            this.buttonGrant.UseVisualStyleBackColor = true;
            this.buttonGrant.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Location = new System.Drawing.Point(302, 18);
            this.dgvRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 51;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(813, 514);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellContentClick);
            // 
            // tabSystemPrivileges
            // 
            this.tabSystemPrivileges.Controls.Add(this.dgvSysPri);
            this.tabSystemPrivileges.Location = new System.Drawing.Point(4, 36);
            this.tabSystemPrivileges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSystemPrivileges.Name = "tabSystemPrivileges";
            this.tabSystemPrivileges.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSystemPrivileges.Size = new System.Drawing.Size(1605, 555);
            this.tabSystemPrivileges.TabIndex = 3;
            this.tabSystemPrivileges.Text = "System Privileges";
            this.tabSystemPrivileges.UseVisualStyleBackColor = true;
            // 
            // dgvSysPri
            // 
            this.dgvSysPri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysPri.Location = new System.Drawing.Point(285, 24);
            this.dgvSysPri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSysPri.Name = "dgvSysPri";
            this.dgvSysPri.RowHeadersWidth = 51;
            this.dgvSysPri.RowTemplate.Height = 24;
            this.dgvSysPri.Size = new System.Drawing.Size(844, 510);
            this.dgvSysPri.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtTable);
            this.tabPage1.Controls.Add(this.dgvCol);
            this.tabPage1.Controls.Add(this.dgvTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1501, 569);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Object Privileges";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGrantSelect
            // 
            this.buttonGrantSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.buttonGrantSelect.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrantSelect.ForeColor = System.Drawing.Color.White;
            this.buttonGrantSelect.Location = new System.Drawing.Point(17, 10);
            this.buttonGrantSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGrantSelect.Name = "buttonGrantSelect";
            this.buttonGrantSelect.Size = new System.Drawing.Size(190, 65);
            this.buttonGrantSelect.TabIndex = 5;
            this.buttonGrantSelect.Text = "Grant Select";
            this.buttonGrantSelect.UseVisualStyleBackColor = false;
            this.buttonGrantSelect.Click += new System.EventHandler(this.buttonGrantSelect_Click);
            // 
            // buttonGrantUpdate
            // 
            this.buttonGrantUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.buttonGrantUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrantUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonGrantUpdate.Location = new System.Drawing.Point(254, 11);
            this.buttonGrantUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGrantUpdate.Name = "buttonGrantUpdate";
            this.buttonGrantUpdate.Size = new System.Drawing.Size(197, 65);
            this.buttonGrantUpdate.TabIndex = 4;
            this.buttonGrantUpdate.Text = "Grant Update";
            this.buttonGrantUpdate.UseVisualStyleBackColor = false;
            this.buttonGrantUpdate.Click += new System.EventHandler(this.buttonGrantUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1037, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "TABLE: ";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(1149, 24);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(309, 36);
            this.txtTable.TabIndex = 2;
            // 
            // dgvCol
            // 
            this.dgvCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCol.Location = new System.Drawing.Point(957, 65);
            this.dgvCol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCol.Name = "dgvCol";
            this.dgvCol.RowHeadersWidth = 51;
            this.dgvCol.RowTemplate.Height = 24;
            this.dgvCol.Size = new System.Drawing.Size(511, 379);
            this.dgvCol.TabIndex = 1;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(9, 65);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(925, 379);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(1300, 620);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(187, 57);
            this.buttonApply.TabIndex = 15;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGrantSelect);
            this.panel1.Controls.Add(this.buttonGrantUpdate);
            this.panel1.Location = new System.Drawing.Point(989, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 88);
            this.panel1.TabIndex = 6;
            // 
            // GrantUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 696);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.tabGrantRole);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GrantUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant User";
            this.tabGrantRole.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.tabSystemPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysPri)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGrantRole;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabSystemPrivileges;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.Button buttonGrant;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvSysPri;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonGrantUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.DataGridView dgvCol;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button buttonGrantSelect;
        private System.Windows.Forms.Panel panel1;
    }
}