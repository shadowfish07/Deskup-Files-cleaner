namespace 桌面文件清理
{
    partial class Form1
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
            this.txt_video_directory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_zip_directory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_picture_directory = new System.Windows.Forms.TextBox();
            this.txt_exe_directory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_pic_num = new System.Windows.Forms.Label();
            this.lbl_video_num = new System.Windows.Forms.Label();
            this.lbl_zip_num = new System.Windows.Forms.Label();
            this.lbl_exe_num = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.txt_document_directory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_documents_num = new System.Windows.Forms.Label();
            this.chk_cleanByDate = new System.Windows.Forms.CheckBox();
            this.btn_avoidList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_video_directory
            // 
            this.txt_video_directory.Location = new System.Drawing.Point(123, 98);
            this.txt_video_directory.Name = "txt_video_directory";
            this.txt_video_directory.Size = new System.Drawing.Size(348, 27);
            this.txt_video_directory.TabIndex = 3;
            this.txt_video_directory.TextChanged += new System.EventHandler(this.Txt_video_directory_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "视频存放路径";
            // 
            // txt_zip_directory
            // 
            this.txt_zip_directory.Location = new System.Drawing.Point(123, 131);
            this.txt_zip_directory.Name = "txt_zip_directory";
            this.txt_zip_directory.Size = new System.Drawing.Size(348, 27);
            this.txt_zip_directory.TabIndex = 5;
            this.txt_zip_directory.TextChanged += new System.EventHandler(this.Txt_zip_directory_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "压缩包存放路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片存放路径";
            // 
            // txt_picture_directory
            // 
            this.txt_picture_directory.Location = new System.Drawing.Point(123, 62);
            this.txt_picture_directory.Name = "txt_picture_directory";
            this.txt_picture_directory.Size = new System.Drawing.Size(348, 27);
            this.txt_picture_directory.TabIndex = 1;
            this.txt_picture_directory.TextChanged += new System.EventHandler(this.Txt_picture_directory_TextChanged);
            // 
            // txt_exe_directory
            // 
            this.txt_exe_directory.Location = new System.Drawing.Point(123, 197);
            this.txt_exe_directory.Name = "txt_exe_directory";
            this.txt_exe_directory.Size = new System.Drawing.Size(348, 27);
            this.txt_exe_directory.TabIndex = 7;
            this.txt_exe_directory.TextChanged += new System.EventHandler(this.Txt_exe_directory_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "程序存放路径";
            // 
            // lbl_pic_num
            // 
            this.lbl_pic_num.AutoSize = true;
            this.lbl_pic_num.Location = new System.Drawing.Point(11, 13);
            this.lbl_pic_num.Name = "lbl_pic_num";
            this.lbl_pic_num.Size = new System.Drawing.Size(69, 20);
            this.lbl_pic_num.TabIndex = 8;
            this.lbl_pic_num.Text = "图片共个";
            // 
            // lbl_video_num
            // 
            this.lbl_video_num.AutoSize = true;
            this.lbl_video_num.Location = new System.Drawing.Point(100, 13);
            this.lbl_video_num.Name = "lbl_video_num";
            this.lbl_video_num.Size = new System.Drawing.Size(69, 20);
            this.lbl_video_num.TabIndex = 9;
            this.lbl_video_num.Text = "视频共个";
            // 
            // lbl_zip_num
            // 
            this.lbl_zip_num.AutoSize = true;
            this.lbl_zip_num.Location = new System.Drawing.Point(175, 13);
            this.lbl_zip_num.Name = "lbl_zip_num";
            this.lbl_zip_num.Size = new System.Drawing.Size(84, 20);
            this.lbl_zip_num.TabIndex = 10;
            this.lbl_zip_num.Text = "压缩包共个";
            // 
            // lbl_exe_num
            // 
            this.lbl_exe_num.AutoSize = true;
            this.lbl_exe_num.Location = new System.Drawing.Point(340, 13);
            this.lbl_exe_num.Name = "lbl_exe_num";
            this.lbl_exe_num.Size = new System.Drawing.Size(69, 20);
            this.lbl_exe_num.TabIndex = 11;
            this.lbl_exe_num.Text = "程序共个";
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(179, 251);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(127, 33);
            this.btn_sort.TabIndex = 12;
            this.btn_sort.Text = "归位";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.Btn_sort_Click);
            // 
            // txt_document_directory
            // 
            this.txt_document_directory.Location = new System.Drawing.Point(123, 164);
            this.txt_document_directory.Name = "txt_document_directory";
            this.txt_document_directory.Size = new System.Drawing.Size(348, 27);
            this.txt_document_directory.TabIndex = 14;
            this.txt_document_directory.TextChanged += new System.EventHandler(this.Txt_document_directory_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "文档存放路径";
            // 
            // lbl_documents_num
            // 
            this.lbl_documents_num.AutoSize = true;
            this.lbl_documents_num.Location = new System.Drawing.Point(265, 13);
            this.lbl_documents_num.Name = "lbl_documents_num";
            this.lbl_documents_num.Size = new System.Drawing.Size(69, 20);
            this.lbl_documents_num.TabIndex = 15;
            this.lbl_documents_num.Text = "文档共个";
            // 
            // chk_cleanByDate
            // 
            this.chk_cleanByDate.AutoSize = true;
            this.chk_cleanByDate.Location = new System.Drawing.Point(312, 260);
            this.chk_cleanByDate.Name = "chk_cleanByDate";
            this.chk_cleanByDate.Size = new System.Drawing.Size(148, 24);
            this.chk_cleanByDate.TabIndex = 16;
            this.chk_cleanByDate.Text = "按时间创建文件夹";
            this.chk_cleanByDate.UseVisualStyleBackColor = true;
            // 
            // btn_avoidList
            // 
            this.btn_avoidList.Location = new System.Drawing.Point(16, 248);
            this.btn_avoidList.Name = "btn_avoidList";
            this.btn_avoidList.Size = new System.Drawing.Size(81, 36);
            this.btn_avoidList.TabIndex = 17;
            this.btn_avoidList.Text = "白名单";
            this.btn_avoidList.UseVisualStyleBackColor = true;
            this.btn_avoidList.Click += new System.EventHandler(this.Btn_avoidList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 307);
            this.Controls.Add(this.btn_avoidList);
            this.Controls.Add(this.chk_cleanByDate);
            this.Controls.Add(this.lbl_documents_num);
            this.Controls.Add(this.txt_document_directory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.lbl_exe_num);
            this.Controls.Add(this.lbl_zip_num);
            this.Controls.Add(this.lbl_video_num);
            this.Controls.Add(this.lbl_pic_num);
            this.Controls.Add(this.txt_exe_directory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_zip_directory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_video_directory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_picture_directory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "桌面文件整理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_video_directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_zip_directory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_picture_directory;
        private System.Windows.Forms.TextBox txt_exe_directory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_pic_num;
        private System.Windows.Forms.Label lbl_video_num;
        private System.Windows.Forms.Label lbl_zip_num;
        private System.Windows.Forms.Label lbl_exe_num;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox txt_document_directory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_documents_num;
        private System.Windows.Forms.CheckBox chk_cleanByDate;
        private System.Windows.Forms.Button btn_avoidList;
    }
}

