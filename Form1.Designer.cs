namespace Converter
{
    partial class Form1
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
            this.fromTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fromBinaryRB = new System.Windows.Forms.RadioButton();
            this.fromDecimalRB = new System.Windows.Forms.RadioButton();
            this.fromHexademicalRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toHexadecimalRB = new System.Windows.Forms.RadioButton();
            this.toDecimalRB = new System.Windows.Forms.RadioButton();
            this.toBinaryRB = new System.Windows.Forms.RadioButton();
            this.convertBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromTb
            // 
            this.fromTb.Location = new System.Drawing.Point(18, 123);
            this.fromTb.Name = "fromTb";
            this.fromTb.Size = new System.Drawing.Size(174, 20);
            this.fromTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перевести из";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(216, 123);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(174, 20);
            this.toTB.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromHexademicalRB);
            this.groupBox1.Controls.Add(this.fromDecimalRB);
            this.groupBox1.Controls.Add(this.fromBinaryRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Из";
            // 
            // fromBinaryRB
            // 
            this.fromBinaryRB.AutoSize = true;
            this.fromBinaryRB.Checked = true;
            this.fromBinaryRB.Location = new System.Drawing.Point(6, 16);
            this.fromBinaryRB.Name = "fromBinaryRB";
            this.fromBinaryRB.Size = new System.Drawing.Size(75, 17);
            this.fromBinaryRB.TabIndex = 0;
            this.fromBinaryRB.TabStop = true;
            this.fromBinaryRB.Text = "Двоичная";
            this.fromBinaryRB.UseVisualStyleBackColor = true;
            this.fromBinaryRB.CheckedChanged += new System.EventHandler(this.fromHexademicalRB_CheckedChanged);
            // 
            // fromDecimalRB
            // 
            this.fromDecimalRB.AutoSize = true;
            this.fromDecimalRB.Location = new System.Drawing.Point(6, 39);
            this.fromDecimalRB.Name = "fromDecimalRB";
            this.fromDecimalRB.Size = new System.Drawing.Size(86, 17);
            this.fromDecimalRB.TabIndex = 1;
            this.fromDecimalRB.Text = "Десятичная";
            this.fromDecimalRB.UseVisualStyleBackColor = true;
            this.fromDecimalRB.CheckedChanged += new System.EventHandler(this.fromHexademicalRB_CheckedChanged);
            // 
            // fromHexademicalRB
            // 
            this.fromHexademicalRB.AutoSize = true;
            this.fromHexademicalRB.Location = new System.Drawing.Point(6, 62);
            this.fromHexademicalRB.Name = "fromHexademicalRB";
            this.fromHexademicalRB.Size = new System.Drawing.Size(122, 17);
            this.fromHexademicalRB.TabIndex = 2;
            this.fromHexademicalRB.Text = "Шеснадцатеричная";
            this.fromHexademicalRB.UseVisualStyleBackColor = true;
            this.fromHexademicalRB.CheckedChanged += new System.EventHandler(this.fromHexademicalRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toHexadecimalRB);
            this.groupBox2.Controls.Add(this.toDecimalRB);
            this.groupBox2.Controls.Add(this.toBinaryRB);
            this.groupBox2.Location = new System.Drawing.Point(210, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 92);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "В";
            // 
            // toHexadecimalRB
            // 
            this.toHexadecimalRB.AutoSize = true;
            this.toHexadecimalRB.Location = new System.Drawing.Point(6, 62);
            this.toHexadecimalRB.Name = "toHexadecimalRB";
            this.toHexadecimalRB.Size = new System.Drawing.Size(122, 17);
            this.toHexadecimalRB.TabIndex = 2;
            this.toHexadecimalRB.Text = "Шеснадцатеричная";
            this.toHexadecimalRB.UseVisualStyleBackColor = true;
            this.toHexadecimalRB.CheckedChanged += new System.EventHandler(this.fromHexademicalRB_CheckedChanged);
            // 
            // toDecimalRB
            // 
            this.toDecimalRB.AutoSize = true;
            this.toDecimalRB.Checked = true;
            this.toDecimalRB.Location = new System.Drawing.Point(6, 39);
            this.toDecimalRB.Name = "toDecimalRB";
            this.toDecimalRB.Size = new System.Drawing.Size(86, 17);
            this.toDecimalRB.TabIndex = 1;
            this.toDecimalRB.TabStop = true;
            this.toDecimalRB.Text = "Десятичная";
            this.toDecimalRB.UseVisualStyleBackColor = true;
            this.toDecimalRB.CheckedChanged += new System.EventHandler(this.fromHexademicalRB_CheckedChanged);
            // 
            // toBinaryRB
            // 
            this.toBinaryRB.AutoSize = true;
            this.toBinaryRB.Location = new System.Drawing.Point(6, 16);
            this.toBinaryRB.Name = "toBinaryRB";
            this.toBinaryRB.Size = new System.Drawing.Size(75, 17);
            this.toBinaryRB.TabIndex = 0;
            this.toBinaryRB.Text = "Двоичная";
            this.toBinaryRB.UseVisualStyleBackColor = true;
            this.toBinaryRB.CheckedChanged += new System.EventHandler(this.fromHexademicalRB_CheckedChanged);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(18, 149);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Перевести";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 464);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromTb);
            this.Name = "Form1";
            this.Text = "Конвертер";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fromHexademicalRB;
        private System.Windows.Forms.RadioButton fromDecimalRB;
        private System.Windows.Forms.RadioButton fromBinaryRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton toHexadecimalRB;
        private System.Windows.Forms.RadioButton toDecimalRB;
        private System.Windows.Forms.RadioButton toBinaryRB;
        private System.Windows.Forms.Button convertBtn;
    }
}

