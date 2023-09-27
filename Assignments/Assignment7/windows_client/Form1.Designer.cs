
namespace windows_client
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
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.n1.Location = new System.Drawing.Point(204, 38);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(186, 26);
            this.n1.TabIndex = 0;
            this.n1.Text = "\r\n\r\n";
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(204, 106);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(186, 26);
            this.n2.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(204, 167);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(186, 71);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(204, 268);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(191, 26);
            this.res.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(95, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(95, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

