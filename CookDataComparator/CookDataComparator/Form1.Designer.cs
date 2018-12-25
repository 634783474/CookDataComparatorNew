namespace CookDataComparator
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonSrcData = new System.Windows.Forms.Button();
            this.openFileDialogSrcData = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSrc);
            this.panel1.Location = new System.Drawing.Point(28, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 341);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.ForeColor = System.Drawing.Color.Black;
            this.textBoxSrc.Location = new System.Drawing.Point(3, 3);
            this.textBoxSrc.Multiline = true;
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(415, 335);
            this.textBoxSrc.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxTemp);
            this.panel2.Location = new System.Drawing.Point(487, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 341);
            this.panel2.TabIndex = 1;
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(3, 3);
            this.textBoxTemp.Multiline = true;
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(415, 335);
            this.textBoxTemp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "原始数据：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "对比数据：";
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(430, 408);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(83, 29);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "比较";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(28, 462);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(880, 260);
            this.richTextBoxResult.TabIndex = 5;
            this.richTextBoxResult.Text = "";
            // 
            // buttonSrcData
            // 
            this.buttonSrcData.Location = new System.Drawing.Point(118, 12);
            this.buttonSrcData.Name = "buttonSrcData";
            this.buttonSrcData.Size = new System.Drawing.Size(328, 30);
            this.buttonSrcData.TabIndex = 6;
            this.buttonSrcData.Text = "导入原始数据";
            this.buttonSrcData.UseVisualStyleBackColor = true;
            this.buttonSrcData.Click += new System.EventHandler(this.buttonSrcData_Click);
            // 
            // openFileDialogSrcData
            // 
            this.openFileDialogSrcData.FileName = "openFileDialogSrcData";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 753);
            this.Controls.Add(this.buttonSrcData);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "CookDataComparator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonSrcData;
        private System.Windows.Forms.OpenFileDialog openFileDialogSrcData;
    }
}

