namespace CodeChum
{
    public partial class DownloadManager : Form
    {

        private const int ProgressIncrement = 10;
        private int maxProgressValue = 0;
        private int currentProgressValue = 0;
        public DownloadManager()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (currentProgressValue < maxProgressValue)
            {
                currentProgressValue += ProgressIncrement;
                if (currentProgressValue > maxProgressValue)
                    currentProgressValue = maxProgressValue;
                progressBar.Value = currentProgressValue;
            }
            else
            {
                ProgressTimer.Stop();
                btnDownload.Enabled = true;
            }
        }

        private void UpdateProgressBarMaxValue()
        {
            maxProgressValue = 0;
            foreach (CheckBox checkBox in groupBox1.Controls)
            {
                if (checkBox.Checked)
                    maxProgressValue += 100;
            }
            progressBar.Maximum = maxProgressValue;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            UpdateProgressBarMaxValue();
            currentProgressValue = 0;
            progressBar.Value = 0;
            btnDownload.Enabled = false;
            ProgressTimer.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProgressTimer.Stop();
            progressBar.Value = 0;
            btnDownload.Enabled = true;
            foreach (CheckBox checkBox in groupBox1.Controls)
            {
                checkBox.Checked = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DownloadManager_Load(object sender, EventArgs e)
        {

        }
    }
}
