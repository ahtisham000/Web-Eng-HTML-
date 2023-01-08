namespace MessManagemenSystem
{
    partial class UIPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnItemTable = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateISearch = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSSearch = new System.Windows.Forms.TextBox();
            this.btnSupplierTable = new System.Windows.Forms.Button();
            this.txtIName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtIId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnISave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSUpdate = new System.Windows.Forms.Button();
            this.btnSSave = new System.Windows.Forms.Button();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.txtSCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSCnic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnIDelete = new System.Windows.Forms.Button();
            this.dateIDate = new System.Windows.Forms.DateTimePicker();
            this.txtIQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnSClear = new System.Windows.Forms.Button();
            this.btnIClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItemTable
            // 
            this.btnItemTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnItemTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemTable.FlatAppearance.BorderSize = 0;
            this.btnItemTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItemTable.Image = ((System.Drawing.Image)(resources.GetObject("btnItemTable.Image")));
            this.btnItemTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemTable.Location = new System.Drawing.Point(393, -6);
            this.btnItemTable.Name = "btnItemTable";
            this.btnItemTable.Size = new System.Drawing.Size(122, 39);
            this.btnItemTable.TabIndex = 19;
            this.btnItemTable.Text = "Item Table";
            this.btnItemTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemTable.UseVisualStyleBackColor = false;
            this.btnItemTable.Click += new System.EventHandler(this.btnItemTable_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(165, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 23);
            this.label13.TabIndex = 50;
            this.label13.Text = "    ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.panel1.Controls.Add(this.dateISearch);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtSSearch);
            this.panel1.Controls.Add(this.btnItemTable);
            this.panel1.Controls.Add(this.btnSupplierTable);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(12, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 30);
            this.panel1.TabIndex = 75;
            // 
            // dateISearch
            // 
            this.dateISearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateISearch.Location = new System.Drawing.Point(581, 3);
            this.dateISearch.Name = "dateISearch";
            this.dateISearch.Size = new System.Drawing.Size(119, 20);
            this.dateISearch.TabIndex = 20;
            this.dateISearch.ValueChanged += new System.EventHandler(this.dateISearch_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(534, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 23);
            this.label11.TabIndex = 73;
            this.label11.Text = "    ";
            // 
            // txtSSearch
            // 
            this.txtSSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSearch.Location = new System.Drawing.Point(209, 2);
            this.txtSSearch.Multiline = true;
            this.txtSSearch.Name = "txtSSearch";
            this.txtSSearch.Size = new System.Drawing.Size(141, 26);
            this.txtSSearch.TabIndex = 18;
            this.txtSSearch.Text = "Enter ID";
            this.txtSSearch.TextChanged += new System.EventHandler(this.txtSSearch_TextChanged);
            this.txtSSearch.Enter += new System.EventHandler(this.txtSSearch_Enter);
            // 
            // btnSupplierTable
            // 
            this.btnSupplierTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSupplierTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierTable.FlatAppearance.BorderSize = 0;
            this.btnSupplierTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupplierTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupplierTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierTable.Image")));
            this.btnSupplierTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierTable.Location = new System.Drawing.Point(10, -4);
            this.btnSupplierTable.Name = "btnSupplierTable";
            this.btnSupplierTable.Size = new System.Drawing.Size(150, 34);
            this.btnSupplierTable.TabIndex = 17;
            this.btnSupplierTable.Text = "Supplier Table";
            this.btnSupplierTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupplierTable.UseVisualStyleBackColor = false;
            this.btnSupplierTable.Click += new System.EventHandler(this.btnSupplierTable_Click);
            // 
            // txtIName
            // 
            this.txtIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIName.Location = new System.Drawing.Point(107, 56);
            this.txtIName.Name = "txtIName";
            this.txtIName.Size = new System.Drawing.Size(147, 22);
            this.txtIName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Item Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(568, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // txtIId
            // 
            this.txtIId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIId.Location = new System.Drawing.Point(107, 30);
            this.txtIId.Name = "txtIId";
            this.txtIId.Size = new System.Drawing.Size(147, 22);
            this.txtIId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Supplier ID";
            // 
            // btnISave
            // 
            this.btnISave.BackColor = System.Drawing.Color.Transparent;
            this.btnISave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnISave.FlatAppearance.BorderSize = 0;
            this.btnISave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnISave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnISave.Image = ((System.Drawing.Image)(resources.GetObject("btnISave.Image")));
            this.btnISave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnISave.Location = new System.Drawing.Point(251, 92);
            this.btnISave.Name = "btnISave";
            this.btnISave.Size = new System.Drawing.Size(85, 30);
            this.btnISave.TabIndex = 14;
            this.btnISave.Text = "Save";
            this.btnISave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnISave.UseVisualStyleBackColor = false;
            this.btnISave.Click += new System.EventHandler(this.btnISave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btnSClear);
            this.groupBox1.Controls.Add(this.btnSUpdate);
            this.groupBox1.Controls.Add(this.btnSSave);
            this.groupBox1.Controls.Add(this.btnSDelete);
            this.groupBox1.Controls.Add(this.txtSCategory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSCnic);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 137);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // btnSUpdate
            // 
            this.btnSUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnSUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSUpdate.FlatAppearance.BorderSize = 0;
            this.btnSUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnSUpdate.Image")));
            this.btnSUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSUpdate.Location = new System.Drawing.Point(445, 103);
            this.btnSUpdate.Name = "btnSUpdate";
            this.btnSUpdate.Size = new System.Drawing.Size(87, 34);
            this.btnSUpdate.TabIndex = 8;
            this.btnSUpdate.Text = "Update";
            this.btnSUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSUpdate.UseVisualStyleBackColor = false;
            this.btnSUpdate.Click += new System.EventHandler(this.btnSUpdate_Click);
            // 
            // btnSSave
            // 
            this.btnSSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSSave.FlatAppearance.BorderSize = 0;
            this.btnSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSSave.Image")));
            this.btnSSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSSave.Location = new System.Drawing.Point(237, 103);
            this.btnSSave.Name = "btnSSave";
            this.btnSSave.Size = new System.Drawing.Size(87, 34);
            this.btnSSave.TabIndex = 6;
            this.btnSSave.Text = "Save";
            this.btnSSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSSave.UseVisualStyleBackColor = false;
            this.btnSSave.Click += new System.EventHandler(this.btnSSave_Click);
            // 
            // btnSDelete
            // 
            this.btnSDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnSDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSDelete.FlatAppearance.BorderSize = 0;
            this.btnSDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSDelete.Image")));
            this.btnSDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDelete.Location = new System.Drawing.Point(340, 106);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(93, 29);
            this.btnSDelete.TabIndex = 7;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSDelete.UseVisualStyleBackColor = false;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // txtSCategory
            // 
            this.txtSCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCategory.Location = new System.Drawing.Point(107, 103);
            this.txtSCategory.Name = "txtSCategory";
            this.txtSCategory.Size = new System.Drawing.Size(112, 22);
            this.txtSCategory.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Category";
            // 
            // txtSPhone
            // 
            this.txtSPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPhone.Location = new System.Drawing.Point(357, 69);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(146, 22);
            this.txtSPhone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = " Phone #";
            // 
            // txtSCnic
            // 
            this.txtSCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCnic.Location = new System.Drawing.Point(107, 69);
            this.txtSCnic.Name = "txtSCnic";
            this.txtSCnic.Size = new System.Drawing.Size(147, 22);
            this.txtSCnic.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "CNIC";
            // 
            // txtSName
            // 
            this.txtSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSName.Location = new System.Drawing.Point(357, 31);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(146, 22);
            this.txtSName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Name";
            // 
            // txtSId
            // 
            this.txtSId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSId.Location = new System.Drawing.Point(107, 31);
            this.txtSId.Name = "txtSId";
            this.txtSId.Size = new System.Drawing.Size(147, 22);
            this.txtSId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Reg. ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.btnIClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnIDelete);
            this.groupBox2.Controls.Add(this.dateIDate);
            this.groupBox2.Controls.Add(this.txtIQuantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIAmount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnISave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 128);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Record";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(441, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 34);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnIDelete
            // 
            this.btnIDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnIDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIDelete.FlatAppearance.BorderSize = 0;
            this.btnIDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnIDelete.Image")));
            this.btnIDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIDelete.Location = new System.Drawing.Point(342, 93);
            this.btnIDelete.Name = "btnIDelete";
            this.btnIDelete.Size = new System.Drawing.Size(93, 29);
            this.btnIDelete.TabIndex = 15;
            this.btnIDelete.Text = "Delete";
            this.btnIDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIDelete.UseVisualStyleBackColor = false;
            this.btnIDelete.Click += new System.EventHandler(this.btnIDelete_Click);
            // 
            // dateIDate
            // 
            this.dateIDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIDate.Location = new System.Drawing.Point(396, 61);
            this.dateIDate.Name = "dateIDate";
            this.dateIDate.Size = new System.Drawing.Size(119, 22);
            this.dateIDate.TabIndex = 12;
            // 
            // txtIQuantity
            // 
            this.txtIQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIQuantity.Location = new System.Drawing.Point(393, 28);
            this.txtIQuantity.Name = "txtIQuantity";
            this.txtIQuantity.Size = new System.Drawing.Size(122, 22);
            this.txtIQuantity.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(287, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Date";
            // 
            // txtIAmount
            // 
            this.txtIAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIAmount.Location = new System.Drawing.Point(107, 89);
            this.txtIAmount.Name = "txtIAmount";
            this.txtIAmount.Size = new System.Drawing.Size(138, 22);
            this.txtIAmount.TabIndex = 13;
            this.txtIAmount.TextChanged += new System.EventHandler(this.txtIAmount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Amount";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvSupplier.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSupplier.ColumnHeadersHeight = 27;
            this.dgvSupplier.Location = new System.Drawing.Point(12, 329);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupplier.RowHeadersWidth = 45;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvSupplier.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSupplier.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSupplier.RowTemplate.Height = 45;
            this.dgvSupplier.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(724, 197);
            this.dgvSupplier.TabIndex = 71;
            // 
            // btnSClear
            // 
            this.btnSClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnSClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSClear.FlatAppearance.BorderSize = 0;
            this.btnSClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSClear.Location = new System.Drawing.Point(485, 0);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(47, 24);
            this.btnSClear.TabIndex = 74;
            this.btnSClear.Text = "Clear";
            this.btnSClear.UseVisualStyleBackColor = false;
            this.btnSClear.Click += new System.EventHandler(this.btnSClear_Click);
            // 
            // btnIClear
            // 
            this.btnIClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnIClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIClear.FlatAppearance.BorderSize = 0;
            this.btnIClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIClear.Location = new System.Drawing.Point(485, 0);
            this.btnIClear.Name = "btnIClear";
            this.btnIClear.Size = new System.Drawing.Size(47, 22);
            this.btnIClear.TabIndex = 76;
            this.btnIClear.Text = "Clear";
            this.btnIClear.UseVisualStyleBackColor = false;
            this.btnIClear.Click += new System.EventHandler(this.btnIClear_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(173)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSupplier);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(754, 529);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItemTable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupplierTable;
        private System.Windows.Forms.TextBox txtIName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtIId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnISave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtSCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSCnic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSUpdate;
        private System.Windows.Forms.Button btnSSave;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIDelete;
        private System.Windows.Forms.DateTimePicker dateIDate;
        private System.Windows.Forms.TextBox txtIQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSSearch;
        private System.Windows.Forms.DateTimePicker dateISearch;
        private System.Windows.Forms.Button btnSClear;
        private System.Windows.Forms.Button btnIClear;
    }
}
