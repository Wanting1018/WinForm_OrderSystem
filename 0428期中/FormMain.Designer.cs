namespace _0428期中
{
    partial class FormMain
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
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn訂購單 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn商品管理
            // 
            this.btn商品管理.BackColor = System.Drawing.Color.Bisque;
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.ForeColor = System.Drawing.Color.Indigo;
            this.btn商品管理.Location = new System.Drawing.Point(277, 156);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(147, 76);
            this.btn商品管理.TabIndex = 12;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = false;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.BackColor = System.Drawing.Color.Bisque;
            this.btn會員資料管理.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料管理.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn會員資料管理.Location = new System.Drawing.Point(473, 97);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(147, 76);
            this.btn會員資料管理.TabIndex = 11;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = false;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.BackColor = System.Drawing.Color.Bisque;
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn訂單管理.Location = new System.Drawing.Point(473, 216);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(147, 76);
            this.btn訂單管理.TabIndex = 10;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn訂購單
            // 
            this.btn訂購單.BackColor = System.Drawing.Color.Bisque;
            this.btn訂購單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂購單.ForeColor = System.Drawing.Color.DarkRed;
            this.btn訂購單.Location = new System.Drawing.Point(277, 33);
            this.btn訂購單.Name = "btn訂購單";
            this.btn訂購單.Size = new System.Drawing.Size(147, 76);
            this.btn訂購單.TabIndex = 9;
            this.btn訂購單.Text = "訂購單 Menu";
            this.btn訂購單.UseVisualStyleBackColor = false;
            this.btn訂購單.Click += new System.EventHandler(this.btn訂購單_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "甜賜良緣";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(416, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "吃口甜食，嘴裡會變甜但生活不會";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::_0428期中.Properties.Resources._0427;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn訂購單);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn訂購單;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}