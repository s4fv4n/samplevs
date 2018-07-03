namespace sample1
{
    partial class FrmcstmrPreview
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerCountry = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCstmrNameData = new System.Windows.Forms.Label();
            this.lblGenderData = new System.Windows.Forms.Label();
            this.lblStatusData = new System.Windows.Forms.Label();
            this.lblCstmrCountryData = new System.Windows.Forms.Label();
            this.lblHobbiesData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(12, 35);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(95, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerCountry
            // 
            this.lblCustomerCountry.AutoSize = true;
            this.lblCustomerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCountry.Location = new System.Drawing.Point(12, 73);
            this.lblCustomerCountry.Name = "lblCustomerCountry";
            this.lblCustomerCountry.Size = new System.Drawing.Size(106, 13);
            this.lblCustomerCountry.TabIndex = 1;
            this.lblCustomerCountry.Text = "Customer Country";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 110);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobbies.Location = new System.Drawing.Point(12, 146);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(53, 13);
            this.lblHobbies.TabIndex = 3;
            this.lblHobbies.Text = "Hobbies";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // lblCstmrNameData
            // 
            this.lblCstmrNameData.AutoSize = true;
            this.lblCstmrNameData.Location = new System.Drawing.Point(153, 35);
            this.lblCstmrNameData.Name = "lblCstmrNameData";
            this.lblCstmrNameData.Size = new System.Drawing.Size(0, 13);
            this.lblCstmrNameData.TabIndex = 5;
            // 
            // lblGenderData
            // 
            this.lblGenderData.AutoSize = true;
            this.lblGenderData.Location = new System.Drawing.Point(153, 110);
            this.lblGenderData.Name = "lblGenderData";
            this.lblGenderData.Size = new System.Drawing.Size(0, 13);
            this.lblGenderData.TabIndex = 6;
            // 
            // lblStatusData
            // 
            this.lblStatusData.AutoSize = true;
            this.lblStatusData.Location = new System.Drawing.Point(153, 181);
            this.lblStatusData.Name = "lblStatusData";
            this.lblStatusData.Size = new System.Drawing.Size(0, 13);
            this.lblStatusData.TabIndex = 8;
            // 
            // lblCstmrCountryData
            // 
            this.lblCstmrCountryData.AutoSize = true;
            this.lblCstmrCountryData.Location = new System.Drawing.Point(153, 73);
            this.lblCstmrCountryData.Name = "lblCstmrCountryData";
            this.lblCstmrCountryData.Size = new System.Drawing.Size(0, 13);
            this.lblCstmrCountryData.TabIndex = 9;
            // 
            // lblHobbiesData
            // 
            this.lblHobbiesData.AutoSize = true;
            this.lblHobbiesData.Location = new System.Drawing.Point(153, 146);
            this.lblHobbiesData.Name = "lblHobbiesData";
            this.lblHobbiesData.Size = new System.Drawing.Size(0, 13);
            this.lblHobbiesData.TabIndex = 7;
            // 
            // FrmcstmrPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 226);
            this.Controls.Add(this.lblCstmrCountryData);
            this.Controls.Add(this.lblStatusData);
            this.Controls.Add(this.lblHobbiesData);
            this.Controls.Add(this.lblGenderData);
            this.Controls.Add(this.lblCstmrNameData);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCustomerCountry);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FrmcstmrPreview";
            this.Text = "Customer Details Preview";
            this.Load += new System.EventHandler(this.FrmcstmrPreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerCountry;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCstmrNameData;
        private System.Windows.Forms.Label lblGenderData;
        private System.Windows.Forms.Label lblStatusData;
        private System.Windows.Forms.Label lblCstmrCountryData;
        private System.Windows.Forms.Label lblHobbiesData;
    }
}