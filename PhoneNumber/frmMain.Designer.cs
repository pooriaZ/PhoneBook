namespace PhoneNumber
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPartner = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnFamily = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnContactRemove = new System.Windows.Forms.Button();
            this.btnContactEdit = new System.Windows.Forms.Button();
            this.btnContactAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemTools,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuMain.Size = new System.Drawing.Size(1077, 28);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuItemTools
            // 
            this.mnuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddContacts});
            this.mnuItemTools.Name = "mnuItemTools";
            this.mnuItemTools.Size = new System.Drawing.Size(73, 24);
            this.mnuItemTools.Text = "options";
            // 
            // mnuItemAddContacts
            // 
            this.mnuItemAddContacts.Name = "mnuItemAddContacts";
            this.mnuItemAddContacts.Size = new System.Drawing.Size(224, 26);
            this.mnuItemAddContacts.Text = "افزودن مخاطب";
            this.mnuItemAddContacts.Click += new System.EventHandler(this.mnuItemAddContacts_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem1.Text = "change password";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItem2.Text = "buying software";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(90, 24);
            this.toolStripMenuItem3.Text = "contact us";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.RightToLeftAutoMirrorImage = true;
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem4.Text = "about us";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPartner);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnContactRemove);
            this.groupBox1.Controls.Add(this.btnContactEdit);
            this.groupBox1.Controls.Add(this.btnContactAdd);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(799, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(260, 555);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "options";
            // 
            // btnPartner
            // 
            this.btnPartner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartner.Location = new System.Drawing.Point(41, 273);
            this.btnPartner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPartner.Name = "btnPartner";
            this.btnPartner.Size = new System.Drawing.Size(183, 38);
            this.btnPartner.TabIndex = 4;
            this.btnPartner.Text = "partners";
            this.btnPartner.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEmergency);
            this.groupBox4.Controls.Add(this.btnFamily);
            this.groupBox4.Controls.Add(this.btnFriends);
            this.groupBox4.Location = new System.Drawing.Point(17, 229);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(229, 299);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "quick access";
            // 
            // btnEmergency
            // 
            this.btnEmergency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmergency.Location = new System.Drawing.Point(24, 231);
            this.btnEmergency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(183, 38);
            this.btnEmergency.TabIndex = 7;
            this.btnEmergency.Text = "emergency";
            this.btnEmergency.UseVisualStyleBackColor = true;
            // 
            // btnFamily
            // 
            this.btnFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamily.Location = new System.Drawing.Point(24, 170);
            this.btnFamily.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Size = new System.Drawing.Size(183, 38);
            this.btnFamily.TabIndex = 6;
            this.btnFamily.Text = "family";
            this.btnFamily.UseVisualStyleBackColor = true;
            // 
            // btnFriends
            // 
            this.btnFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFriends.Location = new System.Drawing.Point(24, 107);
            this.btnFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(183, 38);
            this.btnFriends.TabIndex = 5;
            this.btnFriends.Text = "friends";
            this.btnFriends.UseVisualStyleBackColor = true;
            // 
            // btnContactRemove
            // 
            this.btnContactRemove.Image = global::PhoneNumber.Properties.Resources.removeContact;
            this.btnContactRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactRemove.Location = new System.Drawing.Point(39, 161);
            this.btnContactRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContactRemove.Name = "btnContactRemove";
            this.btnContactRemove.Size = new System.Drawing.Size(183, 38);
            this.btnContactRemove.TabIndex = 2;
            this.btnContactRemove.Text = "delete contact";
            this.btnContactRemove.UseVisualStyleBackColor = true;
            this.btnContactRemove.Click += new System.EventHandler(this.btnContactRemove_Click);
            // 
            // btnContactEdit
            // 
            this.btnContactEdit.Image = global::PhoneNumber.Properties.Resources.EditContact;
            this.btnContactEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactEdit.Location = new System.Drawing.Point(39, 107);
            this.btnContactEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContactEdit.Name = "btnContactEdit";
            this.btnContactEdit.Size = new System.Drawing.Size(183, 38);
            this.btnContactEdit.TabIndex = 1;
            this.btnContactEdit.Text = "edit contact";
            this.btnContactEdit.UseVisualStyleBackColor = true;
            this.btnContactEdit.Click += new System.EventHandler(this.btnContactEdit_Click);
            // 
            // btnContactAdd
            // 
            this.btnContactAdd.Image = global::PhoneNumber.Properties.Resources.addContact;
            this.btnContactAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactAdd.Location = new System.Drawing.Point(39, 50);
            this.btnContactAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContactAdd.Name = "btnContactAdd";
            this.btnContactAdd.Size = new System.Drawing.Size(183, 38);
            this.btnContactAdd.TabIndex = 0;
            this.btnContactAdd.Text = "add contact";
            this.btnContactAdd.UseVisualStyleBackColor = true;
            this.btnContactAdd.Click += new System.EventHandler(this.btnContactAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(768, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "search";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "search text:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(281, 57);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(364, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 169);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(768, 425);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "contacts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 604);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "phone book";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTools;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddContacts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContactRemove;
        private System.Windows.Forms.Button btnContactEdit;
        private System.Windows.Forms.Button btnContactAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPartner;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Button btnFriends;
    }
}