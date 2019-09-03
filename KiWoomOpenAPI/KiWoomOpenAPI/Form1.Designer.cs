namespace KiWoomOpenAPI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_getServer = new System.Windows.Forms.Label();
            this.label_getID = new System.Windows.Forms.Label();
            this.lebel_getName = new System.Windows.Forms.Label();
            this.label_acc = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_server = new System.Windows.Forms.Label();
            this.comboBox_getAccList = new System.Windows.Forms.ComboBox();
            this.listBox_info = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_codeSearch = new System.Windows.Forms.TextBox();
            this.btn_codeSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(713, 415);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(13, 13);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_getServer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_getID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lebel_getName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_acc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_id, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_server, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_getAccList, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label_getServer
            // 
            this.label_getServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_getServer.AutoSize = true;
            this.label_getServer.Location = new System.Drawing.Point(103, 75);
            this.label_getServer.Name = "label_getServer";
            this.label_getServer.Size = new System.Drawing.Size(94, 25);
            this.label_getServer.TabIndex = 7;
            this.label_getServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_getID
            // 
            this.label_getID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_getID.AutoSize = true;
            this.label_getID.Location = new System.Drawing.Point(103, 50);
            this.label_getID.Name = "label_getID";
            this.label_getID.Size = new System.Drawing.Size(94, 25);
            this.label_getID.TabIndex = 6;
            this.label_getID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lebel_getName
            // 
            this.lebel_getName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lebel_getName.AutoSize = true;
            this.lebel_getName.Location = new System.Drawing.Point(103, 25);
            this.lebel_getName.Name = "lebel_getName";
            this.lebel_getName.Size = new System.Drawing.Size(94, 25);
            this.lebel_getName.TabIndex = 5;
            this.lebel_getName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_acc
            // 
            this.label_acc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_acc.AutoSize = true;
            this.label_acc.Location = new System.Drawing.Point(3, 0);
            this.label_acc.Name = "label_acc";
            this.label_acc.Size = new System.Drawing.Size(94, 25);
            this.label_acc.TabIndex = 0;
            this.label_acc.Text = "계좌번호";
            this.label_acc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(3, 25);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(94, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "사용자";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_id
            // 
            this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(3, 50);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(94, 25);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "ID";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_server
            // 
            this.label_server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_server.AutoSize = true;
            this.label_server.Location = new System.Drawing.Point(3, 75);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(94, 25);
            this.label_server.TabIndex = 3;
            this.label_server.Text = "서버";
            this.label_server.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_getAccList
            // 
            this.comboBox_getAccList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_getAccList.FormattingEnabled = true;
            this.comboBox_getAccList.Location = new System.Drawing.Point(103, 3);
            this.comboBox_getAccList.Name = "comboBox_getAccList";
            this.comboBox_getAccList.Size = new System.Drawing.Size(94, 20);
            this.comboBox_getAccList.TabIndex = 4;
            // 
            // listBox_info
            // 
            this.listBox_info.FormattingEnabled = true;
            this.listBox_info.ItemHeight = 12;
            this.listBox_info.Location = new System.Drawing.Point(358, 46);
            this.listBox_info.Name = "listBox_info";
            this.listBox_info.Size = new System.Drawing.Size(428, 352);
            this.listBox_info.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "종목 코드";
            // 
            // textBox_codeSearch
            // 
            this.textBox_codeSearch.Location = new System.Drawing.Point(421, 21);
            this.textBox_codeSearch.Name = "textBox_codeSearch";
            this.textBox_codeSearch.Size = new System.Drawing.Size(100, 21);
            this.textBox_codeSearch.TabIndex = 5;
            // 
            // btn_codeSearch
            // 
            this.btn_codeSearch.Location = new System.Drawing.Point(527, 19);
            this.btn_codeSearch.Name = "btn_codeSearch";
            this.btn_codeSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_codeSearch.TabIndex = 6;
            this.btn_codeSearch.Text = "조회";
            this.btn_codeSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 507);
            this.Controls.Add(this.btn_codeSearch);
            this.Controls.Add(this.textBox_codeSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_info);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_acc;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.ComboBox comboBox_getAccList;
        private System.Windows.Forms.Label label_getServer;
        private System.Windows.Forms.Label label_getID;
        private System.Windows.Forms.Label lebel_getName;
        private System.Windows.Forms.ListBox listBox_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_codeSearch;
        private System.Windows.Forms.Button btn_codeSearch;
    }
}

