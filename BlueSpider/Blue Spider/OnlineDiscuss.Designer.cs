﻿namespace Blue_Spider
{
    partial class OnlineDiscuss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_text_content = new System.Windows.Forms.ListBox();
            this.lb_text_people = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_text_content);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "群聊内容";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_text_people);
            this.groupBox2.Location = new System.Drawing.Point(598, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 343);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参与人员";
            // 
            // lb_text_content
            // 
            this.lb_text_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_text_content.FormattingEnabled = true;
            this.lb_text_content.ItemHeight = 15;
            this.lb_text_content.Location = new System.Drawing.Point(6, 24);
            this.lb_text_content.Name = "lb_text_content";
            this.lb_text_content.Size = new System.Drawing.Size(551, 304);
            this.lb_text_content.TabIndex = 0;
            // 
            // lb_text_people
            // 
            this.lb_text_people.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_text_people.FormattingEnabled = true;
            this.lb_text_people.ItemHeight = 15;
            this.lb_text_people.Location = new System.Drawing.Point(6, 24);
            this.lb_text_people.Name = "lb_text_people";
            this.lb_text_people.Size = new System.Drawing.Size(193, 304);
            this.lb_text_people.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 386);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 64);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "textBox1";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_send.Location = new System.Drawing.Point(626, 400);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(138, 40);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = false;
            // 
            // OnlineDiscuss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 475);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OnlineDiscuss";
            this.Text = "联机讨论";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_text_content;
        private System.Windows.Forms.ListBox lb_text_people;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_send;
    }
}