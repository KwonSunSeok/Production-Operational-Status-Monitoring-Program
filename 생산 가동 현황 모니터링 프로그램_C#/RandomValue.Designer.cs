namespace 생산_가동_현황_모니터링_프로그램
{
    partial class RandomValue
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
            this.btn_randomValue = new System.Windows.Forms.Button();
            this.btn_randomAuto = new System.Windows.Forms.Button();
            this.btn_randomAutoStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_randomValue
            // 
            this.btn_randomValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randomValue.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_randomValue.Location = new System.Drawing.Point(23, 63);
            this.btn_randomValue.Name = "btn_randomValue";
            this.btn_randomValue.Size = new System.Drawing.Size(163, 104);
            this.btn_randomValue.TabIndex = 0;
            this.btn_randomValue.Text = "랜덤변수 입력";
            this.btn_randomValue.UseVisualStyleBackColor = true;
            this.btn_randomValue.Click += new System.EventHandler(this.btn_randomValue_Click);
            // 
            // btn_randomAuto
            // 
            this.btn_randomAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randomAuto.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_randomAuto.Location = new System.Drawing.Point(192, 63);
            this.btn_randomAuto.Name = "btn_randomAuto";
            this.btn_randomAuto.Size = new System.Drawing.Size(264, 49);
            this.btn_randomAuto.TabIndex = 1;
            this.btn_randomAuto.Text = "랜덤변수 자동 입력 Start";
            this.btn_randomAuto.UseVisualStyleBackColor = true;
            this.btn_randomAuto.Click += new System.EventHandler(this.btn_randomAuto_Click);
            // 
            // btn_randomAutoStop
            // 
            this.btn_randomAutoStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randomAutoStop.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_randomAutoStop.Location = new System.Drawing.Point(192, 118);
            this.btn_randomAutoStop.Name = "btn_randomAutoStop";
            this.btn_randomAutoStop.Size = new System.Drawing.Size(264, 49);
            this.btn_randomAutoStop.TabIndex = 2;
            this.btn_randomAutoStop.Text = "랜덤변수 자동 입력 Stop";
            this.btn_randomAutoStop.UseVisualStyleBackColor = true;
            this.btn_randomAutoStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // RandomValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 218);
            this.Controls.Add(this.btn_randomAutoStop);
            this.Controls.Add(this.btn_randomAuto);
            this.Controls.Add(this.btn_randomValue);
            this.Name = "RandomValue";
            this.Text = "랜덤변수 입력";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RandomValue_FormClosed);
            this.Load += new System.EventHandler(this.RandomValue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_randomValue;
        private System.Windows.Forms.Button btn_randomAuto;
        private System.Windows.Forms.Button btn_randomAutoStop;
    }
}