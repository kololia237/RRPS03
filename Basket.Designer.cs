namespace OnlineCafe.CreationalForms
{
    partial class Basket
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
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_TakeAway = new System.Windows.Forms.RadioButton();
            this.radioButton_EatIn = new System.Windows.Forms.RadioButton();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.textBox_YourOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(429, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(41, 43);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Оберіть вид замовлення";
            // 
            // radioButton_TakeAway
            // 
            this.radioButton_TakeAway.AutoSize = true;
            this.radioButton_TakeAway.Location = new System.Drawing.Point(8, 274);
            this.radioButton_TakeAway.Name = "radioButton_TakeAway";
            this.radioButton_TakeAway.Size = new System.Drawing.Size(172, 33);
            this.radioButton_TakeAway.TabIndex = 10;
            this.radioButton_TakeAway.Text = "Їжа з собою";
            this.radioButton_TakeAway.UseVisualStyleBackColor = true;
            // 
            // radioButton_EatIn
            // 
            this.radioButton_EatIn.AutoSize = true;
            this.radioButton_EatIn.Checked = true;
            this.radioButton_EatIn.Location = new System.Drawing.Point(186, 274);
            this.radioButton_EatIn.Name = "radioButton_EatIn";
            this.radioButton_EatIn.Size = new System.Drawing.Size(284, 33);
            this.radioButton_EatIn.TabIndex = 11;
            this.radioButton_EatIn.TabStop = true;
            this.radioButton_EatIn.Text = "Залишитися в закладі";
            this.radioButton_EatIn.UseVisualStyleBackColor = true;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(141, 463);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(201, 78);
            this.button_Confirm.TabIndex = 12;
            this.button_Confirm.Text = "Підтвердити";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // textBox_YourOrder
            // 
            this.textBox_YourOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_YourOrder.Location = new System.Drawing.Point(26, 55);
            this.textBox_YourOrder.Multiline = true;
            this.textBox_YourOrder.Name = "textBox_YourOrder";
            this.textBox_YourOrder.ReadOnly = true;
            this.textBox_YourOrder.Size = new System.Drawing.Size(444, 159);
            this.textBox_YourOrder.TabIndex = 13;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.textBox_YourOrder);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.radioButton_EatIn);
            this.Controls.Add(this.radioButton_TakeAway);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Basket";
            this.Text = "Basket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Close;
        private Label label1;
        private RadioButton radioButton_TakeAway;
        private RadioButton radioButton_EatIn;
        private Button button_Confirm;
        private TextBox textBox_YourOrder;
    }
}