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

namespace CookDataComparator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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

                MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

				MatchCollection matches = Regex.Matches(fileContent, pattern);

				Debug.Write(matches.Count+"\n");

				foreach (Match match in matches)
				{
					Debug.Write(match.Groups[0].Value);
				}

				/*
				if(m.Success)
				{
					Debug.Write();
					MessageBox.Show(m.Groups.Count.ToString());
				}
				else
				{
					MessageBox.Show("match failed.");
				}
				*/
			}

		}
    }
}
