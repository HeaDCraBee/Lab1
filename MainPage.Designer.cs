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
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            mainLabel.Margin = new Padding(5, 0, 5, 0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(1230, 45);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Приветствуем Вас в конфигураторе автомобиля Вашей мечты!";
            mainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(10, 76);
            nameTextBox.Margin = new Padding(5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(561, 39);
            nameTextBox.TabIndex = 1;
            // 
            // configurateButton
            // 
            configurateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            configurateButton.AutoSize = true;
            configurateButton.Location = new Point(581, 66);
            configurateButton.Margin = new Padding(5);
            configurateButton.Name = "configurateButton";
            configurateButton.Size = new Size(284, 58);
            configurateButton.TabIndex = 2;
            configurateButton.Text = "Конфигурировать";
            configurateButton.UseVisualStyleBackColor = true;
            configurateButton.Click += configurateButton_Click;
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Location = new Point(10, 129);
            enterNameLabel.Margin = new Padding(5, 0, 5, 0);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(989, 32);
            enterNameLabel.TabIndex = 3;
            enterNameLabel.Text = "Введите Ваше имя и нажмите кнопку \"Конфигурировать\" для перехода в конфигуратор";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(enterNameLabel);
            mainPanel.Controls.Add(mainLabel);
            mainPanel.Controls.Add(configurateButton);
            mainPanel.Controls.Add(nameTextBox);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1230, 625);
            mainPanel.TabIndex = 4;
            // 
            // configuratorPanel
            // 
            configuratorPanel.Controls.Add(finalPriceValueLabel);
            configuratorPanel.Controls.Add(pictureBox1);
            configuratorPanel.Controls.Add(finalPriceLabel);
            configuratorPanel.Controls.Add(basePriceValueLabel);
            configuratorPanel.Controls.Add(additionsGroupBox1);
            configuratorPanel.Controls.Add(greetingsLabel);
            configuratorPanel.Controls.Add(interialMaterialsGroupBox);
            configuratorPanel.Controls.Add(markSelectionPanel);
            configuratorPanel.Controls.Add(modelSelectionPanel);
            configuratorPanel.Controls.Add(basePriceLabel);
            configuratorPanel.Location = new Point(11, 15);
            configuratorPanel.Name = "configuratorPanel";
            configuratorPanel.Size = new Size(1228, 625);
            configuratorPanel.TabIndex = 15;
            // 
            // finalPriceValueLabel
            // 
            finalPriceValueLabel.AutoSize = true;
            finalPriceValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finalPriceValueLabel.ForeColor = Color.ForestGreen;
            finalPriceValueLabel.Location = new Point(29, 565);
            finalPriceValueLabel.Name = "finalPriceValueLabel";
            finalPriceValueLabel.Size = new Size(37, 45);
            finalPriceValueLabel.TabIndex = 13;
            finalPriceValueLabel.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(529, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 203);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // finalPriceLabel
            // 
            finalPriceLabel.AutoSize = true;
            finalPriceLabel.Location = new Point(16, 533);
            finalPriceLabel.Name = "finalPriceLabel";
            finalPriceLabel.Size = new Size(241, 32);
            finalPriceLabel.TabIndex = 11;
            finalPriceLabel.Text = "Итоговая стоимость:";
            // 
            // basePriceValueLabel
            // 
            basePriceValueLabel.AutoSize = true;
            basePriceValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            basePriceValueLabel.ForeColor = Color.ForestGreen;
            basePriceValueLabel.Location = new Point(29, 263);
            basePriceValueLabel.Name = "basePriceValueLabel";
            basePriceValueLabel.Size = new Size(37, 45);
            basePriceValueLabel.TabIndex = 12;
            basePriceValueLabel.Text = "0";
            // 
            // additionsGroupBox1
            // 
            additionsGroupBox1.Controls.Add(paintProtectionCheckBox);
            additionsGroupBox1.Controls.Add(improvedSoundSystemCheckBox);
            additionsGroupBox1.Controls.Add(tyresCheckBox);
            additionsGroupBox1.Location = new Point(475, 325);
            additionsGroupBox1.Name = "additionsGroupBox1";
            additionsGroupBox1.Size = new Size(735, 194);
            additionsGroupBox1.TabIndex = 10;
            additionsGroupBox1.TabStop = false;
            additionsGroupBox1.Text = "Дополнительные услуги";
            // 
            // paintProtectionCheckBox
            // 
            paintProtectionCheckBox.AutoSize = true;
            paintProtectionCheckBox.Location = new Point(6, 142);
            paintProtectionCheckBox.Name = "paintProtectionCheckBox";
            paintProtectionCheckBox.Size = new Size(181, 36);
            paintProtectionCheckBox.TabIndex = 2;
            paintProtectionCheckBox.Text = "Защита ЛКП";
            paintProtectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // improvedSoundSystemCheckBox
            // 
            improvedSoundSystemCheckBox.AutoSize = true;
            improvedSoundSystemCheckBox.Location = new Point(6, 90);
            improvedSoundSystemCheckBox.Name = "improvedSoundSystemCheckBox";
            improvedSoundSystemCheckBox.Size = new Size(442, 36);
            improvedSoundSystemCheckBox.TabIndex = 1;
            improvedSoundSystemCheckBox.Text = "Улучшенная аккустическая система";
            improvedSoundSystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // tyresCheckBox
            // 
            tyresCheckBox.AutoSize = true;
            tyresCheckBox.Location = new Point(6, 38);
            tyresCheckBox.Name = "tyresCheckBox";
            tyresCheckBox.Size = new Size(197, 36);
            tyresCheckBox.TabIndex = 0;
            tyresCheckBox.Text = "Летние шины";
            tyresCheckBox.UseVisualStyleBackColor = true;
            // 
            // greetingsLabel
            // 
            greetingsLabel.Dock = DockStyle.Top;
            greetingsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            greetingsLabel.Location = new Point(0, 0);
            greetingsLabel.Margin = new Padding(5, 0, 5, 0);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(1228, 44);
            greetingsLabel.TabIndex = 0;
            greetingsLabel.Text = "Здравствуйте, {0}";
            greetingsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // interialMaterialsGroupBox
            // 
            interialMaterialsGroupBox.Controls.Add(alcantaraRadioButton);
            interialMaterialsGroupBox.Controls.Add(leatherRadioButton);
            interialMaterialsGroupBox.Controls.Add(textileRadioButton);
            interialMaterialsGroupBox.Location = new Point(16, 325);
            interialMaterialsGroupBox.Name = "interialMaterialsGroupBox";
            interialMaterialsGroupBox.Size = new Size(445, 194);
            interialMaterialsGroupBox.TabIndex = 5;
            interialMaterialsGroupBox.TabStop = false;
            interialMaterialsGroupBox.Text = "Материалы салона";
            // 
            // alcantaraRadioButton
            // 
            alcantaraRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alcantaraRadioButton.AutoSize = true;
            alcantaraRadioButton.Location = new Point(15, 142);
            alcantaraRadioButton.Name = "alcantaraRadioButton";
            alcantaraRadioButton.Size = new Size(171, 36);
            alcantaraRadioButton.TabIndex = 8;
            alcantaraRadioButton.Text = "Алькантара";
            alcantaraRadioButton.UseVisualStyleBackColor = true;
            // 
            // leatherRadioButton
            // 
            leatherRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            leatherRadioButton.AutoSize = true;
            leatherRadioButton.Location = new Point(15, 90);
            leatherRadioButton.Name = "leatherRadioButton";
            leatherRadioButton.Size = new Size(103, 36);
            leatherRadioButton.TabIndex = 7;
            leatherRadioButton.Text = "Кожа";
            leatherRadioButton.UseVisualStyleBackColor = true;
            // 
            // textileRadioButton
            // 
            textileRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textileRadioButton.AutoSize = true;
            textileRadioButton.Checked = true;
            textileRadioButton.Location = new Point(15, 38);
            textileRadioButton.Name = "textileRadioButton";
            textileRadioButton.Size = new Size(108, 36);
            textileRadioButton.TabIndex = 6;
            textileRadioButton.TabStop = true;
            textileRadioButton.Text = "Ткань";
            textileRadioButton.UseVisualStyleBackColor = true;
            // 
            // markSelectionPanel
            // 
            markSelectionPanel.Controls.Add(markLabel);
            markSelectionPanel.Controls.Add(markComboBox);
            markSelectionPanel.Location = new Point(6, 72);
            markSelectionPanel.Name = "markSelectionPanel";
            markSelectionPanel.Size = new Size(400, 74);
            markSelectionPanel.TabIndex = 8;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new Point(3, 23);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(86, 32);
            markLabel.TabIndex = 3;
            markLabel.Text = "Марка";
            // 
            // markComboBox
            // 
            markComboBox.FormattingEnabled = true;
            markComboBox.Items.AddRange(new object[] { "Volkswagen", "Audi", "Porshe", "Другая" });
            markComboBox.Location = new Point(110, 20);
            markComboBox.Margin = new Padding(5);
            markComboBox.Name = "markComboBox";
            markComboBox.Size = new Size(280, 40);
            markComboBox.TabIndex = 1;
            markComboBox.Text = "Выберете марку...";
            markComboBox.SelectedIndexChanged += markComboBox_SelectedIndexChanged;
            // 
            // modelSelectionPanel
            // 
            modelSelectionPanel.Controls.Add(modelLabel);
            modelSelectionPanel.Controls.Add(modelComboBox);
            modelSelectionPanel.Location = new Point(6, 152);
            modelSelectionPanel.Name = "modelSelectionPanel";
            modelSelectionPanel.Size = new Size(400, 76);
            modelSelectionPanel.TabIndex = 9;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(3, 23);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(101, 32);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Модель";
            // 
            // modelComboBox
            // 
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(110, 20);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(280, 40);
            modelComboBox.TabIndex = 2;
            modelComboBox.Text = "Выберете модель...";
            modelComboBox.SelectedIndexChanged += modelComboBox_SelectedIndexChanged;
            // 
            // basePriceLabel
            // 
            basePriceLabel.AutoSize = true;
            basePriceLabel.Location = new Point(16, 231);
            basePriceLabel.Name = "basePriceLabel";
            basePriceLabel.Size = new Size(234, 32);
            basePriceLabel.TabIndex = 6;
            basePriceLabel.Text = "Базовая стоимость: ";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 649);
            Controls.Add(configuratorPanel);
            Controls.Add(mainPanel);
            Margin = new Padding(5);
            Name = "MainPage";
            Text = "Автомобильный конфигуратор";
            Load += MainPage_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            configuratorPanel.ResumeLayout(false);
            configuratorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
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