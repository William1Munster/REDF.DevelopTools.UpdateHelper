
using System.IO;
using System.Text;
using System;

namespace REDF.DevelopTools.UpdateHelper
{
    /// <summary>
    /// Copyright (c) 2002-2009 Dhthx
    /// ������:     �������˼����Ŷ�
    /// ����:       2008-08-01
    ///
    /// �汾:       3.5
    /// ����:       �ļ�����,�����ļ����� 
    /// ģ����:   
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// ���ļ���Ϊ��д״̬
        /// </summary>
        /// <param name="filePath">�ļ���</param>
        public static void ChangeFileAttributesToWritable(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            FileAttributes attributes = File.GetAttributes(filePath);
            FileAttributes attr = attributes | FileAttributes.ReadOnly;
            if (attr == attributes)
            {
                attributes ^= FileAttributes.ReadOnly;
                File.SetAttributes(filePath, attributes);
            }
        }
        /// <summary>
        /// �ж��ļ��Ƿ�Ϊֻ��״̬
        /// </summary>
        /// <param name="filePath">�ļ���</param>
        /// <returns>boolֵ</returns>
        public static bool IsFileReadOnly(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }
            FileAttributes attributes = File.GetAttributes(filePath);
            FileAttributes attr = attributes | FileAttributes.ReadOnly;
            if (attr == attributes)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// ����0�ֽ��ļ�
        /// </summary>
        /// <param name="filePath">�ļ���</param>
        public static void CreateZeroByteFile(string filePath)
        {
            using (File.Create(filePath))
            {
            }
        }
        /// <summary>
        /// �����ⲿӦ�ó���
        /// </summary>
        /// <param name="fileName">�ļ�����</param>
        public static void ShellOpenFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }
            else
            {
                System.Diagnostics.Process.Start(fileName);
            }
        }

        public static string ReadText(string strFileName)
        {
            string line;
            StringBuilder strResult = new StringBuilder();
            if (!File.Exists(strFileName))
                return "";
            try
            {   StreamReader sr = new StreamReader(strFileName);
                line = sr.ReadLine();
                while (line != null)
                {
                   line = sr.ReadLine();
                   strResult.Append(line);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return strResult.ToString();
        }
        public static void WriteText(string strFileName,string strContent)
        {
            try
            {
                StreamWriter sw = new StreamWriter(strFileName, true, Encoding.ASCII);
                sw.Write(strContent);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
        private static FileStream GetFileStream(string pathName)
        {
            return (new System.IO.FileStream(pathName, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite));
        }
        public static string GetMD5Hash(string pathName)
        {
            string strResult = "";
            string strHashData = "";

            byte[] arrbytHashValue;
            System.IO.FileStream oFileStream = null;

            System.Security.Cryptography.MD5CryptoServiceProvider oMD5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();

            try
            {
                oFileStream = GetFileStream(pathName);
                arrbytHashValue = oMD5Hasher.ComputeHash(oFileStream);
                oFileStream.Close();

                strHashData = System.BitConverter.ToString(arrbytHashValue);
                strHashData = strHashData.Replace("-", "");
                strResult = strHashData;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            }

            return (strResult);
        }
    }
}