namespace Veresiye.UI
{
    partial class CustomerActivityDetailForm
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
            this.groupBox_Activity = new System.Windows.Forms.GroupBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.numericUpDown_Total = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Activity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Total)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Activity
            // 
            this.groupBox_Activity.Controls.Add(this.numericUpDown_Total);
            this.groupBox_Activity.Controls.Add(this.comboBox_Type);
            this.groupBox_Activity.Controls.Add(this.textBox_Description);
            this.groupBox_Activity.Controls.Add(this.label_Total);
            this.groupBox_Activity.Controls.Add(this.label_Description);
            this.groupBox_Activity.Controls.Add(this.label_Type);
            this.groupBox_Activity.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Activity.Name = "groupBox_Activity";
            this.groupBox_Activity.Size = new System.Drawing.Size(277, 118);
            this.groupBox_Activity.TabIndex = 0;
            this.groupBox_Activity.TabStop = false;
            this.groupBox_Activity.Text = "Hareket Bilgileri";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(81, 25);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(185, 21);
            this.comboBox_Type.TabIndex = 1;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(81, 52);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(185, 20);
            this.textBox_Description.TabIndex = 3;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(21, 81);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(32, 13);
            this.label_Total.TabIndex = 4;
            this.label_Total.Text = "Tutar";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(21, 55);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(50, 13);
            this.label_Description.TabIndex = 2;
            this.label_Description.Text = "Açıklama";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(21, 28);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(24, 13);
            this.label_Type.TabIndex = 0;
            this.label_Type.Text = "Tipi";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(52, 136);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(133, 136);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Güncelle";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(214, 136);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Sil";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // numericUpDown_Total
            // 
            this.numericUpDown_Total.DecimalPlaces = 2;
            this.numericUpDown_Total.Location = new System.Drawing.Point(81, 78);
            this.numericUpDown_Total.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_Total.Name = "numericUpDown_Total";
            this.numericUpDown_Total.Size = new System.Drawing.Size(185, 20);
            this.numericUpDown_Total.TabIndex = 7;
            this.numericUpDown_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CustomerActivityDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 171);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.groupBox_Activity);
            this.Name = "CustomerActivityDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareket Detayları";
            this.Load += new System.EventHandler(this.CustomerActivityDetailForm_Load);
            this.groupBox_Activity.ResumeLayout(false);
            this.groupBox_Activity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Total)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Activity;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.NumericUpDown numericUpDown_Total;
    }
}