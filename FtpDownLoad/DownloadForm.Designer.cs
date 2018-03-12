using System.Windows.Forms;

namespace FtpDownLoad
{
    partial class DownloadForm
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
            this.DownLoadProgress = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RateLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.BytesDownLabel = new System.Windows.Forms.Label();
            this.DownBytesValue = new System.Windows.Forms.Label();
            this.EstTimeValue = new System.Windows.Forms.Label();
            this.TransRateValue = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownLoadProgress
            // 
            this.DownLoadProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.DownLoadProgress.Location = new System.Drawing.Point(0, 0);
            this.DownLoadProgress.Name = "DownLoadProgress";
            this.DownLoadProgress.Size = new System.Drawing.Size(284, 23);
            this.DownLoadProgress.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel1.Controls.Add(this.RateLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimeLeftLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BytesDownLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DownBytesValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EstTimeValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TransRateValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RateLabel.Location = new System.Drawing.Point(3, 0);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(70, 13);
            this.RateLabel.TabIndex = 0;
            this.RateLabel.Text = "Transfer rate:";
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimeLeftLabel.Location = new System.Drawing.Point(3, 13);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(95, 13);
            this.TimeLeftLabel.TabIndex = 1;
            this.TimeLeftLabel.Text = "Estimated time left:";
            // 
            // BytesDownLabel
            // 
            this.BytesDownLabel.AutoSize = true;
            this.BytesDownLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BytesDownLabel.Location = new System.Drawing.Point(3, 26);
            this.BytesDownLabel.Name = "BytesDownLabel";
            this.BytesDownLabel.Size = new System.Drawing.Size(98, 13);
            this.BytesDownLabel.TabIndex = 2;
            this.BytesDownLabel.Text = "Downloaded bytes:";
            // 
            // DownBytesValue
            // 
            this.DownBytesValue.AutoSize = true;
            this.DownBytesValue.Location = new System.Drawing.Point(139, 26);
            this.DownBytesValue.Name = "DownBytesValue";
            this.DownBytesValue.Size = new System.Drawing.Size(35, 13);
            this.DownBytesValue.TabIndex = 3;
            this.DownBytesValue.Text = "label1";
            // 
            // EstTimeValue
            // 
            this.EstTimeValue.AutoSize = true;
            this.EstTimeValue.Location = new System.Drawing.Point(139, 13);
            this.EstTimeValue.Name = "EstTimeValue";
            this.EstTimeValue.Size = new System.Drawing.Size(35, 13);
            this.EstTimeValue.TabIndex = 4;
            this.EstTimeValue.Text = "label2";
            // 
            // TransRateValue
            // 
            this.TransRateValue.AutoSize = true;
            this.TransRateValue.Location = new System.Drawing.Point(139, 0);
            this.TransRateValue.Name = "TransRateValue";
            this.TransRateValue.Size = new System.Drawing.Size(35, 13);
            this.TransRateValue.TabIndex = 5;
            this.TransRateValue.Text = "label3";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(3, 42);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 93);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DownLoadProgress);
            this.Name = "DownloadForm";
            this.Text = "DownLoadMaster";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar DownLoadProgress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Label BytesDownLabel;
        private System.Windows.Forms.Label DownBytesValue;
        private System.Windows.Forms.Label EstTimeValue;
        private System.Windows.Forms.Label TransRateValue;
        private System.Windows.Forms.Button StartBtn;
    }
}

