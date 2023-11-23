namespace Script
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
            this.panel1_Check1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2_Check2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3_Check3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1_Check1.SuspendLayout();
            this.panel2_Check2.SuspendLayout();
            this.panel3_Check3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_Check1
            // 
            this.panel1_Check1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1_Check1.Controls.Add(this.label1);
            this.panel1_Check1.Location = new System.Drawing.Point(51, 71);
            this.panel1_Check1.Name = "panel1_Check1";
            this.panel1_Check1.Size = new System.Drawing.Size(464, 28);
            this.panel1_Check1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(108, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origem dicom difere de Usuario";
            // 
            // panel2_Check2
            // 
            this.panel2_Check2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2_Check2.Controls.Add(this.label2);
            this.panel2_Check2.Location = new System.Drawing.Point(51, 119);
            this.panel2_Check2.Name = "panel2_Check2";
            this.panel2_Check2.Size = new System.Drawing.Size(464, 28);
            this.panel2_Check2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Algoritmo de calculo AcurosXB_15606 ou AAA_15606";
            // 
            // panel3_Check3
            // 
            this.panel3_Check3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3_Check3.Controls.Add(this.label3);
            this.panel3_Check3.Location = new System.Drawing.Point(51, 175);
            this.panel3_Check3.Name = "panel3_Check3";
            this.panel3_Check3.Size = new System.Drawing.Size(464, 28);
            this.panel3_Check3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(62, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Todos os campos possuem bolus se inserido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(578, 352);
            this.Controls.Add(this.panel3_Check3);
            this.Controls.Add(this.panel2_Check2);
            this.Controls.Add(this.panel1_Check1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1_Check1.ResumeLayout(false);
            this.panel1_Check1.PerformLayout();
            this.panel2_Check2.ResumeLayout(false);
            this.panel2_Check2.PerformLayout();
            this.panel3_Check3.ResumeLayout(false);
            this.panel3_Check3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_Check1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2_Check2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3_Check3;
        private System.Windows.Forms.Label label3;
    }
}