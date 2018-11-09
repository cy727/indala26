namespace indala26
{
	partial class FormIndala
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownLowTop = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownLowBottom = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownHigh = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonSingle = new System.Windows.Forms.Button();
			this.buttonMany = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelLow = new System.Windows.Forms.Label();
			this.labelHigh = new System.Windows.Forms.Label();
			this.textBoxIndala = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridViewIndala = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowBottom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHigh)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndala)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.numericUpDownLowTop);
			this.groupBox1.Controls.Add(this.numericUpDownLowBottom);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numericUpDownHigh);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 116);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "初始值";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(93, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "高值";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "低值";
			// 
			// numericUpDownLowTop
			// 
			this.numericUpDownLowTop.Location = new System.Drawing.Point(140, 80);
			this.numericUpDownLowTop.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownLowTop.Name = "numericUpDownLowTop";
			this.numericUpDownLowTop.Size = new System.Drawing.Size(97, 21);
			this.numericUpDownLowTop.TabIndex = 5;
			this.numericUpDownLowTop.Value = new decimal(new int[] {
            24270,
            0,
            0,
            0});
			// 
			// numericUpDownLowBottom
			// 
			this.numericUpDownLowBottom.Location = new System.Drawing.Point(140, 53);
			this.numericUpDownLowBottom.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownLowBottom.Name = "numericUpDownLowBottom";
			this.numericUpDownLowBottom.Size = new System.Drawing.Size(97, 21);
			this.numericUpDownLowBottom.TabIndex = 4;
			this.numericUpDownLowBottom.Value = new decimal(new int[] {
            24101,
            0,
            0,
            0});
			this.numericUpDownLowBottom.ValueChanged += new System.EventHandler(this.numericUpDownLowBottom_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "低位";
			// 
			// numericUpDownHigh
			// 
			this.numericUpDownHigh.Location = new System.Drawing.Point(95, 22);
			this.numericUpDownHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDownHigh.Name = "numericUpDownHigh";
			this.numericUpDownHigh.Size = new System.Drawing.Size(93, 21);
			this.numericUpDownHigh.TabIndex = 2;
			this.numericUpDownHigh.Value = new decimal(new int[] {
            93,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "高位";
			// 
			// buttonSingle
			// 
			this.buttonSingle.Location = new System.Drawing.Point(26, 134);
			this.buttonSingle.Name = "buttonSingle";
			this.buttonSingle.Size = new System.Drawing.Size(108, 23);
			this.buttonSingle.TabIndex = 1;
			this.buttonSingle.Text = "单个转换";
			this.buttonSingle.UseVisualStyleBackColor = true;
			this.buttonSingle.Click += new System.EventHandler(this.buttonSingle_Click);
			// 
			// buttonMany
			// 
			this.buttonMany.Location = new System.Drawing.Point(141, 134);
			this.buttonMany.Name = "buttonMany";
			this.buttonMany.Size = new System.Drawing.Size(108, 23);
			this.buttonMany.TabIndex = 2;
			this.buttonMany.Text = "批量转换";
			this.buttonMany.UseVisualStyleBackColor = true;
			this.buttonMany.Click += new System.EventHandler(this.buttonMany_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelLow);
			this.groupBox2.Controls.Add(this.labelHigh);
			this.groupBox2.Controls.Add(this.textBoxIndala);
			this.groupBox2.Location = new System.Drawing.Point(12, 163);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(259, 142);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "单个转换（低值）";
			// 
			// labelLow
			// 
			this.labelLow.AutoSize = true;
			this.labelLow.Location = new System.Drawing.Point(20, 60);
			this.labelLow.Name = "labelLow";
			this.labelLow.Size = new System.Drawing.Size(41, 12);
			this.labelLow.TabIndex = 3;
			this.labelLow.Text = "000000";
			// 
			// labelHigh
			// 
			this.labelHigh.AutoSize = true;
			this.labelHigh.Location = new System.Drawing.Point(20, 31);
			this.labelHigh.Name = "labelHigh";
			this.labelHigh.Size = new System.Drawing.Size(29, 12);
			this.labelHigh.TabIndex = 2;
			this.labelHigh.Text = "0000";
			// 
			// textBoxIndala
			// 
			this.textBoxIndala.Font = new System.Drawing.Font("Times", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxIndala.Location = new System.Drawing.Point(22, 85);
			this.textBoxIndala.Name = "textBoxIndala";
			this.textBoxIndala.Size = new System.Drawing.Size(215, 41);
			this.textBoxIndala.TabIndex = 0;
			this.textBoxIndala.Text = "00000000";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridViewIndala);
			this.groupBox3.Location = new System.Drawing.Point(277, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(346, 292);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "批量";
			// 
			// dataGridViewIndala
			// 
			this.dataGridViewIndala.AllowUserToAddRows = false;
			this.dataGridViewIndala.AllowUserToDeleteRows = false;
			this.dataGridViewIndala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewIndala.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewIndala.Location = new System.Drawing.Point(3, 17);
			this.dataGridViewIndala.Name = "dataGridViewIndala";
			this.dataGridViewIndala.ReadOnly = true;
			this.dataGridViewIndala.RowTemplate.Height = 23;
			this.dataGridViewIndala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewIndala.Size = new System.Drawing.Size(340, 272);
			this.dataGridViewIndala.TabIndex = 0;
			this.dataGridViewIndala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewIndala_KeyDown);
			// 
			// FormIndala
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 316);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonMany);
			this.Controls.Add(this.buttonSingle);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormIndala";
			this.ShowIcon = false;
			this.Text = "Indala";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowBottom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHigh)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndala)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownLowTop;
		private System.Windows.Forms.NumericUpDown numericUpDownLowBottom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownHigh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSingle;
		private System.Windows.Forms.Button buttonMany;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelLow;
		private System.Windows.Forms.Label labelHigh;
		private System.Windows.Forms.TextBox textBoxIndala;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridViewIndala;
	}
}

