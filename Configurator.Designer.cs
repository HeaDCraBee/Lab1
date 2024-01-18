namespace Lab1
{
    partial class Configurator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            greetingsLabel = new Label();
            markComboBox = new ComboBox();
            SuspendLayout();
            // 
            // greetingsLabel
            // 
            greetingsLabel.Dock = DockStyle.Top;
            greetingsLabel.Location = new Point(0, 0);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(836, 25);
            greetingsLabel.TabIndex = 0;
            greetingsLabel.Text = "Здравствуйте, username";
            greetingsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // markComboBox
            // 
            markComboBox.FormattingEnabled = true;
            markComboBox.Items.AddRange(new object[] { "Volkswagen", "Audi", "Porshe", "Другая" });
            markComboBox.Location = new Point(27, 28);
            markComboBox.Name = "markComboBox";
            markComboBox.Size = new Size(289, 28);
            markComboBox.TabIndex = 1;
            markComboBox.Text = "Выберете марку...";
            // 
            // Configurator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 433);
            Controls.Add(markComboBox);
            Controls.Add(greetingsLabel);
            Name = "Configurator";
            Text = "Configurator";
            ResumeLayout(false);
        }

        #endregion

        private Label greetingsLabel;
        private ComboBox markComboBox;
    }
}