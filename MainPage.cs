using Lab1.Manufactures;
using Lab1.Manufactures.Factorys;

namespace Lab1
{
    public partial class MainPage : Form
    {
        private Dictionary<int, ManufacturesFactory> _manufactorIndexToFactory = new()
        {
            {0, new VWFactory() },
            {1, new AudiFactory() },
            {2, new PorsheFactory() },
            {3, null }
        };

        private Manufactor _currentManufactor;

        public MainPage()
        {
            InitializeComponent();
        }

        private void configurateButton_Click(object sender, EventArgs e)
        {
            greetingsLabel.Text = string.Format(greetingsLabel.Text, nameTextBox.Text);
            tyresCheckBox.Text = $"{((DateTime.Now.Month > 2 && DateTime.Now.Month < 11) ? "Зимние" : "Летние")} шины";
            mainPanel.Visible = false;
            configuratorPanel.Visible = true;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            configuratorPanel.Visible = false;
        }

        private void markComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var factory = _manufactorIndexToFactory[markComboBox.SelectedIndex];

            if (factory == null)
            {
                ConfiguratorSetValues();
                return;
            }

            _currentManufactor = factory.Create();

            modelComboBox.Items.Clear();
            modelComboBox.Items.AddRange(_currentManufactor.ModelsList.Keys.ToArray());
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentManufactor.SetBasePrice(modelComboBox.SelectedText);
            ConfiguratorSetValues();
        }

        private void ConfiguratorSetValues()
        {
            
        }

    }
}