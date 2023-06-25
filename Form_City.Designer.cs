
namespace ADBTeamImp_DB4O
{
    partial class Form_City
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_CityID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.textBox_CityID = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dataGridView_City = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_City)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CityID
            // 
            this.label_CityID.AutoSize = true;
            this.label_CityID.Location = new System.Drawing.Point(12, 12);
            this.label_CityID.Name = "label_CityID";
            this.label_CityID.Size = new System.Drawing.Size(65, 25);
            this.label_CityID.TabIndex = 0;
            this.label_CityID.Text = "City ID";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 49);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(59, 25);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Location = new System.Drawing.Point(12, 86);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(75, 25);
            this.label_Country.TabIndex = 2;
            this.label_Country.Text = "Country";
            // 
            // textBox_CityID
            // 
            this.textBox_CityID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CityID.Location = new System.Drawing.Point(93, 9);
            this.textBox_CityID.Name = "textBox_CityID";
            this.textBox_CityID.Size = new System.Drawing.Size(727, 31);
            this.textBox_CityID.TabIndex = 6;
            // 
            // textBox_Country
            // 
            this.textBox_Country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Country.Location = new System.Drawing.Point(93, 83);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(727, 31);
            this.textBox_Country.TabIndex = 7;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(93, 46);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(727, 31);
            this.textBox_Name.TabIndex = 8;
            // 
            // dataGridView_City
            // 
            this.dataGridView_City.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_City.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_City.Location = new System.Drawing.Point(12, 120);
            this.dataGridView_City.Name = "dataGridView_City";
            this.dataGridView_City.RowHeadersWidth = 62;
            this.dataGridView_City.RowTemplate.Height = 33;
            this.dataGridView_City.Size = new System.Drawing.Size(1198, 385);
            this.dataGridView_City.TabIndex = 12;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(844, 9);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(112, 34);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 517);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_City);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.textBox_CityID);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_CityID);
            this.Name = "Form_City";
            this.Text = "City";
            this.Load += new System.EventHandler(this.Form_City_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_City)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CityID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.TextBox textBox_CityID;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DataGridView dataGridView_City;
        private System.Windows.Forms.Button button_Add;
    }
}

