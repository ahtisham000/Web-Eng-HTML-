namespace MessManagemenSystem
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCGender = new System.Windows.Forms.ComboBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.dateCDateOfJoin = new System.Windows.Forms.DateTimePicker();
            this.txtCUnit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCClear = new System.Windows.Forms.Button();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCCity = new System.Windows.Forms.TextBox();
            this.btnCSave = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnTSoldUnit = new System.Windows.Forms.Button();
            this.textSUSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateSUSearch = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCGender
            // 
            this.cmbCGender.FormattingEnabled = true;
            this.cmbCGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbCGender.Location = new System.Drawing.Point(332, 194);
            this.cmbCGender.Name = "cmbCGender";
            this.cmbCGender.Size = new System.Drawing.Size(131, 26);
            this.cmbCGender.TabIndex = 7;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(15, -3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(154, 39);
            this.btnCustomer.TabIndex = 12;
            this.btnCustomer.Text = "  Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.panel1.Controls.Add(this.dateSUSearch);
            this.panel1.Controls.Add(this.textSUSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTSoldUnit);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 30);
            this.panel1.TabIndex = 30;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(211, 1);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(125, 26);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "Enter ID";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(175, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 23);
            this.label13.TabIndex = 50;
            this.label13.Text = "    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Phone #";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPhone.Location = new System.Drawing.Point(331, 94);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(131, 22);
            this.txtCPhone.TabIndex = 4;
            // 
            // dateCDateOfJoin
            // 
            this.dateCDateOfJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCDateOfJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCDateOfJoin.Location = new System.Drawing.Point(100, 193);
            this.dateCDateOfJoin.Name = "dateCDateOfJoin";
            this.dateCDateOfJoin.Size = new System.Drawing.Size(124, 20);
            this.dateCDateOfJoin.TabIndex = 5;
            // 
            // txtCUnit
            // 
            this.txtCUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUnit.Location = new System.Drawing.Point(100, 237);
            this.txtCUnit.Name = "txtCUnit";
            this.txtCUnit.Size = new System.Drawing.Size(131, 22);
            this.txtCUnit.TabIndex = 8;
            this.txtCUnit.TextChanged += new System.EventHandler(this.txtCUnit_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCClear);
            this.groupBox1.Controls.Add(this.btnCUpdate);
            this.groupBox1.Controls.Add(this.cmbCGender);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCPhone);
            this.groupBox1.Controls.Add(this.dateCDateOfJoin);
            this.groupBox1.Controls.Add(this.txtCUnit);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCCity);
            this.groupBox1.Controls.Add(this.btnCSave);
            this.groupBox1.Controls.Add(this.btnCDelete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCId);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 301);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Customer Details";
            // 
            // btnCClear
            // 
            this.btnCClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnCClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCClear.FlatAppearance.BorderSize = 0;
            this.btnCClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCClear.Location = new System.Drawing.Point(417, 9);
            this.btnCClear.Name = "btnCClear";
            this.btnCClear.Size = new System.Drawing.Size(50, 27);
            this.btnCClear.TabIndex = 63;
            this.btnCClear.Text = "Clear";
            this.btnCClear.UseVisualStyleBackColor = false;
            this.btnCClear.Click += new System.EventHandler(this.btnCClear_Click);
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnCUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCUpdate.FlatAppearance.BorderSize = 0;
            this.btnCUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCUpdate.Image")));
            this.btnCUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCUpdate.Location = new System.Drawing.Point(270, 266);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnCUpdate.TabIndex = 11;
            this.btnCUpdate.Text = "Update";
            this.btnCUpdate.UseVisualStyleBackColor = false;
            this.btnCUpdate.Click += new System.EventHandler(this.btnCUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Buy Units";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(257, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "City";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAddress.Location = new System.Drawing.Point(100, 94);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(130, 71);
            this.txtCAddress.TabIndex = 3;
            this.txtCAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "DO Join";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Address";
            // 
            // txtCCity
            // 
            this.txtCCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCity.Location = new System.Drawing.Point(332, 149);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(130, 22);
            this.txtCCity.TabIndex = 6;
            // 
            // btnCSave
            // 
            this.btnCSave.BackColor = System.Drawing.Color.Transparent;
            this.btnCSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSave.FlatAppearance.BorderSize = 0;
            this.btnCSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSave.Image = ((System.Drawing.Image)(resources.GetObject("btnCSave.Image")));
            this.btnCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSave.Location = new System.Drawing.Point(14, 266);
            this.btnCSave.Name = "btnCSave";
            this.btnCSave.Size = new System.Drawing.Size(117, 34);
            this.btnCSave.TabIndex = 9;
            this.btnCSave.Text = "Save";
            this.btnCSave.UseVisualStyleBackColor = false;
            this.btnCSave.Click += new System.EventHandler(this.btnCSave_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnCDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCDelete.FlatAppearance.BorderSize = 0;
            this.btnCDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCDelete.Image")));
            this.btnCDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDelete.Location = new System.Drawing.Point(137, 266);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(127, 34);
            this.btnCDelete.TabIndex = 10;
            this.btnCDelete.Text = "Delete";
            this.btnCDelete.UseVisualStyleBackColor = false;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Reg. #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // txtCId
            // 
            this.txtCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCId.Location = new System.Drawing.Point(99, 48);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(131, 22);
            this.txtCId.TabIndex = 1;
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(332, 50);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(130, 22);
            this.txtCName.TabIndex = 2;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomer.ColumnHeadersHeight = 27;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 335);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomer.RowHeadersWidth = 45;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.RowTemplate.Height = 45;
            this.dgvCustomer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(754, 173);
            this.dgvCustomer.TabIndex = 29;
            this.dgvCustomer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomer_CellMouseClick);
            // 
            // btnTSoldUnit
            // 
            this.btnTSoldUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTSoldUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTSoldUnit.FlatAppearance.BorderSize = 0;
            this.btnTSoldUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSoldUnit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSoldUnit.ForeColor = System.Drawing.Color.White;
            this.btnTSoldUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnTSoldUnit.Image")));
            this.btnTSoldUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTSoldUnit.Location = new System.Drawing.Point(351, -6);
            this.btnTSoldUnit.Name = "btnTSoldUnit";
            this.btnTSoldUnit.Size = new System.Drawing.Size(149, 39);
            this.btnTSoldUnit.TabIndex = 51;
            this.btnTSoldUnit.Text = "  Sale Record";
            this.btnTSoldUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTSoldUnit.UseVisualStyleBackColor = false;
            this.btnTSoldUnit.Click += new System.EventHandler(this.btnTSoldUnit_Click);
            // 
            // textSUSearch
            // 
            this.textSUSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSUSearch.Location = new System.Drawing.Point(542, 1);
            this.textSUSearch.Multiline = true;
            this.textSUSearch.Name = "textSUSearch";
            this.textSUSearch.Size = new System.Drawing.Size(85, 26);
            this.textSUSearch.TabIndex = 52;
            this.textSUSearch.Text = "Enter ID";
            this.textSUSearch.TextChanged += new System.EventHandler(this.textSUSearch_TextChanged);
            this.textSUSearch.Enter += new System.EventHandler(this.textSUSearch_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(506, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "    ";
            // 
            // dateSUSearch
            // 
            this.dateSUSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSUSearch.Location = new System.Drawing.Point(632, 4);
            this.dateSUSearch.Name = "dateSUSearch";
            this.dateSUSearch.Size = new System.Drawing.Size(119, 20);
            this.dateSUSearch.TabIndex = 54;
            this.dateSUSearch.ValueChanged += new System.EventHandler(this.dateSUSearch_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(489, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(173)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(754, 529);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCGender;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.DateTimePicker dateCDateOfJoin;
        private System.Windows.Forms.TextBox txtCUnit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtCAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCCity;
        private System.Windows.Forms.Button btnCSave;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCClear;
        private System.Windows.Forms.TextBox textSUSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTSoldUnit;
        private System.Windows.Forms.DateTimePicker dateSUSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
