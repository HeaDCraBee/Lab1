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
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.Dock = DockStyle.Top;
            mainLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.ImageAlign = ContentAlignment.TopCenter;
            mainLabel.Location = new Point(0, 0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(741, 33);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Приветствуем Вас в конфигураторе автомобиля Вашей мечты!";
            mainLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(12, 76);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(316, 27);
            nameTextBox.TabIndex = 1;
            // 
            // configurateButton
            // 
            configurateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            configurateButton.AutoSize = true;
            configurateButton.Location = new Point(334, 71);
            configurateButton.Name = "configurateButton";
            configurateButton.Size = new Size(144, 36);
            configurateButton.TabIndex = 2;
            configurateButton.Text = "Конфигурировать";
            configurateButton.UseVisualStyleBackColor = true;
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Location = new Point(12, 110);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(622, 20);
            enterNameLabel.TabIndex = 3;
            enterNameLabel.Text = "Введите Ваше имя и нажмите кнопку \"Конфигурировать\" для перехода в конфигуратор";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 563);
            Controls.Add(enterNameLabel);
            Controls.Add(configurateButton);
            Controls.Add(nameTextBox);
            Controls.Add(mainLabel);
            Name = "Form1";
            Text = "Автомобильный конфигуратор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private TextBox nameTextBox;
        private Button configurateButton;
        private Label enterNameLabel;
    }
}