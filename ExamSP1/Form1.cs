using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ExamSP1
{
    public partial class Form1 : Form
    {
        Thread thread;
        ManualResetEvent shutdownEvent = new ManualResetEvent(false);
        ManualResetEvent pauseEvent = new ManualResetEvent(true);

        class BufferSize 
        {
            public int Size { get; set; }
            public int AverageSpeed { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 1000;
            btnCopy.Tag = 0;
        }

        private void CopyFile(object bufferSize)
        {
            BufferSize buf = (BufferSize) bufferSize;

            try
            {
                byte[] buffer = new byte[buf.Size];
                long AllBytes = 0;

                using (FileStream fsOut = new FileStream(txtSource.Text, FileMode.Open, FileAccess.Read))
                {
                    long fSize = fsOut.Length;
                    int ptr = (int)fSize / buf.Size;

                using (FileStream fsIn = new FileStream(txtDestinition.Text, FileMode.Create, FileAccess.Write))
                    {
                        int startmin = DateTime.Now.Minute;
                        int startsec = DateTime.Now.Second;
                        while (true)
                        {
                            pauseEvent.WaitOne(Timeout.Infinite);
                            if (shutdownEvent.WaitOne(0)) break;
                            int bytesread = fsOut.Read(buffer, 0, buf.Size);

                            if (bytesread == 0)
                            {
                                break;
                            }
                            fsIn.Write(buffer, 0, bytesread);
                            AllBytes += bytesread;

                            if (bytesread < buf.Size)
                            {
                                break;
                            }

                            progressBar1.Invoke(new Action(() => { progressBar1.Value = (int)(AllBytes * 1000 / fSize); progressBar1.PerformStep(); }));
                            lblPrecentage.Invoke(new Action(() => { float progress = (float)progressBar1.Value / 10; lblPrecentage.Text = string.Format(" {0:F1}% ", progress); }));
                        }
                        int endmin = DateTime.Now.Minute;
                        int endsec = DateTime.Now.Second;
                        buf.AverageSpeed = (int)(fSize / (((endmin - startmin) * 60) + (endsec - startsec)) / 1024);
                        listView1.Invoke(new Action(() => {ListViewItem lstv = listView1.Items.Add(buf.Size.ToString());
                            lstv.SubItems.Add(buf.AverageSpeed.ToString());
                        }));
                    }
                }
                MessageBox.Show("Копирование завершено");
            }
            catch(Exception e)
            {
                MessageBox.Show("Ошибка" + e.Message);
            }            
        }
        int tag = 0;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = ofd.FileName;
            }
        }

        private void btnDestinition_Click(object sender, EventArgs e)
        {
            SFD.FileName = ofd.SafeFileName;
            if(SFD.ShowDialog() == DialogResult.OK)
            {
                txtDestinition.Text = SFD.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            shutdownEvent.Set();
            MessageBox.Show("Поток остановлен");
            pauseEvent.Set();
            thread.Join();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            BufferSize buffersize = new BufferSize();
            
            if (tag == 0)
            {
                buffersize.Size = 512;
            }
            else if (tag == 1)
            {
                buffersize.Size = 1024;
            }
            else if (tag == 2)
            {
                buffersize.Size = 2 * 1024;
            }
            else if (tag == 3)
            {
                buffersize.Size = 4 * 1024;
            }
            else if (tag == 4)
            {
                buffersize.Size = 16 * 1024;
            }
            else if (tag == 5)
            {
                buffersize.Size = 64 * 1024;
            }
            else if (tag == 6)
            {
                buffersize.Size = 256 * 1024;
            }
            else if (tag == 7)
            {
                buffersize.Size = 1024 * 1024;
            }
            else if (tag == 8)
            {
                buffersize.Size = 4 * 1024 * 1024;
            }
            else if (tag == 9)
            {
                buffersize.Size = 16 * 1024 * 1024;
            }
            else if (tag == 10)
            {
                buffersize.Size = 32 * 1024 * 1024;
            }

            thread = new Thread(CopyFile);
            thread.Start(buffersize);
            tag++;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pauseEvent.Reset();
            MessageBox.Show("Поток на паузе");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            pauseEvent.Set();
            MessageBox.Show("Поток возобновлен ");
        }
    }
}
