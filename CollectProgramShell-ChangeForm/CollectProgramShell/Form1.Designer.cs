﻿
namespace CollectProgramShell
{
    partial class MainMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowForm2
            // 
            this.btnShowForm2.Location = new System.Drawing.Point(158, 85);
            this.btnShowForm2.Name = "btnShowForm2";
            this.btnShowForm2.Size = new System.Drawing.Size(75, 23);
            this.btnShowForm2.TabIndex = 0;
            this.btnShowForm2.Text = "顯示Form2";
            this.btnShowForm2.UseVisualStyleBackColor = true;
            this.btnShowForm2.Click += new System.EventHandler(this.btnShowForm2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowForm2);
            this.Name = "MainMenu";
            this.Text = "主選單";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.Move += new System.EventHandler(this.MainMenu_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm2;
    }
}

