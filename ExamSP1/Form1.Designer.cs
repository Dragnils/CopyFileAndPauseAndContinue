namespace ExamSP1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnDestinition = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestinition = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDstn = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lblPrecentage = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AvarageSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.Buffersize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(614, 44);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Файл..";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnDestinition
            // 
            this.btnDestinition.Location = new System.Drawing.Point(614, 98);
            this.btnDestinition.Name = "btnDestinition";
            this.btnDestinition.Size = new System.Drawing.Size(75, 23);
            this.btnDestinition.TabIndex = 1;
            this.btnDestinition.Text = "Файл..";
            this.btnDestinition.UseVisualStyleBackColor = true;
            this.btnDestinition.Click += new System.EventHandler(this.btnDestinition_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(441, 243);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Копирование";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(662, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(187, 46);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(408, 20);
            this.txtSource.TabIndex = 5;
            // 
            // txtDestinition
            // 
            this.txtDestinition.Location = new System.Drawing.Point(187, 98);
            this.txtDestinition.Name = "txtDestinition";
            this.txtDestinition.Size = new System.Drawing.Size(408, 20);
            this.txtDestinition.TabIndex = 6;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(84, 53);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(46, 13);
            this.lblSource.TabIndex = 7;
            this.lblSource.Text = "От куда";
            // 
            // lblDstn
            // 
            this.lblDstn.AutoSize = true;
            this.lblDstn.Location = new System.Drawing.Point(87, 98);
            this.lblDstn.Name = "lblDstn";
            this.lblDstn.Size = new System.Drawing.Size(31, 13);
            this.lblDstn.TabIndex = 8;
            this.lblDstn.Text = "Куда";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 176);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(680, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(554, 243);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // lblPrecentage
            // 
            this.lblPrecentage.AutoSize = true;
            this.lblPrecentage.Location = new System.Drawing.Point(356, 176);
            this.lblPrecentage.Name = "lblPrecentage";
            this.lblPrecentage.Size = new System.Drawing.Size(35, 13);
            this.lblPrecentage.TabIndex = 11;
            this.lblPrecentage.Text = "label1";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(554, 282);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(94, 23);
            this.btnContinue.TabIndex = 12;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Buffersize,
            this.AvarageSpeed});
            this.listView1.Location = new System.Drawing.Point(57, 243);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 97);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // AvarageSpeed
            // 
            this.AvarageSpeed.DisplayIndex = 0;
            this.AvarageSpeed.Text = "Средняя скорость";
            this.AvarageSpeed.Width = 105;
            // 
            // Buffersize
            // 
            this.Buffersize.DisplayIndex = 1;
            this.Buffersize.Text = "Размер буфера";
            this.Buffersize.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblPrecentage);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblDstn);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtDestinition);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDestinition);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnDestinition;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestinition;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDstn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lblPrecentage;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ListView listView1;
      
        private System.Windows.Forms.ColumnHeader AvarageSpeed;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.ColumnHeader Buffersize;
    }
}

