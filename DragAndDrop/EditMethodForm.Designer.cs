namespace DragAndDrop
{
    partial class EditMethodForm
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
            NametextBox1 = new TextBox();
            label1 = new Label();
            Exitbutton1 = new Button();
            ApplyButton = new Button();
            SuspendLayout();
            // 
            // NametextBox1
            // 
            NametextBox1.Location = new Point(12, 36);
            NametextBox1.Name = "NametextBox1";
            NametextBox1.Size = new Size(100, 23);
            NametextBox1.TabIndex = 0;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // Exitbutton1
            // 
            Exitbutton1.Location = new Point(195, 74);
            Exitbutton1.Name = "Exitbutton1";
            Exitbutton1.Size = new Size(75, 23);
            Exitbutton1.TabIndex = 2;
            Exitbutton1.Text = "Exit";
            Exitbutton1.UseVisualStyleBackColor = true;
            Exitbutton1.Click += ExitButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(17, 75);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(75, 23);
            ApplyButton.TabIndex = 3;
            ApplyButton.Text = "Apply";
            ApplyButton.TextAlign = ContentAlignment.BottomLeft;
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // EditMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 109);
            Controls.Add(ApplyButton);
            Controls.Add(Exitbutton1);
            Controls.Add(label1);
            Controls.Add(NametextBox1);
            Name = "EditMethodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditMethodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NametextBox1;
        private Label label1;
        private Button Exitbutton1;
        private Button ApplyButton;
    }
}