namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.arg1 = new System.Windows.Forms.TextBox();
            this.arg2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(528, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Számolj!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(416, 89);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 1;
            // 
            // arg1
            // 
            this.arg1.Location = new System.Drawing.Point(158, 44);
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(100, 20);
            this.arg1.TabIndex = 2;
            this.arg1.Leave += new System.EventHandler(this.arg1_Leave);
            // 
            // arg2
            // 
            this.arg2.Location = new System.Drawing.Point(374, 44);
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(100, 20);
            this.arg2.TabIndex = 3;
            this.arg2.Leave += new System.EventHandler(this.arg2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.arg2);
            this.Controls.Add(this.arg1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Text = "I will add two numbers for you.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox arg1;
        private System.Windows.Forms.TextBox arg2;
    }
}

