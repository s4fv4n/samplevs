namespace sample1
{
    partial class FrmAddCustomer
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
            this.lblCstmrName = new System.Windows.Forms.Label();
            this.lblCstmrCountry = new System.Windows.Forms.Label();
            this.txtCstmrName = new System.Windows.Forms.TextBox();
            this.grpbxGender = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.chkbxReading = new System.Windows.Forms.CheckBox();
            this.chkbxPainting = new System.Windows.Forms.CheckBox();
            this.lblHobby = new System.Windows.Forms.Label();
            this.grpbxStatus = new System.Windows.Forms.GroupBox();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cBoxCountry = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpbxGender.SuspendLayout();
            this.grpbxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCstmrName
            // 
            this.lblCstmrName.AutoSize = true;
            this.lblCstmrName.Location = new System.Drawing.Point(21, 37);
            this.lblCstmrName.Name = "lblCstmrName";
            this.lblCstmrName.Size = new System.Drawing.Size(82, 13);
            this.lblCstmrName.TabIndex = 0;
            this.lblCstmrName.Text = "Customer Name";
            // 
            // lblCstmrCountry
            // 
            this.lblCstmrCountry.AutoSize = true;
            this.lblCstmrCountry.Location = new System.Drawing.Point(21, 73);
            this.lblCstmrCountry.Name = "lblCstmrCountry";
            this.lblCstmrCountry.Size = new System.Drawing.Size(90, 13);
            this.lblCstmrCountry.TabIndex = 1;
            this.lblCstmrCountry.Text = "Customer Country";
            this.lblCstmrCountry.Click += new System.EventHandler(this.lblCstmrCountry_Click);
            // 
            // txtCstmrName
            // 
            this.txtCstmrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCstmrName.Location = new System.Drawing.Point(155, 34);
            this.txtCstmrName.Name = "txtCstmrName";
            this.txtCstmrName.Size = new System.Drawing.Size(161, 24);
            this.txtCstmrName.TabIndex = 2;
            // 
            // grpbxGender
            // 
            this.grpbxGender.Controls.Add(this.rbtnFemale);
            this.grpbxGender.Controls.Add(this.rbtnMale);
            this.grpbxGender.Location = new System.Drawing.Point(24, 109);
            this.grpbxGender.Name = "grpbxGender";
            this.grpbxGender.Size = new System.Drawing.Size(292, 71);
            this.grpbxGender.TabIndex = 4;
            this.grpbxGender.TabStop = false;
            this.grpbxGender.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(131, 29);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(31, 29);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // chkbxReading
            // 
            this.chkbxReading.AutoSize = true;
            this.chkbxReading.Location = new System.Drawing.Point(85, 226);
            this.chkbxReading.Name = "chkbxReading";
            this.chkbxReading.Size = new System.Drawing.Size(66, 17);
            this.chkbxReading.TabIndex = 5;
            this.chkbxReading.Text = "Reading";
            this.chkbxReading.UseVisualStyleBackColor = true;
            // 
            // chkbxPainting
            // 
            this.chkbxPainting.AutoSize = true;
            this.chkbxPainting.Location = new System.Drawing.Point(201, 226);
            this.chkbxPainting.Name = "chkbxPainting";
            this.chkbxPainting.Size = new System.Drawing.Size(64, 17);
            this.chkbxPainting.TabIndex = 6;
            this.chkbxPainting.Text = "Painting";
            this.chkbxPainting.UseVisualStyleBackColor = true;
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(28, 197);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(52, 13);
            this.lblHobby.TabIndex = 7;
            this.lblHobby.Text = "Hobbies :";
            // 
            // grpbxStatus
            // 
            this.grpbxStatus.Controls.Add(this.rbtnSingle);
            this.grpbxStatus.Controls.Add(this.rbtnMarried);
            this.grpbxStatus.Location = new System.Drawing.Point(31, 270);
            this.grpbxStatus.Name = "grpbxStatus";
            this.grpbxStatus.Size = new System.Drawing.Size(292, 71);
            this.grpbxStatus.TabIndex = 8;
            this.grpbxStatus.TabStop = false;
            this.grpbxStatus.Text = "Status";
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Location = new System.Drawing.Point(131, 29);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(54, 17);
            this.rbtnSingle.TabIndex = 1;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Location = new System.Drawing.Point(31, 29);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(60, 17);
            this.rbtnMarried.TabIndex = 0;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Married";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(24, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 25);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cBoxCountry
            // 
            this.cBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCountry.FormattingEnabled = true;
            this.cBoxCountry.Items.AddRange(new object[] {
            "India",
            "USA",
            "Pakistan",
            "Russia",
            "SriLanka",
            "UAE",
            "Saudi Arabia",
            "New Zealand",
            "Jordan"});
            this.cBoxCountry.Location = new System.Drawing.Point(155, 66);
            this.cBoxCountry.Name = "cBoxCountry";
            this.cBoxCountry.Size = new System.Drawing.Size(161, 26);
            this.cBoxCountry.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 307);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(257, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 24);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(146, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 24);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 396);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBoxCountry);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpbxStatus);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.chkbxPainting);
            this.Controls.Add(this.chkbxReading);
            this.Controls.Add(this.grpbxGender);
            this.Controls.Add(this.txtCstmrName);
            this.Controls.Add(this.lblCstmrCountry);
            this.Controls.Add(this.lblCstmrName);
            this.Name = "FrmAddCustomer";
            this.Text = "Add Customer Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxGender.ResumeLayout(false);
            this.grpbxGender.PerformLayout();
            this.grpbxStatus.ResumeLayout(false);
            this.grpbxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCstmrName;
        private System.Windows.Forms.Label lblCstmrCountry;
        private System.Windows.Forms.TextBox txtCstmrName;
        private System.Windows.Forms.GroupBox grpbxGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.CheckBox chkbxReading;
        private System.Windows.Forms.CheckBox chkbxPainting;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.GroupBox grpbxStatus;
        private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cBoxCountry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

