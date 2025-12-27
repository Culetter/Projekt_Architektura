namespace Projekt_Architektura
{
    partial class Symulator
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
            this.firstNum = new System.Windows.Forms.TextBox();
            this.convertedFirstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.convertedSecondNum = new System.Windows.Forms.TextBox();
            this.resultBin = new System.Windows.Forms.TextBox();
            this.resultDeci = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(51, 130);
            this.firstNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNum.MaxLength = 32;
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(308, 22);
            this.firstNum.TabIndex = 0;
            this.firstNum.TextChanged += new System.EventHandler(this.firstNum_TextChanged);
            this.firstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNum_KeyPress);
            // 
            // convertedFirstNum
            // 
            this.convertedFirstNum.Enabled = false;
            this.convertedFirstNum.Location = new System.Drawing.Point(51, 209);
            this.convertedFirstNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convertedFirstNum.Name = "convertedFirstNum";
            this.convertedFirstNum.Size = new System.Drawing.Size(308, 22);
            this.convertedFirstNum.TabIndex = 1;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(387, 130);
            this.secondNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondNum.MaxLength = 32;
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(337, 22);
            this.secondNum.TabIndex = 2;
            this.secondNum.TextChanged += new System.EventHandler(this.secondNum_TextChanged);
            this.secondNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNum_KeyPress);
            // 
            // convertedSecondNum
            // 
            this.convertedSecondNum.Enabled = false;
            this.convertedSecondNum.Location = new System.Drawing.Point(387, 209);
            this.convertedSecondNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convertedSecondNum.Name = "convertedSecondNum";
            this.convertedSecondNum.Size = new System.Drawing.Size(337, 22);
            this.convertedSecondNum.TabIndex = 3;
            // 
            // resultBin
            // 
            this.resultBin.Enabled = false;
            this.resultBin.Location = new System.Drawing.Point(760, 130);
            this.resultBin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultBin.Name = "resultBin";
            this.resultBin.Size = new System.Drawing.Size(337, 22);
            this.resultBin.TabIndex = 4;
            // 
            // resultDeci
            // 
            this.resultDeci.Enabled = false;
            this.resultDeci.Location = new System.Drawing.Point(760, 209);
            this.resultDeci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultDeci.Name = "resultDeci";
            this.resultDeci.Size = new System.Drawing.Size(337, 22);
            this.resultDeci.TabIndex = 5;
            // 
            // convertBtn
            // 
            this.convertBtn.Enabled = false;
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertBtn.Location = new System.Drawing.Point(456, 277);
            this.convertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(218, 45);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Calculate";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(365, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(731, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Liczba 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(383, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liczba 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reprezentacja dziesiętna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(756, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wynik";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(51, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 2);
            this.panel1.TabIndex = 13;
            // 
            // Symulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.resultDeci);
            this.Controls.Add(this.resultBin);
            this.Controls.Add(this.convertedSecondNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.convertedFirstNum);
            this.Controls.Add(this.firstNum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Symulator";
            this.Text = "Symulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox convertedFirstNum;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.TextBox convertedSecondNum;
        private System.Windows.Forms.TextBox resultBin;
        private System.Windows.Forms.TextBox resultDeci;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

