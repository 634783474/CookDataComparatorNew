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
            this.components = new System.ComponentModel.Container();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onOffRadioButton = new System.Windows.Forms.RadioButton();
            this.serialportOpenButton = new System.Windows.Forms.Button();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.parityLabel = new System.Windows.Forms.Label();
            this.stopbitsComboBox = new System.Windows.Forms.ComboBox();
            this.stopbitsLabel = new System.Windows.Forms.Label();
            this.databitsComboBox = new System.Windows.Forms.ComboBox();
            this.databitsLabel = new System.Windows.Forms.Label();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.baudLabel = new System.Windows.Forms.Label();
            this.serialportNameComboBox = new System.Windows.Forms.ComboBox();
            this.serialportNameLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.textBoxTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "待对比数据：";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onOffRadioButton);
            this.groupBox1.Controls.Add(this.serialportOpenButton);
            this.groupBox1.Controls.Add(this.parityComboBox);
            this.groupBox1.Controls.Add(this.parityLabel);
            this.groupBox1.Controls.Add(this.stopbitsComboBox);
            this.groupBox1.Controls.Add(this.stopbitsLabel);
            this.groupBox1.Controls.Add(this.databitsComboBox);
            this.groupBox1.Controls.Add(this.databitsLabel);
            this.groupBox1.Controls.Add(this.baudComboBox);
            this.groupBox1.Controls.Add(this.baudLabel);
            this.groupBox1.Controls.Add(this.serialportNameComboBox);
            this.groupBox1.Controls.Add(this.serialportNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(928, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(322, 338);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口参数设置";
            // 
            // onOffRadioButton
            // 
            this.onOffRadioButton.AutoSize = true;
            this.onOffRadioButton.BackColor = System.Drawing.Color.White;
            this.onOffRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffRadioButton.Location = new System.Drawing.Point(48, 279);
            this.onOffRadioButton.Name = "onOffRadioButton";
            this.onOffRadioButton.Size = new System.Drawing.Size(17, 16);
            this.onOffRadioButton.TabIndex = 10;
            this.onOffRadioButton.UseVisualStyleBackColor = false;
            // 
            // serialportOpenButton
            // 
            this.serialportOpenButton.Location = new System.Drawing.Point(105, 267);
            this.serialportOpenButton.Name = "serialportOpenButton";
            this.serialportOpenButton.Size = new System.Drawing.Size(163, 40);
            this.serialportOpenButton.TabIndex = 9;
            this.serialportOpenButton.Text = "打开串口";
            this.serialportOpenButton.UseVisualStyleBackColor = true;
            this.serialportOpenButton.Click += new System.EventHandler(this.serialportOpenButton_Click);
            // 
            // parityComboBox
            // 
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.parityComboBox.Location = new System.Drawing.Point(135, 224);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(131, 34);
            this.parityComboBox.TabIndex = 8;
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parityLabel.Location = new System.Drawing.Point(5, 227);
            this.parityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(147, 27);
            this.parityLabel.TabIndex = 7;
            this.parityLabel.Text = "奇偶校验：";
            // 
            // stopbitsComboBox
            // 
            this.stopbitsComboBox.FormattingEnabled = true;
            this.stopbitsComboBox.Items.AddRange(new object[] {
            "1"});
            this.stopbitsComboBox.Location = new System.Drawing.Point(135, 181);
            this.stopbitsComboBox.Name = "stopbitsComboBox";
            this.stopbitsComboBox.Size = new System.Drawing.Size(131, 34);
            this.stopbitsComboBox.TabIndex = 6;
            // 
            // stopbitsLabel
            // 
            this.stopbitsLabel.AutoSize = true;
            this.stopbitsLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopbitsLabel.Location = new System.Drawing.Point(13, 184);
            this.stopbitsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.stopbitsLabel.Name = "stopbitsLabel";
            this.stopbitsLabel.Size = new System.Drawing.Size(120, 27);
            this.stopbitsLabel.TabIndex = 5;
            this.stopbitsLabel.Text = "停止位：";
            // 
            // databitsComboBox
            // 
            this.databitsComboBox.FormattingEnabled = true;
            this.databitsComboBox.Items.AddRange(new object[] {
            "8"});
            this.databitsComboBox.Location = new System.Drawing.Point(135, 138);
            this.databitsComboBox.Name = "databitsComboBox";
            this.databitsComboBox.Size = new System.Drawing.Size(131, 34);
            this.databitsComboBox.TabIndex = 6;
            // 
            // databitsLabel
            // 
            this.databitsLabel.AutoSize = true;
            this.databitsLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.databitsLabel.Location = new System.Drawing.Point(13, 141);
            this.databitsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.databitsLabel.Name = "databitsLabel";
            this.databitsLabel.Size = new System.Drawing.Size(120, 27);
            this.databitsLabel.TabIndex = 5;
            this.databitsLabel.Text = "数据位：";
            // 
            // baudComboBox
            // 
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudComboBox.Location = new System.Drawing.Point(135, 95);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(131, 34);
            this.baudComboBox.TabIndex = 3;
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baudLabel.Location = new System.Drawing.Point(13, 98);
            this.baudLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(120, 27);
            this.baudLabel.TabIndex = 2;
            this.baudLabel.Text = "波特率：";
            // 
            // serialportNameComboBox
            // 
            this.serialportNameComboBox.FormattingEnabled = true;
            this.serialportNameComboBox.Location = new System.Drawing.Point(135, 52);
            this.serialportNameComboBox.Name = "serialportNameComboBox";
            this.serialportNameComboBox.Size = new System.Drawing.Size(131, 34);
            this.serialportNameComboBox.TabIndex = 1;
            // 
            // serialportNameLabel
            // 
            this.serialportNameLabel.AutoSize = true;
            this.serialportNameLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serialportNameLabel.Location = new System.Drawing.Point(13, 55);
            this.serialportNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.serialportNameLabel.Name = "serialportNameLabel";
            this.serialportNameLabel.Size = new System.Drawing.Size(120, 27);
            this.serialportNameLabel.TabIndex = 0;
            this.serialportNameLabel.Text = "串口名：";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 753);
            this.Controls.Add(this.groupBox1);
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
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton onOffRadioButton;
        private System.Windows.Forms.Button serialportOpenButton;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.ComboBox stopbitsComboBox;
        private System.Windows.Forms.Label stopbitsLabel;
        private System.Windows.Forms.ComboBox databitsComboBox;
        private System.Windows.Forms.Label databitsLabel;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.ComboBox serialportNameComboBox;
        private System.Windows.Forms.Label serialportNameLabel;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

