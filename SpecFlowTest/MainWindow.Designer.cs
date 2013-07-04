namespace SpecFlowTest
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.goodButton = new System.Windows.Forms.Button();
            this.faultyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goodButton
            // 
            this.goodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.goodButton.Location = new System.Drawing.Point(12, 12);
            this.goodButton.Name = "goodButton";
            this.goodButton.Size = new System.Drawing.Size(97, 23);
            this.goodButton.TabIndex = 0;
            this.goodButton.Text = "Good Button";
            this.goodButton.UseVisualStyleBackColor = false;
            this.goodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // faultyButton
            // 
            this.faultyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.faultyButton.Location = new System.Drawing.Point(132, 12);
            this.faultyButton.Name = "faultyButton";
            this.faultyButton.Size = new System.Drawing.Size(97, 23);
            this.faultyButton.TabIndex = 0;
            this.faultyButton.Text = "Faulty Button";
            this.faultyButton.UseVisualStyleBackColor = false;
            this.faultyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 94);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 156);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.faultyButton);
            this.Controls.Add(this.goodButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(260, 194);
            this.MinimumSize = new System.Drawing.Size(260, 194);
            this.Name = "MainWindow";
            this.Text = "Plus One";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goodButton;
        private System.Windows.Forms.Button faultyButton;
        public System.Windows.Forms.TextBox textBox1;
    }
}

