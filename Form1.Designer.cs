namespace SerializationDemo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSerialization = new System.Windows.Forms.Button();
            this.btnDeserialization = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(693, 441);
            this.textBox1.TabIndex = 2;
            // 
            // btnSerialization
            // 
            this.btnSerialization.Location = new System.Drawing.Point(13, 22);
            this.btnSerialization.Name = "btnSerialization";
            this.btnSerialization.Size = new System.Drawing.Size(217, 23);
            this.btnSerialization.TabIndex = 0;
            this.btnSerialization.Text = "Serialization";
            this.btnSerialization.UseVisualStyleBackColor = true;
            this.btnSerialization.Click += new System.EventHandler(this.btnSerialization_Click);
            // 
            // btnDeserialization
            // 
            this.btnDeserialization.Location = new System.Drawing.Point(13, 52);
            this.btnDeserialization.Name = "btnDeserialization";
            this.btnDeserialization.Size = new System.Drawing.Size(217, 23);
            this.btnDeserialization.TabIndex = 1;
            this.btnDeserialization.Text = "Deserialization";
            this.btnDeserialization.UseVisualStyleBackColor = true;
            this.btnDeserialization.Click += new System.EventHandler(this.btnDeserialization_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deserialization";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Serialization";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDeserialization);
            this.Controls.Add(this.btnSerialization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSerialization;
        private System.Windows.Forms.Button btnDeserialization;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

