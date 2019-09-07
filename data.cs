using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桌面文件清理
{
    static class  Data
    {
        public  const  string ADMIN_FOLDER_NAME = "\\自动整理";
        public static string deskup_Directory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static string picture_Directory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)+ ADMIN_FOLDER_NAME + "_图片";
        public static string exe_Directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments ) + ADMIN_FOLDER_NAME + "_程序";
        public static string documents_Directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ADMIN_FOLDER_NAME + "_文档";
        public static string video_Directory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures ) + ADMIN_FOLDER_NAME + "_视频";
        public static string zip_Directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments ) + ADMIN_FOLDER_NAME + "_压缩包";
        public static string picture_extensioin = ".jpg .jpeg .bmp .png";
        public static string exe_extensioin = ".exe";
        public static string documents_extensioin = ".doc .docx .xlsx .ppt .pptx";
        public static string video_extensioin = ".mpg .mpeg .avi .mp4";
        public static string zip_extensioin = ".zip .rar";
        public static int picture_num = 0;
        public static int exe_num = 0;
        public static int documents_num = 0;
        public static int video_num = 0;
        public static int zip_num = 0;
        public static MyFileInfo[] fileinfo = new MyFileInfo[1000];
        public static string[] AvoidList = new string[1000];
    }
    class MyFileInfo
    {
        public string Name;
        public string Fullname;
        public enum Type
        {
            picture,
            zip,
            video,
            documents,
            exe
        }
        public Type type = new Type() ;
        public string GetTargetDirector()
        {
            if (type == Type.picture) return Data.picture_Directory;
            if (type == Type.zip ) return Data.zip_Directory ;
            if (type == Type.video ) return Data.video_Directory ;
            if (type == Type.documents ) return Data.documents_Directory ;
            if (type == Type.exe) return Data.exe_Directory ;
            return "";
        }
    }
}
