namespace ExcelControl
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
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            compareButton = new Button();
            excelFile1Label = new Label();
            excelFile2Label = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            comparisonResultsGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comparisonResultsGrid).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // compareButton
            // 
            compareButton.Location = new Point(145, 93);
            compareButton.Name = "compareButton";
            compareButton.Size = new Size(75, 23);
            compareButton.TabIndex = 0;
            compareButton.Text = "Karşılaştır";
            compareButton.UseVisualStyleBackColor = true;
            compareButton.Click += compareButton_Click;
            // 
            // excelFile1Label
            // 
            excelFile1Label.AutoSize = true;
            excelFile1Label.Location = new Point(19, 25);
            excelFile1Label.Name = "excelFile1Label";
            excelFile1Label.Size = new Size(92, 15);
            excelFile1Label.TabIndex = 1;
            excelFile1Label.Text = "1.Excel Dosyası: ";
            // 
            // excelFile2Label
            // 
            excelFile2Label.AutoSize = true;
            excelFile2Label.Location = new Point(19, 54);
            excelFile2Label.Name = "excelFile2Label";
            excelFile2Label.Size = new Size(92, 15);
            excelFile2Label.TabIndex = 2;
            excelFile2Label.Text = "2.Excel Dosyası: ";
            // 
            // button1
            // 
            button1.Location = new Point(145, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Dosya Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 54);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Dosya Seç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(excelFile1Label);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(compareButton);
            groupBox1.Controls.Add(excelFile2Label);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 163);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Excel Karşılaştırma";
            // 
            // comparisonResultsGrid
            // 
            comparisonResultsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comparisonResultsGrid.Location = new Point(-2, 177);
            comparisonResultsGrid.Name = "comparisonResultsGrid";
            comparisonResultsGrid.RowTemplate.Height = 25;
            comparisonResultsGrid.Size = new Size(802, 276);
            comparisonResultsGrid.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 27);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "1.Dosya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 56);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "2.Dosya";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comparisonResultsGrid);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Excel Karşılaştırma";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comparisonResultsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button compareButton;
        private Label excelFile1Label;
        private Label excelFile2Label;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private DataGridView comparisonResultsGrid;
        private Label label2;
        private Label label1;
    }
}