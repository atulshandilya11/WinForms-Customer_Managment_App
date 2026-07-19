namespace FIleSearchWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FILESearch.File fileobj = new FILESearch.File();
            fileobj.sendFileName += sendFileName;
            Thread thread = new Thread(() => fileobj.Search(txtDir.Text));
            thread.Start();
        }

        private void sendFileName(string file)
        {
            Invoke(() =>
            {
                listFiles.Items.Add(file);
            });
        }
    }
}
