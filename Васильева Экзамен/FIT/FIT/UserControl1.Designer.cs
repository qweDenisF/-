namespace FIT
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.idLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(3, 2);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(44, 16);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "label1";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceLabel.Location = new System.Drawing.Point(292, 2);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(44, 16);
            this.serviceLabel.TabIndex = 1;
            this.serviceLabel.Text = "label1";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(42, 2);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(44, 16);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "label1";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(1123, 2);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "label1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(1209, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(44, 16);
            this.time.TabIndex = 4;
            this.time.Text = "label1";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.SystemColors.Window;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(1372, 2);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(44, 16);
            this.Phone.TabIndex = 5;
            this.Phone.Text = "label1";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.SystemColors.Window;
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.deleteLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteLabel.Location = new System.Drawing.Point(1476, 2);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(47, 22);
            this.deleteLabel.TabIndex = 6;
            this.deleteLabel.Text = "  Х  ";
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            this.deleteLabel.MouseLeave += new System.EventHandler(this.deleteLabel_MouseLeave);
            this.deleteLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deleteLabel_MouseMove);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.time);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1523, 31);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label deleteLabel;
    }
}
