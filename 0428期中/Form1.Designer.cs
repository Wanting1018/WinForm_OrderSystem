namespace _0428期中
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn查看購物車 = new System.Windows.Forms.Button();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl品項 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk買購物袋 = new System.Windows.Forms.CheckBox();
            this.listBox蛋糕品項 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo加料 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo冰塊 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combo甜度 = new System.Windows.Forms.ComboBox();
            this.listView飲品選項 = new System.Windows.Forms.ListView();
            this.lbl訂購人 = new System.Windows.Forms.Label();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.radio內用 = new System.Windows.Forms.RadioButton();
            this.combo內用桌號 = new System.Windows.Forms.ComboBox();
            this.radio外帶 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn查看購物車
            // 
            this.btn查看購物車.BackColor = System.Drawing.Color.Gainsboro;
            this.btn查看購物車.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看購物車.ForeColor = System.Drawing.Color.Navy;
            this.btn查看購物車.Location = new System.Drawing.Point(1019, 646);
            this.btn查看購物車.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn查看購物車.Name = "btn查看購物車";
            this.btn查看購物車.Size = new System.Drawing.Size(380, 65);
            this.btn查看購物車.TabIndex = 29;
            this.btn查看購物車.Text = "查看購物車";
            this.btn查看購物車.UseVisualStyleBackColor = false;
            this.btn查看購物車.Click += new System.EventHandler(this.btn查看購物車_Click);
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.BackColor = System.Drawing.Color.Gainsboro;
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.ForeColor = System.Drawing.Color.Navy;
            this.btn加入購物車.Location = new System.Drawing.Point(597, 646);
            this.btn加入購物車.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(380, 65);
            this.btn加入購物車.TabIndex = 28;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = false;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.BackColor = System.Drawing.Color.Plum;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.Location = new System.Drawing.Point(413, 659);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(137, 38);
            this.lbl總價.TabIndex = 27;
            this.lbl總價.Text = "00000元";
            this.lbl總價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(413, 605);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(119, 38);
            this.lbl單價.TabIndex = 26;
            this.lbl單價.Text = "0000元";
            this.lbl單價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(256, 659);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 38);
            this.label5.TabIndex = 25;
            this.label5.Text = "品項總價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(284, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 38);
            this.label4.TabIndex = 24;
            this.label4.Text = "單價";
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(107, 600);
            this.txt數量.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(112, 43);
            this.txt數量.TabIndex = 23;
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(20, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 38);
            this.label3.TabIndex = 22;
            this.label3.Text = "數量";
            // 
            // lbl品項
            // 
            this.lbl品項.AutoSize = true;
            this.lbl品項.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl品項.Location = new System.Drawing.Point(589, 51);
            this.lbl品項.Name = "lbl品項";
            this.lbl品項.Size = new System.Drawing.Size(137, 38);
            this.lbl品項.TabIndex = 30;
            this.lbl品項.Text = "飲品品項";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(1059, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 62);
            this.label1.TabIndex = 32;
            this.label1.Text = "訂購單 Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk買購物袋
            // 
            this.chk買購物袋.AutoSize = true;
            this.chk買購物袋.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk買購物袋.ForeColor = System.Drawing.Color.SaddleBrown;
            this.chk買購物袋.Location = new System.Drawing.Point(27, 659);
            this.chk買購物袋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk買購物袋.Name = "chk買購物袋";
            this.chk買購物袋.Size = new System.Drawing.Size(149, 40);
            this.chk買購物袋.TabIndex = 33;
            this.chk買購物袋.Text = "買購物袋";
            this.chk買購物袋.UseVisualStyleBackColor = true;
            this.chk買購物袋.CheckedChanged += new System.EventHandler(this.chk買購物袋_CheckedChanged);
            // 
            // listBox蛋糕品項
            // 
            this.listBox蛋糕品項.BackColor = System.Drawing.Color.MistyRose;
            this.listBox蛋糕品項.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox蛋糕品項.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox蛋糕品項.FormattingEnabled = true;
            this.listBox蛋糕品項.ItemHeight = 35;
            this.listBox蛋糕品項.Location = new System.Drawing.Point(597, 391);
            this.listBox蛋糕品項.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox蛋糕品項.Name = "listBox蛋糕品項";
            this.listBox蛋糕品項.Size = new System.Drawing.Size(801, 249);
            this.listBox蛋糕品項.TabIndex = 35;
            this.listBox蛋糕品項.SelectedIndexChanged += new System.EventHandler(this.listBox蛋糕品項_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(589, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 38);
            this.label8.TabIndex = 34;
            this.label8.Text = "蛋糕品項";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(20, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 37;
            this.label2.Text = "冷飲加料";
            // 
            // combo加料
            // 
            this.combo加料.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo加料.FormattingEnabled = true;
            this.combo加料.Location = new System.Drawing.Point(23, 442);
            this.combo加料.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo加料.Name = "combo加料";
            this.combo加料.Size = new System.Drawing.Size(268, 46);
            this.combo加料.TabIndex = 36;
            this.combo加料.SelectedIndexChanged += new System.EventHandler(this.combo加料_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(315, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 38);
            this.label9.TabIndex = 39;
            this.label9.Text = "冰塊";
            // 
            // combo冰塊
            // 
            this.combo冰塊.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo冰塊.FormattingEnabled = true;
            this.combo冰塊.Location = new System.Drawing.Point(317, 379);
            this.combo冰塊.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo冰塊.Name = "combo冰塊";
            this.combo冰塊.Size = new System.Drawing.Size(251, 46);
            this.combo冰塊.TabIndex = 38;
            this.combo冰塊.SelectedIndexChanged += new System.EventHandler(this.combo冰塊_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(320, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 38);
            this.label10.TabIndex = 41;
            this.label10.Text = "甜度";
            // 
            // combo甜度
            // 
            this.combo甜度.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo甜度.FormattingEnabled = true;
            this.combo甜度.Location = new System.Drawing.Point(323, 521);
            this.combo甜度.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo甜度.Name = "combo甜度";
            this.combo甜度.Size = new System.Drawing.Size(251, 46);
            this.combo甜度.TabIndex = 40;
            this.combo甜度.SelectedIndexChanged += new System.EventHandler(this.combo甜度_SelectedIndexChanged);
            // 
            // listView飲品選項
            // 
            this.listView飲品選項.BackColor = System.Drawing.Color.MistyRose;
            this.listView飲品選項.HideSelection = false;
            this.listView飲品選項.Location = new System.Drawing.Point(597, 92);
            this.listView飲品選項.Name = "listView飲品選項";
            this.listView飲品選項.Size = new System.Drawing.Size(801, 255);
            this.listView飲品選項.TabIndex = 43;
            this.listView飲品選項.UseCompatibleStateImageBehavior = false;
            // 
            // lbl訂購人
            // 
            this.lbl訂購人.AutoSize = true;
            this.lbl訂購人.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl訂購人.Location = new System.Drawing.Point(20, 51);
            this.lbl訂購人.Name = "lbl訂購人";
            this.lbl訂購人.Size = new System.Drawing.Size(107, 38);
            this.lbl訂購人.TabIndex = 15;
            this.lbl訂購人.Text = "訂購人";
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人.Location = new System.Drawing.Point(23, 92);
            this.txt訂購人.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(287, 47);
            this.txt訂購人.TabIndex = 16;
            this.txt訂購人.TextChanged += new System.EventHandler(this.txt訂購人_TextChanged);
            // 
            // radio內用
            // 
            this.radio內用.AutoSize = true;
            this.radio內用.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio內用.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radio內用.Location = new System.Drawing.Point(32, 24);
            this.radio內用.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio內用.Name = "radio內用";
            this.radio內用.Size = new System.Drawing.Size(98, 42);
            this.radio內用.TabIndex = 0;
            this.radio內用.TabStop = true;
            this.radio內用.Text = "內用";
            this.radio內用.UseVisualStyleBackColor = true;
            this.radio內用.CheckedChanged += new System.EventHandler(this.radio內用_CheckedChanged);
            // 
            // combo內用桌號
            // 
            this.combo內用桌號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo內用桌號.FormattingEnabled = true;
            this.combo內用桌號.Location = new System.Drawing.Point(144, 24);
            this.combo內用桌號.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo內用桌號.Name = "combo內用桌號";
            this.combo內用桌號.Size = new System.Drawing.Size(161, 46);
            this.combo內用桌號.TabIndex = 42;
            this.combo內用桌號.SelectedIndexChanged += new System.EventHandler(this.combo內用桌號_SelectedIndexChanged);
            // 
            // radio外帶
            // 
            this.radio外帶.AutoSize = true;
            this.radio外帶.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio外帶.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radio外帶.Location = new System.Drawing.Point(32, 98);
            this.radio外帶.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio外帶.Name = "radio外帶";
            this.radio外帶.Size = new System.Drawing.Size(98, 42);
            this.radio外帶.TabIndex = 1;
            this.radio外帶.TabStop = true;
            this.radio外帶.Text = "外帶";
            this.radio外帶.UseVisualStyleBackColor = true;
            this.radio外帶.CheckedChanged += new System.EventHandler(this.radio外帶_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.radio外帶);
            this.groupBox1.Controls.Add(this.combo內用桌號);
            this.groupBox1.Controls.Add(this.radio內用);
            this.groupBox1.Location = new System.Drawing.Point(23, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(319, 156);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1411, 722);
            this.Controls.Add(this.listView飲品選項);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo甜度);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo冰塊);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo加料);
            this.Controls.Add(this.listBox蛋糕品項);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk買購物袋);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl品項);
            this.Controls.Add(this.btn查看購物車);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.lbl訂購人);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn查看購物車;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl品項;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk買購物袋;
        private System.Windows.Forms.ListBox listBox蛋糕品項;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo加料;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo冰塊;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo甜度;
        private System.Windows.Forms.ListView listView飲品選項;
        private System.Windows.Forms.Label lbl訂購人;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.RadioButton radio內用;
        private System.Windows.Forms.ComboBox combo內用桌號;
        private System.Windows.Forms.RadioButton radio外帶;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

