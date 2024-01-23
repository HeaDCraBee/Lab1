using Lab1.Manufactures;
using Lab1.Manufactures.Factorys;
using System.Resources;

namespace Lab1
{
    public partial class MainPage : Form
    {
        private const string resxFile = @".\MainPage.resx";

        private Dictionary<int, ManufacturesFactory> _manufactorIndexToFactory = new()
        {
            {0, new VWFactory() },
            {1, new AudiFactory() },
            {2, new PorsheFactory() },
            {3, null }
        };

        private Manufactor _currentManufactor;
        private decimal _currentPrice;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ConfiguratorSetValues()
        {

            if (_currentManufactor is null)
                ConfiguratorSetDefaultValues();
            else
            {
                _currentPrice = _currentManufactor.BasePrice;

                leatherRadioButton.Text = leatherRadioButton.Text + $" +{_currentManufactor.LeatherPrice}";
                alcantaraRadioButton.Text = alcantaraRadioButton.Text + $" +{_currentManufactor.AlcantaraPrice}";

                tyresCheckBox.Text = tyresCheckBox.Text + $" +{_currentManufactor.TyresPrice}";
                improvedSoundSystemCheckBox.Text = improvedSoundSystemCheckBox.Text + $" +{_currentManufactor.ImprovedSoundSystemPrice}";
                paintProtectionCheckBox.Text = paintProtectionCheckBox.Text + $" +{_currentManufactor.PaintProtectionPrice}";

                basePriceValueLabel.Text = _currentPrice.ToString();
                finalPriceValueLabel.Text = _currentPrice.ToString();

                using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                {
                    pictureBox.Image = (Bitmap)resxSet.GetObject(_currentManufactor.Name + _currentManufactor.SelectedModel, true);
                }
            }
        }

        private void ConfiguratorSetDefaultValues()
        {
            textileRadioButton.Checked = true;
            leatherRadioButton.Checked = false;
            alcantaraRadioButton.Checked = false;

            tyresCheckBox.Checked = false;
            improvedSoundSystemCheckBox.Checked = false;
            paintProtectionCheckBox.Checked = false;

            basePriceValueLabel.Text = "0";
            finalPriceValueLabel.Text = "0";

            leatherRadioButton.Text = "Кожа";
            alcantaraRadioButton.Text = "Алькантара";

            tyresCheckBox.Text = $"{((DateTime.Now.Month > 2 && DateTime.Now.Month < 11) ? "Зимние" : "Летние")} шины";
            improvedSoundSystemCheckBox.Text = "Улучшенная акустическая система";
            paintProtectionCheckBox.Text = "Защита ЛКП";

            basePriceValueLabel.Text = "0";
            finalPriceValueLabel.Text = "0";

            pictureBox.Image = null;
        }

        private decimal CalculateDiscount()
        {
            if (tyresCheckBox.Checked && improvedSoundSystemCheckBox.Checked && paintProtectionCheckBox.Checked)
                return _currentPrice * 0.9m;

            return _currentPrice;
        }

        private void configurateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Введите Ваше имя", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            modelComboBox.Text = "Выберете модель...";

            ConfiguratorSetDefaultValues();

            if (factory == null)
            {
                MessageBox.Show("Поверьте, Вам нужен Volkswagen", "Das Auto", MessageBoxButtons.OK);
                markComboBox.SelectedIndex = 0;
                return;
            }

            _currentManufactor = factory.Create();

            modelComboBox.Items.Clear();
            modelComboBox.Items.AddRange(_currentManufactor.ModelsList.Keys.ToArray());
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentManufactor.SetModel(modelComboBox.SelectedItem.ToString());
            ConfiguratorSetDefaultValues();
            ConfiguratorSetValues();
        }

        private void leatherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentManufactor is null)
                return;

            if (leatherRadioButton.Checked)
                _currentPrice += _currentManufactor.LeatherPrice;
            else
                _currentPrice -= _currentManufactor.LeatherPrice;

            finalPriceValueLabel.Text = CalculateDiscount().ToString();
        }

        private void alcantaraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentManufactor is null)
                return;

            if (alcantaraRadioButton.Checked)
                _currentPrice += _currentManufactor.AlcantaraPrice;
            else
                _currentPrice -= _currentManufactor.AlcantaraPrice;

            finalPriceValueLabel.Text = CalculateDiscount().ToString(); ;
        }

        private void tyresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentManufactor is null)
                return;

            if (tyresCheckBox.Checked)
                _currentPrice += _currentManufactor.TyresPrice;
            else
                _currentPrice -= _currentManufactor.TyresPrice;

            finalPriceValueLabel.Text = CalculateDiscount().ToString();
        }

        private void improvedSoundSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentManufactor is null)
                return;

            if (improvedSoundSystemCheckBox.Checked)
                _currentPrice += _currentManufactor.ImprovedSoundSystemPrice;
            else
                _currentPrice -= _currentManufactor.ImprovedSoundSystemPrice;

            finalPriceValueLabel.Text = CalculateDiscount().ToString();
        }

        private void paintProtectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentManufactor is null)
                return;

            if (paintProtectionCheckBox.Checked)
                _currentPrice += _currentManufactor.PaintProtectionPrice;
            else
                _currentPrice -= _currentManufactor.PaintProtectionPrice;


            finalPriceValueLabel.Text = CalculateDiscount().ToString();
        }
    }
}