namespace TrabalhoDeConversao
{
    partial class FormConverte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValorConverter = new System.Windows.Forms.TextBox();
            this.comboBoxBase = new System.Windows.Forms.ComboBox();
            this.comboBoxQualConverter = new System.Windows.Forms.ComboBox();
            this.richTextBoxMostrar = new System.Windows.Forms.RichTextBox();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a converter: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe a Base do Valor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base Para Converter: ";
            // 
            // textBoxValorConverter
            // 
            this.textBoxValorConverter.Location = new System.Drawing.Point(139, 12);
            this.textBoxValorConverter.Name = "textBoxValorConverter";
            this.textBoxValorConverter.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorConverter.TabIndex = 3;
            // 
            // comboBoxBase
            // 
            this.comboBoxBase.AccessibleRole = System.Windows.Forms.AccessibleRole.HotkeyField;
            this.comboBoxBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase.FormattingEnabled = true;
            this.comboBoxBase.Items.AddRange(new object[] {
            "Decimal\t",
            "Octal",
            "Binário",
            "Hexadecimal\t"});
            this.comboBoxBase.Location = new System.Drawing.Point(539, 9);
            this.comboBoxBase.Name = "comboBoxBase";
            this.comboBoxBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxBase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBase.TabIndex = 4;
            // 
            // comboBoxQualConverter
            // 
            this.comboBoxQualConverter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQualConverter.FormattingEnabled = true;
            this.comboBoxQualConverter.Items.AddRange(new object[] {
            "Decimal\t",
            "Octal",
            "Binário",
            "Hexadecimal\t"});
            this.comboBoxQualConverter.Location = new System.Drawing.Point(139, 65);
            this.comboBoxQualConverter.Name = "comboBoxQualConverter";
            this.comboBoxQualConverter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQualConverter.TabIndex = 5;
            // 
            // richTextBoxMostrar
            // 
            this.richTextBoxMostrar.Location = new System.Drawing.Point(13, 165);
            this.richTextBoxMostrar.Name = "richTextBoxMostrar";
            this.richTextBoxMostrar.Size = new System.Drawing.Size(708, 301);
            this.richTextBoxMostrar.TabIndex = 6;
            this.richTextBoxMostrar.Text = "";
            // 
            // buttonConverter
            // 
            this.buttonConverter.Location = new System.Drawing.Point(340, 125);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(75, 23);
            this.buttonConverter.TabIndex = 7;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // FormConverte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 502);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.richTextBoxMostrar);
            this.Controls.Add(this.comboBoxQualConverter);
            this.Controls.Add(this.comboBoxBase);
            this.Controls.Add(this.textBoxValorConverter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConverte";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValorConverter;
        private System.Windows.Forms.ComboBox comboBoxQualConverter;
        private System.Windows.Forms.RichTextBox richTextBoxMostrar;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.ComboBox comboBoxBase;
    }
}

