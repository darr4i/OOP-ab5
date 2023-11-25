namespace lab5
{
    partial class MyTable
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
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            shapeName = new DataGridViewTextBoxColumn();
            shape_x1 = new DataGridViewTextBoxColumn();
            shape_y1 = new DataGridViewTextBoxColumn();
            shape_x2 = new DataGridViewTextBoxColumn();
            shape_y2 = new DataGridViewTextBoxColumn();
            shape_penSize = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { shapeName, shape_x1, shape_y1, shape_x2, shape_y2, shape_penSize });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(697, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(595, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // shapeName
            // 
            shapeName.Frozen = true;
            shapeName.HeaderText = "Назва";
            shapeName.MinimumWidth = 6;
            shapeName.Name = "shapeName";
            shapeName.ReadOnly = true;
            // 
            // shape_x1
            // 
            shape_x1.Frozen = true;
            shape_x1.HeaderText = "x1";
            shape_x1.MinimumWidth = 6;
            shape_x1.Name = "shape_x1";
            shape_x1.ReadOnly = true;
            shape_x1.Width = 90;
            // 
            // shape_y1
            // 
            shape_y1.Frozen = true;
            shape_y1.HeaderText = "y1";
            shape_y1.MinimumWidth = 6;
            shape_y1.Name = "shape_y1";
            shape_y1.ReadOnly = true;
            shape_y1.Width = 90;
            // 
            // shape_x2
            // 
            shape_x2.Frozen = true;
            shape_x2.HeaderText = "x2";
            shape_x2.MinimumWidth = 6;
            shape_x2.Name = "shape_x2";
            shape_x2.ReadOnly = true;
            shape_x2.Width = 90;
            // 
            // shape_y2
            // 
            shape_y2.Frozen = true;
            shape_y2.HeaderText = "y2";
            shape_y2.MinimumWidth = 6;
            shape_y2.Name = "shape_y2";
            shape_y2.ReadOnly = true;
            shape_y2.Width = 90;
            // 
            // shape_penSize
            // 
            shape_penSize.Frozen = true;
            shape_penSize.HeaderText = "Розмір олівця";
            shape_penSize.MinimumWidth = 6;
            shape_penSize.Name = "shape_penSize";
            shape_penSize.ReadOnly = true;
            shape_penSize.Width = 125;
            // 
            // MyTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 450);
            ControlBox = false;
            Controls.Add(deleteButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyTable";
            Text = "Таблиця фігур";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView dataGridView1;
        internal Button deleteButton;
        private DataGridViewTextBoxColumn shapeName;
        private DataGridViewTextBoxColumn shape_x1;
        private DataGridViewTextBoxColumn shape_y1;
        private DataGridViewTextBoxColumn shape_x2;
        private DataGridViewTextBoxColumn shape_y2;
        private DataGridViewTextBoxColumn shape_penSize;
    }
}