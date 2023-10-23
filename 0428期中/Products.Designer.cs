namespace _0428期中
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn重新整理
            // 
            this.btn重新整理.BackColor = System.Drawing.Color.Peru;
            this.btn重新整理.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新整理.Location = new System.Drawing.Point(861, 465);
            this.btn重新整理.Margin = new System.Windows.Forms.Padding(4);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(191, 70);
            this.btn重新整理.TabIndex = 12;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = false;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.Color.BurlyWood;
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.Location = new System.Drawing.Point(861, 359);
            this.btn新增商品.Margin = new System.Windows.Forms.Padding(4);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(191, 70);
            this.btn新增商品.TabIndex = 11;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = false;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.BackColor = System.Drawing.Color.Tan;
            this.btn列表模式.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.Location = new System.Drawing.Point(861, 248);
            this.btn列表模式.Margin = new System.Windows.Forms.Padding(4);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(191, 70);
            this.btn列表模式.TabIndex = 10;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.UseVisualStyleBackColor = false;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.BackColor = System.Drawing.Color.Wheat;
            this.btn圖片模式.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.Location = new System.Drawing.Point(861, 131);
            this.btn圖片模式.Margin = new System.Windows.Forms.Padding(4);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(191, 70);
            this.btn圖片模式.TabIndex = 9;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = false;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(320, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "商  品  管  理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView商品展示
            // 
            this.listView商品展示.BackColor = System.Drawing.Color.Linen;
            this.listView商品展示.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(32, 78);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(4);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(792, 724);
            this.listView商品展示.TabIndex = 8;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::_0428期中.Properties.Resources._9d4367716234e5d682480dd63d02a281;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 815);
            this.Controls.Add(this.btn重新整理);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList產品圖檔;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Label label1;
    }
}