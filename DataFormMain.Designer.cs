namespace PostgresqlGenerator
{
    partial class DataFormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new CCWin.SkinControl.SkinButton();
            this.btnBulid = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtCnnString = new CCWin.SkinControl.SkinTextBox();
            this.dgvData = new CCWin.SkinControl.SkinDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnBulid);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.txtCnnString);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 180);
            this.panel1.TabIndex = 3;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnExcel.DownBack = null;
            this.btnExcel.Location = new System.Drawing.Point(867, 97);
            this.btnExcel.MouseBack = null;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.NormlBack = null;
            this.btnExcel.Size = new System.Drawing.Size(217, 53);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "生成Excel文档";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBulid
            // 
            this.btnBulid.BackColor = System.Drawing.Color.Transparent;
            this.btnBulid.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBulid.DownBack = null;
            this.btnBulid.Location = new System.Drawing.Point(1090, 97);
            this.btnBulid.MouseBack = null;
            this.btnBulid.Name = "btnBulid";
            this.btnBulid.NormlBack = null;
            this.btnBulid.Size = new System.Drawing.Size(224, 53);
            this.btnBulid.TabIndex = 5;
            this.btnBulid.Text = "生成Word文档";
            this.btnBulid.UseVisualStyleBackColor = false;
            this.btnBulid.Click += new System.EventHandler(this.btnBulid_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel1.Location = new System.Drawing.Point(20, 33);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(218, 25);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "SQL Server连接字符串：";
            // 
            // txtCnnString
            // 
            this.txtCnnString.BackColor = System.Drawing.Color.Transparent;
            this.txtCnnString.DownBack = null;
            this.txtCnnString.Icon = null;
            this.txtCnnString.IconIsButton = false;
            this.txtCnnString.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCnnString.IsPasswordChat = '\0';
            this.txtCnnString.IsSystemPasswordChar = false;
            this.txtCnnString.Lines = new string[] {
        "Data Source=ServerIP;Initial Catalog=DBName;UID=sa;PWD=password"};
            this.txtCnnString.Location = new System.Drawing.Point(241, 23);
            this.txtCnnString.Margin = new System.Windows.Forms.Padding(0);
            this.txtCnnString.MaxLength = 32767;
            this.txtCnnString.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtCnnString.MouseBack = null;
            this.txtCnnString.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCnnString.Multiline = true;
            this.txtCnnString.Name = "txtCnnString";
            this.txtCnnString.NormlBack = null;
            this.txtCnnString.Padding = new System.Windows.Forms.Padding(6);
            this.txtCnnString.ReadOnly = false;
            this.txtCnnString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCnnString.Size = new System.Drawing.Size(1073, 35);
            // 
            // 
            // 
            this.txtCnnString.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnnString.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCnnString.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnnString.SkinTxt.Location = new System.Drawing.Point(6, 6);
            this.txtCnnString.SkinTxt.Multiline = true;
            this.txtCnnString.SkinTxt.Name = "BaseText";
            this.txtCnnString.SkinTxt.Size = new System.Drawing.Size(1061, 23);
            this.txtCnnString.SkinTxt.TabIndex = 0;
            this.txtCnnString.SkinTxt.Text = "Data Source=ServerIP;Initial Catalog=DBName;UID=sa;PWD=password";
            this.txtCnnString.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCnnString.SkinTxt.WaterText = "";
            this.txtCnnString.TabIndex = 3;
            this.txtCnnString.Text = "Data Source=ServerIP;Initial Catalog=DBName;UID=sa;PWD=password";
            this.txtCnnString.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCnnString.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCnnString.WaterText = "";
            this.txtCnnString.WordWrap = true;
            // 
            // dgvData
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnFont = null;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvData.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvData.HeadFont = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvData.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvData.Location = new System.Drawing.Point(4, 208);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1445, 608);
            this.dgvData.TabIndex = 6;
            this.dgvData.TitleBack = null;
            this.dgvData.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvData.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // DataFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 820);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.Name = "DataFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据字典生成器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinButton btnExcel;
        private CCWin.SkinControl.SkinButton btnBulid;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtCnnString;
        private CCWin.SkinControl.SkinDataGridView dgvData;
    }
}
