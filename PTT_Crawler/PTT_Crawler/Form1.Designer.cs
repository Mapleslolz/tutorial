namespace PTT_Crawler
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.insertData = new System.Windows.Forms.Button();
            this.myData = new System.Windows.Forms.TextBox();
            this.crawPTT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertData
            // 
            this.insertData.Location = new System.Drawing.Point(117, 12);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(75, 23);
            this.insertData.TabIndex = 0;
            this.insertData.Text = "輸入資料";
            this.insertData.UseVisualStyleBackColor = true;
            this.insertData.Click += new System.EventHandler(this.insertData_Click);
            // 
            // myData
            // 
            this.myData.Location = new System.Drawing.Point(11, 12);
            this.myData.Name = "myData";
            this.myData.Size = new System.Drawing.Size(100, 22);
            this.myData.TabIndex = 1;
            // 
            // crawPTT
            // 
            this.crawPTT.Location = new System.Drawing.Point(57, 94);
            this.crawPTT.Name = "crawPTT";
            this.crawPTT.Size = new System.Drawing.Size(151, 23);
            this.crawPTT.TabIndex = 2;
            this.crawPTT.Text = "爬取PTT NBA版";
            this.crawPTT.UseVisualStyleBackColor = true;
            this.crawPTT.Click += new System.EventHandler(this.crawPTT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 299);
            this.Controls.Add(this.crawPTT);
            this.Controls.Add(this.myData);
            this.Controls.Add(this.insertData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertData;
        private System.Windows.Forms.TextBox myData;
        private System.Windows.Forms.Button crawPTT;
    }
}