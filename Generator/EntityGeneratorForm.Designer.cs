using NPOI.SS.Formula.Functions;

namespace PostgresqlGenerator
{
    partial class EntityGeneratorForm
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
            this.txtEntityCode = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtConnectionString = new CCWin.SkinControl.SkinTextBox();
            this.txtEntityName = new CCWin.SkinControl.SkinTextBox();
            this.txtTableName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnGenerate = new CCWin.SkinControl.SkinButton();
            this.lblTableName = new CCWin.SkinControl.SkinLabel();
            this.lblEntityName = new CCWin.SkinControl.SkinLabel();
            this.cboTableList = new CCWin.SkinControl.SkinComboBox();
            this.btnLoadTableList = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // txtEntityCode
            // 
            this.txtEntityCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEntityCode.Location = new System.Drawing.Point(4, 259);
            this.txtEntityCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEntityCode.Multiline = true;
            this.txtEntityCode.Name = "txtEntityCode";
            this.txtEntityCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEntityCode.Size = new System.Drawing.Size(1052, 647);
            this.txtEntityCode.TabIndex = 7;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "提示";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.BackColor = System.Drawing.Color.Transparent;
            this.txtConnectionString.DownBack = null;
            this.txtConnectionString.Icon = null;
            this.txtConnectionString.IconIsButton = false;
            this.txtConnectionString.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtConnectionString.IsPasswordChat = '\0';
            this.txtConnectionString.IsSystemPasswordChar = false;
            this.txtConnectionString.Lines = new string[] {
        "Server=localhost;Port=5432;Database=BlogDB;User Id=postgres;Password=*****"};
            this.txtConnectionString.Location = new System.Drawing.Point(145, 49);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(0);
            this.txtConnectionString.MaxLength = 32767;
            this.txtConnectionString.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtConnectionString.MouseBack = null;
            this.txtConnectionString.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.NormlBack = null;
            this.txtConnectionString.Padding = new System.Windows.Forms.Padding(6);
            this.txtConnectionString.ReadOnly = false;
            this.txtConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConnectionString.Size = new System.Drawing.Size(857, 35);
            // 
            // 
            // 
            this.txtConnectionString.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConnectionString.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnectionString.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConnectionString.SkinTxt.Location = new System.Drawing.Point(6, 6);
            this.txtConnectionString.SkinTxt.Multiline = true;
            this.txtConnectionString.SkinTxt.Name = "BaseText";
            this.txtConnectionString.SkinTxt.Size = new System.Drawing.Size(845, 23);
            this.txtConnectionString.SkinTxt.TabIndex = 0;
            this.txtConnectionString.SkinTxt.Text = "Server=localhost;Port=5432;Database=BlogDB;User Id=postgres;Password=*****";
            this.txtConnectionString.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtConnectionString.SkinTxt.WaterText = "";
            this.txtConnectionString.TabIndex = 9;
            this.txtConnectionString.Text = "Server=localhost;Port=5432;Database=BlogDB;User Id=postgres;Password=*****";
            this.txtConnectionString.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.txtConnectionString, "请输入 PostgreSQL 数据库的连接字符串");
            this.txtConnectionString.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtConnectionString.WaterText = "";
            this.txtConnectionString.WordWrap = true;
            // 
            // txtEntityName
            // 
            this.txtEntityName.BackColor = System.Drawing.Color.Transparent;
            this.txtEntityName.DownBack = null;
            this.txtEntityName.Icon = null;
            this.txtEntityName.IconIsButton = false;
            this.txtEntityName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtEntityName.IsPasswordChat = '\0';
            this.txtEntityName.IsSystemPasswordChar = false;
            this.txtEntityName.Lines = new string[] {
        "xxxEntity"};
            this.txtEntityName.Location = new System.Drawing.Point(532, 121);
            this.txtEntityName.Margin = new System.Windows.Forms.Padding(0);
            this.txtEntityName.MaxLength = 32767;
            this.txtEntityName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtEntityName.MouseBack = null;
            this.txtEntityName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtEntityName.Multiline = true;
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.NormlBack = null;
            this.txtEntityName.Padding = new System.Windows.Forms.Padding(5);
            this.txtEntityName.ReadOnly = false;
            this.txtEntityName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEntityName.Size = new System.Drawing.Size(271, 48);
            // 
            // 
            // 
            this.txtEntityName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntityName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEntityName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEntityName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtEntityName.SkinTxt.Multiline = true;
            this.txtEntityName.SkinTxt.Name = "BaseText";
            this.txtEntityName.SkinTxt.Size = new System.Drawing.Size(221, 38);
            this.txtEntityName.SkinTxt.TabIndex = 0;
            this.txtEntityName.SkinTxt.Text = "xxxEntity";
            this.txtEntityName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtEntityName.SkinTxt.WaterText = "";
            this.txtEntityName.TabIndex = 11;
            this.txtEntityName.Text = "xxxEntity";
            this.txtEntityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.txtEntityName, "请输入生成的实体类的名称");
            this.txtEntityName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtEntityName.WaterText = "";
            this.txtEntityName.WordWrap = true;
            // 
            // txtTableName
            // 
            this.txtTableName.BackColor = System.Drawing.Color.Transparent;
            this.txtTableName.DownBack = null;
            this.txtTableName.Icon = null;
            this.txtTableName.IconIsButton = false;
            this.txtTableName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTableName.IsPasswordChat = '\0';
            this.txtTableName.IsSystemPasswordChar = false;
            this.txtTableName.Lines = new string[0];
            this.txtTableName.Location = new System.Drawing.Point(145, 121);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(0);
            this.txtTableName.MaxLength = 32767;
            this.txtTableName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtTableName.MouseBack = null;
            this.txtTableName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTableName.Multiline = true;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.NormlBack = null;
            this.txtTableName.Padding = new System.Windows.Forms.Padding(5);
            this.txtTableName.ReadOnly = false;
            this.txtTableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTableName.Size = new System.Drawing.Size(249, 48);
            // 
            // 
            // 
            this.txtTableName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTableName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtTableName.SkinTxt.Multiline = true;
            this.txtTableName.SkinTxt.Name = "BaseText";
            this.txtTableName.SkinTxt.Size = new System.Drawing.Size(217, 38);
            this.txtTableName.SkinTxt.TabIndex = 0;
            this.txtTableName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTableName.SkinTxt.WaterText = "";
            this.txtTableName.TabIndex = 14;
            this.txtTableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.txtTableName, "请输入 PostgreSQL 数据库中的表名称");
            this.txtTableName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTableName.WaterText = "";
            this.txtTableName.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel1.Location = new System.Drawing.Point(22, 55);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(120, 25);
            this.skinLabel1.TabIndex = 10;
            this.skinLabel1.Text = "连接字符串：";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnGenerate.DownBack = null;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(736, 186);
            this.btnGenerate.MouseBack = null;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.NormlBack = null;
            this.btnGenerate.Size = new System.Drawing.Size(266, 40);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "生成实体类代码";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.BackColor = System.Drawing.Color.Transparent;
            this.lblTableName.BorderColor = System.Drawing.Color.White;
            this.lblTableName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTableName.Location = new System.Drawing.Point(59, 144);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(71, 25);
            this.lblTableName.TabIndex = 15;
            this.lblTableName.Text = "表名称:";
            // 
            // lblEntityName
            // 
            this.lblEntityName.AutoSize = true;
            this.lblEntityName.BackColor = System.Drawing.Color.Transparent;
            this.lblEntityName.BorderColor = System.Drawing.Color.White;
            this.lblEntityName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblEntityName.Location = new System.Drawing.Point(427, 144);
            this.lblEntityName.Name = "lblEntityName";
            this.lblEntityName.Size = new System.Drawing.Size(102, 25);
            this.lblEntityName.TabIndex = 16;
            this.lblEntityName.Text = "实体名称：";
            // 
            // cboTableList
            // 
            this.cboTableList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTableList.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTableList.FormattingEnabled = true;
            this.cboTableList.Location = new System.Drawing.Point(145, 186);
            this.cboTableList.Name = "cboTableList";
            this.cboTableList.Size = new System.Drawing.Size(249, 42);
            this.cboTableList.TabIndex = 17;
            this.cboTableList.Text = "-请选择表-";
            this.cboTableList.WaterText = "";
            this.cboTableList.SelectedIndexChanged += new System.EventHandler(this.cboTableList_SelectedIndexChanged);
            // 
            // btnLoadTableList
            // 
            this.btnLoadTableList.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadTableList.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLoadTableList.DownBack = null;
            this.btnLoadTableList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadTableList.Location = new System.Drawing.Point(427, 185);
            this.btnLoadTableList.MouseBack = null;
            this.btnLoadTableList.Name = "btnLoadTableList";
            this.btnLoadTableList.NormlBack = null;
            this.btnLoadTableList.Size = new System.Drawing.Size(280, 42);
            this.btnLoadTableList.TabIndex = 18;
            this.btnLoadTableList.Text = "加载表列表";
            this.btnLoadTableList.UseVisualStyleBackColor = false;
            this.btnLoadTableList.Click += new System.EventHandler(this.btnLoadTableList_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel2.Location = new System.Drawing.Point(22, 201);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(120, 25);
            this.skinLabel2.TabIndex = 19;
            this.skinLabel2.Text = "表名称列表：";
            // 
            // EntityGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 910);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.btnLoadTableList);
            this.Controls.Add(this.cboTableList);
            this.Controls.Add(this.lblEntityName);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.txtEntityCode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EntityGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostgreSQL 实体类代码生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.TextBox txtEntityCode;
        private System.Windows.Forms.ToolTip toolTip1;
        private CCWin.SkinControl.SkinTextBox txtConnectionString;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtEntityName;
        private CCWin.SkinControl.SkinButton btnGenerate;
        private CCWin.SkinControl.SkinTextBox txtTableName;
        private CCWin.SkinControl.SkinLabel lblTableName;
        private CCWin.SkinControl.SkinLabel lblEntityName;
        private CCWin.SkinControl.SkinComboBox cboTableList;
        private CCWin.SkinControl.SkinButton btnLoadTableList;
        private CCWin.SkinControl.SkinLabel skinLabel2;
    }
}