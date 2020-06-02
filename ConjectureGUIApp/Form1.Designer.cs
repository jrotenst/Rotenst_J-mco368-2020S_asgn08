namespace ConjectureGUIApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.LimitTextBox = new System.Windows.Forms.TextBox();
            this.ResultsTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm Up To:";
            // 
            // LimitTextBox
            // 
            this.LimitTextBox.Location = new System.Drawing.Point(136, 32);
            this.LimitTextBox.Name = "LimitTextBox";
            this.LimitTextBox.Size = new System.Drawing.Size(100, 20);
            this.LimitTextBox.TabIndex = 1;
            // 
            // ResultsTextbox
            // 
            this.ResultsTextbox.Location = new System.Drawing.Point(55, 109);
            this.ResultsTextbox.Multiline = true;
            this.ResultsTextbox.Name = "ResultsTextbox";
            this.ResultsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextbox.Size = new System.Drawing.Size(181, 123);
            this.ResultsTextbox.TabIndex = 2;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(109, 70);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(72, 24);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(109, 252);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(72, 24);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 288);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultsTextbox);
            this.Controls.Add(this.LimitTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Goldback Conjecture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimitTextBox;
        private System.Windows.Forms.TextBox ResultsTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}

