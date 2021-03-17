
using System.Threading;

namespace Zaderzhka
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
            this.firstBox = new System.Windows.Forms.Label();
            this.secondBox = new System.Windows.Forms.Label();
            this.thirdBox = new System.Windows.Forms.Label();
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstBox
            // 
            this.firstBox.AutoSize = true;
            this.firstBox.Location = new System.Drawing.Point(60, 41);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(13, 13);
            this.firstBox.TabIndex = 0;
            this.firstBox.Text = "0";
            // 
            // secondBox
            // 
            this.secondBox.AutoSize = true;
            this.secondBox.Location = new System.Drawing.Point(159, 41);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(13, 13);
            this.secondBox.TabIndex = 0;
            this.secondBox.Text = "0";
            // 
            // thirdBox
            // 
            this.thirdBox.AutoSize = true;
            this.thirdBox.Location = new System.Drawing.Point(260, 41);
            this.thirdBox.Name = "thirdBox";
            this.thirdBox.Size = new System.Drawing.Size(13, 13);
            this.thirdBox.TabIndex = 0;
            this.thirdBox.Text = "0";
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(29, 111);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 23);
            this.firstButton.TabIndex = 1;
            this.firstButton.Text = "Start";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(128, 111);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(75, 23);
            this.secondButton.TabIndex = 1;
            this.secondButton.Text = "Start";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // thirdButton
            // 
            this.thirdButton.Location = new System.Drawing.Point(229, 111);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(75, 23);
            this.thirdButton.TabIndex = 1;
            this.thirdButton.Text = "Start";
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.Click += new System.EventHandler(this.thirdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 169);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.thirdBox);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.firstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstBox;
        private System.Windows.Forms.Label secondBox;
        private System.Windows.Forms.Label thirdBox;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button thirdButton;

        private int firstValue;
        private int secondValue;
        private int thirdValue;

        private bool firstClick;
        private bool secondClick;
        private bool thirdClick;

        private Thread firstThread;
        private Thread secondThread;
        private Thread thirdThread;
    }
}

