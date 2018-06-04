namespace WindowsFormsApplication1
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
            this.equation = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.Location = new System.Drawing.Point(12, 9);
            this.equation.MaximumSize = new System.Drawing.Size(200, 25);
            this.equation.MinimumSize = new System.Drawing.Size(200, 25);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(200, 25);
            this.equation.TabIndex = 1;
            this.equation.Text = "label1";
            this.equation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultTxt
            // 
            this.resultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxt.Location = new System.Drawing.Point(12, 43);
            this.resultTxt.MaximumSize = new System.Drawing.Size(200, 25);
            this.resultTxt.MinimumSize = new System.Drawing.Size(200, 25);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(200, 25);
            this.resultTxt.TabIndex = 2;
            this.resultTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.submitResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 80);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.equation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.TextBox resultTxt;
    }
}

