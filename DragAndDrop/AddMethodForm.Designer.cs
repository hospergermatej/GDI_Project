namespace DragAndDrop
{
    partial class AddMethodForm
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            DataTypeTextBox = new TextBox();
            label3 = new Label();
            NameTextBox = new TextBox();
            ApplyButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "AccesModifier";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Data type";
            // 
            // DataTypeTextBox
            // 
            DataTypeTextBox.Location = new Point(12, 92);
            DataTypeTextBox.Name = "DataTypeTextBox";
            DataTypeTextBox.Size = new Size(100, 23);
            DataTypeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 151);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 5;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(12, 265);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(75, 23);
            ApplyButton.TabIndex = 6;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // AddMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 312);
            Controls.Add(ApplyButton);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(DataTypeTextBox);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "AddMethodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMethodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox DataTypeTextBox;
        private Label label3;
        private TextBox NameTextBox;
        private Button ApplyButton;
    }
}