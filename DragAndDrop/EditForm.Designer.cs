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
            label1 = new Label();
            label2 = new Label();
            AbstractCheckBox = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            AttributesListBox1 = new ListBox();
            MethodsListBox1 = new ListBox();
            AddAttrButton = new Button();
            RemAttrButton = new Button();
            AddMetButton = new Button();
            RemMetButton = new Button();
            SuspendLayout();
            // 
            // ClassNameTextBox
            // 
            ClassNameTextBox.Location = new Point(12, 37);
            ClassNameTextBox.Name = "ClassNameTextBox";
            ClassNameTextBox.PlaceholderText = "ClassName";
            ClassNameTextBox.Size = new Size(422, 23);
            ClassNameTextBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(359, 336);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(12, 336);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(116, 23);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply Changes";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Class name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 6;
            label2.Text = "Abstract class?";
            // 
            // AbstractCheckBox
            // 
            AbstractCheckBox.AutoSize = true;
            AbstractCheckBox.Location = new Point(102, 81);
            AbstractCheckBox.Name = "AbstractCheckBox";
            AbstractCheckBox.Size = new Size(43, 19);
            AbstractCheckBox.TabIndex = 7;
            AbstractCheckBox.Text = "Yes";
            AbstractCheckBox.UseVisualStyleBackColor = true;
            AbstractCheckBox.CheckedChanged += AbstractCheckBox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "Attributes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 117);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Methods:";
            // 
            // AttributesListBox1
            // 
            AttributesListBox1.FormattingEnabled = true;
            AttributesListBox1.ItemHeight = 15;
            AttributesListBox1.Location = new Point(12, 137);
            AttributesListBox1.Name = "AttributesListBox1";
            AttributesListBox1.Size = new Size(184, 139);
            AttributesListBox1.TabIndex = 10;
            AttributesListBox1.MouseClick += AttributesListBox1_MouseClick;
            // 
            // MethodsListBox1
            // 
            MethodsListBox1.FormattingEnabled = true;
            MethodsListBox1.ItemHeight = 15;
            MethodsListBox1.Location = new Point(250, 137);
            MethodsListBox1.Name = "MethodsListBox1";
            MethodsListBox1.Size = new Size(184, 139);
            MethodsListBox1.TabIndex = 11;
            // 
            // AddAttrButton
            // 
            AddAttrButton.Location = new Point(21, 282);
            AddAttrButton.Name = "AddAttrButton";
            AddAttrButton.Size = new Size(53, 23);
            AddAttrButton.TabIndex = 12;
            AddAttrButton.Text = "Add";
            AddAttrButton.UseVisualStyleBackColor = true;
            AddAttrButton.Click += AddAttrButton_Click;
            // 
            // RemAttrButton
            // 
            RemAttrButton.Location = new Point(136, 282);
            RemAttrButton.Name = "RemAttrButton";
            RemAttrButton.Size = new Size(47, 23);
            RemAttrButton.TabIndex = 13;
            RemAttrButton.Text = "Rem";
            RemAttrButton.UseVisualStyleBackColor = true;
            RemAttrButton.Click += RemAttrButton_Click;
            // 
            // AddMetButton
            // 
            AddMetButton.Location = new Point(260, 282);
            AddMetButton.Name = "AddMetButton";
            AddMetButton.Size = new Size(47, 23);
            AddMetButton.TabIndex = 14;
            AddMetButton.Text = "Add";
            AddMetButton.UseVisualStyleBackColor = true;
            AddMetButton.Click += AddMetButton_Click;
            // 
            // RemMetButton
            // 
            RemMetButton.Location = new Point(370, 282);
            RemMetButton.Name = "RemMetButton";
            RemMetButton.Size = new Size(51, 23);
            RemMetButton.TabIndex = 15;
            RemMetButton.Text = "Rem";
            RemMetButton.UseVisualStyleBackColor = true;
            RemMetButton.Click += RemMetButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 371);
            Controls.Add(RemMetButton);
            Controls.Add(AddMetButton);
            Controls.Add(RemAttrButton);
            Controls.Add(AddAttrButton);
            Controls.Add(MethodsListBox1);
            Controls.Add(AttributesListBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AbstractCheckBox);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private CheckBox AbstractCheckBox;
        private Label label3;
        private Label label4;
        private ListBox AttributesListBox1;
        private ListBox MethodsListBox1;
        private Button AddAttrButton;
        private Button RemAttrButton;
        private Button AddMetButton;
        private Button RemMetButton;
    }
}