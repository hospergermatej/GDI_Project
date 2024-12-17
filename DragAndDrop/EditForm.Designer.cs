namespace DragAndDrop
{
    partial class EditForm
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
            ClassNameTextBox = new TextBox();
            ExitButton = new Button();
            ApplyButton = new Button();
            AttributeTextBox = new TextBox();
            MethodTextBox = new TextBox();
            SuspendLayout();
            // 
            // ClassNameTextBox
            // 
            ClassNameTextBox.Location = new Point(70, 26);
            ClassNameTextBox.Name = "ClassNameTextBox";
            ClassNameTextBox.PlaceholderText = "ClassName";
            ClassNameTextBox.Size = new Size(100, 23);
            ClassNameTextBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(483, 307);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(12, 307);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(116, 23);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply Changes";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // AttributeTextBox
            // 
            AttributeTextBox.Location = new Point(70, 75);
            AttributeTextBox.Name = "AttributeTextBox";
            AttributeTextBox.PlaceholderText = "AttributeType";
            AttributeTextBox.Size = new Size(100, 23);
            AttributeTextBox.TabIndex = 3;
            // 
            // MethodTextBox
            // 
            MethodTextBox.Location = new Point(70, 129);
            MethodTextBox.Name = "MethodTextBox";
            MethodTextBox.PlaceholderText = "Methods";
            MethodTextBox.Size = new Size(100, 23);
            MethodTextBox.TabIndex = 4;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 342);
            Controls.Add(MethodTextBox);
            Controls.Add(AttributeTextBox);
            Controls.Add(ApplyButton);
            Controls.Add(ExitButton);
            Controls.Add(ClassNameTextBox);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ClassNameTextBox;
        private Button ExitButton;
        private Button ApplyButton;
        private TextBox AttributeTextBox;
        private TextBox MethodTextBox;
    }
}