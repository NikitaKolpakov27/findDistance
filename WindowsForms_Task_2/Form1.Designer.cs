using System;

namespace WindowsForms_Task_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boat = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.TextBox();
            this.lake = new System.Windows.Forms.TextBox();
            this.river = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Определить путь S, пройденный лодкой\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Location = new System.Drawing.Point(-2, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите скорость лодки:\r\n";
            this.label3.Location = new System.Drawing.Point(-1, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите скорость течения:\r\n";
            this.label4.Location = new System.Drawing.Point(-1, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите время по озеру:\r\n";
            this.label5.Location = new System.Drawing.Point(-1, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Введите время по реке: \r\n\r\n\r\n";
            this.boat.Location = new System.Drawing.Point(184, 77);
            this.boat.Name = "boat";
            this.boat.Size = new System.Drawing.Size(110, 22);
            this.boat.TabIndex = 5;
            this.course.Location = new System.Drawing.Point(184, 121);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(110, 22);
            this.course.TabIndex = 6;
            this.lake.Location = new System.Drawing.Point(184, 166);
            this.lake.Name = "lake";
            this.lake.Size = new System.Drawing.Size(109, 22);
            this.lake.TabIndex = 7;
            this.river.Location = new System.Drawing.Point(184, 208);
            this.river.Name = "river";
            this.river.Size = new System.Drawing.Size(108, 22);
            this.river.TabIndex = 8;
            this.calculate.Location = new System.Drawing.Point(346, 122);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(159, 58);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Посчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new EventHandler(this.calculate_Click);
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(284, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Результат";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.Location = new System.Drawing.Point(326, 324);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(118, 22);
            this.result.TabIndex = 11;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.river);
            this.Controls.Add(this.lake);
            this.Controls.Add(this.course);
            this.Controls.Add(this.boat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox boat;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lake;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox river;

        #endregion
    }
}