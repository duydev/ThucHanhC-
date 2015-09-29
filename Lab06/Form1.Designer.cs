namespace Lab06
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhoai = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnGT = new System.Windows.Forms.Button();
            this.btnGP = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnTC = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnPT = new System.Windows.Forms.Button();
            this.btnPG = new System.Windows.Forms.Button();
            this.btnPB = new System.Windows.Forms.Button();
            this.cbbBan = new System.Windows.Forms.ComboBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(268, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fastfood Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhoai);
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnCafe);
            this.groupBox1.Controls.Add(this.btnLipton);
            this.groupBox1.Controls.Add(this.btn7up);
            this.groupBox1.Controls.Add(this.btnCoca);
            this.groupBox1.Controls.Add(this.btnPepsi);
            this.groupBox1.Controls.Add(this.btnGT);
            this.groupBox1.Controls.Add(this.btnGP);
            this.groupBox1.Controls.Add(this.btnGC);
            this.groupBox1.Controls.Add(this.btnTC);
            this.groupBox1.Controls.Add(this.btnPC);
            this.groupBox1.Controls.Add(this.btnPT);
            this.groupBox1.Controls.Add(this.btnPG);
            this.groupBox1.Controls.Add(this.btnPB);
            this.groupBox1.Location = new System.Drawing.Point(22, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // btnKhoai
            // 
            this.btnKhoai.ForeColor = System.Drawing.Color.Lime;
            this.btnKhoai.Location = new System.Drawing.Point(447, 195);
            this.btnKhoai.Name = "btnKhoai";
            this.btnKhoai.Size = new System.Drawing.Size(178, 48);
            this.btnKhoai.TabIndex = 16;
            this.btnKhoai.Text = "Khoai tây chiên";
            this.btnKhoai.UseVisualStyleBackColor = true;
            this.btnKhoai.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnCam
            // 
            this.btnCam.ForeColor = System.Drawing.Color.Red;
            this.btnCam.Location = new System.Drawing.Point(539, 141);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(86, 48);
            this.btnCam.TabIndex = 15;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.ForeColor = System.Drawing.Color.Red;
            this.btnCafe.Location = new System.Drawing.Point(447, 141);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(86, 48);
            this.btnCafe.TabIndex = 14;
            this.btnCafe.Text = "Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnLipton
            // 
            this.btnLipton.ForeColor = System.Drawing.Color.Red;
            this.btnLipton.Location = new System.Drawing.Point(539, 87);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(86, 48);
            this.btnLipton.TabIndex = 13;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            this.btnLipton.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btn7up
            // 
            this.btn7up.ForeColor = System.Drawing.Color.Red;
            this.btn7up.Location = new System.Drawing.Point(447, 87);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(86, 48);
            this.btn7up.TabIndex = 12;
            this.btn7up.Text = "7 up";
            this.btn7up.UseVisualStyleBackColor = true;
            this.btn7up.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnCoca
            // 
            this.btnCoca.ForeColor = System.Drawing.Color.Red;
            this.btnCoca.Location = new System.Drawing.Point(539, 33);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(86, 48);
            this.btnCoca.TabIndex = 11;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.ForeColor = System.Drawing.Color.Red;
            this.btnPepsi.Location = new System.Drawing.Point(447, 33);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(86, 48);
            this.btnPepsi.TabIndex = 10;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnGT
            // 
            this.btnGT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGT.Location = new System.Drawing.Point(256, 195);
            this.btnGT.Name = "btnGT";
            this.btnGT.Size = new System.Drawing.Size(185, 48);
            this.btnGT.TabIndex = 9;
            this.btnGT.Text = "Cơm Gà Tender";
            this.btnGT.UseVisualStyleBackColor = true;
            this.btnGT.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnGP
            // 
            this.btnGP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGP.Location = new System.Drawing.Point(256, 141);
            this.btnGP.Name = "btnGP";
            this.btnGP.Size = new System.Drawing.Size(185, 48);
            this.btnGP.TabIndex = 8;
            this.btnGP.Text = "Gà rán phần";
            this.btnGP.UseVisualStyleBackColor = true;
            this.btnGP.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnGC
            // 
            this.btnGC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGC.Location = new System.Drawing.Point(256, 87);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(185, 48);
            this.btnGC.TabIndex = 7;
            this.btnGC.Text = "Gà viên Cola";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnTC
            // 
            this.btnTC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTC.Location = new System.Drawing.Point(256, 33);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(185, 48);
            this.btnTC.TabIndex = 6;
            this.btnTC.Text = "Tôm viên Cola";
            this.btnTC.UseVisualStyleBackColor = true;
            this.btnTC.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnPC
            // 
            this.btnPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPC.Location = new System.Drawing.Point(18, 198);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(232, 48);
            this.btnPC.TabIndex = 5;
            this.btnPC.Text = "Burger Phô mai Cá";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnPT
            // 
            this.btnPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPT.Location = new System.Drawing.Point(18, 144);
            this.btnPT.Name = "btnPT";
            this.btnPT.Size = new System.Drawing.Size(232, 48);
            this.btnPT.TabIndex = 4;
            this.btnPT.Text = "Burger Phô mai Tôm";
            this.btnPT.UseVisualStyleBackColor = true;
            this.btnPT.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnPG
            // 
            this.btnPG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPG.Location = new System.Drawing.Point(18, 90);
            this.btnPG.Name = "btnPG";
            this.btnPG.Size = new System.Drawing.Size(232, 48);
            this.btnPG.TabIndex = 3;
            this.btnPG.Text = "Burger Phô mai Gà";
            this.btnPG.UseVisualStyleBackColor = true;
            this.btnPG.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // btnPB
            // 
            this.btnPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPB.Location = new System.Drawing.Point(18, 36);
            this.btnPB.Name = "btnPB";
            this.btnPB.Size = new System.Drawing.Size(232, 48);
            this.btnPB.TabIndex = 2;
            this.btnPB.Text = "Burger Phô mai Bò";
            this.btnPB.UseVisualStyleBackColor = true;
            this.btnPB.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // cbbBan
            // 
            this.cbbBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBan.FormattingEnabled = true;
            this.cbbBan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbBan.Location = new System.Drawing.Point(304, 386);
            this.cbbBan.Name = "cbbBan";
            this.cbbBan.Size = new System.Drawing.Size(218, 35);
            this.cbbBan.TabIndex = 3;
            this.cbbBan.SelectedIndexChanged += new System.EventHandler(this.cbbBan_SelectedIndexChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMon,
            this.colSoLuong});
            this.dgvOrder.Location = new System.Drawing.Point(22, 430);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(639, 250);
            this.dgvOrder.TabIndex = 4;
            // 
            // colTenMon
            // 
            this.colTenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTenMon.DataPropertyName = "FoodName";
            this.colTenMon.HeaderText = "Món ăn";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.Width = 113;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoLuong.DataPropertyName = "Quantity";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 126;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 104);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(22, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bàn";
            // 
            // btnOrder
            // 
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(547, 381);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(114, 43);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 692);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.cbbBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "E-Order Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhoai;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnGT;
        private System.Windows.Forms.Button btnGP;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnTC;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnPT;
        private System.Windows.Forms.Button btnPG;
        private System.Windows.Forms.Button btnPB;
        private System.Windows.Forms.ComboBox cbbBan;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}

