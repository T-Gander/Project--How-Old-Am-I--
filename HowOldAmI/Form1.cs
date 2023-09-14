namespace HowOldAmI
{
    public partial class Form1 : Form
    {
        private DateTime SelectedDateTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            SelectedDateTime = dtpDateOfBirth.Value.Date;
            tmrRefresh.Enabled = true;
            lblAge.Visible = true;
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            AgeCalculator calculator = new AgeCalculator(SelectedDateTime);
            lblAge.Text = calculator.FinalAge;
        }
    }
}