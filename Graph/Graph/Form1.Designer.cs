﻿namespace Graph
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
            this.vertex1 = new System.Windows.Forms.Button();
            this.vertex2 = new System.Windows.Forms.Button();
            this.vertex3 = new System.Windows.Forms.Button();
            this.vertex4 = new System.Windows.Forms.Button();
            this.vertex5 = new System.Windows.Forms.Button();
            this.vertex6 = new System.Windows.Forms.Button();
            this.vertex7 = new System.Windows.Forms.Button();
            this.vertex8 = new System.Windows.Forms.Button();
            this.vertex9 = new System.Windows.Forms.Button();
            this.vertex10 = new System.Windows.Forms.Button();
            this.vertex11 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // vertex1
            // 
            this.vertex1.Location = new System.Drawing.Point(12, 8);
            this.vertex1.Name = "vertex1";
            this.vertex1.Size = new System.Drawing.Size(79, 78);
            this.vertex1.TabIndex = 0;
            this.vertex1.UseVisualStyleBackColor = true;
            this.vertex1.Click += new System.EventHandler(this.vertex1_Click);
            // 
            // vertex2
            // 
            this.vertex2.Location = new System.Drawing.Point(146, 8);
            this.vertex2.Name = "vertex2";
            this.vertex2.Size = new System.Drawing.Size(79, 78);
            this.vertex2.TabIndex = 1;
            this.vertex2.UseVisualStyleBackColor = true;
            this.vertex2.Click += new System.EventHandler(this.vertex2_Click);
            // 
            // vertex3
            // 
            this.vertex3.Location = new System.Drawing.Point(12, 199);
            this.vertex3.Name = "vertex3";
            this.vertex3.Size = new System.Drawing.Size(79, 78);
            this.vertex3.TabIndex = 2;
            this.vertex3.UseVisualStyleBackColor = true;
            this.vertex3.Click += new System.EventHandler(this.vertex3_Click);
            // 
            // vertex4
            // 
            this.vertex4.Location = new System.Drawing.Point(12, 380);
            this.vertex4.Name = "vertex4";
            this.vertex4.Size = new System.Drawing.Size(79, 78);
            this.vertex4.TabIndex = 3;
            this.vertex4.UseVisualStyleBackColor = true;
            this.vertex4.Click += new System.EventHandler(this.vertex4_Click);
            // 
            // vertex5
            // 
            this.vertex5.Location = new System.Drawing.Point(479, 380);
            this.vertex5.Name = "vertex5";
            this.vertex5.Size = new System.Drawing.Size(79, 78);
            this.vertex5.TabIndex = 4;
            this.vertex5.UseVisualStyleBackColor = true;
            this.vertex5.Click += new System.EventHandler(this.vertex5_Click);
            // 
            // vertex6
            // 
            this.vertex6.Location = new System.Drawing.Point(479, 12);
            this.vertex6.Name = "vertex6";
            this.vertex6.Size = new System.Drawing.Size(79, 78);
            this.vertex6.TabIndex = 5;
            this.vertex6.UseVisualStyleBackColor = true;
            this.vertex6.Click += new System.EventHandler(this.vertex6_Click);
            // 
            // vertex7
            // 
            this.vertex7.Location = new System.Drawing.Point(683, 12);
            this.vertex7.Name = "vertex7";
            this.vertex7.Size = new System.Drawing.Size(79, 78);
            this.vertex7.TabIndex = 6;
            this.vertex7.UseVisualStyleBackColor = true;
            this.vertex7.Click += new System.EventHandler(this.vertex7_Click);
            // 
            // vertex8
            // 
            this.vertex8.Location = new System.Drawing.Point(683, 199);
            this.vertex8.Name = "vertex8";
            this.vertex8.Size = new System.Drawing.Size(79, 78);
            this.vertex8.TabIndex = 7;
            this.vertex8.UseVisualStyleBackColor = true;
            this.vertex8.Click += new System.EventHandler(this.vertex8_Click);
            // 
            // vertex9
            // 
            this.vertex9.Location = new System.Drawing.Point(683, 380);
            this.vertex9.Name = "vertex9";
            this.vertex9.Size = new System.Drawing.Size(79, 78);
            this.vertex9.TabIndex = 8;
            this.vertex9.UseVisualStyleBackColor = true;
            this.vertex9.Click += new System.EventHandler(this.vertex9_Click);
            // 
            // vertex10
            // 
            this.vertex10.Location = new System.Drawing.Point(901, 380);
            this.vertex10.Name = "vertex10";
            this.vertex10.Size = new System.Drawing.Size(79, 78);
            this.vertex10.TabIndex = 9;
            this.vertex10.Text = "S";
            this.vertex10.UseVisualStyleBackColor = true;
            this.vertex10.Click += new System.EventHandler(this.vertex10_Click);
            // 
            // vertex11
            // 
            this.vertex11.Location = new System.Drawing.Point(901, 508);
            this.vertex11.Name = "vertex11";
            this.vertex11.Size = new System.Drawing.Size(79, 78);
            this.vertex11.TabIndex = 10;
            this.vertex11.UseVisualStyleBackColor = true;
            this.vertex11.Click += new System.EventHandler(this.vertex11_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(901, 255);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(217, 51);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Найти путь!";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(901, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(330, 205);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 687);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.vertex11);
            this.Controls.Add(this.vertex10);
            this.Controls.Add(this.vertex9);
            this.Controls.Add(this.vertex8);
            this.Controls.Add(this.vertex7);
            this.Controls.Add(this.vertex6);
            this.Controls.Add(this.vertex5);
            this.Controls.Add(this.vertex4);
            this.Controls.Add(this.vertex3);
            this.Controls.Add(this.vertex2);
            this.Controls.Add(this.vertex1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vertex1;
        private System.Windows.Forms.Button vertex2;
        private System.Windows.Forms.Button vertex3;
        private System.Windows.Forms.Button vertex4;
        private System.Windows.Forms.Button vertex5;
        private System.Windows.Forms.Button vertex6;
        private System.Windows.Forms.Button vertex7;
        private System.Windows.Forms.Button vertex8;
        private System.Windows.Forms.Button vertex9;
        private System.Windows.Forms.Button vertex10;
        private System.Windows.Forms.Button vertex11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

