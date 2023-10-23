namespace _0428期中
{
    partial class FormOrderDetails
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
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv訂單資料列表 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listbox搜尋結果 = new System.Windows.Forms.ListBox();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.btn搜尋關鍵字 = new System.Windows.Forms.Button();
            this.combo訂單資料欄位 = new System.Windows.Forms.ComboBox();
            this.txt欄位關鍵字搜尋 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl生日區間 = new System.Windows.Forms.Label();
            this.lbl欄位關鍵字搜尋 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt訂單內容 = new System.Windows.Forms.TextBox();
            this.dtp訂單成立日期 = new System.Windows.Forms.DateTimePicker();
            this.txt訂單總價 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除訂單資料 = new System.Windows.Forms.Button();
            this.btn訂單資料修改 = new System.Windows.Forms.Button();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.btn會員基本資料 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單資料列表)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Plum;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(5, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(508, 50);
            this.label14.TabIndex = 13;
            this.label14.Text = "訂   單   資   料   管   理   ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.dgv訂單資料列表);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(7, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1004, 331);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "訂單資料列表";
            // 
            // dgv訂單資料列表
            // 
            this.dgv訂單資料列表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv訂單資料列表.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv訂單資料列表.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv訂單資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂單資料列表.Location = new System.Drawing.Point(17, 34);
            this.dgv訂單資料列表.Name = "dgv訂單資料列表";
            this.dgv訂單資料列表.RowHeadersWidth = 51;
            this.dgv訂單資料列表.RowTemplate.Height = 24;
            this.dgv訂單資料列表.Size = new System.Drawing.Size(970, 286);
            this.dgv訂單資料列表.TabIndex = 0;
            this.dgv訂單資料列表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂單資料列表_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.listbox搜尋結果);
            this.groupBox3.Controls.Add(this.dtp結束時間);
            this.groupBox3.Controls.Add(this.dtp開始時間);
            this.groupBox3.Controls.Add(this.btn搜尋關鍵字);
            this.groupBox3.Controls.Add(this.combo訂單資料欄位);
            this.groupBox3.Controls.Add(this.txt欄位關鍵字搜尋);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbl生日區間);
            this.groupBox3.Controls.Add(this.lbl欄位關鍵字搜尋);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(248, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 306);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訂單資料進階搜尋";
            // 
            // listbox搜尋結果
            // 
            this.listbox搜尋結果.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.listbox搜尋結果.FormattingEnabled = true;
            this.listbox搜尋結果.ItemHeight = 21;
            this.listbox搜尋結果.Location = new System.Drawing.Point(267, 90);
            this.listbox搜尋結果.Name = "listbox搜尋結果";
            this.listbox搜尋結果.Size = new System.Drawing.Size(231, 151);
            this.listbox搜尋結果.TabIndex = 12;
            this.listbox搜尋結果.Visible = false;
            this.listbox搜尋結果.SelectedIndexChanged += new System.EventHandler(this.listbox搜尋結果_SelectedIndexChanged);
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dtp結束時間.Location = new System.Drawing.Point(35, 241);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(200, 29);
            this.dtp結束時間.TabIndex = 10;
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始時間.Location = new System.Drawing.Point(35, 190);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(200, 29);
            this.dtp開始時間.TabIndex = 9;
            this.dtp開始時間.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // btn搜尋關鍵字
            // 
            this.btn搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋關鍵字.Location = new System.Drawing.Point(170, 96);
            this.btn搜尋關鍵字.Name = "btn搜尋關鍵字";
            this.btn搜尋關鍵字.Size = new System.Drawing.Size(75, 33);
            this.btn搜尋關鍵字.TabIndex = 8;
            this.btn搜尋關鍵字.Text = "搜尋";
            this.btn搜尋關鍵字.UseVisualStyleBackColor = true;
            this.btn搜尋關鍵字.Click += new System.EventHandler(this.btn搜尋關鍵字_Click);
            // 
            // combo訂單資料欄位
            // 
            this.combo訂單資料欄位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.combo訂單資料欄位.FormattingEnabled = true;
            this.combo訂單資料欄位.Location = new System.Drawing.Point(170, 63);
            this.combo訂單資料欄位.Name = "combo訂單資料欄位";
            this.combo訂單資料欄位.Size = new System.Drawing.Size(84, 29);
            this.combo訂單資料欄位.TabIndex = 7;
            // 
            // txt欄位關鍵字搜尋
            // 
            this.txt欄位關鍵字搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.txt欄位關鍵字搜尋.Location = new System.Drawing.Point(11, 63);
            this.txt欄位關鍵字搜尋.Name = "txt欄位關鍵字搜尋";
            this.txt欄位關鍵字搜尋.Size = new System.Drawing.Size(153, 29);
            this.txt欄位關鍵字搜尋.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Thistle;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(266, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "搜尋結果";
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Thistle;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(6, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "到";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Thistle;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(6, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "從";
            // 
            // lbl生日區間
            // 
            this.lbl生日區間.AutoSize = true;
            this.lbl生日區間.BackColor = System.Drawing.Color.Thistle;
            this.lbl生日區間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lbl生日區間.ForeColor = System.Drawing.Color.Navy;
            this.lbl生日區間.Location = new System.Drawing.Point(8, 159);
            this.lbl生日區間.Name = "lbl生日區間";
            this.lbl生日區間.Size = new System.Drawing.Size(138, 21);
            this.lbl生日區間.TabIndex = 1;
            this.lbl生日區間.Text = "訂單成立日期區間";
            // 
            // lbl欄位關鍵字搜尋
            // 
            this.lbl欄位關鍵字搜尋.AutoSize = true;
            this.lbl欄位關鍵字搜尋.BackColor = System.Drawing.Color.Thistle;
            this.lbl欄位關鍵字搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lbl欄位關鍵字搜尋.ForeColor = System.Drawing.Color.Navy;
            this.lbl欄位關鍵字搜尋.Location = new System.Drawing.Point(6, 34);
            this.lbl欄位關鍵字搜尋.Name = "lbl欄位關鍵字搜尋";
            this.lbl欄位關鍵字搜尋.Size = new System.Drawing.Size(122, 21);
            this.lbl欄位關鍵字搜尋.TabIndex = 0;
            this.lbl欄位關鍵字搜尋.Text = "欄位關鍵字搜尋";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.txt訂單內容);
            this.groupBox2.Controls.Add(this.dtp訂單成立日期);
            this.groupBox2.Controls.Add(this.txt訂單總價);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(519, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 358);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訂單資料";
            // 
            // txt訂單內容
            // 
            this.txt訂單內容.Location = new System.Drawing.Point(21, 184);
            this.txt訂單內容.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt訂單內容.Multiline = true;
            this.txt訂單內容.Name = "txt訂單內容";
            this.txt訂單內容.Size = new System.Drawing.Size(426, 170);
            this.txt訂單內容.TabIndex = 35;
            // 
            // dtp訂單成立日期
            // 
            this.dtp訂單成立日期.CalendarFont = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp訂單成立日期.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp訂單成立日期.Location = new System.Drawing.Point(242, 146);
            this.dtp訂單成立日期.Name = "dtp訂單成立日期";
            this.dtp訂單成立日期.Size = new System.Drawing.Size(205, 29);
            this.dtp訂單成立日期.TabIndex = 34;
            this.dtp訂單成立日期.Value = new System.DateTime(2023, 4, 27, 20, 49, 9, 0);
            // 
            // txt訂單總價
            // 
            this.txt訂單總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂單總價.Location = new System.Drawing.Point(242, 90);
            this.txt訂單總價.Name = "txt訂單總價";
            this.txt訂單總價.Size = new System.Drawing.Size(205, 29);
            this.txt訂單總價.TabIndex = 31;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(21, 110);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(203, 29);
            this.txt姓名.TabIndex = 29;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.DarkOrange;
            this.lblid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblid.Location = new System.Drawing.Point(48, 46);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(70, 21);
            this.lblid.TabIndex = 28;
            this.lblid.Text = "000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(17, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "訂單內容";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(238, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "訂單總價";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(238, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "訂單成立日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn刪除訂單資料);
            this.groupBox1.Controls.Add(this.btn訂單資料修改);
            this.groupBox1.Controls.Add(this.btn重新整理);
            this.groupBox1.Controls.Add(this.btn會員基本資料);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(7, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 312);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn清空欄位.Location = new System.Drawing.Point(21, 88);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(176, 46);
            this.btn清空欄位.TabIndex = 5;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn刪除訂單資料
            // 
            this.btn刪除訂單資料.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn刪除訂單資料.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn刪除訂單資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn刪除訂單資料.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn刪除訂單資料.Location = new System.Drawing.Point(21, 195);
            this.btn刪除訂單資料.Name = "btn刪除訂單資料";
            this.btn刪除訂單資料.Size = new System.Drawing.Size(176, 46);
            this.btn刪除訂單資料.TabIndex = 4;
            this.btn刪除訂單資料.Text = "刪除訂單資料";
            this.btn刪除訂單資料.UseVisualStyleBackColor = false;
            this.btn刪除訂單資料.Click += new System.EventHandler(this.btn刪除訂單資料_Click);
            // 
            // btn訂單資料修改
            // 
            this.btn訂單資料修改.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn訂單資料修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn訂單資料修改.Location = new System.Drawing.Point(21, 33);
            this.btn訂單資料修改.Name = "btn訂單資料修改";
            this.btn訂單資料修改.Size = new System.Drawing.Size(176, 46);
            this.btn訂單資料修改.TabIndex = 2;
            this.btn訂單資料修改.Text = "訂單資料修改";
            this.btn訂單資料修改.UseVisualStyleBackColor = false;
            this.btn訂單資料修改.Click += new System.EventHandler(this.btn訂單資料修改_Click);
            // 
            // btn重新整理
            // 
            this.btn重新整理.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn重新整理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn重新整理.ForeColor = System.Drawing.Color.Navy;
            this.btn重新整理.Location = new System.Drawing.Point(21, 247);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(176, 46);
            this.btn重新整理.TabIndex = 1;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = false;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // btn會員基本資料
            // 
            this.btn會員基本資料.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn會員基本資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn會員基本資料.Location = new System.Drawing.Point(21, 140);
            this.btn會員基本資料.Name = "btn會員基本資料";
            this.btn會員基本資料.Size = new System.Drawing.Size(176, 46);
            this.btn會員基本資料.TabIndex = 0;
            this.btn會員基本資料.Text = "會員基本資料";
            this.btn會員基本資料.UseVisualStyleBackColor = false;
            this.btn會員基本資料.Click += new System.EventHandler(this.btn會員基本資料_Click);
            // 
            // FormOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_0428期中.Properties.Resources._3cffa4b6e68369a01fc4aac04cb6e49e;
            this.ClientSize = new System.Drawing.Size(1026, 715);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrderDetails";
            this.Text = "FormOrderDetails";
            this.Load += new System.EventHandler(this.FormOrderDetails_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單資料列表)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv訂單資料列表;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.Button btn搜尋關鍵字;
        private System.Windows.Forms.ComboBox combo訂單資料欄位;
        private System.Windows.Forms.TextBox txt欄位關鍵字搜尋;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl生日區間;
        private System.Windows.Forms.Label lbl欄位關鍵字搜尋;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp訂單成立日期;
        private System.Windows.Forms.TextBox txt訂單總價;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除訂單資料;
        private System.Windows.Forms.Button btn訂單資料修改;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.Button btn會員基本資料;
        private System.Windows.Forms.TextBox txt訂單內容;
        private System.Windows.Forms.ListBox listbox搜尋結果;
        private System.Windows.Forms.Label label13;
    }
}