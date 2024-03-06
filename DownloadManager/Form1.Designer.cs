namespace CodeChum
{
    partial class DownloadManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar = new ProgressBar();
            btnDownload = new Button();
            btnCancel = new Button();
            ProgressTimer = new System.Windows.Forms.Timer(components);
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Top;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(348, 23);
            progressBar.TabIndex = 0;
            progressBar.Click += progressBar1_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(75, 276);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(189, 276);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProgressTimer
            // 
            ProgressTimer.Tick += ProgressTimer_Tick;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(38, 147);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(61, 19);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "Videos";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(38, 122);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(52, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "PDFs";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(38, 97);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(79, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Excel Files";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(38, 72);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Word Documents";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Games";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Location = new Point(75, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 206);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Files Manager";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // DownloadManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 340);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnDownload);
            Controls.Add(progressBar);
            Name = "DownloadManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DownloadManager";
            Load += DownloadManager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
        private Button btnDownload;
        private Button btnCancel;
        private System.Windows.Forms.Timer ProgressTimer;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
    }
}
