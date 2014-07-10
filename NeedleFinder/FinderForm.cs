using System.Windows.Forms;
using System.Text;

namespace NeedleFinder
{
    public partial class FinderForm : Form
    {
        public FinderForm()
        {
            InitializeComponent();
        }

        private void MatchButton_Click(object sender, System.EventArgs e)
        {
            string text = HaystackTextBox.Text;
            string subtext = NeedleTextBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter Text", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MatchesTextBox.Text = Finder.GetMatchResult(text, subtext, MatchCaseCheckBox.Checked);
            }
        }
    }
}
