
namespace Lab1Dll
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCreditAmount = new System.Windows.Forms.TextBox();
            this.labelCreditAmount = new System.Windows.Forms.Label();
            this.textBoxCreditDuration = new System.Windows.Forms.TextBox();
            this.labelCreditDuration = new System.Windows.Forms.Label();
            this.labelMonthPayment = new System.Windows.Forms.Label();
            this.textBoxMonthPayment = new System.Windows.Forms.TextBox();
            this.labelAccountList = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxAccountList = new System.Windows.Forms.TextBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxUpDown = new System.Windows.Forms.TextBox();
            this.buttonReplenish = new System.Windows.Forms.Button();
            this.buttonDeduce = new System.Windows.Forms.Button();
            this.buttonMonthPayment = new System.Windows.Forms.Button();
            this.labelAccountNum = new System.Windows.Forms.Label();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФИО клиента:";
            // 
            // textBoxCreditAmount
            // 
            this.textBoxCreditAmount.Location = new System.Drawing.Point(12, 93);
            this.textBoxCreditAmount.Name = "textBoxCreditAmount";
            this.textBoxCreditAmount.Size = new System.Drawing.Size(125, 27);
            this.textBoxCreditAmount.TabIndex = 2;
            this.textBoxCreditAmount.Text = "100000";
            this.textBoxCreditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCreditAmount_KeyPress);
            // 
            // labelCreditAmount
            // 
            this.labelCreditAmount.AutoSize = true;
            this.labelCreditAmount.Location = new System.Drawing.Point(12, 70);
            this.labelCreditAmount.Name = "labelCreditAmount";
            this.labelCreditAmount.Size = new System.Drawing.Size(117, 20);
            this.labelCreditAmount.TabIndex = 3;
            this.labelCreditAmount.Text = "Сумма кредита:";
            // 
            // textBoxCreditDuration
            // 
            this.textBoxCreditDuration.Location = new System.Drawing.Point(12, 176);
            this.textBoxCreditDuration.Name = "textBoxCreditDuration";
            this.textBoxCreditDuration.Size = new System.Drawing.Size(125, 27);
            this.textBoxCreditDuration.TabIndex = 4;
            this.textBoxCreditDuration.Text = "5";
            this.textBoxCreditDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCreditDuration_KeyPress);
            // 
            // labelCreditDuration
            // 
            this.labelCreditDuration.Location = new System.Drawing.Point(12, 132);
            this.labelCreditDuration.Name = "labelCreditDuration";
            this.labelCreditDuration.Size = new System.Drawing.Size(156, 41);
            this.labelCreditDuration.TabIndex = 5;
            this.labelCreditDuration.Text = "Продолжительность кредита:";
            // 
            // labelMonthPayment
            // 
            this.labelMonthPayment.AutoSize = true;
            this.labelMonthPayment.Location = new System.Drawing.Point(12, 215);
            this.labelMonthPayment.Name = "labelMonthPayment";
            this.labelMonthPayment.Size = new System.Drawing.Size(139, 20);
            this.labelMonthPayment.TabIndex = 6;
            this.labelMonthPayment.Text = "Месячный платёж:";
            // 
            // textBoxMonthPayment
            // 
            this.textBoxMonthPayment.Location = new System.Drawing.Point(12, 238);
            this.textBoxMonthPayment.Name = "textBoxMonthPayment";
            this.textBoxMonthPayment.Size = new System.Drawing.Size(125, 27);
            this.textBoxMonthPayment.TabIndex = 7;
            this.textBoxMonthPayment.Text = "20000";
            this.textBoxMonthPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonthPayment_KeyPress);
            // 
            // labelAccountList
            // 
            this.labelAccountList.AutoSize = true;
            this.labelAccountList.Location = new System.Drawing.Point(12, 277);
            this.labelAccountList.Name = "labelAccountList";
            this.labelAccountList.Size = new System.Drawing.Size(112, 20);
            this.labelAccountList.TabIndex = 9;
            this.labelAccountList.Text = "Список счетов:";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.textBoxAccountList);
            this.panelData.Controls.Add(this.textBoxName);
            this.panelData.Controls.Add(this.labelName);
            this.panelData.Controls.Add(this.textBoxCreditAmount);
            this.panelData.Controls.Add(this.labelCreditAmount);
            this.panelData.Controls.Add(this.textBoxCreditDuration);
            this.panelData.Controls.Add(this.labelCreditDuration);
            this.panelData.Controls.Add(this.labelMonthPayment);
            this.panelData.Controls.Add(this.textBoxMonthPayment);
            this.panelData.Controls.Add(this.labelAccountList);
            this.panelData.Location = new System.Drawing.Point(3, 3);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(169, 417);
            this.panelData.TabIndex = 10;
            // 
            // textBoxAccountList
            // 
            this.textBoxAccountList.Location = new System.Drawing.Point(12, 300);
            this.textBoxAccountList.Multiline = true;
            this.textBoxAccountList.Name = "textBoxAccountList";
            this.textBoxAccountList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAccountList.Size = new System.Drawing.Size(125, 111);
            this.textBoxAccountList.TabIndex = 10;
            this.textBoxAccountList.Text = "20000";
            this.textBoxAccountList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAccountList_KeyPress);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(698, 426);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownAmount.TabIndex = 12;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(3, 426);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(137, 60);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Создать нового клиента";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(178, 2);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(619, 418);
            this.textBoxOutput.TabIndex = 11;
            // 
            // textBoxUpDown
            // 
            this.textBoxUpDown.Location = new System.Drawing.Point(698, 459);
            this.textBoxUpDown.Name = "textBoxUpDown";
            this.textBoxUpDown.Size = new System.Drawing.Size(99, 27);
            this.textBoxUpDown.TabIndex = 11;
            this.textBoxUpDown.Text = "400";
            this.textBoxUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUpDown_KeyPress);
            // 
            // buttonReplenish
            // 
            this.buttonReplenish.Location = new System.Drawing.Point(146, 426);
            this.buttonReplenish.Name = "buttonReplenish";
            this.buttonReplenish.Size = new System.Drawing.Size(137, 60);
            this.buttonReplenish.TabIndex = 13;
            this.buttonReplenish.Text = "Пополнить счёт";
            this.buttonReplenish.UseVisualStyleBackColor = true;
            this.buttonReplenish.Click += new System.EventHandler(this.buttonReplenish_Click);
            // 
            // buttonDeduce
            // 
            this.buttonDeduce.Location = new System.Drawing.Point(289, 426);
            this.buttonDeduce.Name = "buttonDeduce";
            this.buttonDeduce.Size = new System.Drawing.Size(137, 60);
            this.buttonDeduce.TabIndex = 14;
            this.buttonDeduce.Text = "Списать с счёта";
            this.buttonDeduce.UseVisualStyleBackColor = true;
            this.buttonDeduce.Click += new System.EventHandler(this.buttonDeduce_Click);
            // 
            // buttonMonthPayment
            // 
            this.buttonMonthPayment.Location = new System.Drawing.Point(432, 426);
            this.buttonMonthPayment.Name = "buttonMonthPayment";
            this.buttonMonthPayment.Size = new System.Drawing.Size(160, 60);
            this.buttonMonthPayment.TabIndex = 15;
            this.buttonMonthPayment.Text = "Списать месячный платёж";
            this.buttonMonthPayment.UseVisualStyleBackColor = true;
            this.buttonMonthPayment.Click += new System.EventHandler(this.buttonMonthPayment_Click);
            // 
            // labelAccountNum
            // 
            this.labelAccountNum.AutoSize = true;
            this.labelAccountNum.Location = new System.Drawing.Point(598, 428);
            this.labelAccountNum.Name = "labelAccountNum";
            this.labelAccountNum.Size = new System.Drawing.Size(101, 20);
            this.labelAccountNum.TabIndex = 16;
            this.labelAccountNum.Text = "Номер счёта:";
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Location = new System.Drawing.Point(598, 459);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(58, 20);
            this.labelPaymentAmount.TabIndex = 17;
            this.labelPaymentAmount.Text = "Сумма:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.labelPaymentAmount);
            this.Controls.Add(this.labelAccountNum);
            this.Controls.Add(this.buttonMonthPayment);
            this.Controls.Add(this.buttonDeduce);
            this.Controls.Add(this.buttonReplenish);
            this.Controls.Add(this.textBoxUpDown);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelData);
            this.Name = "FormMain";
            this.Text = "FinTech";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCreditAmount;
        private System.Windows.Forms.Label labelCreditAmount;
        private System.Windows.Forms.TextBox textBoxCreditDuration;
        private System.Windows.Forms.Label labelCreditDuration;
        private System.Windows.Forms.Label labelMonthPayment;
        private System.Windows.Forms.TextBox textBoxMonthPayment;
        private System.Windows.Forms.Label labelAccountList;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxAccountList;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.TextBox textBoxUpDown;
        private System.Windows.Forms.Button buttonReplenish;
        private System.Windows.Forms.Button buttonDeduce;
        private System.Windows.Forms.Button buttonMonthPayment;
        private System.Windows.Forms.Label labelAccountNum;
        private System.Windows.Forms.Label labelPaymentAmount;
    }
}

