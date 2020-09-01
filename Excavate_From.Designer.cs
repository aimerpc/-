namespace 网络搜索词挖掘软件
{
    partial class Excavate_Form
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
            this.Result_ListView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndexWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_KeyWord = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result_ListView
            // 
            this.Result_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.KeyWord,
            this.IndexWord});
            this.Result_ListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result_ListView.GridLines = true;
            this.Result_ListView.HideSelection = false;
            this.Result_ListView.Location = new System.Drawing.Point(0, 174);
            this.Result_ListView.Name = "Result_ListView";
            this.Result_ListView.Size = new System.Drawing.Size(617, 236);
            this.Result_ListView.TabIndex = 0;
            this.Result_ListView.UseCompatibleStateImageBehavior = false;
            this.Result_ListView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "序号";
            this.Id.Width = 120;
            // 
            // KeyWord
            // 
            this.KeyWord.Text = "关键词";
            this.KeyWord.Width = 210;
            // 
            // IndexWord
            // 
            this.IndexWord.Text = "指数词";
            this.IndexWord.Width = 310;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键字";
            // 
            // txt_KeyWord
            // 
            this.txt_KeyWord.Location = new System.Drawing.Point(177, 53);
            this.txt_KeyWord.Name = "txt_KeyWord";
            this.txt_KeyWord.Size = new System.Drawing.Size(179, 21);
            this.txt_KeyWord.TabIndex = 2;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(376, 53);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(100, 23);
            this.Btn_Search.TabIndex = 3;
            this.Btn_Search.Text = "搜索";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Excavate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_KeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result_ListView);
            this.Name = "Excavate_Form";
            this.Text = "关键字挖掘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Result_ListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_KeyWord;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader KeyWord;
        private System.Windows.Forms.ColumnHeader IndexWord;
        private System.Windows.Forms.Button button1;
    }
}

