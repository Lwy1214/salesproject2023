namespace salesproj2023
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.메인 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.재고검색 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분류 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판매가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고갯수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.유통기한 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.유통기한만료여부 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.메인.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.재고검색.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.메인);
            this.tabControl1.Controls.Add(this.재고검색);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // 메인
            // 
            this.메인.Controls.Add(this.label1);
            this.메인.Controls.Add(this.dataGridView1);
            this.메인.Location = new System.Drawing.Point(4, 28);
            this.메인.Name = "메인";
            this.메인.Padding = new System.Windows.Forms.Padding(3);
            this.메인.Size = new System.Drawing.Size(948, 473);
            this.메인.TabIndex = 0;
            this.메인.Text = "재고관리 메인";
            this.메인.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(381, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "재고관리";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.분류,
            this.제품명,
            this.판매가격,
            this.재고갯수,
            this.유통기한,
            this.유통기한만료여부});
            this.dataGridView1.Location = new System.Drawing.Point(3, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(937, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 재고검색
            // 
            this.재고검색.Controls.Add(this.comboBox1);
            this.재고검색.Location = new System.Drawing.Point(4, 28);
            this.재고검색.Name = "재고검색";
            this.재고검색.Padding = new System.Windows.Forms.Padding(3);
            this.재고검색.Size = new System.Drawing.Size(948, 473);
            this.재고검색.TabIndex = 1;
            this.재고검색.Text = "재고검색";
            this.재고검색.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "전체",
            "번호",
            "분류",
            "제품명",
            "재고갯수",
            "유통기한",
            "유통기한만료여부",
            "판매가격"});
            this.comboBox1.Location = new System.Drawing.Point(87, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.HeaderText = "번호";
            this.Num.MinimumWidth = 8;
            this.Num.Name = "Num";
            this.Num.Width = 150;
            // 
            // 분류
            // 
            this.분류.HeaderText = "분류";
            this.분류.MinimumWidth = 8;
            this.분류.Name = "분류";
            this.분류.Width = 150;
            // 
            // 제품명
            // 
            this.제품명.HeaderText = "제품명";
            this.제품명.MinimumWidth = 8;
            this.제품명.Name = "제품명";
            this.제품명.Width = 150;
            // 
            // 판매가격
            // 
            this.판매가격.HeaderText = "판매가격(단위:원)";
            this.판매가격.MinimumWidth = 8;
            this.판매가격.Name = "판매가격";
            this.판매가격.Width = 150;
            // 
            // 재고갯수
            // 
            this.재고갯수.HeaderText = "재고갯수";
            this.재고갯수.MinimumWidth = 8;
            this.재고갯수.Name = "재고갯수";
            this.재고갯수.Width = 150;
            // 
            // 유통기한
            // 
            this.유통기한.HeaderText = "유통기한";
            this.유통기한.MinimumWidth = 8;
            this.유통기한.Name = "유통기한";
            this.유통기한.Width = 150;
            // 
            // 유통기한만료여부
            // 
            this.유통기한만료여부.HeaderText = "유통기한만료여부";
            this.유통기한만료여부.MinimumWidth = 8;
            this.유통기한만료여부.Name = "유통기한만료여부";
            this.유통기한만료여부.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.메인.ResumeLayout(false);
            this.메인.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.재고검색.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 메인;
        private System.Windows.Forms.TabPage 재고검색;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판매가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고갯수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 유통기한;
        private System.Windows.Forms.DataGridViewTextBoxColumn 유통기한만료여부;
    }
}

