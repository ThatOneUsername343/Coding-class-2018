namespace Winforms
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
            this.Something = new System.Windows.Forms.Button();
            this.Failsafe = new System.Windows.Forms.CheckBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ThatOneLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Something
            // 
            this.Something.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Something.Location = new System.Drawing.Point(15, 218);
            this.Something.Name = "Something";
            this.Something.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Something.Size = new System.Drawing.Size(400, 220);
            this.Something.TabIndex = 0;
            this.Something.Text = "Something.";
            this.Something.UseVisualStyleBackColor = true;
            this.Something.Click += new System.EventHandler(this.button1_Click);
            // 
            // Failsafe
            // 
            this.Failsafe.AutoSize = true;
            this.Failsafe.Location = new System.Drawing.Point(12, 12);
            this.Failsafe.Name = "Failsafe";
            this.Failsafe.Size = new System.Drawing.Size(210, 21);
            this.Failsafe.TabIndex = 1;
            this.Failsafe.Text = "FAILSAFE. DO NOT PRESS.";
            this.Failsafe.UseVisualStyleBackColor = true;
            this.Failsafe.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(12, 50);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateTimePicker.TabIndex = 2;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // ThatOneLabel
            // 
            this.ThatOneLabel.AutoSize = true;
            this.ThatOneLabel.Location = new System.Drawing.Point(240, 30);
            this.ThatOneLabel.Name = "ThatOneLabel";
            this.ThatOneLabel.Size = new System.Drawing.Size(46, 17);
            this.ThatOneLabel.TabIndex = 3;
            this.ThatOneLabel.Text = "label1";
            this.ThatOneLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 124);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ThatOneLabel);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Failsafe);
            this.Controls.Add(this.Something);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Something;
        private System.Windows.Forms.CheckBox Failsafe;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label ThatOneLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

