namespace DragAndDrop
{
    partial class AddAttributeForm
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
            DataTypetextBox1 = new TextBox();
            ApplyButton = new Button();
            label3 = new Label();
            NametextBox1 = new TextBox();
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
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Data type";
            // 
            // DataTypetextBox1
            // 
            DataTypetextBox1.Location = new Point(12, 83);
            DataTypetextBox1.Name = "DataTypetextBox1";
            DataTypetextBox1.Size = new Size(100, 23);
            DataTypetextBox1.TabIndex = 3;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(12, 277);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(75, 23);
            ApplyButton.TabIndex = 4;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // NametextBox1
            // 
            NametextBox1.Location = new Point(12, 139);
            NametextBox1.Name = "NametextBox1";
            NametextBox1.Size = new Size(100, 23);
            NametextBox1.TabIndex = 6;
            // 
            // AddAttributeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 312);
            Controls.Add(NametextBox1);
            Controls.Add(label3);
            Controls.Add(ApplyButton);
            Controls.Add(DataTypetextBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "AddAttributeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAttributeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox DataTypetextBox1;
        private Button ApplyButton;
        private Label label3;
        private TextBox NametextBox1;
    }
}