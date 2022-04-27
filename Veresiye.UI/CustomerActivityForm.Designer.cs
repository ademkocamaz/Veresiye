namespace Veresiye.UI
{
    partial class CustomerActivityForm
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
            this.dataGridView_Activity = new System.Windows.Forms.DataGridView();
            this.button_New = new System.Windows.Forms.Button();
            this.label_CustomerCalling = new System.Windows.Forms.Label();
            this.label_Balance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Activity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Activity
            // 
            this.dataGridView_Activity.AllowUserToAddRows = false;
            this.dataGridView_Activity.AllowUserToDeleteRows = false;
            this.dataGridView_Activity.AllowUserToResizeRows = false;
            this.dataGridView_Activity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Activity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Activity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Activity.Location = new System.Drawing.Point(12, 57);
            this.dataGridView_Activity.Name = "dataGridView_Activity";
            this.dataGridView_Activity.ReadOnly = true;
            this.dataGridView_Activity.RowHeadersVisible = false;
            this.dataGridView_Activity.Size = new System.Drawing.Size(776, 330);
            this.dataGridView_Activity.TabIndex = 0;
            this.dataGridView_Activity.DoubleClick += new System.EventHandler(this.dataGridView_Activity_DoubleClick);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(12, 12);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(90, 39);
            this.button_New.TabIndex = 2;
            this.button_New.Text = "Yeni";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // label_CustomerCalling
            // 
            this.label_CustomerCalling.AutoSize = true;
            this.label_CustomerCalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CustomerCalling.Location = new System.Drawing.Point(108, 12);
            this.label_CustomerCalling.Name = "label_CustomerCalling";
            this.label_CustomerCalling.Size = new System.Drawing.Size(223, 31);
            this.label_CustomerCalling.TabIndex = 3;
            this.label_CustomerCalling.Text = "Customer.Calling";
            // 
            // label_Balance
            // 
            this.label_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Balance.AutoSize = true;
            this.label_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Balance.Location = new System.Drawing.Point(12, 390);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(111, 31);
            this.label_Balance.TabIndex = 4;
            this.label_Balance.Text = "Bakiye :";
            // 
            // CustomerActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Balance);
            this.Controls.Add(this.label_CustomerCalling);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.dataGridView_Activity);
            this.Name = "CustomerActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareketler";
            this.Load += new System.EventHandler(this.CustomerActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Activity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Activity;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Label label_CustomerCalling;
        private System.Windows.Forms.Label label_Balance;
    }
}