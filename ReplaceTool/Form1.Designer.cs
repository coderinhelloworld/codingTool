﻿
using ReaLTaiizor.Forms;

namespace ReplaceTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.htmlTextOutPutBox = new System.Windows.Forms.RichTextBox();
            this.panel4 = new ReaLTaiizor.Controls.Panel();
            this.htmlTextBox = new System.Windows.Forms.RichTextBox();
            this.toolbarGenerate = new ReaLTaiizor.Controls.TabPage();
            this.常用工具 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneratNetPropertyWithSetGetBtn = new System.Windows.Forms.Button();
            this.OutPutBox = new System.Windows.Forms.TextBox();
            this.colNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GenerateNetPropertyBtn = new System.Windows.Forms.Button();
            this.SqlParaReplaceBtn = new System.Windows.Forms.Button();
            this.propertyGenerateBtn = new System.Windows.Forms.Button();
            this.JsonToClassBtn = new System.Windows.Forms.Button();
            this.ToolBar生成 = new System.Windows.Forms.TabPage();
            this.GenerateToolBarTextBtn = new ReaLTaiizor.Controls.AirButton();
            this.参数命名 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.字符串处理 = new System.Windows.Forms.TabPage();
            this.fromNumberBox = new System.Windows.Forms.TextBox();
            this.toNumberBox = new System.Windows.Forms.TextBox();
            this.AddItSelf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contactText = new System.Windows.Forms.TextBox();
            this.contactTxtBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.多字符替换 = new System.Windows.Forms.TabPage();
            this.ReplaceBtn = new System.Windows.Forms.Button();
            this.SettingNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtdAddRow = new System.Windows.Forms.Button();
            this.SettingListBox = new System.Windows.Forms.ComboBox();
            this.ConfigDelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolbarGenerate.SuspendLayout();
            this.常用工具.SuspendLayout();
            this.ToolBar生成.SuspendLayout();
            this.参数命名.SuspendLayout();
            this.字符串处理.SuspendLayout();
            this.多字符替换.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 37);
            this.panel1.TabIndex = 33;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(944, 10);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(20, 19);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.toolbarGenerate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 797);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 338);
            this.panel3.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel5.Controls.Add(this.htmlTextOutPutBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(469, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(503, 338);
            this.panel5.TabIndex = 12;
            // 
            // htmlTextOutPutBox
            // 
            this.htmlTextOutPutBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.htmlTextOutPutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.htmlTextOutPutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTextOutPutBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.htmlTextOutPutBox.Location = new System.Drawing.Point(5, 5);
            this.htmlTextOutPutBox.Name = "htmlTextOutPutBox";
            this.htmlTextOutPutBox.Size = new System.Drawing.Size(493, 328);
            this.htmlTextOutPutBox.TabIndex = 10;
            this.htmlTextOutPutBox.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel4.Controls.Add(this.htmlTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(468, 338);
            this.panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel4.TabIndex = 11;
            this.panel4.Text = "panel4";
            // 
            // htmlTextBox
            // 
            this.htmlTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.htmlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.htmlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.htmlTextBox.Location = new System.Drawing.Point(5, 5);
            this.htmlTextBox.Name = "htmlTextBox";
            this.htmlTextBox.Size = new System.Drawing.Size(458, 328);
            this.htmlTextBox.TabIndex = 9;
            this.htmlTextBox.Text = "";
            this.htmlTextBox.TextChanged += new System.EventHandler(this.htmlTextBox_TextChanged);
            // 
            // toolbarGenerate
            // 
            this.toolbarGenerate.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolbarGenerate.ActiveLineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.toolbarGenerate.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.toolbarGenerate.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.toolbarGenerate.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.toolbarGenerate.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.toolbarGenerate.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.toolbarGenerate.Controls.Add(this.常用工具);
            this.toolbarGenerate.Controls.Add(this.ToolBar生成);
            this.toolbarGenerate.Controls.Add(this.参数命名);
            this.toolbarGenerate.Controls.Add(this.字符串处理);
            this.toolbarGenerate.Controls.Add(this.多字符替换);
            this.toolbarGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolbarGenerate.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.toolbarGenerate.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.toolbarGenerate.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.toolbarGenerate.ItemSize = new System.Drawing.Size(44, 135);
            this.toolbarGenerate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.toolbarGenerate.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.toolbarGenerate.Location = new System.Drawing.Point(0, 339);
            this.toolbarGenerate.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.toolbarGenerate.Multiline = true;
            this.toolbarGenerate.Name = "toolbarGenerate";
            this.toolbarGenerate.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.toolbarGenerate.Padding = new System.Drawing.Point(300, 330);
            this.toolbarGenerate.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.toolbarGenerate.SelectedIndex = 0;
            this.toolbarGenerate.Size = new System.Drawing.Size(972, 458);
            this.toolbarGenerate.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.toolbarGenerate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.toolbarGenerate.StringType = System.Drawing.StringAlignment.Near;
            this.toolbarGenerate.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.toolbarGenerate.TabIndex = 30;
            // 
            // 常用工具
            // 
            this.常用工具.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.常用工具.Controls.Add(this.label4);
            this.常用工具.Controls.Add(this.GeneratNetPropertyWithSetGetBtn);
            this.常用工具.Controls.Add(this.OutPutBox);
            this.常用工具.Controls.Add(this.colNo);
            this.常用工具.Controls.Add(this.label7);
            this.常用工具.Controls.Add(this.GenerateNetPropertyBtn);
            this.常用工具.Controls.Add(this.SqlParaReplaceBtn);
            this.常用工具.Controls.Add(this.propertyGenerateBtn);
            this.常用工具.Controls.Add(this.JsonToClassBtn);
            this.常用工具.Location = new System.Drawing.Point(139, 4);
            this.常用工具.Name = "常用工具";
            this.常用工具.Padding = new System.Windows.Forms.Padding(3);
            this.常用工具.Size = new System.Drawing.Size(829, 450);
            this.常用工具.TabIndex = 1;
            this.常用工具.Text = "常用工具";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "输出内容";
            // 
            // GeneratNetPropertyWithSetGetBtn
            // 
            this.GeneratNetPropertyWithSetGetBtn.Location = new System.Drawing.Point(183, 94);
            this.GeneratNetPropertyWithSetGetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeneratNetPropertyWithSetGetBtn.Name = "GeneratNetPropertyWithSetGetBtn";
            this.GeneratNetPropertyWithSetGetBtn.Size = new System.Drawing.Size(135, 44);
            this.GeneratNetPropertyWithSetGetBtn.TabIndex = 29;
            this.GeneratNetPropertyWithSetGetBtn.Text = "生成GetSet方法";
            this.GeneratNetPropertyWithSetGetBtn.UseVisualStyleBackColor = true;
            this.GeneratNetPropertyWithSetGetBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // OutPutBox
            // 
            this.OutPutBox.Location = new System.Drawing.Point(88, 570);
            this.OutPutBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutPutBox.Multiline = true;
            this.OutPutBox.Name = "OutPutBox";
            this.OutPutBox.Size = new System.Drawing.Size(559, 97);
            this.OutPutBox.TabIndex = 8;
            // 
            // colNo
            // 
            this.colNo.Location = new System.Drawing.Point(434, 108);
            this.colNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colNo.Name = "colNo";
            this.colNo.Size = new System.Drawing.Size(38, 23);
            this.colNo.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "注释所在列";
            // 
            // GenerateNetPropertyBtn
            // 
            this.GenerateNetPropertyBtn.Location = new System.Drawing.Point(32, 94);
            this.GenerateNetPropertyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerateNetPropertyBtn.Name = "GenerateNetPropertyBtn";
            this.GenerateNetPropertyBtn.Size = new System.Drawing.Size(124, 44);
            this.GenerateNetPropertyBtn.TabIndex = 23;
            this.GenerateNetPropertyBtn.Text = "生成C#字段带注释";
            this.GenerateNetPropertyBtn.UseVisualStyleBackColor = true;
            this.GenerateNetPropertyBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // SqlParaReplaceBtn
            // 
            this.SqlParaReplaceBtn.Location = new System.Drawing.Point(166, 19);
            this.SqlParaReplaceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SqlParaReplaceBtn.Name = "SqlParaReplaceBtn";
            this.SqlParaReplaceBtn.Size = new System.Drawing.Size(100, 44);
            this.SqlParaReplaceBtn.TabIndex = 12;
            this.SqlParaReplaceBtn.Text = "Sql参数替换";
            this.SqlParaReplaceBtn.UseVisualStyleBackColor = true;
            this.SqlParaReplaceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // propertyGenerateBtn
            // 
            this.propertyGenerateBtn.Location = new System.Drawing.Point(302, 19);
            this.propertyGenerateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.propertyGenerateBtn.Name = "propertyGenerateBtn";
            this.propertyGenerateBtn.Size = new System.Drawing.Size(94, 44);
            this.propertyGenerateBtn.TabIndex = 22;
            this.propertyGenerateBtn.Text = "生成C#字段";
            this.propertyGenerateBtn.UseVisualStyleBackColor = true;
            this.propertyGenerateBtn.Click += new System.EventHandler(this.propertyGenerateBtn_Click);
            // 
            // JsonToClassBtn
            // 
            this.JsonToClassBtn.Location = new System.Drawing.Point(32, 19);
            this.JsonToClassBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JsonToClassBtn.Name = "JsonToClassBtn";
            this.JsonToClassBtn.Size = new System.Drawing.Size(100, 44);
            this.JsonToClassBtn.TabIndex = 21;
            this.JsonToClassBtn.Text = "Json生成C#类";
            this.JsonToClassBtn.UseVisualStyleBackColor = true;
            this.JsonToClassBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ToolBar生成
            // 
            this.ToolBar生成.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.ToolBar生成.Controls.Add(this.GenerateToolBarTextBtn);
            this.ToolBar生成.Location = new System.Drawing.Point(139, 4);
            this.ToolBar生成.Name = "ToolBar生成";
            this.ToolBar生成.Padding = new System.Windows.Forms.Padding(3);
            this.ToolBar生成.Size = new System.Drawing.Size(829, 450);
            this.ToolBar生成.TabIndex = 2;
            this.ToolBar生成.Text = "ToolBar生成";
            // 
            // GenerateToolBarTextBtn
            // 
            this.GenerateToolBarTextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateToolBarTextBtn.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.GenerateToolBarTextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateToolBarTextBtn.Image = null;
            this.GenerateToolBarTextBtn.Location = new System.Drawing.Point(18, 16);
            this.GenerateToolBarTextBtn.Name = "GenerateToolBarTextBtn";
            this.GenerateToolBarTextBtn.NoRounding = false;
            this.GenerateToolBarTextBtn.Size = new System.Drawing.Size(123, 47);
            this.GenerateToolBarTextBtn.TabIndex = 0;
            this.GenerateToolBarTextBtn.Text = "生成Toolbar文本";
            this.GenerateToolBarTextBtn.Transparent = false;
            this.GenerateToolBarTextBtn.Click += new System.EventHandler(this.GenerateToolBarTextBtn_Click);
            // 
            // 参数命名
            // 
            this.参数命名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.参数命名.Controls.Add(this.button2);
            this.参数命名.Location = new System.Drawing.Point(139, 4);
            this.参数命名.Name = "参数命名";
            this.参数命名.Padding = new System.Windows.Forms.Padding(3);
            this.参数命名.Size = new System.Drawing.Size(829, 450);
            this.参数命名.TabIndex = 3;
            this.参数命名.Text = "参数命名";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "转驼峰";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // 字符串处理
            // 
            this.字符串处理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.字符串处理.Controls.Add(this.fromNumberBox);
            this.字符串处理.Controls.Add(this.toNumberBox);
            this.字符串处理.Controls.Add(this.AddItSelf);
            this.字符串处理.Controls.Add(this.label5);
            this.字符串处理.Controls.Add(this.label6);
            this.字符串处理.Controls.Add(this.contactText);
            this.字符串处理.Controls.Add(this.contactTxtBtn);
            this.字符串处理.Controls.Add(this.button5);
            this.字符串处理.Location = new System.Drawing.Point(139, 4);
            this.字符串处理.Name = "字符串处理";
            this.字符串处理.Size = new System.Drawing.Size(829, 450);
            this.字符串处理.TabIndex = 4;
            this.字符串处理.Text = "字符串处理";
            // 
            // fromNumberBox
            // 
            this.fromNumberBox.Location = new System.Drawing.Point(350, 176);
            this.fromNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromNumberBox.Name = "fromNumberBox";
            this.fromNumberBox.Size = new System.Drawing.Size(41, 23);
            this.fromNumberBox.TabIndex = 29;
            // 
            // toNumberBox
            // 
            this.toNumberBox.Location = new System.Drawing.Point(435, 176);
            this.toNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toNumberBox.Name = "toNumberBox";
            this.toNumberBox.Size = new System.Drawing.Size(41, 23);
            this.toNumberBox.TabIndex = 32;
            // 
            // AddItSelf
            // 
            this.AddItSelf.Location = new System.Drawing.Point(27, 166);
            this.AddItSelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddItSelf.Name = "AddItSelf";
            this.AddItSelf.Size = new System.Drawing.Size(281, 44);
            this.AddItSelf.TabIndex = 28;
            this.AddItSelf.Text = "替换数值添加到本身,后面设置加到几";
            this.AddItSelf.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "到";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "从";
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(179, 97);
            this.contactText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactText.Multiline = true;
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(48, 43);
            this.contactText.TabIndex = 27;
            // 
            // contactTxtBtn
            // 
            this.contactTxtBtn.Location = new System.Drawing.Point(27, 97);
            this.contactTxtBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactTxtBtn.Name = "contactTxtBtn";
            this.contactTxtBtn.Size = new System.Drawing.Size(135, 43);
            this.contactTxtBtn.TabIndex = 26;
            this.contactTxtBtn.Text = "使用后面的符号拼接";
            this.contactTxtBtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 33);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 44);
            this.button5.TabIndex = 25;
            this.button5.Text = "转成字符串";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // 多字符替换
            // 
            this.多字符替换.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.多字符替换.Controls.Add(this.ReplaceBtn);
            this.多字符替换.Controls.Add(this.SettingNameBox);
            this.多字符替换.Controls.Add(this.label1);
            this.多字符替换.Controls.Add(this.BtdAddRow);
            this.多字符替换.Controls.Add(this.SettingListBox);
            this.多字符替换.Controls.Add(this.ConfigDelBtn);
            this.多字符替换.Controls.Add(this.label2);
            this.多字符替换.Controls.Add(this.dataGridView1);
            this.多字符替换.Location = new System.Drawing.Point(139, 4);
            this.多字符替换.Name = "多字符替换";
            this.多字符替换.Size = new System.Drawing.Size(829, 450);
            this.多字符替换.TabIndex = 5;
            this.多字符替换.Text = "多字符替换";
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Location = new System.Drawing.Point(26, 331);
            this.ReplaceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(100, 44);
            this.ReplaceBtn.TabIndex = 32;
            this.ReplaceBtn.Text = "替换";
            this.ReplaceBtn.UseVisualStyleBackColor = true;
            this.ReplaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click_1);
            // 
            // SettingNameBox
            // 
            this.SettingNameBox.Location = new System.Drawing.Point(392, 287);
            this.SettingNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingNameBox.Name = "SettingNameBox";
            this.SettingNameBox.Size = new System.Drawing.Size(187, 23);
            this.SettingNameBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "选择保存的配置";
            // 
            // BtdAddRow
            // 
            this.BtdAddRow.Location = new System.Drawing.Point(599, 285);
            this.BtdAddRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtdAddRow.Name = "BtdAddRow";
            this.BtdAddRow.Size = new System.Drawing.Size(96, 27);
            this.BtdAddRow.TabIndex = 26;
            this.BtdAddRow.Text = "保存配置";
            this.BtdAddRow.UseVisualStyleBackColor = true;
            this.BtdAddRow.Click += new System.EventHandler(this.BtdAddRow_Click_1);
            // 
            // SettingListBox
            // 
            this.SettingListBox.FormattingEnabled = true;
            this.SettingListBox.Location = new System.Drawing.Point(172, 286);
            this.SettingListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingListBox.Name = "SettingListBox";
            this.SettingListBox.Size = new System.Drawing.Size(115, 25);
            this.SettingListBox.TabIndex = 28;
            this.SettingListBox.SelectedIndexChanged += new System.EventHandler(this.SettingListBox_SelectedIndexChanged_1);
            // 
            // ConfigDelBtn
            // 
            this.ConfigDelBtn.Location = new System.Drawing.Point(710, 285);
            this.ConfigDelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfigDelBtn.Name = "ConfigDelBtn";
            this.ConfigDelBtn.Size = new System.Drawing.Size(100, 27);
            this.ConfigDelBtn.TabIndex = 31;
            this.ConfigDelBtn.Text = "删除配置";
            this.ConfigDelBtn.UseVisualStyleBackColor = true;
            this.ConfigDelBtn.Click += new System.EventHandler(this.ConfigDelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "配置名称";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(829, 218);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 834);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "常用功能";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.toolbarGenerate.ResumeLayout(false);
            this.常用工具.ResumeLayout(false);
            this.常用工具.PerformLayout();
            this.ToolBar生成.ResumeLayout(false);
            this.参数命名.ResumeLayout(false);
            this.字符串处理.ResumeLayout(false);
            this.字符串处理.PerformLayout();
            this.多字符替换.ResumeLayout(false);
            this.多字符替换.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.TabPage toolbarGenerate;
        private System.Windows.Forms.TabPage 常用工具;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GeneratNetPropertyWithSetGetBtn;
        private System.Windows.Forms.TextBox OutPutBox;
        private System.Windows.Forms.TextBox colNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GenerateNetPropertyBtn;
        private System.Windows.Forms.Button SqlParaReplaceBtn;
        private System.Windows.Forms.Button propertyGenerateBtn;
        private System.Windows.Forms.Button JsonToClassBtn;
        private System.Windows.Forms.TabPage ToolBar生成;
        private ReaLTaiizor.Controls.AirButton GenerateToolBarTextBtn;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RichTextBox htmlTextBox;
        private System.Windows.Forms.RichTextBox htmlTextOutPutBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private ReaLTaiizor.Controls.Panel panel4;
        private System.Windows.Forms.TabPage 参数命名;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage 字符串处理;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.Button contactTxtBtn;
        private System.Windows.Forms.TextBox fromNumberBox;
        private System.Windows.Forms.TextBox toNumberBox;
        private System.Windows.Forms.Button AddItSelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage 多字符替换;
        private System.Windows.Forms.Button ReplaceBtn;
        private System.Windows.Forms.TextBox SettingNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtdAddRow;
        private System.Windows.Forms.ComboBox SettingListBox;
        private System.Windows.Forms.Button ConfigDelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
