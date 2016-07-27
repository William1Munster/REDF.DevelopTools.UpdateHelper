using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace REDF.DevelopTools.UpdateHelper
{
    public partial class FormUpdateHalper : Form
    {
        public FormUpdateHalper()
        {
            InitializeComponent();
        }

        private string strPath = "";
        /// <summary>
        /// 选择要更新的文件目录，生成目录下的所有文件以及文件夹的md5信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckFIles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (strPath != "")
            {
                fbd.SelectedPath = strPath;
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                strPath = fbd.SelectedPath;
            }


            //fbd.ShowDialog();
            if (fbd.SelectedPath == "")
                return;

            dsAssemblyInfor.Clear();


            strPath = fbd.SelectedPath;
            CheckFiles(new DirectoryInfo(strPath));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p = Properties.Settings.Default.path;
            if (!string.IsNullOrEmpty(p))
                openFileDialog1.InitialDirectory = p;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string f = openFileDialog1.FileName;
                p = Path.GetDirectoryName(f);
                Properties.Settings.Default.path = p;
                Properties.Settings.Default.Save();
                //MessageBox.Show(p);
            }
        }
        /// <summary>
        /// 递归生成文件信息
        /// </summary>
        /// <param name="dirInfor"></param>
        private void CheckFiles(DirectoryInfo dirInfor)
        {
            // 复制所有文件
            FileInfo[] files = dirInfor.GetFiles();
            foreach (FileInfo file in files)
            {
                string strName = file.FullName;
                string strMD5 = FileHelper.GetMD5Hash(strName);
                string strExtension = file.Extension;
                long FileSize = file.Length / 1024;
                if (strName != "AssemblyInfor.xml")
                    dsAssemblyInfor.AssemblyInfor.Rows.Add(strName.Replace(strPath, ""), strMD5, strExtension, FileSize.ToString());
            }

            // 处理子目录
            DirectoryInfo[] dirs = dirInfor.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                string destinationDir = Path.Combine(dirInfor.FullName, dir.Name);
                //记录文件夹信息
                dsAssemblyInfor.DirectoriesInfor.Rows.Add(destinationDir.Replace(strPath, ""));

                // 递归处理子目录
                CheckFiles(new DirectoryInfo(destinationDir));
            }
        }
        /// <summary>
        /// 排除不需要更新的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelFileInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = bsAssemblyInfor.Current as DataRowView;
            if (drv != null)
            {
                drv.Delete();
            }
        }
        /// <summary>
        /// 发布更新列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFileList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dsAssemblyInfor.AssemblyInfor.Rows.Count > 0)
            {
                dsAssemblyInfor.WriteXml(strPath + "\\AssemblyInfor.xml");
                dsAssemblyInfor.AcceptChanges();
            }
            else
                MessageBox.Show("请检查发布文件内容后再进行此操作!");
        }
        private string strOlePatch = "";
        /// <summary>
        /// 读取已有的更新列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadFileXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "更新文件 (AssemblyInfor.xml)|AssemblyInfor.xml";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dsAssemblyInfor.Clear();
                if (File.Exists(ofd.FileName) && ofd.FileName.Contains("AssemblyInfor.xml"))
                {
                    strOlePatch = ofd.FileName;
                    dsAssemblyInfor.ReadXml(ofd.FileName);
                }
            }
        }
        /// <summary>
        /// 更新特定文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckOneFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            string strPatch = strOlePatch.Replace("\\AssemblyInfor.xml", "");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileNames.Length > 0)
                {
                    foreach (string FileName in ofd.FileNames)
                    {
                        if (File.Exists(FileName))
                        {
                            FileInfo file = new FileInfo(FileName);
                            DataRow[] drs = dsAssemblyInfor.AssemblyInfor.Select("AssemblyName = '" + FileName.Replace(strPatch, "") + "'");
                            if (drs.Length == 1)
                            {
                                drs[0]["AssemblyMD5"] = FileHelper.GetMD5Hash(FileName);
                                drs[0]["AssemblyExtension"] = file.Extension;
                                drs[0]["AssemblySize"] = file.Length / 1024;
                            }
                            else if (drs.Length == 0)
                            {
                                DataRow drn = dsAssemblyInfor.AssemblyInfor.NewRow();
                                drn["AssemblyName"] = FileName.Replace(strPatch, "");
                                drn["AssemblyMD5"] = FileHelper.GetMD5Hash(FileName);
                                drn["AssemblyExtension"] = file.Extension;
                                drn["AssemblySize"] = file.Length / 1024;
                                dsAssemblyInfor.AssemblyInfor.Rows.Add(drn);
                            }
                        }
                    }

                }
            }
        }
        /// <summary>
        /// 保存更改后的文件信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dsAssemblyInfor.AssemblyInfor.Rows.Count > 0)
            {
                dsAssemblyInfor.WriteXml(strOlePatch);
                dsAssemblyInfor.AcceptChanges();
            }
            else
                MessageBox.Show("请检查发布文件内容后再进行此操作!");
        }
    }
}
