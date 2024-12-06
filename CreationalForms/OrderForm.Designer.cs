namespace OnlineCafe.CreationalForms
{
    partial class OrderForm
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
            this.comboBox_CoffeeList = new System.Windows.Forms.ComboBox();
            this.numericUpDown_CoffeeAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Basket = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_ConfirmOrder = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoffeeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_CoffeeList
            // 
            this.comboBox_CoffeeList.DisplayMember = "1";
            this.comboBox_CoffeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CoffeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_CoffeeList.FormattingEnabled = true;
            this.comboBox_CoffeeList.Location = new System.Drawing.Point(73, 109);
            this.comboBox_CoffeeList.Name = "comboBox_CoffeeList";
            this.comboBox_CoffeeList.Size = new System.Drawing.Size(287, 33);
            this.comboBox_CoffeeList.TabIndex = 0;
            this.comboBox_CoffeeList.ValueMember = "1";
            // 
            // numericUpDown_CoffeeAmount
            // 
            this.numericUpDown_CoffeeAmount.Location = new System.Drawing.Point(146, 201);
            this.numericUpDown_CoffeeAmount.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown_CoffeeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CoffeeAmount.Name = "numericUpDown_CoffeeAmount";
            this.numericUpDown_CoffeeAmount.Size = new System.Drawing.Size(150, 34);
            this.numericUpDown_CoffeeAmount.TabIndex = 1;
            this.numericUpDown_CoffeeAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оберіть каву:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість";
            // 
            // button_Basket
            // 
            this.button_Basket.Location = new System.Drawing.Point(84, 417);
            this.button_Basket.Name = "button_Basket";
            this.button_Basket.Size = new System.Drawing.Size(260, 59);
            this.button_Basket.TabIndex = 4;
            this.button_Basket.Text = "Перейти в кошик";
            this.button_Basket.UseVisualStyleBackColor = true;
            this.button_Basket.Click += new System.EventHandler(this.button_Basket_Click);
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(84, 333);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(260, 59);
            this.button_Menu.TabIndex = 5;
            this.button_Menu.Text = "Перейти до меню";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // button_ConfirmOrder
            // 
            this.button_ConfirmOrder.Location = new System.Drawing.Point(84, 255);
            this.button_ConfirmOrder.Name = "button_ConfirmOrder";
            this.button_ConfirmOrder.Size = new System.Drawing.Size(260, 59);
            this.button_ConfirmOrder.TabIndex = 6;
            this.button_ConfirmOrder.Text = "Замовити";
            this.button_ConfirmOrder.UseVisualStyleBackColor = true;
            this.button_ConfirmOrder.Click += new System.EventHandler(this.button_ConfirmOrder_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(429, 24);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(41, 43);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_ConfirmOrder);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.button_Basket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_CoffeeAmount);
            this.Controls.Add(this.comboBox_CoffeeList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrderForm";
            this.Text = "OrderCoffee";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoffeeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_CoffeeList;
        private NumericUpDown numericUpDown_CoffeeAmount;
        private Label label1;
        private Label label2;
        private Button button_Basket;
        private Button button_Menu;
        private Button button_ConfirmOrder;
        private Button button_Close;
    }
}