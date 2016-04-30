namespace WF_Uppg_1
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
            this.btn_getCust = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtReader = new System.Windows.Forms.RichTextBox();
            this.txtboxup2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_getCust
            // 
            this.btn_getCust.Location = new System.Drawing.Point(12, 280);
            this.btn_getCust.Name = "btn_getCust";
            this.btn_getCust.Size = new System.Drawing.Size(150, 29);
            this.btn_getCust.TabIndex = 0;
            this.btn_getCust.Text = "Get Customers";
            this.btn_getCust.UseVisualStyleBackColor = true;
            this.btn_getCust.Click += new System.EventHandler(this.btn_getCust_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Reservations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open Text File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(357, 284);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(159, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "Enter your file here";
            // 
            // txtReader
            // 
            this.txtReader.Location = new System.Drawing.Point(357, 12);
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(315, 239);
            this.txtReader.TabIndex = 4;
            this.txtReader.Text = "";
            // 
            // txtboxup2
            // 
            this.txtboxup2.Location = new System.Drawing.Point(12, 12);
            this.txtboxup2.Name = "txtboxup2";
            this.txtboxup2.Size = new System.Drawing.Size(306, 239);
            this.txtboxup2.TabIndex = 5;
            this.txtboxup2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 321);
            this.Controls.Add(this.txtboxup2);
            this.Controls.Add(this.txtReader);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_getCust);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getCust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox txtReader;
        private System.Windows.Forms.RichTextBox txtboxup2;
    }
}

