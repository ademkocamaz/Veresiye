namespace Veresiye.UI
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Activity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Customers
            // 
            this.dataGridView_Customers.AllowUserToAddRows = false;
            this.dataGridView_Customers.AllowUserToDeleteRows = false;
            this.dataGridView_Customers.AllowUserToResizeRows = false;
            this.dataGridView_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customers.Location = new System.Drawing.Point(12, 57);
            this.dataGridView_Customers.Name = "dataGridView_Customers";
            this.dataGridView_Customers.ReadOnly = true;
            this.dataGridView_Customers.RowHeadersVisible = false;
            this.dataGridView_Customers.Size = new System.Drawing.Size(776, 381);
            this.dataGridView_Customers.TabIndex = 0;
            this.dataGridView_Customers.DoubleClick += new System.EventHandler(this.dataGridView_Customers_DoubleClick);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(12, 12);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(90, 39);
            this.button_New.TabIndex = 1;
            this.button_New.Text = "Yeni";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_Activity
            // 
            this.button_Activity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Activity.Location = new System.Drawing.Point(615, 12);
            this.button_Activity.Name = "button_Activity";
            this.button_Activity.Size = new System.Drawing.Size(173, 39);
            this.button_Activity.TabIndex = 1;
            this.button_Activity.Text = "Hareketler";
            this.button_Activity.UseVisualStyleBackColor = true;
            this.button_Activity.Click += new System.EventHandler(this.button_Activity_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Activity);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.dataGridView_Customers);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Customers;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Activity;
    }
}

