namespace FIT
{
    partial class ClientUserControl3
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
            this.deleteLabel = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.membershiptype = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.SystemColors.Window;
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.deleteLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteLabel.Location = new System.Drawing.Point(1474, 4);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(47, 22);
            this.deleteLabel.TabIndex = 13;
            this.deleteLabel.Text = "  Х  ";
            this.deleteLabel.MouseLeave += new System.EventHandler(this.deleteLabel_MouseLeave);
            this.deleteLabel.MouseHover += new System.EventHandler(this.deleteLabel_MouseHover);
            this.deleteLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deleteLabel_MouseMove);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.SystemColors.Window;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(1370, 4);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(44, 16);
            this.Phone.TabIndex = 12;
            this.Phone.Text = "label1";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(1149, 4);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 16);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "label1";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(661, 4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(44, 16);
            this.number.TabIndex = 10;
            this.number.Text = "label1";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(40, 4);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(44, 16);
            this.fullNameLabel.TabIndex = 9;
            this.fullNameLabel.Text = "label1";
            // 
            // membershiptype
            // 
            this.membershiptype.AutoSize = true;
            this.membershiptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.membershiptype.Location = new System.Drawing.Point(290, 4);
            this.membershiptype.Name = "membershiptype";
            this.membershiptype.Size = new System.Drawing.Size(108, 16);
            this.membershiptype.TabIndex = 8;
            this.membershiptype.Text = "membershiptype";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(1, 4);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(44, 16);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "label1";
            // 
            // ClientUserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.number);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.membershiptype);
            this.Controls.Add(this.idLabel);
            this.Name = "ClientUserControl3";
            this.Size = new System.Drawing.Size(1523, 31);
            this.Load += new System.EventHandler(this.ClientUserControl3_Load);
            this.MouseLeave += new System.EventHandler(this.ClientUserControl3_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientUserControl3_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label membershiptype;
        private System.Windows.Forms.Label idLabel;
    }
}
