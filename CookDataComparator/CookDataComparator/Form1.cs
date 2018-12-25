using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections;

namespace CookDataComparator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        ArrayList portList = new ArrayList();

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            List<char> charSrcList = new List<char>() ;

            List<char> charTempList = new List<char>();
            
            String strSrc = textBoxSrc.Text;
            String strTemp = textBoxTemp.Text;

            strSrc=strSrc.Replace("\n", "").Replace("\r", "").Replace(" ", "");

            strTemp = strTemp.Replace("\n", "").Replace("\r", "").Replace(" ", "");

            charSrcList.AddRange(strSrc.ToCharArray());
            charTempList.AddRange(strTemp.ToCharArray());

            List<bool> isSameList = new List<bool>();

            for (int i = 0; i < charSrcList.Count; i++)
            {
                isSameList.Add(false);
            }

            for (int i=0;i< isSameList.Count;i++)
            {
                if(Char.Equals(charSrcList[i],charTempList[i])==false)
                {
                    isSameList[i] = false;
                    
                }
                else
                {
                    isSameList[i] = true;
                }
            }

            richTextBoxResult.Clear();
            richTextBoxResult.Font = new Font(FontFamily.GenericMonospace, 20.0F,
        FontStyle.Regular, GraphicsUnit.Pixel);
            //textBoxSrc.Clear();
            //textBoxTemp.Clear();
            for (int i=0;i<isSameList.Count;i+=2)
            {
                richTextBoxResult.SelectionStart = i;
                richTextBoxResult.SelectionLength = 2;

                if ((isSameList[i] == true)&&(isSameList[i+1] == true))
                {
                    richTextBoxResult.SelectionColor = Color.Black;
                    //textBoxTemp.ForeColor = Color.Black;
                }
                else
                {
                    richTextBoxResult.SelectionColor = Color.Red;
                    //textBoxSrc.ForeColor = Color.Red;
                    //textBoxTemp.ForeColor = Color.Red;
                }


                richTextBoxResult.AppendText(charSrcList[i].ToString());
                richTextBoxResult.AppendText(charSrcList[i+1].ToString());
                //textBoxTemp.AppendText(charTempList[i].ToString());
            }



            /*
            if(String.CompareOrdinal(strSrc, strTemp)!=0)
            {
                MessageBox.Show("两个字符不相等!!!");
            }
            else
            {
                MessageBox.Show("两个字符相等");
            }
            */
        }

        private void buttonSrcData_Click(object sender, EventArgs e)
        {
            string srcStr=null;
            
			string pattern = @"0x[0-9 a-f A-F]{1,2}|[0-9]{1,3}";
			var fileContent = string.Empty;
            var filePath = string.Empty;
            openFileDialogSrcData.Filter = "js files (*.js)|*.js|All files (*.*)|*.*";
            //openFileDialogSrcData.ShowDialog();

            if (openFileDialogSrcData.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialogSrcData.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialogSrcData.OpenFile();

                StreamReader reader = new StreamReader(fileStream);
                
                fileContent = reader.ReadToEnd();

                fileContent = fileContent.Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("\t","");

                //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

				MatchCollection matches = Regex.Matches(fileContent, pattern);

				//Debug.Write(matches.Count+"\n");
                if(matches.Count!=133)
                {
                     MessageBox.Show("指定的文件格式不对。");
                }
                else
                {
                    foreach (Match match in matches)
				    {
					    //Debug.Write(match.Groups[0].Value);
                        //Debug.Write("\n");
                        //string beforeFormat=Convert.ToString(Convert.ToUInt16(match.Groups[0].Value,16),16)

                        string valueTemp = match.Groups[0].Value;

                        Match match1 = Regex.Match(valueTemp, "0[x|X]");
                        Int16 a;
                        if(match1.Success)
                        {
                            a = Convert.ToInt16(match.Groups[0].Value, 16);
                        }
                        else
                        {
                            a = Convert.ToInt16(match.Groups[0].Value, 10);
                        }
                         
                        string strTemp = String.Format("{0:x2}", a);

                        srcStr+=strTemp;
				    }

                    textBoxSrc.Text = srcStr;
                }
				
                //MessageBox.Show(srcStr);
			
			}

		}

        private void FormMain_Shown(object sender, EventArgs e)
        {
            portList.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            portList.Sort();
            serialportNameComboBox.Items.AddRange(portList.ToArray());
            serialportNameComboBox.SelectedIndex = 0;
            baudComboBox.SelectedIndex = 1;
            databitsComboBox.SelectedIndex = 0;
            stopbitsComboBox.SelectedIndex = 0;
            parityComboBox.SelectedIndex = 0;
        }

        private void serialportOpenButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialportOpenButton.Text = "打开串口";
                onOffRadioButton.Checked = false;
                return;
            }
            serialPort1.PortName = serialportNameComboBox.Text;
            serialPort1.BaudRate = Convert.ToInt32(baudComboBox.Text);
            serialPort1.DataBits = Convert.ToInt32(databitsComboBox.Text);
            if (stopbitsComboBox.Text == "1")
            {
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
            }
            else
            {
                serialPort1.StopBits = System.IO.Ports.StopBits.None;
            }

            if (parityComboBox.Text == "偶校验")
            {
                serialPort1.Parity = System.IO.Ports.Parity.Even;
            }
            else if (parityComboBox.Text == "奇校验")
            {
                serialPort1.Parity = System.IO.Ports.Parity.Odd;
            }
            else
            {
                serialPort1.Parity = System.IO.Ports.Parity.None;
            }

            try
            {
                serialPort1.Open();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }


            serialportOpenButton.Text = "关闭串口";
            onOffRadioButton.Checked = true;
        }

        string gblStr;
        bool isMatchCdk = false;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string serialPortRecData=serialPort1.ReadExisting();
            gblStr+= serialPortRecData;
            Match match = Regex.Match(gblStr, "CKD:");
            if((match.Success)&&(isMatchCdk==false))
            {
                isMatchCdk = true;
                //MessageBox.Show("发现烹饪数据标记");

                MatchCollection matches = Regex.Matches(gblStr, "[0-9 a-f]{266}");
                Debug.Write(matches.Count + "\n");
                string valueTemp = null ;
                foreach (Match match1 in matches)
                {
                    valueTemp += match1.Groups[0].Value;
                }
                gblStr = null;
                isMatchCdk = false;

                this.Invoke(new EventHandler(delegate
                {
                    textBoxTemp.Clear();
                    textBoxTemp.Text += valueTemp;
                    
                }));
            }
           
        }
    }
}
