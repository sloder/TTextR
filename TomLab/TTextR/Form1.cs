using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace TTextR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool bFolder = false;
        private bool bReSearch = false;
        private bool bReContent = false;
        private string strContent = "";
        private int fileCount = 0;
        private string ftext = "", rtext = "";
        private bool bReplace = false;
        private Form2 fm = null;
        delegate void ListMessage(string dd);
        private ListMessage lMsg = null;
        private ListMessage aMsg = null;
        private ListMessage bMsg = null;
        private static object oolock = new object();
        private void Form1_Load(object sender, EventArgs e)
        {
            lMsg = new ListMessage(OverMessage);
            aMsg = new ListMessage(AppendMessage);
            bMsg = new ListMessage(AlertMessage);
        }
        private void btSelect_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (cbFloder.Checked)
            {
                dr = fbdFloder.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    lbFilePaths.Text = fbdFloder.SelectedPath;
                    bFolder = true;
                }

            }
            else
            {
                dr = opfPath.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    string fname = string.Join(",", opfPath.FileNames);
                    lbFilePaths.Text = fname;
                    bFolder = false;
                }
            }


        }
        private void OverMessage(string data)
        {
            this.lbFileNum.Text = fileCount.ToString();
            pbWait.Visible = false;
        }
        private void AppendMessage(string data)
        {
            this.tbMessage.Text += "\r\n" + data;
            this.lbFileNum.Text = fileCount.ToString();
        }
        private void AlertMessage(string data)
        {
            this.tbMessage.Text += "\r\n" + data;
        }
        //查询替换主方法
        private void FileOperate()
        {
            if (lbFilePaths.Text != "")
            {
                ftext = tbFindText.Text.Trim();
                string extNames = tbExt.Text;

                Thread th;
                string fpath = lbFilePaths.Text;
                if (fpath == "") return;
                FileInfo[] arrFI = null;
                strContent = "";
                bReSearch = cbRE.Checked;
                if (cbInclude.Checked)
                    strContent = tbIncludeText.Text.Trim();
                if (ftext == "" && strContent == "")
                {
                    MessageBox.Show("请输入查找过滤内容！");
                    return;
                }
                rtext = tbReplaceText.Text;
                bReContent = cbReInclude.Checked;
                pbWait.Visible = true;
                fileCount = 0;
                tbMessage.Text = "";
                this.lbFileNum.Text = "0";
                if (bFolder)
                {
                    DirectoryInfo diA = new DirectoryInfo(fpath);
                    if (extNames == "")
                    {                        
                        arrFI = diA.GetFiles("*.*", SearchOption.AllDirectories);
                        th = new Thread(new ParameterizedThreadStart(FindFile));
                        th.Start(arrFI);
                    }
                    else
                    {
                        string[] extNameArr = extNames.Split(',');
                        for (int i = 0; i < extNameArr.Length; i++)
                        {
                            pbWait.Visible = true;
                            arrFI = diA.GetFiles(extNameArr[i], SearchOption.AllDirectories);
                            th = new Thread(new ParameterizedThreadStart(FindFile));
                            th.Start(arrFI);
                        }
                    }
                }
                else
                {
                    string[] paths = fpath.Split(',');
                    arrFI = new FileInfo[paths.Length];
                    for (int i = 0; i < arrFI.Length; i++)
                    {
                        arrFI[i] = new FileInfo(paths[i]);
                    }
                    th = new Thread(new ParameterizedThreadStart(FindFile));
                    th.Start(arrFI);
                }
            }
        }
        private void btFileCount_Click(object sender, EventArgs e)
        {
            bReplace = false;
            FileOperate();
        }
        /// <summary>
        /// 获取文件编码
        /// </summary>
        /// <param name="fs"></param>
        /// <returns></returns>
        public Encoding GetFileEncodeType(FileStream fs)
        {
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
            Byte[] buffer = br.ReadBytes(2);
            if (buffer.Length < 2) return null;
            //br.Close();
            Encoding ed = Encoding.ASCII;
            if (buffer[0] >= 0xEF)
            {
                if (buffer[0] == 0xEF && buffer[1] == 0xBB)
                {
                    ed = Encoding.UTF8;
                }
                else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                {
                    ed = Encoding.BigEndianUnicode;
                }
                else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                {
                    ed = Encoding.Unicode;
                }
                else
                {
                    ed = Encoding.Default;
                }
            }
            else
            {
                ed = Encoding.Default;
            }
            return ed;

        }
        /// <summary>
        /// 查询线程方法
        /// </summary>
        /// <param name="oo"></param>
        private void FindFile(object oo)
        {
            FileInfo[] fis = oo as FileInfo[];
            if (fis != null)
            {
                FileStream fs = null;
                FileInfo fi = null;
                int count;
                string text = "";
                byte[] bts = new byte[1024000];
                foreach (FileInfo fix in fis)
                {
                    try
                    {
                        fi = fix;
                        if (bReplace)
                            fs = fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                        else
                            fs = fi.OpenRead();
                        var ed = GetFileEncodeType(fs);
                        if (ed == null) continue;
                        fs.Seek(0, SeekOrigin.Begin);                        
                        count = fs.Read(bts, 0, 1024000);
                        text = ed.GetString(bts, 0, count);

                        if (strContent != "")
                        {
                            if (bReContent)
                            {
                                Regex rg = new Regex(strContent, RegexOptions.Multiline);
                                var mt = rg.Match(text);
                                if (mt.Success)
                                {
                                    if (ftext != "")
                                    {
                                        if (OperateContent(text, fs, ftext, ed))
                                        {
                                            lock (oolock)
                                            {
                                                fileCount++;
                                            }
                                            this.Invoke(aMsg, fi.FullName);
                                        }
                                    }
                                    else
                                    {
                                        lock (oolock)
                                        {
                                            fileCount++;
                                        }
                                        this.Invoke(aMsg, fi.FullName);
                                    }
                                }
                            }
                            else
                            {
                                if (text.IndexOf(strContent) > 0)
                                {
                                    if (ftext != "")
                                    {
                                        if (OperateContent(text, fs, ftext, ed))
                                        {
                                            lock (oolock)
                                            {
                                                fileCount++;
                                            }
                                            this.Invoke(aMsg, fi.FullName);
                                        }
                                    }
                                    else
                                    {
                                        lock (oolock)
                                        {
                                            fileCount++;
                                        }
                                        this.Invoke(aMsg, fi.FullName);
                                    }

                                }
                            }
                        }
                        else //搜索包含内容为空
                        {
                            if (ftext != "")
                            {
                                if (OperateContent(text, fs, ftext, ed))
                                {
                                    lock (oolock)
                                    {
                                        fileCount++;
                                    }
                                    this.Invoke(aMsg, fi.FullName);
                                }
                            }
                            else
                            {
                                lock (oolock)
                                {
                                    fileCount++;
                                }
                                this.Invoke(aMsg, fi.FullName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Tom.Common.GYF.WriteLogEx(ex, fix.FullName, "ccc");                        
                        break;
                    }
                    finally
                    {
                        if (fs != null) fs.Close();
                    }
                }

            }
            this.Invoke(lMsg, "");
        }
        /// <summary>
        /// 查询替换文件子方法
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fs"></param>
        /// <param name="fftext"></param>
        /// <param name="ed"></param>
        /// <returns></returns>
        private bool OperateContent(string text, FileStream fs, string fftext, Encoding ed)
        {
            bool find = false;
            byte[] byteTemp;
            if (bReSearch)
            {
                Regex rg = new Regex(fftext, RegexOptions.Multiline);
                var mt = rg.Match(text);
                if (mt.Success)
                {
                    find = true;
                    if (bReplace)
                    {
                        text = Regex.Replace(text, fftext, rtext, RegexOptions.Multiline);
                        byteTemp = ed.GetBytes(text);
                        fs.SetLength(0);
                        fs.Write(byteTemp, 0, byteTemp.Length);
                        //fs.Flush();
                    }
                }
            }
            else
            {
                if (text.IndexOf(fftext) > 0)
                {
                    find = true;
                    if (bReplace)
                    {
                        text = text.Replace(fftext, rtext);
                        byteTemp = ed.GetBytes(text);
                        fs.SetLength(0);
                        fs.Write(byteTemp, 0, byteTemp.Length);
                        //fs.Flush();
                    }
                }
            }
            return find;
        }
        private void btReplace_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("确实需要替换吗？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                return;
            }
            bReplace = true;
            FileOperate();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            if (fm == null) fm = new Form2();

            fm.ShowDialog(this);
        }

        private void cbInclude_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInclude.Checked)
            {
                cbReInclude.Enabled = true;
                tbIncludeText.Enabled = true;
            }
            else
            {
                cbReInclude.Enabled = false;
                tbIncludeText.Enabled = false;
                cbReInclude.Checked = false;
            }
        }



    }
}
