using System.Windows.Forms;

namespace eazy_HASH
{
    public partial class Form1 : Form
    {
        EazyHasher hasher;
        public Form1()
        {
            hasher = new EazyHasher("", "", "");
            InitializeComponent();
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                inputPathLabel.Text = selectedFile;
                hasher.SetInputPath(selectedFile);
            }
        }

        private void outputFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                outputFileLabel.Text = selectedFile;
                hasher.SetOutputPath(selectedFile);
            }
        }

        private void hashDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hashDropDown.SelectedItem != null)
            {
                string selectedHash = hashDropDown.SelectedItem.ToString();
                hashDropDown.Text = selectedHash;
                hasher.SetHashName(selectedHash);
            }
        }

        private void hashButton_Click(object sender, EventArgs e)
        {
            hasher.HashFileAsync();
        }
    }
}
