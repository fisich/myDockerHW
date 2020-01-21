namespace MyOnlineCinema
{
    partial class BuyFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyFilm));
            this.label1 = new System.Windows.Forms.Label();
            this._confirmPayment = new System.Windows.Forms.Button();
            this._price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Здесь должно быть окно покупки через карту";
            // 
            // _confirmPayment
            // 
            this._confirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._confirmPayment.Location = new System.Drawing.Point(17, 62);
            this._confirmPayment.Name = "_confirmPayment";
            this._confirmPayment.Size = new System.Drawing.Size(353, 27);
            this._confirmPayment.TabIndex = 8;
            this._confirmPayment.Text = "Подтвердить платеж";
            this._confirmPayment.UseVisualStyleBackColor = true;
            this._confirmPayment.Click += new System.EventHandler(this._confirmPayment_Click);
            // 
            // _price
            // 
            this._price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._price.Location = new System.Drawing.Point(153, 32);
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            this._price.Size = new System.Drawing.Size(217, 24);
            this._price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "К оплате";
            // 
            // BuyFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 98);
            this.Controls.Add(this._confirmPayment);
            this.Controls.Add(this._price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 137);
            this.MinimumSize = new System.Drawing.Size(398, 137);
            this.Name = "BuyFilm";
            this.Text = "Покупка фильма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _confirmPayment;
        private System.Windows.Forms.TextBox _price;
        private System.Windows.Forms.Label label4;
    }
}