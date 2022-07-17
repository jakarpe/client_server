namespace chat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.REMOTEPORT = new System.Windows.Forms.TextBox();
            this.LOCALPORT = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.chat = new System.Windows.Forms.ListBox();
            this.connection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP для отправки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт для отправки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Твой порт";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(236, 37);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(173, 22);
            this.IP.TabIndex = 3;
            this.IP.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // REMOTEPORT
            // 
            this.REMOTEPORT.Location = new System.Drawing.Point(236, 71);
            this.REMOTEPORT.Name = "REMOTEPORT";
            this.REMOTEPORT.Size = new System.Drawing.Size(173, 22);
            this.REMOTEPORT.TabIndex = 4;
            // 
            // LOCALPORT
            // 
            this.LOCALPORT.Location = new System.Drawing.Point(236, 108);
            this.LOCALPORT.Name = "LOCALPORT";
            this.LOCALPORT.Size = new System.Drawing.Size(173, 22);
            this.LOCALPORT.TabIndex = 5;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(508, 37);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(205, 93);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(553, 344);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(125, 33);
            this.Send.TabIndex = 7;
            this.Send.Text = "send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(45, 349);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(443, 22);
            this.message.TabIndex = 8;
            // 
            // chat
            // 
            this.chat.FormattingEnabled = true;
            this.chat.ItemHeight = 16;
            this.chat.Location = new System.Drawing.Point(45, 152);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(443, 164);
            this.chat.TabIndex = 9;
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(550, 152);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(113, 17);
            this.connection.TabIndex = 10;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.LOCALPORT);
            this.Controls.Add(this.REMOTEPORT);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox REMOTEPORT;
        private System.Windows.Forms.TextBox LOCALPORT;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ListBox chat;
        private System.Windows.Forms.Label connection;
    }
}

