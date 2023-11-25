namespace lab5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox = new PictureBox();
            brushSizePicker = new NumericUpDown();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            dotButton = new ToolStripButton();
            lineButton = new ToolStripButton();
            rectangleButton = new ToolStripButton();
            elipseButton = new ToolStripButton();
            cubeButton = new ToolStripButton();
            barButton = new ToolStripButton();
            clearButton = new ToolStripButton();
            tableButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brushSizePicker).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ControlLightLight;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(12, 87);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1251, 598);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // brushSizePicker
            // 
            brushSizePicker.DecimalPlaces = 1;
            brushSizePicker.Location = new Point(185, 57);
            brushSizePicker.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            brushSizePicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            brushSizePicker.Name = "brushSizePicker";
            brushSizePicker.Size = new Size(150, 27);
            brushSizePicker.TabIndex = 2;
            brushSizePicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 3;
            label1.Text = "Оберіть розмір олівця";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { dotButton, lineButton, rectangleButton, elipseButton, cubeButton, barButton, clearButton, tableButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(779, 54);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // dotButton
            // 
            dotButton.AutoSize = false;
            dotButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            dotButton.Image = (Image)resources.GetObject("dotButton.Image");
            dotButton.ImageTransparentColor = Color.Magenta;
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(34, 34);
            dotButton.Text = "Крапка";
            dotButton.Click += dotButton_Click;
            // 
            // lineButton
            // 
            lineButton.AutoSize = false;
            lineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            lineButton.Image = (Image)resources.GetObject("lineButton.Image");
            lineButton.ImageTransparentColor = Color.Magenta;
            lineButton.Name = "lineButton";
            lineButton.Size = new Size(34, 34);
            lineButton.Text = "Лінія";
            lineButton.Click += lineButton_Click;
            // 
            // rectangleButton
            // 
            rectangleButton.AutoSize = false;
            rectangleButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rectangleButton.Image = (Image)resources.GetObject("rectangleButton.Image");
            rectangleButton.ImageTransparentColor = Color.Magenta;
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(34, 34);
            rectangleButton.Text = "Прямокутник";
            rectangleButton.Click += rectangleButton_Click;
            // 
            // elipseButton
            // 
            elipseButton.AutoSize = false;
            elipseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            elipseButton.Image = (Image)resources.GetObject("elipseButton.Image");
            elipseButton.ImageTransparentColor = Color.Magenta;
            elipseButton.Name = "elipseButton";
            elipseButton.Size = new Size(34, 34);
            elipseButton.Text = "Еліпс";
            elipseButton.Click += elipseButton_Click;
            // 
            // cubeButton
            // 
            cubeButton.AutoSize = false;
            cubeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cubeButton.Image = (Image)resources.GetObject("cubeButton.Image");
            cubeButton.ImageTransparentColor = Color.Magenta;
            cubeButton.Name = "cubeButton";
            cubeButton.Size = new Size(34, 34);
            cubeButton.Text = "toolStripButton1";
            cubeButton.ToolTipText = "Куб";
            cubeButton.Click += cubeButton_Click;
            // 
            // barButton
            // 
            barButton.AutoSize = false;
            barButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            barButton.Image = (Image)resources.GetObject("barButton.Image");
            barButton.ImageTransparentColor = Color.Magenta;
            barButton.Name = "barButton";
            barButton.Size = new Size(34, 34);
            barButton.Text = "toolStripButton2";
            barButton.ToolTipText = "Гантеля";
            barButton.Click += barButton_Click;
            // 
            // clearButton
            // 
            clearButton.AutoSize = false;
            clearButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            clearButton.Image = (Image)resources.GetObject("clearButton.Image");
            clearButton.ImageTransparentColor = Color.Magenta;
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(34, 34);
            clearButton.Text = "Очистити";
            clearButton.Click += clearButton_Click;
            // 
            // tableButton
            // 
            tableButton.AutoSize = false;
            tableButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tableButton.Image = (Image)resources.GetObject("tableButton.Image");
            tableButton.ImageTransparentColor = Color.Magenta;
            tableButton.Name = "tableButton";
            tableButton.Size = new Size(34, 34);
            tableButton.Text = "Відкрити таблицю";
            tableButton.Click += tableButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(779, 697);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(brushSizePicker);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Оберіть фігуру";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)brushSizePicker).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox;
        private NumericUpDown brushSizePicker;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton dotButton;
        private ToolStripButton lineButton;
        private ToolStripButton rectangleButton;
        private ToolStripButton elipseButton;
        private ToolStripButton clearButton;
        private ToolStripButton cubeButton;
        private ToolStripButton barButton;
        private ToolStripButton tableButton;
    }
}