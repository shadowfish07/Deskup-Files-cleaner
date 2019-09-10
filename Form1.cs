using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 桌面文件清理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_document_directory.Text  = Data.documents_Directory;
            txt_exe_directory.Text = Data.exe_Directory;
            txt_picture_directory.Text = Data.picture_Directory;
            txt_video_directory.Text = Data.video_Directory;
            txt_zip_directory.Text = Data.zip_Directory;
            ReadFiles(Data.deskup_Directory);
            ReadRes();
        }

        private void ReadRes()
        {
            if(File .Exists ("avoidList.txt"))
            {
                using (StreamReader sr = new StreamReader ("avoidList.txt"))
                {
                    string line;
                    int i=0;
                    while ((line = sr.ReadLine() )!= null )
                    {
                        Data.AvoidList[i++] += line;
                    }
                }

            }
            else
            {
                File.Create("avoidList.txt");
            }
        }

        private void  ReadFiles(string  directory)
        {

            DirectoryInfo directory1 = new DirectoryInfo(directory);
            foreach (FileInfo   nextinfo in directory1.GetFiles ()   )
            {
                if (Data .picture_extensioin .Contains ( nextinfo.Extension))
                {
                    Data.picture_num += 1;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1] = new MyFileInfo();
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Name = nextinfo.Name;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Fullname  = nextinfo.FullName ;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].type = MyFileInfo.Type.picture;
                }
                else if(Data.video_extensioin .Contains(nextinfo.Extension))
                {
                    Data.video_num += 1;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1] = new MyFileInfo();
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Name = nextinfo.Name;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Fullname = nextinfo.FullName;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].type = MyFileInfo.Type.video;
                }
                else if(Data.zip_extensioin.Contains(nextinfo.Extension))
                {
                    Data.zip_num += 1;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1] = new MyFileInfo();
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Name = nextinfo.Name;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Fullname = nextinfo.FullName;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].type = MyFileInfo.Type.zip ;
                }
                else if(Data.documents_extensioin .Contains(nextinfo.Extension))
                {
                    Data.documents_num += 1;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1] = new MyFileInfo();
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Name = nextinfo.Name;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Fullname = nextinfo.FullName;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].type =  MyFileInfo.Type.documents ;
                }
                else if (Data.exe_extensioin .Contains(nextinfo.Extension))
                {
                    Data.exe_num += 1;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1] = new MyFileInfo();
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Name = nextinfo.Name;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].Fullname = nextinfo.FullName;
                    Data.fileinfo[Data.picture_num + Data.exe_num + Data.video_num + Data.zip_num + Data.documents_num - 1].type = MyFileInfo.Type.exe ;
                }
            }
            if (Data.picture_num != 0)
            {
                lbl_pic_num.Text = "图片共" + Data.picture_num.ToString() + "个";
            }
            else lbl_pic_num.Visible = false;
            if (Data.video_num   != 0)
            {
                lbl_video_num .Text = "视频共" + Data.video_num .ToString() + "个";
            }
            else lbl_video_num .Visible = false;
            if (Data.zip_num  != 0)
            {
                lbl_zip_num.Text = "压缩包共" + Data.zip_num.ToString() + "个";
            }
            else lbl_zip_num.Visible = false;
            if (Data.documents_num  != 0)
            {
                lbl_documents_num .Text = "文档共" + Data.documents_num.ToString() + "个";
            }
            else lbl_documents_num.Visible = false;
            if (Data.exe_num != 0)
            {
                lbl_exe_num .Text = "程序共" + Data.exe_num .ToString() + "个";
            }
            else lbl_exe_num.Visible = false;
            Label[] lbls = { lbl_pic_num, lbl_video_num, lbl_zip_num, lbl_documents_num, lbl_exe_num };
            int[] nums = { Data.picture_num, Data.video_num, Data.zip_num, Data.documents_num, Data.exe_num };
            int lastvisible = 0;
            
            for (int i = 0; i < 5; i++)
            {
                if (nums[i] !=0 && i != 0)
                {
                    lbls[i].Location = new Point(lbls[lastvisible].Location.X + lbls[lastvisible].Width , lbls[i].Location.Y);
                    lastvisible = i;
                }
                
            }
        }

        private void Btn_sort_Click(object sender, EventArgs e)
        {
            string timeName = "\\" + DateTime.Now.ToShortDateString().Replace ('/','_');
            if (!Directory.Exists(Data.picture_Directory)) Directory.CreateDirectory(Data.picture_Directory);
            if (!Directory.Exists(Data.exe_Directory )) Directory.CreateDirectory(Data.exe_Directory );
            if (!Directory.Exists(Data.video_Directory )) Directory.CreateDirectory(Data.video_Directory );
            if (!Directory.Exists(Data.zip_Directory )) Directory.CreateDirectory(Data.zip_Directory );
            if (!Directory.Exists(Data.documents_Directory)) Directory.CreateDirectory(Data.documents_Directory);
            

            for (int i = 0; i < Data.picture_num+Data.exe_num +Data.video_num +Data.zip_num +Data.documents_num  ; i++)
            {
                if (avoidList.CheckAovidList(Data.fileinfo[i].Fullname)) continue;
                if(chk_cleanByDate .Checked)
                {
                    if (!Directory.Exists(Data.fileinfo[i].GetTargetDirector() +  timeName)) Directory.CreateDirectory(Data.fileinfo[i].GetTargetDirector() + timeName);
                    File.Move(Data.fileinfo[i].Fullname, Data.fileinfo[i].GetTargetDirector()+timeName  + "\\" + Data.fileinfo[i].Name);
                }
                else File.Move(Data.fileinfo[i].Fullname , Data.fileinfo[i].GetTargetDirector() + "\\"+Data.fileinfo[i].Name);
                
            }
            MessageBox.Show("整理完成");
            System.Environment.Exit(0);
        }

        private void Txt_picture_directory_TextChanged(object sender, EventArgs e)
        {
            Data.picture_Directory = txt_picture_directory.Text;
        }

        private void Txt_video_directory_TextChanged(object sender, EventArgs e)
        {
            Data.video_Directory = txt_video_directory.Text;
        }

        private void Txt_zip_directory_TextChanged(object sender, EventArgs e)
        {
            Data.zip_Directory  = txt_zip_directory .Text;
        }

        private void Txt_document_directory_TextChanged(object sender, EventArgs e)
        {
            Data.documents_Directory = txt_document_directory.Text;
        }

        private void Txt_exe_directory_TextChanged(object sender, EventArgs e)
        {
            Data.exe_Directory = txt_exe_directory.Text;
        }

        private void Btn_avoidList_Click(object sender, EventArgs e)
        {
            avoidList al = new avoidList();
            al.Show();
        }
    }
}
