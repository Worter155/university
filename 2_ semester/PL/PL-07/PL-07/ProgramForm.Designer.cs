namespace PL_07
{
    partial class ProgramForm
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
            this.SumButton = new System.Windows.Forms.Button();
            this.ScalarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloneButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SerealizeButton = new System.Windows.Forms.Button();
            this.ReadCharStreamButton = new System.Windows.Forms.Button();
            this.WriteCharStreamButton = new System.Windows.Forms.Button();
            this.ReadByteStreamButton = new System.Windows.Forms.Button();
            this.WriteByteStreamButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SumButton
            // 
            this.SumButton.BackColor = System.Drawing.Color.LightSalmon;
            this.SumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumButton.Location = new System.Drawing.Point(7, 54);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(120, 42);
            this.SumButton.TabIndex = 0;
            this.SumButton.Text = "Сумма векторов";
            this.SumButton.UseVisualStyleBackColor = false;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // ScalarButton
            // 
            this.ScalarButton.BackColor = System.Drawing.Color.LightSalmon;
            this.ScalarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScalarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScalarButton.Location = new System.Drawing.Point(136, 54);
            this.ScalarButton.Name = "ScalarButton";
            this.ScalarButton.Size = new System.Drawing.Size(120, 42);
            this.ScalarButton.TabIndex = 1;
            this.ScalarButton.Text = "Скалярное произведение";
            this.ScalarButton.UseVisualStyleBackColor = false;
            this.ScalarButton.Click += new System.EventHandler(this.ScalarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номера веторов";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 28);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(192, 28);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloneButton);
            this.groupBox1.Controls.Add(this.EqualsButton);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ScalarButton);
            this.groupBox1.Controls.Add(this.SumButton);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 155);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции над векторами";
            // 
            // CloneButton
            // 
            this.CloneButton.BackColor = System.Drawing.Color.LightSalmon;
            this.CloneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloneButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloneButton.Location = new System.Drawing.Point(136, 102);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(120, 42);
            this.CloneButton.TabIndex = 6;
            this.CloneButton.Text = "Клонировать 1-ый вектор";
            this.CloneButton.UseVisualStyleBackColor = false;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.LightSalmon;
            this.EqualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualsButton.Location = new System.Drawing.Point(7, 103);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(120, 42);
            this.EqualsButton.TabIndex = 5;
            this.EqualsButton.Text = "Сравнить вектора";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortButton);
            this.groupBox2.Controls.Add(this.MinButton);
            this.groupBox2.Controls.Add(this.MaxButton);
            this.groupBox2.Location = new System.Drawing.Point(5, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 138);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции над массивом";
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.LightSalmon;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.Location = new System.Drawing.Point(6, 86);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(250, 42);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Отсортировать массив";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.LightSalmon;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinButton.Location = new System.Drawing.Point(136, 20);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(120, 60);
            this.MinButton.TabIndex = 1;
            this.MinButton.Text = "Минимальный по кол-ву координат";
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.BackColor = System.Drawing.Color.LightSalmon;
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxButton.Location = new System.Drawing.Point(7, 20);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(120, 60);
            this.MaxButton.TabIndex = 0;
            this.MaxButton.Text = "Максимальный по кол-ву координат";
            this.MaxButton.UseVisualStyleBackColor = false;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SerealizeButton);
            this.groupBox3.Controls.Add(this.ReadCharStreamButton);
            this.groupBox3.Controls.Add(this.WriteCharStreamButton);
            this.groupBox3.Controls.Add(this.ReadByteStreamButton);
            this.groupBox3.Controls.Add(this.WriteByteStreamButton);
            this.groupBox3.Location = new System.Drawing.Point(5, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 185);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Работа с потоками";
            // 
            // SerealizeButton
            // 
            this.SerealizeButton.BackColor = System.Drawing.Color.LightSalmon;
            this.SerealizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerealizeButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerealizeButton.Location = new System.Drawing.Point(7, 134);
            this.SerealizeButton.Name = "SerealizeButton";
            this.SerealizeButton.Size = new System.Drawing.Size(250, 42);
            this.SerealizeButton.TabIndex = 4;
            this.SerealizeButton.Text = "Сериализация векторов";
            this.SerealizeButton.UseVisualStyleBackColor = false;
            this.SerealizeButton.Click += new System.EventHandler(this.SerealizeButton_Click);
            // 
            // ReadCharStreamButton
            // 
            this.ReadCharStreamButton.BackColor = System.Drawing.Color.LightSalmon;
            this.ReadCharStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadCharStreamButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadCharStreamButton.Location = new System.Drawing.Point(137, 68);
            this.ReadCharStreamButton.Name = "ReadCharStreamButton";
            this.ReadCharStreamButton.Size = new System.Drawing.Size(120, 60);
            this.ReadCharStreamButton.TabIndex = 3;
            this.ReadCharStreamButton.Text = "Чтение из символьного потока";
            this.ReadCharStreamButton.UseVisualStyleBackColor = false;
            this.ReadCharStreamButton.Click += new System.EventHandler(this.ReadCharStreamButton_Click);
            // 
            // WriteCharStreamButton
            // 
            this.WriteCharStreamButton.BackColor = System.Drawing.Color.LightSalmon;
            this.WriteCharStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteCharStreamButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteCharStreamButton.Location = new System.Drawing.Point(6, 68);
            this.WriteCharStreamButton.Name = "WriteCharStreamButton";
            this.WriteCharStreamButton.Size = new System.Drawing.Size(120, 60);
            this.WriteCharStreamButton.TabIndex = 2;
            this.WriteCharStreamButton.Text = "Запись в символьный поток";
            this.WriteCharStreamButton.UseVisualStyleBackColor = false;
            this.WriteCharStreamButton.Click += new System.EventHandler(this.WriteCharStreamButton_Click);
            // 
            // ReadByteStreamButton
            // 
            this.ReadByteStreamButton.BackColor = System.Drawing.Color.LightSalmon;
            this.ReadByteStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadByteStreamButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadByteStreamButton.Location = new System.Drawing.Point(136, 20);
            this.ReadByteStreamButton.Name = "ReadByteStreamButton";
            this.ReadByteStreamButton.Size = new System.Drawing.Size(120, 42);
            this.ReadByteStreamButton.TabIndex = 1;
            this.ReadByteStreamButton.Text = "Чтение из байтового потока";
            this.ReadByteStreamButton.UseVisualStyleBackColor = false;
            this.ReadByteStreamButton.Click += new System.EventHandler(this.ReadByteStreamButton_Click);
            // 
            // WriteByteStreamButton
            // 
            this.WriteByteStreamButton.BackColor = System.Drawing.Color.LightSalmon;
            this.WriteByteStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteByteStreamButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteByteStreamButton.Location = new System.Drawing.Point(6, 20);
            this.WriteByteStreamButton.Name = "WriteByteStreamButton";
            this.WriteByteStreamButton.Size = new System.Drawing.Size(120, 42);
            this.WriteByteStreamButton.TabIndex = 0;
            this.WriteByteStreamButton.Text = "Запись в байтовый поток";
            this.WriteByteStreamButton.UseVisualStyleBackColor = false;
            this.WriteByteStreamButton.Click += new System.EventHandler(this.WriteByteStreamButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(307, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Массив векторов";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Beige;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(311, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 129);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Beige;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(311, 200);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 303);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(311, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результаты";
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(583, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button ScalarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button CloneButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SerealizeButton;
        private System.Windows.Forms.Button ReadCharStreamButton;
        private System.Windows.Forms.Button WriteCharStreamButton;
        private System.Windows.Forms.Button ReadByteStreamButton;
        private System.Windows.Forms.Button WriteByteStreamButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}