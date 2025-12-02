namespace Projekt_Architektura
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
            this.firstNum = new System.Windows.Forms.TextBox();
            this.convertedFirstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.convertedSecondNum = new System.Windows.Forms.TextBox();
            this.resultBin = new System.Windows.Forms.TextBox();
            this.resultDeci = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(38, 106);
            this.firstNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNum.MaxLength = 32;
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(232, 20);
            this.firstNum.TabIndex = 0;
            this.firstNum.TextChanged += new System.EventHandler(this.firstNum_TextChanged);
            this.firstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNum_KeyPress);
            // 
            // convertedFirstNum
            // 
            this.convertedFirstNum.Enabled = false;
            this.convertedFirstNum.Location = new System.Drawing.Point(38, 165);
            this.convertedFirstNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertedFirstNum.Name = "convertedFirstNum";
            this.convertedFirstNum.Size = new System.Drawing.Size(232, 20);
            this.convertedFirstNum.TabIndex = 1;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(290, 106);
            this.secondNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondNum.MaxLength = 32;
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(254, 20);
            this.secondNum.TabIndex = 2;
            this.secondNum.TextChanged += new System.EventHandler(this.secondNum_TextChanged);
            this.secondNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNum_KeyPress);
            // 
            // convertedSecondNum
            // 
            this.convertedSecondNum.Enabled = false;
            this.convertedSecondNum.Location = new System.Drawing.Point(290, 165);
            this.convertedSecondNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertedSecondNum.Name = "convertedSecondNum";
            this.convertedSecondNum.Size = new System.Drawing.Size(254, 20);
            this.convertedSecondNum.TabIndex = 3;
            // 
            // resultBin
            // 
            this.resultBin.Enabled = false;
            this.resultBin.Location = new System.Drawing.Point(570, 106);
            this.resultBin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultBin.Name = "resultBin";
            this.resultBin.Size = new System.Drawing.Size(337, 20);
            this.resultBin.TabIndex = 4;
            // 
            // resultDeci
            // 
            this.resultDeci.Enabled = false;
            this.resultDeci.Location = new System.Drawing.Point(570, 165);
            this.resultDeci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultDeci.Name = "resultDeci";
            this.resultDeci.Size = new System.Drawing.Size(337, 20);
            this.resultDeci.TabIndex = 5;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(226, 231);
            this.convertBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(124, 32);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Calculate";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(274, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(548, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.resultDeci);
            this.Controls.Add(this.resultBin);
            this.Controls.Add(this.convertedSecondNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.convertedFirstNum);
            this.Controls.Add(this.firstNum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

