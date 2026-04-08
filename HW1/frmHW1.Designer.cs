namespace HW1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblGrace = new System.Windows.Forms.Label();
            this.txtGrace = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutTotal = new System.Windows.Forms.Label();
            this.txtOutTotalInt = new System.Windows.Forms.Label();
            this.txtOutPri1 = new System.Windows.Forms.Label();
            this.txtOutInt1 = new System.Windows.Forms.Label();
            this.txtOutMonthly = new System.Windows.Forms.Label();
            this.txtOutLoan = new System.Windows.Forms.Label();
            this.lblOutTotal = new System.Windows.Forms.Label();
            this.lblOutTotalInt = new System.Windows.Forms.Label();
            this.lblOutPri1 = new System.Windows.Forms.Label();
            this.lblOutInt1 = new System.Windows.Forms.Label();
            this.lblOutMonthly = new System.Windows.Forms.Label();
            this.lblOutLoan = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.Wheat;
            this.grpInput.Controls.Add(this.btnCalc);
            this.grpInput.Controls.Add(this.lblGrace);
            this.grpInput.Controls.Add(this.txtGrace);
            this.grpInput.Controls.Add(this.lblTerm);
            this.grpInput.Controls.Add(this.lblRate);
            this.grpInput.Controls.Add(this.rbAmount);
            this.grpInput.Controls.Add(this.rbPercent);
            this.grpInput.Controls.Add(this.lblDown);
            this.grpInput.Controls.Add(this.lblPrice);
            this.grpInput.Controls.Add(this.txtTerm);
            this.grpInput.Controls.Add(this.txtRate);
            this.grpInput.Controls.Add(this.txtDown);
            this.grpInput.Controls.Add(this.txtPrice);
            this.grpInput.Location = new System.Drawing.Point(15, 28);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpInput.Size = new System.Drawing.Size(451, 435);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入資料";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalc.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalc.Location = new System.Drawing.Point(8, 349);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(435, 56);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "計   算";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblGrace
            // 
            this.lblGrace.AutoSize = true;
            this.lblGrace.Location = new System.Drawing.Point(157, 272);
            this.lblGrace.Name = "lblGrace";
            this.lblGrace.Size = new System.Drawing.Size(139, 20);
            this.lblGrace.TabIndex = 12;
            this.lblGrace.Text = "寬限期 (選填)";
            // 
            // txtGrace
            // 
            this.txtGrace.Location = new System.Drawing.Point(8, 296);
            this.txtGrace.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrace.Name = "txtGrace";
            this.txtGrace.Size = new System.Drawing.Size(435, 31);
            this.txtGrace.TabIndex = 6;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(296, 200);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(89, 20);
            this.lblTerm.TabIndex = 10;
            this.lblTerm.Text = "貸款年限";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(62, 200);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(89, 20);
            this.lblRate.TabIndex = 9;
            this.lblRate.Text = "貸款利率";
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Location = new System.Drawing.Point(290, 117);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(80, 24);
            this.rbAmount.TabIndex = 2;
            this.rbAmount.TabStop = true;
            this.rbAmount.Text = "金額$";
            this.rbAmount.UseVisualStyleBackColor = true;
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Location = new System.Drawing.Point(66, 117);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(100, 24);
            this.rbPercent.TabIndex = 1;
            this.rbPercent.TabStop = true;
            this.rbPercent.Text = "百分比%";
            this.rbPercent.UseVisualStyleBackColor = true;
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(188, 103);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(69, 20);
            this.lblDown.TabIndex = 5;
            this.lblDown.Text = "自備款";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(178, 28);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "房屋總價";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(245, 224);
            this.txtTerm.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(198, 31);
            this.txtTerm.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(8, 224);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(198, 31);
            this.txtRate.TabIndex = 4;
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(8, 148);
            this.txtDown.Margin = new System.Windows.Forms.Padding(4);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(435, 31);
            this.txtDown.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(8, 52);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(435, 31);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Tag = "";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.Wheat;
            this.grpOutput.Controls.Add(this.txtOutTotal);
            this.grpOutput.Controls.Add(this.txtOutTotalInt);
            this.grpOutput.Controls.Add(this.txtOutPri1);
            this.grpOutput.Controls.Add(this.txtOutInt1);
            this.grpOutput.Controls.Add(this.txtOutMonthly);
            this.grpOutput.Controls.Add(this.txtOutLoan);
            this.grpOutput.Controls.Add(this.lblOutTotal);
            this.grpOutput.Controls.Add(this.lblOutTotalInt);
            this.grpOutput.Controls.Add(this.lblOutPri1);
            this.grpOutput.Controls.Add(this.lblOutInt1);
            this.grpOutput.Controls.Add(this.lblOutMonthly);
            this.grpOutput.Controls.Add(this.lblOutLoan);
            this.grpOutput.Location = new System.Drawing.Point(546, 28);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpOutput.Size = new System.Drawing.Size(416, 435);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "輸出資料";
            // 
            // txtOutTotal
            // 
            this.txtOutTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOutTotal.Location = new System.Drawing.Point(225, 360);
            this.txtOutTotal.Name = "txtOutTotal";
            this.txtOutTotal.Size = new System.Drawing.Size(140, 20);
            this.txtOutTotal.TabIndex = 11;
            this.txtOutTotal.Text = " ";
            // 
            // txtOutTotalInt
            // 
            this.txtOutTotalInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOutTotalInt.Location = new System.Drawing.Point(225, 296);
            this.txtOutTotalInt.Name = "txtOutTotalInt";
            this.txtOutTotalInt.Size = new System.Drawing.Size(140, 20);
            this.txtOutTotalInt.TabIndex = 10;
            this.txtOutTotalInt.Text = " ";
            // 
            // txtOutPri1
            // 
            this.txtOutPri1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOutPri1.Location = new System.Drawing.Point(225, 231);
            this.txtOutPri1.Name = "txtOutPri1";
            this.txtOutPri1.Size = new System.Drawing.Size(140, 20);
            this.txtOutPri1.TabIndex = 9;
            this.txtOutPri1.Text = " ";
            // 
            // txtOutInt1
            // 
            this.txtOutInt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOutInt1.Location = new System.Drawing.Point(225, 167);
            this.txtOutInt1.Name = "txtOutInt1";
            this.txtOutInt1.Size = new System.Drawing.Size(140, 20);
            this.txtOutInt1.TabIndex = 8;
            this.txtOutInt1.Text = " ";
            // 
            // txtOutMonthly
            // 
            this.txtOutMonthly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOutMonthly.Location = new System.Drawing.Point(225, 103);
            this.txtOutMonthly.Name = "txtOutMonthly";
            this.txtOutMonthly.Size = new System.Drawing.Size(140, 20);
            this.txtOutMonthly.TabIndex = 7;
            this.txtOutMonthly.Text = " ";
            // 
            // txtOutLoan
            // 
            this.txtOutLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOutLoan.Location = new System.Drawing.Point(225, 39);
            this.txtOutLoan.Name = "txtOutLoan";
            this.txtOutLoan.Size = new System.Drawing.Size(140, 20);
            this.txtOutLoan.TabIndex = 6;
            this.txtOutLoan.Text = " ";
            // 
            // lblOutTotal
            // 
            this.lblOutTotal.AutoSize = true;
            this.lblOutTotal.Location = new System.Drawing.Point(110, 360);
            this.lblOutTotal.Name = "lblOutTotal";
            this.lblOutTotal.Size = new System.Drawing.Size(109, 20);
            this.lblOutTotal.TabIndex = 5;
            this.lblOutTotal.Text = "總還款金額";
            // 
            // lblOutTotalInt
            // 
            this.lblOutTotalInt.AutoSize = true;
            this.lblOutTotalInt.Location = new System.Drawing.Point(110, 296);
            this.lblOutTotalInt.Name = "lblOutTotalInt";
            this.lblOutTotalInt.Size = new System.Drawing.Size(109, 20);
            this.lblOutTotalInt.TabIndex = 4;
            this.lblOutTotalInt.Text = "總利息支出";
            // 
            // lblOutPri1
            // 
            this.lblOutPri1.AutoSize = true;
            this.lblOutPri1.Location = new System.Drawing.Point(130, 231);
            this.lblOutPri1.Name = "lblOutPri1";
            this.lblOutPri1.Size = new System.Drawing.Size(89, 20);
            this.lblOutPri1.TabIndex = 3;
            this.lblOutPri1.Text = "首期本金";
            // 
            // lblOutInt1
            // 
            this.lblOutInt1.AutoSize = true;
            this.lblOutInt1.Location = new System.Drawing.Point(130, 167);
            this.lblOutInt1.Name = "lblOutInt1";
            this.lblOutInt1.Size = new System.Drawing.Size(89, 20);
            this.lblOutInt1.TabIndex = 2;
            this.lblOutInt1.Text = "首期利息";
            // 
            // lblOutMonthly
            // 
            this.lblOutMonthly.AutoSize = true;
            this.lblOutMonthly.Location = new System.Drawing.Point(20, 103);
            this.lblOutMonthly.Name = "lblOutMonthly";
            this.lblOutMonthly.Size = new System.Drawing.Size(199, 20);
            this.lblOutMonthly.TabIndex = 1;
            this.lblOutMonthly.Text = "每月應繳金額(本+息)";
            // 
            // lblOutLoan
            // 
            this.lblOutLoan.AutoSize = true;
            this.lblOutLoan.Location = new System.Drawing.Point(110, 39);
            this.lblOutLoan.Name = "lblOutLoan";
            this.lblOutLoan.Size = new System.Drawing.Size(109, 20);
            this.lblOutLoan.TabIndex = 0;
            this.lblOutLoan.Text = "貸款總金額";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1000, 502);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblGrace;
        private System.Windows.Forms.TextBox txtGrace;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblOutTotalInt;
        private System.Windows.Forms.Label lblOutPri1;
        private System.Windows.Forms.Label lblOutInt1;
        private System.Windows.Forms.Label lblOutMonthly;
        private System.Windows.Forms.Label lblOutLoan;
        private System.Windows.Forms.Label lblOutTotal;
        private System.Windows.Forms.Label txtOutTotal;
        private System.Windows.Forms.Label txtOutTotalInt;
        private System.Windows.Forms.Label txtOutPri1;
        private System.Windows.Forms.Label txtOutInt1;
        private System.Windows.Forms.Label txtOutMonthly;
        private System.Windows.Forms.Label txtOutLoan;
    }
}

