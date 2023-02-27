namespace 顺序表_第一周
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_prime = new System.Windows.Forms.Button();
            this.bt_rand = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.rb_datasx2 = new System.Windows.Forms.RadioButton();
            this.rb_datasx1 = new System.Windows.Forms.RadioButton();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_maxcount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_modify_dt = new System.Windows.Forms.TextBox();
            this.tb_modify_no = new System.Windows.Forms.TextBox();
            this.rb_last = new System.Windows.Forms.RadioButton();
            this.rb_second = new System.Windows.Forms.RadioButton();
            this.rb_first = new System.Windows.Forms.RadioButton();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reverse = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_prime);
            this.groupBox1.Controls.Add(this.bt_rand);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Controls.Add(this.rb_datasx2);
            this.groupBox1.Controls.Add(this.rb_datasx1);
            this.groupBox1.Controls.Add(this.tb_count);
            this.groupBox1.Controls.Add(this.tb_maxcount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(438, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始化";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_prime
            // 
            this.bt_prime.Location = new System.Drawing.Point(125, 156);
            this.bt_prime.Name = "bt_prime";
            this.bt_prime.Size = new System.Drawing.Size(64, 33);
            this.bt_prime.TabIndex = 9;
            this.bt_prime.Text = "素数";
            this.bt_prime.UseVisualStyleBackColor = true;
            this.bt_prime.Click += new System.EventHandler(this.bt_prime_Click);
            // 
            // bt_rand
            // 
            this.bt_rand.Location = new System.Drawing.Point(19, 156);
            this.bt_rand.Name = "bt_rand";
            this.bt_rand.Size = new System.Drawing.Size(73, 33);
            this.bt_rand.TabIndex = 8;
            this.bt_rand.Text = "n个不同随机数";
            this.bt_rand.UseVisualStyleBackColor = true;
            this.bt_rand.Click += new System.EventHandler(this.bt_rand_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(124, 117);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(65, 33);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(19, 117);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(72, 33);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "初始化";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // rb_datasx2
            // 
            this.rb_datasx2.AutoSize = true;
            this.rb_datasx2.Location = new System.Drawing.Point(125, 92);
            this.rb_datasx2.Name = "rb_datasx2";
            this.rb_datasx2.Size = new System.Drawing.Size(73, 19);
            this.rb_datasx2.TabIndex = 5;
            this.rb_datasx2.TabStop = true;
            this.rb_datasx2.Text = "随机数";
            this.rb_datasx2.UseVisualStyleBackColor = true;
            // 
            // rb_datasx1
            // 
            this.rb_datasx1.AutoSize = true;
            this.rb_datasx1.Location = new System.Drawing.Point(19, 92);
            this.rb_datasx1.Name = "rb_datasx1";
            this.rb_datasx1.Size = new System.Drawing.Size(73, 19);
            this.rb_datasx1.TabIndex = 4;
            this.rb_datasx1.TabStop = true;
            this.rb_datasx1.Text = "顺序数";
            this.rb_datasx1.UseVisualStyleBackColor = true;
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(124, 61);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(65, 25);
            this.tb_count.TabIndex = 3;
            // 
            // tb_maxcount
            // 
            this.tb_maxcount.Location = new System.Drawing.Point(124, 22);
            this.tb_maxcount.Name = "tb_maxcount";
            this.tb_maxcount.Size = new System.Drawing.Size(65, 25);
            this.tb_maxcount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大个数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据个数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_modify_dt);
            this.groupBox2.Controls.Add(this.tb_modify_no);
            this.groupBox2.Controls.Add(this.rb_last);
            this.groupBox2.Controls.Add(this.rb_second);
            this.groupBox2.Controls.Add(this.rb_first);
            this.groupBox2.Controls.Add(this.btn_insert);
            this.groupBox2.Controls.Add(this.btn_change);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(438, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结点移动";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "操作数据";
            // 
            // tb_modify_dt
            // 
            this.tb_modify_dt.Location = new System.Drawing.Point(124, 172);
            this.tb_modify_dt.Name = "tb_modify_dt";
            this.tb_modify_dt.Size = new System.Drawing.Size(65, 25);
            this.tb_modify_dt.TabIndex = 14;
            // 
            // tb_modify_no
            // 
            this.tb_modify_no.Location = new System.Drawing.Point(147, 77);
            this.tb_modify_no.Name = "tb_modify_no";
            this.tb_modify_no.Size = new System.Drawing.Size(42, 25);
            this.tb_modify_no.TabIndex = 13;
            // 
            // rb_last
            // 
            this.rb_last.AutoSize = true;
            this.rb_last.Location = new System.Drawing.Point(124, 113);
            this.rb_last.Name = "rb_last";
            this.rb_last.Size = new System.Drawing.Size(43, 19);
            this.rb_last.TabIndex = 12;
            this.rb_last.TabStop = true;
            this.rb_last.Text = "尾";
            this.rb_last.UseVisualStyleBackColor = true;
            // 
            // rb_second
            // 
            this.rb_second.AutoSize = true;
            this.rb_second.Location = new System.Drawing.Point(124, 79);
            this.rb_second.Name = "rb_second";
            this.rb_second.Size = new System.Drawing.Size(17, 16);
            this.rb_second.TabIndex = 11;
            this.rb_second.TabStop = true;
            this.rb_second.UseVisualStyleBackColor = true;
            // 
            // rb_first
            // 
            this.rb_first.AutoSize = true;
            this.rb_first.Location = new System.Drawing.Point(124, 43);
            this.rb_first.Name = "rb_first";
            this.rb_first.Size = new System.Drawing.Size(43, 19);
            this.rb_first.TabIndex = 10;
            this.rb_first.TabStop = true;
            this.rb_first.Text = "首";
            this.rb_first.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(19, 143);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(64, 33);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "插入";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(19, 90);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(64, 33);
            this.btn_change.TabIndex = 8;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(19, 36);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(64, 37);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "操作位置";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(-3, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(444, 545);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(457, 449);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(170, 63);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reverse
            // 
            this.btn_reverse.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_reverse.Location = new System.Drawing.Point(679, 34);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(126, 63);
            this.btn_reverse.TabIndex = 8;
            this.btn_reverse.Text = "元素逆转";
            this.btn_reverse.UseVisualStyleBackColor = true;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_find.Location = new System.Drawing.Point(679, 113);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(126, 63);
            this.btn_find.TabIndex = 9;
            this.btn_find.Text = "元素查找";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // tb_find
            // 
            this.tb_find.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_find.Location = new System.Drawing.Point(679, 207);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(172, 30);
            this.tb_find.TabIndex = 14;
            this.tb_find.Text = "请输入查找元素";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 536);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_reverse);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "顺序表_第一周";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_datasx2;
        private System.Windows.Forms.RadioButton rb_datasx1;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.TextBox tb_maxcount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_modify_dt;
        private System.Windows.Forms.TextBox tb_modify_no;
        private System.Windows.Forms.RadioButton rb_last;
        private System.Windows.Forms.RadioButton rb_second;
        private System.Windows.Forms.RadioButton rb_first;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button bt_rand;
        private System.Windows.Forms.Button bt_prime;
        private System.Windows.Forms.Button btn_reverse;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox tb_find;
    }
}

