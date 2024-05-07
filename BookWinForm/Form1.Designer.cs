namespace BookWinForm
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
            label1 = new Label();
            BookNameTextBox = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            PriceTextBox = new TextBox();
            Price = new Label();
            AddBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 13);
            label1.TabIndex = 0;
            label1.Text = "BookName";
            // 
            // BookNameTextBox
            // 
            BookNameTextBox.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookNameTextBox.Location = new Point(10, 37);
            BookNameTextBox.Name = "BookNameTextBox";
            BookNameTextBox.Size = new Size(86, 33);
            BookNameTextBox.TabIndex = 1;
            BookNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 22);
            label2.Name = "label2";
            label2.Size = new Size(0, 13);
            label2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(206, 130);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTextBox.Location = new Point(141, 37);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(86, 33);
            PriceTextBox.TabIndex = 4;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(146, 22);
            Price.Name = "Price";
            Price.Size = new Size(31, 13);
            Price.TabIndex = 5;
            Price.Text = "Price";
            Price.Click += Price_Click;
            // 
            // AddBook
            // 
            AddBook.BackColor = SystemColors.ControlDark;
            AddBook.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBook.Location = new Point(276, 42);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(94, 28);
            AddBook.TabIndex = 6;
            AddBook.Text = "Add Book";
            AddBook.UseVisualStyleBackColor = false;
            AddBook.Click += AddBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(AddBook);
            Controls.Add(Price);
            Controls.Add(PriceTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(BookNameTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox BookNameTextBox;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox PriceTextBox;
        private Label Price;
        private Button AddBook;
    }
}
