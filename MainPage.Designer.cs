namespace Lab1
{
    partial class MainPage
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
            mainLabel = new Label();
            nameTextBox = new TextBox();
            configurateButton = new Button();
            enterNameLabel = new Label();
            mainPanel = new Panel();
            configuratorPanel = new Panel();
            finalPriceValueLabel = new Label();
            pictureBox = new PictureBox();
            finalPriceLabel = new Label();
            basePriceValueLabel = new Label();
            additionsGroupBox1 = new GroupBox();
            paintProtectionCheckBox = new CheckBox();
            improvedSoundSystemCheckBox = new CheckBox();
            tyresCheckBox = new CheckBox();
            greetingsLabel = new Label();
            interialMaterialsGroupBox = new GroupBox();
            alcantaraRadioButton = new RadioButton();
            leatherRadioButton = new RadioButton();
            textileRadioButton = new RadioButton();
            markSelectionPanel = new Panel();
            markLabel = new Label();
            markComboBox = new ComboBox();
            modelSelectionPanel = new Panel();
            modelLabel = new Label();
            modelComboBox = new ComboBox();
            basePriceLabel = new Label();
            mainPanel.SuspendLayout();
            configuratorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            additionsGroupBox1.SuspendLayout();
            interialMaterialsGroupBox.SuspendLayout();
            markSelectionPanel.SuspendLayout();
            modelSelectionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AccessibleRole = AccessibleRole.Grip;
            mainLabel.Dock = DockStyle.Top;
            mainLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.ImageAlign = ContentAlignment.TopCenter;
            mainLabel.Location = new Point(0, 0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(757, 28);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Приветствуем Вас в конфигураторе автомобиля Вашей мечты!";
            mainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(6, 48);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(347, 27);
            nameTextBox.TabIndex = 1;
            // 
            // configurateButton
            // 
            configurateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            configurateButton.AutoSize = true;
            configurateButton.Location = new Point(358, 41);
            configurateButton.Name = "configurateButton";
            configurateButton.Size = new Size(175, 36);
            configurateButton.TabIndex = 2;
            configurateButton.Text = "Конфигурировать";
            configurateButton.UseVisualStyleBackColor = true;
            configurateButton.Click += configurateButton_Click;
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Location = new Point(6, 81);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(622, 20);
            enterNameLabel.TabIndex = 3;
            enterNameLabel.Text = "Введите Ваше имя и нажмите кнопку \"Конфигурировать\" для перехода в конфигуратор";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(enterNameLabel);
            mainPanel.Controls.Add(mainLabel);
            mainPanel.Controls.Add(configurateButton);
            mainPanel.Controls.Add(nameTextBox);
            mainPanel.Location = new Point(7, 8);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(757, 391);
            mainPanel.TabIndex = 4;
            // 
            // configuratorPanel
            // 
            configuratorPanel.Controls.Add(finalPriceValueLabel);
            configuratorPanel.Controls.Add(pictureBox);
            configuratorPanel.Controls.Add(finalPriceLabel);
            configuratorPanel.Controls.Add(basePriceValueLabel);
            configuratorPanel.Controls.Add(additionsGroupBox1);
            configuratorPanel.Controls.Add(greetingsLabel);
            configuratorPanel.Controls.Add(interialMaterialsGroupBox);
            configuratorPanel.Controls.Add(markSelectionPanel);
            configuratorPanel.Controls.Add(modelSelectionPanel);
            configuratorPanel.Controls.Add(basePriceLabel);
            configuratorPanel.Location = new Point(7, 9);
            configuratorPanel.Margin = new Padding(2);
            configuratorPanel.Name = "configuratorPanel";
            configuratorPanel.Size = new Size(756, 391);
            configuratorPanel.TabIndex = 15;
            // 
            // finalPriceValueLabel
            // 
            finalPriceValueLabel.AutoSize = true;
            finalPriceValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finalPriceValueLabel.ForeColor = Color.ForestGreen;
            finalPriceValueLabel.Location = new Point(18, 353);
            finalPriceValueLabel.Margin = new Padding(2, 0, 2, 0);
            finalPriceValueLabel.Name = "finalPriceValueLabel";
            finalPriceValueLabel.Size = new Size(23, 28);
            finalPriceValueLabel.TabIndex = 13;
            finalPriceValueLabel.Text = "0";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(409, 40);
            pictureBox.Margin = new Padding(2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(276, 152);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // finalPriceLabel
            // 
            finalPriceLabel.AutoSize = true;
            finalPriceLabel.Location = new Point(10, 333);
            finalPriceLabel.Margin = new Padding(2, 0, 2, 0);
            finalPriceLabel.Name = "finalPriceLabel";
            finalPriceLabel.Size = new Size(153, 20);
            finalPriceLabel.TabIndex = 11;
            finalPriceLabel.Text = "Итоговая стоимость:";
            // 
            // basePriceValueLabel
            // 
            basePriceValueLabel.AutoSize = true;
            basePriceValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            basePriceValueLabel.ForeColor = Color.ForestGreen;
            basePriceValueLabel.Location = new Point(18, 164);
            basePriceValueLabel.Margin = new Padding(2, 0, 2, 0);
            basePriceValueLabel.Name = "basePriceValueLabel";
            basePriceValueLabel.Size = new Size(23, 28);
            basePriceValueLabel.TabIndex = 12;
            basePriceValueLabel.Text = "0";
            // 
            // additionsGroupBox1
            // 
            additionsGroupBox1.Controls.Add(paintProtectionCheckBox);
            additionsGroupBox1.Controls.Add(improvedSoundSystemCheckBox);
            additionsGroupBox1.Controls.Add(tyresCheckBox);
            additionsGroupBox1.Location = new Point(292, 203);
            additionsGroupBox1.Margin = new Padding(2);
            additionsGroupBox1.Name = "additionsGroupBox1";
            additionsGroupBox1.Padding = new Padding(2);
            additionsGroupBox1.Size = new Size(452, 121);
            additionsGroupBox1.TabIndex = 10;
            additionsGroupBox1.TabStop = false;
            additionsGroupBox1.Text = "Дополнительные услуги(-10% при выборе всех)";
            // 
            // paintProtectionCheckBox
            // 
            paintProtectionCheckBox.AutoSize = true;
            paintProtectionCheckBox.Location = new Point(4, 89);
            paintProtectionCheckBox.Margin = new Padding(2);
            paintProtectionCheckBox.Name = "paintProtectionCheckBox";
            paintProtectionCheckBox.Size = new Size(116, 24);
            paintProtectionCheckBox.TabIndex = 2;
            paintProtectionCheckBox.Text = "Защита ЛКП";
            paintProtectionCheckBox.UseVisualStyleBackColor = true;
            paintProtectionCheckBox.CheckedChanged += paintProtectionCheckBox_CheckedChanged;
            // 
            // improvedSoundSystemCheckBox
            // 
            improvedSoundSystemCheckBox.AutoSize = true;
            improvedSoundSystemCheckBox.Location = new Point(4, 56);
            improvedSoundSystemCheckBox.Margin = new Padding(2);
            improvedSoundSystemCheckBox.Name = "improvedSoundSystemCheckBox";
            improvedSoundSystemCheckBox.Size = new Size(271, 24);
            improvedSoundSystemCheckBox.TabIndex = 1;
            improvedSoundSystemCheckBox.Text = "Улучшенная акустическая система";
            improvedSoundSystemCheckBox.UseVisualStyleBackColor = true;
            improvedSoundSystemCheckBox.CheckedChanged += improvedSoundSystemCheckBox_CheckedChanged;
            // 
            // tyresCheckBox
            // 
            tyresCheckBox.AutoSize = true;
            tyresCheckBox.Location = new Point(4, 24);
            tyresCheckBox.Margin = new Padding(2);
            tyresCheckBox.Name = "tyresCheckBox";
            tyresCheckBox.Size = new Size(126, 24);
            tyresCheckBox.TabIndex = 0;
            tyresCheckBox.Text = "Летние шины";
            tyresCheckBox.UseVisualStyleBackColor = true;
            tyresCheckBox.CheckedChanged += tyresCheckBox_CheckedChanged;
            // 
            // greetingsLabel
            // 
            greetingsLabel.Dock = DockStyle.Top;
            greetingsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            greetingsLabel.Location = new Point(0, 0);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(756, 28);
            greetingsLabel.TabIndex = 0;
            greetingsLabel.Text = "Здравствуйте, {0}";
            greetingsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // interialMaterialsGroupBox
            // 
            interialMaterialsGroupBox.Controls.Add(alcantaraRadioButton);
            interialMaterialsGroupBox.Controls.Add(leatherRadioButton);
            interialMaterialsGroupBox.Controls.Add(textileRadioButton);
            interialMaterialsGroupBox.Location = new Point(10, 203);
            interialMaterialsGroupBox.Margin = new Padding(2);
            interialMaterialsGroupBox.Name = "interialMaterialsGroupBox";
            interialMaterialsGroupBox.Padding = new Padding(2);
            interialMaterialsGroupBox.Size = new Size(274, 121);
            interialMaterialsGroupBox.TabIndex = 5;
            interialMaterialsGroupBox.TabStop = false;
            interialMaterialsGroupBox.Text = "Материалы салона";
            // 
            // alcantaraRadioButton
            // 
            alcantaraRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alcantaraRadioButton.AutoSize = true;
            alcantaraRadioButton.Location = new Point(9, 89);
            alcantaraRadioButton.Margin = new Padding(2);
            alcantaraRadioButton.Name = "alcantaraRadioButton";
            alcantaraRadioButton.Size = new Size(111, 24);
            alcantaraRadioButton.TabIndex = 8;
            alcantaraRadioButton.Text = "Алькантара";
            alcantaraRadioButton.UseVisualStyleBackColor = true;
            alcantaraRadioButton.CheckedChanged += alcantaraRadioButton_CheckedChanged;
            // 
            // leatherRadioButton
            // 
            leatherRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            leatherRadioButton.AutoSize = true;
            leatherRadioButton.Location = new Point(9, 56);
            leatherRadioButton.Margin = new Padding(2);
            leatherRadioButton.Name = "leatherRadioButton";
            leatherRadioButton.Size = new Size(67, 24);
            leatherRadioButton.TabIndex = 7;
            leatherRadioButton.Text = "Кожа";
            leatherRadioButton.UseVisualStyleBackColor = true;
            leatherRadioButton.CheckedChanged += leatherRadioButton_CheckedChanged;
            // 
            // textileRadioButton
            // 
            textileRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textileRadioButton.AutoSize = true;
            textileRadioButton.Checked = true;
            textileRadioButton.Location = new Point(9, 24);
            textileRadioButton.Margin = new Padding(2);
            textileRadioButton.Name = "textileRadioButton";
            textileRadioButton.Size = new Size(70, 24);
            textileRadioButton.TabIndex = 6;
            textileRadioButton.TabStop = true;
            textileRadioButton.Text = "Ткань";
            textileRadioButton.UseVisualStyleBackColor = true;
            // 
            // markSelectionPanel
            // 
            markSelectionPanel.Controls.Add(markLabel);
            markSelectionPanel.Controls.Add(markComboBox);
            markSelectionPanel.Location = new Point(4, 45);
            markSelectionPanel.Margin = new Padding(2);
            markSelectionPanel.Name = "markSelectionPanel";
            markSelectionPanel.Size = new Size(246, 46);
            markSelectionPanel.TabIndex = 8;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new Point(2, 14);
            markLabel.Margin = new Padding(2, 0, 2, 0);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(54, 20);
            markLabel.TabIndex = 3;
            markLabel.Text = "Марка";
            // 
            // markComboBox
            // 
            markComboBox.FormattingEnabled = true;
            markComboBox.Items.AddRange(new object[] { "Volkswagen", "Audi", "Porshe", "Другая" });
            markComboBox.Location = new Point(68, 12);
            markComboBox.Name = "markComboBox";
            markComboBox.Size = new Size(174, 28);
            markComboBox.TabIndex = 1;
            markComboBox.Text = "Выберете марку...";
            markComboBox.SelectedIndexChanged += markComboBox_SelectedIndexChanged;
            // 
            // modelSelectionPanel
            // 
            modelSelectionPanel.Controls.Add(modelLabel);
            modelSelectionPanel.Controls.Add(modelComboBox);
            modelSelectionPanel.Location = new Point(4, 95);
            modelSelectionPanel.Margin = new Padding(2);
            modelSelectionPanel.Name = "modelSelectionPanel";
            modelSelectionPanel.Size = new Size(246, 48);
            modelSelectionPanel.TabIndex = 9;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(2, 14);
            modelLabel.Margin = new Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(63, 20);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Модель";
            // 
            // modelComboBox
            // 
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(68, 12);
            modelComboBox.Margin = new Padding(2);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(174, 28);
            modelComboBox.TabIndex = 2;
            modelComboBox.Text = "Выберете модель...";
            modelComboBox.SelectedIndexChanged += modelComboBox_SelectedIndexChanged;
            // 
            // basePriceLabel
            // 
            basePriceLabel.AutoSize = true;
            basePriceLabel.Location = new Point(10, 144);
            basePriceLabel.Margin = new Padding(2, 0, 2, 0);
            basePriceLabel.Name = "basePriceLabel";
            basePriceLabel.Size = new Size(149, 20);
            basePriceLabel.TabIndex = 6;
            basePriceLabel.Text = "Базовая стоимость: ";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 406);
            Controls.Add(mainPanel);
            Controls.Add(configuratorPanel);
            Name = "MainPage";
            Text = "Андреенко Д.Р. Z1432K";
            Load += MainPage_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            configuratorPanel.ResumeLayout(false);
            configuratorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            additionsGroupBox1.ResumeLayout(false);
            additionsGroupBox1.PerformLayout();
            interialMaterialsGroupBox.ResumeLayout(false);
            interialMaterialsGroupBox.PerformLayout();
            markSelectionPanel.ResumeLayout(false);
            markSelectionPanel.PerformLayout();
            modelSelectionPanel.ResumeLayout(false);
            modelSelectionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label mainLabel;
        private TextBox nameTextBox;
        private Button configurateButton;
        private Label enterNameLabel;
        private Panel mainPanel;
        private Panel configuratorPanel;
        private Label finalPriceValueLabel;
        private PictureBox pictureBox;
        private Label finalPriceLabel;
        private Label basePriceValueLabel;
        private GroupBox additionsGroupBox1;
        private CheckBox paintProtectionCheckBox;
        private CheckBox improvedSoundSystemCheckBox;
        private CheckBox tyresCheckBox;
        private Label greetingsLabel;
        private GroupBox interialMaterialsGroupBox;
        private RadioButton alcantaraRadioButton;
        private RadioButton leatherRadioButton;
        private RadioButton textileRadioButton;
        private Panel markSelectionPanel;
        private Label markLabel;
        private ComboBox markComboBox;
        private Panel modelSelectionPanel;
        private Label modelLabel;
        private ComboBox modelComboBox;
        private Label basePriceLabel;
    }
}