namespace 생산_가동_현황_모니터링_프로그램
{
    partial class GotoWork
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label_workLine = new MetroFramework.Controls.MetroLabel();
            this.combo_yesNo = new MetroFramework.Controls.MetroComboBox();
            this.combo_workLine = new MetroFramework.Controls.MetroComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btn_OK.Location = new System.Drawing.Point(52, 148);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 29);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "책임유무";
            // 
            // label_workLine
            // 
            this.label_workLine.AutoSize = true;
            this.label_workLine.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_workLine.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_workLine.Location = new System.Drawing.Point(23, 60);
            this.label_workLine.Name = "label_workLine";
            this.label_workLine.Size = new System.Drawing.Size(84, 25);
            this.label_workLine.TabIndex = 6;
            this.label_workLine.Text = "작업라인";
            // 
            // combo_yesNo
            // 
            this.combo_yesNo.FormattingEnabled = true;
            this.combo_yesNo.ItemHeight = 23;
            this.combo_yesNo.Location = new System.Drawing.Point(113, 95);
            this.combo_yesNo.Name = "combo_yesNo";
            this.combo_yesNo.Size = new System.Drawing.Size(121, 29);
            this.combo_yesNo.TabIndex = 3;
            // 
            // combo_workLine
            // 
            this.combo_workLine.FormattingEnabled = true;
            this.combo_workLine.ItemHeight = 23;
            this.combo_workLine.Location = new System.Drawing.Point(113, 60);
            this.combo_workLine.Name = "combo_workLine";
            this.combo_workLine.Size = new System.Drawing.Size(121, 29);
            this.combo_workLine.Sorted = true;
            this.combo_workLine.TabIndex = 4;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Location = new System.Drawing.Point(133, 148);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // GotoWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label_workLine);
            this.Controls.Add(this.combo_yesNo);
            this.Controls.Add(this.combo_workLine);
            this.Name = "GotoWork";
            this.Load += new System.EventHandler(this.GotoWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel label_workLine;
        private MetroFramework.Controls.MetroComboBox combo_yesNo;
        private MetroFramework.Controls.MetroComboBox combo_workLine;
        private System.Windows.Forms.Button btn_Cancel;
    }
}