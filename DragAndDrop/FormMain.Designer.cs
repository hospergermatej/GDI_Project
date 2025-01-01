namespace DragAndDrop
{
    partial class FormMain
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
            pictureBox = new PictureBox();
            AddClassButton = new Button();
            ExitButton = new Button();
            Exportbutton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(85, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(969, 635);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseDoubleClick += pictureBox_MouseDoubleClick;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // AddClassButton
            // 
            AddClassButton.Location = new Point(4, 34);
            AddClassButton.Name = "AddClassButton";
            AddClassButton.Size = new Size(75, 23);
            AddClassButton.TabIndex = 1;
            AddClassButton.Text = "Add Class";
            AddClassButton.UseVisualStyleBackColor = true;
            AddClassButton.Click += AddClassButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.RosyBrown;
            ExitButton.ForeColor = SystemColors.ButtonFace;
            ExitButton.Location = new Point(4, 603);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Exportbutton1
            // 
            Exportbutton1.Location = new Point(4, 532);
            Exportbutton1.Name = "Exportbutton1";
            Exportbutton1.Size = new Size(75, 48);
            Exportbutton1.TabIndex = 3;
            Exportbutton1.Text = "Export to PNG";
            Exportbutton1.UseVisualStyleBackColor = true;
            Exportbutton1.Click += Exportbutton1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 659);
            Controls.Add(Exportbutton1);
            Controls.Add(ExitButton);
            Controls.Add(AddClassButton);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DragAndDrop";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button AddClassButton;
        private Button ExitButton;
        private Button Exportbutton1;
    }
}
