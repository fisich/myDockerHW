namespace MyOnlineCinema
{
    partial class BuySub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuySub));
            this.label1 = new System.Windows.Forms.Label();
            this._monthCountUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.TextBox();
            this._confirmPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._monthCountUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здесь должно быть окно покупки через карту";
            // 
            // _monthCountUD
            // 
            this._monthCountUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._monthCountUD.Location = new System.Drawing.Point(17, 68);
            this._monthCountUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this._monthCountUD.Name = "_monthCountUD";
            this._monthCountUD.Size = new System.Drawing.Size(198, 24);
            this._monthCountUD.TabIndex = 1;
            this._monthCountUD.ValueChanged += new System.EventHandler(this._monthCountUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "На сколько месяцев";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(222, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "К оплате";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(224, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "К оплате";
            // 
            // _price
            // 
            this._price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._price.Location = new System.Drawing.Point(228, 68);
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            this._price.Size = new System.Drawing.Size(142, 24);
            this._price.TabIndex = 4;
            // 
            // _confirmPayment
            // 
            this._confirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._confirmPayment.Location = new System.Drawing.Point(17, 99);
            this._confirmPayment.Name = "_confirmPayment";
            this._confirmPayment.Size = new System.Drawing.Size(353, 27);
            this._confirmPayment.TabIndex = 5;
            this._confirmPayment.Text = "Подтвердить платеж";
            this._confirmPayment.UseVisualStyleBackColor = true;
            this._confirmPayment.Click += new System.EventHandler(this._confirmPayment_Click);
            // 
            // BuySub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 137);
            this.Controls.Add(this._confirmPayment);
            this.Controls.Add(this._price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._monthCountUD);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 176);
            this.MinimumSize = new System.Drawing.Size(398, 176);
            this.Name = "BuySub";
            this.Text = "Оплата подписки";
            ((System.ComponentModel.ISupportInitialize)(this._monthCountUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _monthCountUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _price;
        private System.Windows.Forms.Button _confirmPayment;
    }
}