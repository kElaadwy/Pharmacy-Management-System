
namespace Market.Screens.Customers
{
    partial class ViewCustomers
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearchPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearchName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.TxtFinance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.marketDataSet2 = new Market.MarketDataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Market.MarketDataSet2TableAdapters.CustomerTableAdapter();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marketDataSet3 = new Market.MarketDataSet3();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new Market.MarketDataSet3TableAdapters.CustomerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(6, 25);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(51, 31);
            this.BtnBack.TabIndex = 39;
            this.BtnBack.Text = "عودة";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(80, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(90, 46);
            this.BtnSearch.TabIndex = 38;
            this.BtnSearch.Text = "بحث";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearchPhone
            // 
            this.TxtSearchPhone.Location = new System.Drawing.Point(176, 38);
            this.TxtSearchPhone.Name = "TxtSearchPhone";
            this.TxtSearchPhone.Size = new System.Drawing.Size(257, 20);
            this.TxtSearchPhone.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(439, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "الهاتف";
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Location = new System.Drawing.Point(176, 12);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Size = new System.Drawing.Size(257, 20);
            this.TxtSearchName.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(439, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "الاسم";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(108, 386);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 43);
            this.BtnDelete.TabIndex = 65;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(375, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 27);
            this.label8.TabIndex = 64;
            this.label8.Text = "*";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(108, 191);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(257, 80);
            this.TxtNotes.TabIndex = 61;
            // 
            // TxtFinance
            // 
            this.TxtFinance.Location = new System.Drawing.Point(108, 142);
            this.TxtFinance.Name = "TxtFinance";
            this.TxtFinance.Size = new System.Drawing.Size(257, 20);
            this.TxtFinance.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(391, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 58;
            this.label4.Text = "العنوان";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(287, 386);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 56);
            this.BtnSave.TabIndex = 57;
            this.BtnSave.Text = "تعديل";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(108, 93);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(257, 20);
            this.TxtPhone.TabIndex = 56;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(108, 44);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(257, 20);
            this.TxtName.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(405, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 27);
            this.label11.TabIndex = 54;
            this.label11.Text = "الاسم";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(893, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 27);
            this.label12.TabIndex = 53;
            this.label12.Text = "تعديل المستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBoxActive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.TxtFinance);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtNotes);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(682, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 435);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(364, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "المستحقات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(432, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 27);
            this.label10.TabIndex = 50;
            this.label10.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(394, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "الهاتف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(371, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "ملاحظات";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(108, 300);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(257, 80);
            this.TxtAddress.TabIndex = 67;
            // 
            // marketDataSet2
            // 
            this.marketDataSet2.DataSetName = "MarketDataSet2";
            this.marketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.marketDataSet2;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(25, 135);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(74, 29);
            this.checkBoxActive.TabIndex = 68;
            this.checkBoxActive.Text = "نشط";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.duesDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 386);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // marketDataSet3
            // 
            this.marketDataSet3.DataSetName = "MarketDataSet3";
            this.marketDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.marketDataSet3;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duesDataGridViewTextBoxColumn
            // 
            this.duesDataGridViewTextBoxColumn.DataPropertyName = "dues";
            this.duesDataGridViewTextBoxColumn.HeaderText = "المستحقات";
            this.duesDataGridViewTextBoxColumn.Name = "duesDataGridViewTextBoxColumn";
            this.duesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "الهاتف";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "نشط";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 50;
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Market.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearchPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearchName);
            this.Controls.Add(this.label7);
            this.Name = "ViewCustomers";
            this.Text = "ViewCustomers";
            this.Load += new System.EventHandler(this.ViewCustomers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearchPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.TextBox TxtFinance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAddress;
        private MarketDataSet2 marketDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MarketDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MarketDataSet3 marketDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private MarketDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}