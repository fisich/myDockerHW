namespace MyOnlineCinema
{
    partial class FilmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmInfo));
            this._posterTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._peopleGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._filmNameLbl = new System.Windows.Forms.Label();
            this._filmDateLbl = new System.Windows.Forms.Label();
            this._filmSubLbl = new System.Windows.Forms.Label();
            this._filmRatingLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._filmLengthLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._priceLbl = new System.Windows.Forms.Label();
            this._filmSubTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._genreLbl = new System.Windows.Forms.Label();
            this._buyBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._descriptionTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._peopleGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _posterTB
            // 
            this._posterTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._posterTB.Location = new System.Drawing.Point(20, 20);
            this._posterTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._posterTB.Multiline = true;
            this._posterTB.Name = "_posterTB";
            this._posterTB.ReadOnly = true;
            this._posterTB.Size = new System.Drawing.Size(200, 268);
            this._posterTB.TabIndex = 0;
            this._posterTB.Text = "Здесь должен находиться постер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._peopleGV);
            this.groupBox1.Location = new System.Drawing.Point(237, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Люди, работающие над фильмом";
            // 
            // _peopleGV
            // 
            this._peopleGV.AllowUserToAddRows = false;
            this._peopleGV.AllowUserToDeleteRows = false;
            this._peopleGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._peopleGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._peopleGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._peopleGV.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this._peopleGV.Location = new System.Drawing.Point(7, 26);
            this._peopleGV.Name = "_peopleGV";
            this._peopleGV.ReadOnly = true;
            this._peopleGV.Size = new System.Drawing.Size(433, 207);
            this._peopleGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название фильма:................................................................." +
    ".........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата выхода:....................................................................." +
    "...............";
            // 
            // _filmNameLbl
            // 
            this._filmNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._filmNameLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._filmNameLbl.Location = new System.Drawing.Point(534, 20);
            this._filmNameLbl.Name = "_filmNameLbl";
            this._filmNameLbl.Size = new System.Drawing.Size(148, 20);
            this._filmNameLbl.TabIndex = 5;
            this._filmNameLbl.Text = "_filmNameLbl";
            this._filmNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _filmDateLbl
            // 
            this._filmDateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._filmDateLbl.Location = new System.Drawing.Point(572, 53);
            this._filmDateLbl.Name = "_filmDateLbl";
            this._filmDateLbl.Size = new System.Drawing.Size(111, 20);
            this._filmDateLbl.TabIndex = 6;
            this._filmDateLbl.Text = "_filmDateLbl";
            this._filmDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _filmSubLbl
            // 
            this._filmSubLbl.AutoSize = true;
            this._filmSubLbl.Location = new System.Drawing.Point(16, 293);
            this._filmSubLbl.Name = "_filmSubLbl";
            this._filmSubLbl.Size = new System.Drawing.Size(119, 20);
            this._filmSubLbl.TabIndex = 8;
            this._filmSubLbl.Text = "Цена фильма:";
            this._filmSubLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _filmRatingLbl
            // 
            this._filmRatingLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._filmRatingLbl.Location = new System.Drawing.Point(641, 87);
            this._filmRatingLbl.Name = "_filmRatingLbl";
            this._filmRatingLbl.Size = new System.Drawing.Size(43, 20);
            this._filmRatingLbl.TabIndex = 8;
            this._filmRatingLbl.Text = "9.9";
            this._filmRatingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Рейтинг фильма:.................................................................." +
    "..........";
            // 
            // _filmLengthLbl
            // 
            this._filmLengthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._filmLengthLbl.Location = new System.Drawing.Point(590, 120);
            this._filmLengthLbl.Name = "_filmLengthLbl";
            this._filmLengthLbl.Size = new System.Drawing.Size(90, 20);
            this._filmLengthLbl.TabIndex = 10;
            this._filmLengthLbl.Text = "120 мин.";
            this._filmLengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Продолжительность фильма:....................................................";
            // 
            // _priceLbl
            // 
            this._priceLbl.Location = new System.Drawing.Point(141, 293);
            this._priceLbl.Name = "_priceLbl";
            this._priceLbl.Size = new System.Drawing.Size(79, 20);
            this._priceLbl.TabIndex = 11;
            this._priceLbl.Text = "1000 руб.";
            this._priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _filmSubTB
            // 
            this._filmSubTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._filmSubTB.ForeColor = System.Drawing.Color.Teal;
            this._filmSubTB.Location = new System.Drawing.Point(20, 316);
            this._filmSubTB.Multiline = true;
            this._filmSubTB.Name = "_filmSubTB";
            this._filmSubTB.ReadOnly = true;
            this._filmSubTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._filmSubTB.Size = new System.Drawing.Size(200, 78);
            this._filmSubTB.TabIndex = 12;
            this._filmSubTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Жанр:.......................................................";
            // 
            // _genreLbl
            // 
            this._genreLbl.Location = new System.Drawing.Point(299, 155);
            this._genreLbl.Name = "_genreLbl";
            this._genreLbl.Size = new System.Drawing.Size(384, 20);
            this._genreLbl.TabIndex = 14;
            this._genreLbl.Text = "Фантастика";
            this._genreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _buyBTN
            // 
            this._buyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._buyBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._buyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._buyBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buyBTN.Location = new System.Drawing.Point(20, 406);
            this._buyBTN.Name = "_buyBTN";
            this._buyBTN.Size = new System.Drawing.Size(200, 26);
            this._buyBTN.TabIndex = 15;
            this._buyBTN.Text = "Купить";
            this._buyBTN.UseVisualStyleBackColor = false;
            this._buyBTN.Click += new System.EventHandler(this._buyBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._descriptionTB);
            this.groupBox2.Location = new System.Drawing.Point(694, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 419);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Описание фильма (Осторожно, спойлеры)";
            // 
            // _descriptionTB
            // 
            this._descriptionTB.Location = new System.Drawing.Point(7, 26);
            this._descriptionTB.Multiline = true;
            this._descriptionTB.Name = "_descriptionTB";
            this._descriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._descriptionTB.Size = new System.Drawing.Size(358, 387);
            this._descriptionTB.TabIndex = 0;
            // 
            // FilmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._buyBTN);
            this.Controls.Add(this._genreLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._filmSubTB);
            this.Controls.Add(this._priceLbl);
            this.Controls.Add(this._filmLengthLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._filmSubLbl);
            this.Controls.Add(this._filmRatingLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._filmDateLbl);
            this.Controls.Add(this._filmNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._posterTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1093, 478);
            this.MinimumSize = new System.Drawing.Size(1093, 478);
            this.Name = "FilmInfo";
            this.Text = "Информация о фильме";
            this.Load += new System.EventHandler(this.FilmInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._peopleGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _posterTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _filmNameLbl;
        private System.Windows.Forms.Label _filmDateLbl;
        private System.Windows.Forms.Label _filmSubLbl;
        private System.Windows.Forms.Label _filmRatingLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _filmLengthLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _priceLbl;
        private System.Windows.Forms.TextBox _filmSubTB;
        private System.Windows.Forms.DataGridView _peopleGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _genreLbl;
        private System.Windows.Forms.Button _buyBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _descriptionTB;
    }
}