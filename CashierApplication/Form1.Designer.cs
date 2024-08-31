namespace CashierApplication
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            DiscountInput = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            PaymentInput = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            AmountDisplay = new TextBox();
            ChangeDisplay = new TextBox();
            ComputeButt = new Button();
            SubmitButt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(356, 28);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 2;
            label3.Text = "Discount(%):";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(316, 112);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(149, 235);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 4;
            label5.Text = "Total amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 315);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 5;
            label6.Text = "Payment received:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(149, 372);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 6;
            label7.Text = "Change:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DiscountInput
            // 
            DiscountInput.Location = new Point(356, 56);
            DiscountInput.Name = "DiscountInput";
            DiscountInput.Size = new Size(154, 23);
            DiscountInput.TabIndex = 8;
            DiscountInput.TextChanged += DiscountInput_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(400, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // PaymentInput
            // 
            PaymentInput.Location = new Point(182, 317);
            PaymentInput.Name = "PaymentInput";
            PaymentInput.Size = new Size(133, 23);
            PaymentInput.TabIndex = 11;
            PaymentInput.TextChanged += PaymentInput_TextChanged;
            // 
            // AmountDisplay
            // 
            AmountDisplay.Location = new Point(281, 235);
            AmountDisplay.Name = "AmountDisplay";
            AmountDisplay.Size = new Size(133, 23);
            AmountDisplay.TabIndex = 12;
            AmountDisplay.TextChanged += AmountDisplay_TextChanged;
            // 
            // ChangeDisplay
            // 
            ChangeDisplay.Location = new Point(226, 377);
            ChangeDisplay.Name = "ChangeDisplay";
            ChangeDisplay.Size = new Size(133, 23);
            ChangeDisplay.TabIndex = 13;
            ChangeDisplay.TextChanged += ChangeDisplay_TextChanged;
            // 
            // ComputeButt
            // 
            ComputeButt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComputeButt.Location = new Point(256, 176);
            ComputeButt.Name = "ComputeButt";
            ComputeButt.Size = new Size(91, 30);
            ComputeButt.TabIndex = 14;
            ComputeButt.Text = "Compute";
            ComputeButt.UseVisualStyleBackColor = true;
            ComputeButt.Click += button1_Click;
            // 
            // SubmitButt
            // 
            SubmitButt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButt.Location = new Point(341, 313);
            SubmitButt.Name = "SubmitButt";
            SubmitButt.Size = new Size(91, 30);
            SubmitButt.TabIndex = 15;
            SubmitButt.Text = "Submit";
            SubmitButt.UseVisualStyleBackColor = true;
            SubmitButt.Click += SubmitButt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(SubmitButt);
            Controls.Add(ComputeButt);
            Controls.Add(ChangeDisplay);
            Controls.Add(AmountDisplay);
            Controls.Add(PaymentInput);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(DiscountInput);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Purchase Discounted Item";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox DiscountInput;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox PaymentInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox AmountDisplay;
        private TextBox ChangeDisplay;
        private Button ComputeButt;
        private Button SubmitButt;
    }
}