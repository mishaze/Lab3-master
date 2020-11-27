namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produsers = new System.Windows.Forms.ListBox();
            this.Consumers = new System.Windows.Forms.ListBox();
            this.Buffer = new System.Windows.Forms.ListBox();
            this.Btn_add_produser = new System.Windows.Forms.Button();
            this.btn_add_consumer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_produser_time = new System.Windows.Forms.TextBox();
            this.tb_consumer_time = new System.Windows.Forms.TextBox();
            this.btn_Start_Stop = new System.Windows.Forms.Button();
            this.btn_ChangeTime = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_changeTime = new System.Windows.Forms.TextBox();
            this.checkProduser = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkConsumer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Produsers
            // 
            this.Produsers.FormattingEnabled = true;
            this.Produsers.Location = new System.Drawing.Point(12, 16);
            this.Produsers.Name = "Produsers";
            this.Produsers.Size = new System.Drawing.Size(174, 225);
            this.Produsers.TabIndex = 0;
            this.Produsers.SelectedIndexChanged += new System.EventHandler(this.Produsers_SelectedIndexChanged);
            // 
            // Consumers
            // 
            this.Consumers.FormattingEnabled = true;
            this.Consumers.Location = new System.Drawing.Point(449, 16);
            this.Consumers.Name = "Consumers";
            this.Consumers.Size = new System.Drawing.Size(175, 225);
            this.Consumers.TabIndex = 1;
            this.Consumers.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Buffer
            // 
            this.Buffer.FormattingEnabled = true;
            this.Buffer.Location = new System.Drawing.Point(240, 16);
            this.Buffer.Name = "Buffer";
            this.Buffer.Size = new System.Drawing.Size(157, 225);
            this.Buffer.TabIndex = 2;
            this.Buffer.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Btn_add_produser
            // 
            this.Btn_add_produser.Location = new System.Drawing.Point(12, 248);
            this.Btn_add_produser.Name = "Btn_add_produser";
            this.Btn_add_produser.Size = new System.Drawing.Size(112, 40);
            this.Btn_add_produser.TabIndex = 3;
            this.Btn_add_produser.Text = "Add produser";
            this.Btn_add_produser.UseVisualStyleBackColor = true;
            this.Btn_add_produser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_consumer
            // 
            this.btn_add_consumer.Location = new System.Drawing.Point(512, 247);
            this.btn_add_consumer.Name = "btn_add_consumer";
            this.btn_add_consumer.Size = new System.Drawing.Size(112, 40);
            this.btn_add_consumer.TabIndex = 4;
            this.btn_add_consumer.Text = "add consumer\r\n";
            this.btn_add_consumer.UseVisualStyleBackColor = true;
            this.btn_add_consumer.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "buffer\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_produser_time
            // 
            this.tb_produser_time.Location = new System.Drawing.Point(12, 294);
            this.tb_produser_time.Name = "tb_produser_time";
            this.tb_produser_time.Size = new System.Drawing.Size(100, 20);
            this.tb_produser_time.TabIndex = 6;
            this.tb_produser_time.TextChanged += new System.EventHandler(this.tb_produser_time_TextChanged);
            // 
            // tb_consumer_time
            // 
            this.tb_consumer_time.Location = new System.Drawing.Point(524, 294);
            this.tb_consumer_time.Name = "tb_consumer_time";
            this.tb_consumer_time.Size = new System.Drawing.Size(100, 20);
            this.tb_consumer_time.TabIndex = 7;
            this.tb_consumer_time.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Start_Stop
            // 
            this.btn_Start_Stop.Location = new System.Drawing.Point(141, 390);
            this.btn_Start_Stop.Name = "btn_Start_Stop";
            this.btn_Start_Stop.Size = new System.Drawing.Size(112, 40);
            this.btn_Start_Stop.TabIndex = 8;
            this.btn_Start_Stop.Text = "Start/Stop";
            this.btn_Start_Stop.UseVisualStyleBackColor = true;
            this.btn_Start_Stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ChangeTime
            // 
            this.btn_ChangeTime.Location = new System.Drawing.Point(259, 390);
            this.btn_ChangeTime.Name = "btn_ChangeTime";
            this.btn_ChangeTime.Size = new System.Drawing.Size(112, 40);
            this.btn_ChangeTime.TabIndex = 9;
            this.btn_ChangeTime.Text = "change time";
            this.btn_ChangeTime.UseVisualStyleBackColor = true;
            this.btn_ChangeTime.Click += new System.EventHandler(this.btn_ChangeTime_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(377, 390);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 40);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(266, 364);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 20);
            this.tb_num.TabIndex = 11;
            // 
            // tb_changeTime
            // 
            this.tb_changeTime.Location = new System.Drawing.Point(389, 364);
            this.tb_changeTime.Name = "tb_changeTime";
            this.tb_changeTime.Size = new System.Drawing.Size(100, 20);
            this.tb_changeTime.TabIndex = 12;
            // 
            // checkProduser
            // 
            this.checkProduser.AutoSize = true;
            this.checkProduser.Location = new System.Drawing.Point(141, 344);
            this.checkProduser.Name = "checkProduser";
            this.checkProduser.Size = new System.Drawing.Size(69, 17);
            this.checkProduser.TabIndex = 13;
            this.checkProduser.Text = "Producer";
            this.checkProduser.UseVisualStyleBackColor = true;
            this.checkProduser.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Num";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Produsers\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkConsumer
            // 
            this.checkConsumer.AutoSize = true;
            this.checkConsumer.Location = new System.Drawing.Point(141, 364);
            this.checkConsumer.Name = "checkConsumer";
            this.checkConsumer.Size = new System.Drawing.Size(73, 17);
            this.checkConsumer.TabIndex = 18;
            this.checkConsumer.Text = "Consumer";
            this.checkConsumer.UseVisualStyleBackColor = true;
            this.checkConsumer.CheckedChanged += new System.EventHandler(this.checkConsumer_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 442);
            this.Controls.Add(this.checkConsumer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkProduser);
            this.Controls.Add(this.tb_changeTime);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_ChangeTime);
            this.Controls.Add(this.btn_Start_Stop);
            this.Controls.Add(this.tb_consumer_time);
            this.Controls.Add(this.tb_produser_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_consumer);
            this.Controls.Add(this.Btn_add_produser);
            this.Controls.Add(this.Buffer);
            this.Controls.Add(this.Consumers);
            this.Controls.Add(this.Produsers);
            this.Name = "Form1";
            this.Text = "buffer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Produsers;
        private System.Windows.Forms.ListBox Consumers;
        public System.Windows.Forms.ListBox Buffer;
        private System.Windows.Forms.Button Btn_add_produser;
        private System.Windows.Forms.Button btn_add_consumer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_produser_time;
        private System.Windows.Forms.TextBox tb_consumer_time;
        private System.Windows.Forms.Button btn_Start_Stop;
        private System.Windows.Forms.Button btn_ChangeTime;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_changeTime;
        private System.Windows.Forms.CheckBox checkProduser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkConsumer;
    }
}

