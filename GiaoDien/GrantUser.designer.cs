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
            this.tabGrantRole.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabSystemPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysPri)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGrantRole
            // 
            this.tabGrantRole.Controls.Add(this.tabPage3);
            this.tabGrantRole.Controls.Add(this.tabSystemPrivileges);
            this.tabGrantRole.Controls.Add(this.tabPage1);
            this.tabGrantRole.Location = new System.Drawing.Point(0, 2);
            this.tabGrantRole.Name = "tabGrantRole";
            this.tabGrantRole.SelectedIndex = 0;
            this.tabGrantRole.Size = new System.Drawing.Size(994, 407);
            this.tabGrantRole.TabIndex = 0;
            this.tabGrantRole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabGrantRole_MouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonGrant);
            this.tabPage3.Controls.Add(this.dgvRole);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grant Roles";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // buttonGrant
            // 
            this.buttonGrant.Location = new System.Drawing.Point(105, 393);
            this.buttonGrant.Name = "buttonGrant";
            this.buttonGrant.Size = new System.Drawing.Size(75, 23);
            this.buttonGrant.TabIndex = 1;
            this.buttonGrant.Text = "Granted";
            this.buttonGrant.UseVisualStyleBackColor = true;
            this.buttonGrant.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Location = new System.Drawing.Point(0, 3);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 51;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(542, 367);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellContentClick);
            // 
            // tabSystemPrivileges
            // 
            this.tabSystemPrivileges.Controls.Add(this.dgvSysPri);
            this.tabSystemPrivileges.Location = new System.Drawing.Point(4, 25);
            this.tabSystemPrivileges.Name = "tabSystemPrivileges";
            this.tabSystemPrivileges.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemPrivileges.Size = new System.Drawing.Size(986, 378);
            this.tabSystemPrivileges.TabIndex = 3;
            this.tabSystemPrivileges.Text = "System Privileges";
            this.tabSystemPrivileges.UseVisualStyleBackColor = true;
            // 
            // dgvSysPri
            // 
            this.dgvSysPri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysPri.Location = new System.Drawing.Point(3, 3);
            this.dgvSysPri.Name = "dgvSysPri";
            this.dgvSysPri.RowHeadersWidth = 51;
            this.dgvSysPri.RowTemplate.Height = 24;
            this.dgvSysPri.Size = new System.Drawing.Size(564, 369);
            this.dgvSysPri.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGrantSelect);
            this.tabPage1.Controls.Add(this.buttonGrantUpdate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtTable);
            this.tabPage1.Controls.Add(this.dgvCol);
            this.tabPage1.Controls.Add(this.dgvTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 378);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Object Privileges";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGrantSelect
            // 
            this.buttonGrantSelect.Location = new System.Drawing.Point(668, 321);
            this.buttonGrantSelect.Name = "buttonGrantSelect";
            this.buttonGrantSelect.Size = new System.Drawing.Size(75, 45);
            this.buttonGrantSelect.TabIndex = 5;
            this.buttonGrantSelect.Text = "Grant Select";
            this.buttonGrantSelect.UseVisualStyleBackColor = true;
            this.buttonGrantSelect.Click += new System.EventHandler(this.buttonGrantSelect_Click);
            // 
            // buttonGrantUpdate
            // 
            this.buttonGrantUpdate.Location = new System.Drawing.Point(905, 319);
            this.buttonGrantUpdate.Name = "buttonGrantUpdate";
            this.buttonGrantUpdate.Size = new System.Drawing.Size(75, 48);
            this.buttonGrantUpdate.TabIndex = 4;
            this.buttonGrantUpdate.Text = "Grant Update";
            this.buttonGrantUpdate.UseVisualStyleBackColor = true;
            this.buttonGrantUpdate.Click += new System.EventHandler(this.buttonGrantUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "TABLE: ";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(731, 0);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(221, 22);
            this.txtTable.TabIndex = 2;
            // 
            // dgvCol
            // 
            this.dgvCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCol.Location = new System.Drawing.Point(668, 32);
            this.dgvCol.Name = "dgvCol";
            this.dgvCol.RowHeadersWidth = 51;
            this.dgvCol.RowTemplate.Height = 24;
            this.dgvCol.Size = new System.Drawing.Size(312, 281);
            this.dgvCol.TabIndex = 1;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(0, 7);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(605, 306);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(356, 415);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 32);
            this.buttonApply.TabIndex = 15;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GrantUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 490);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.tabGrantRole);
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
    }
}