namespace OnlineCafe.CreationalForms
{
    partial class SpecialCoffeeForm
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
            this.button_ConfirmOrder = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Basket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_CoffeeAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBox_CoffeeList = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Sugar = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Syrup = new System.Windows.Forms.ComboBox();
            this.radioButton_HotCoffee = new System.Windows.Forms.RadioButton();
            this.radioButton_IceCoffee = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoffeeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sugar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(429, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(41, 43);
            this.button_Close.TabIndex = 15;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_ConfirmOrder
            // 
            this.button_ConfirmOrder.Location = new System.Drawing.Point(113, 388);
            this.button_ConfirmOrder.Name = "button_ConfirmOrder";
            this.button_ConfirmOrder.Size = new System.Drawing.Size(260, 59);
            this.button_ConfirmOrder.TabIndex = 14;
            this.button_ConfirmOrder.Text = "Замовити";
            this.button_ConfirmOrder.UseVisualStyleBackColor = true;
            this.button_ConfirmOrder.Click += new System.EventHandler(this.button_ConfirmOrder_Click);
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(4, 467);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(230, 60);
            this.button_Menu.TabIndex = 13;
            this.button_Menu.Text = "Перейти до меню";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // button_Basket
            // 
            this.button_Basket.Location = new System.Drawing.Point(240, 467);
            this.button_Basket.Name = "button_Basket";
            this.button_Basket.Size = new System.Drawing.Size(230, 60);
            this.button_Basket.TabIndex = 12;
            this.button_Basket.Text = "Перейти в кошик";
            this.button_Basket.UseVisualStyleBackColor = true;
            this.button_Basket.Click += new System.EventHandler(this.button_Basket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Позиції в замовленні:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Особлива кава сезону";
            // 
            // numericUpDown_CoffeeAmount
            // 
            this.numericUpDown_CoffeeAmount.Location = new System.Drawing.Point(171, 346);
            this.numericUpDown_CoffeeAmount.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown_CoffeeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CoffeeAmount.Name = "numericUpDown_CoffeeAmount";
            this.numericUpDown_CoffeeAmount.Size = new System.Drawing.Size(150, 34);
            this.numericUpDown_CoffeeAmount.TabIndex = 9;
            this.numericUpDown_CoffeeAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_CoffeeList
            // 
            this.comboBox_CoffeeList.DisplayMember = "1";
            this.comboBox_CoffeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CoffeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_CoffeeList.FormattingEnabled = true;
            this.comboBox_CoffeeList.Location = new System.Drawing.Point(86, 96);
            this.comboBox_CoffeeList.Name = "comboBox_CoffeeList";
            this.comboBox_CoffeeList.Size = new System.Drawing.Size(287, 33);
            this.comboBox_CoffeeList.TabIndex = 8;
            this.comboBox_CoffeeList.ValueMember = "1";
            // 
            // numericUpDown_Sugar
            // 
            this.numericUpDown_Sugar.Location = new System.Drawing.Point(58, 201);
            this.numericUpDown_Sugar.Name = "numericUpDown_Sugar";
            this.numericUpDown_Sugar.Size = new System.Drawing.Size(150, 34);
            this.numericUpDown_Sugar.TabIndex = 16;
            // 
            // comboBox_Syrup
            // 
            this.comboBox_Syrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Syrup.FormattingEnabled = true;
            this.comboBox_Syrup.Items.AddRange(new object[] {
            "Без сиропу",
            "Карамельний",
            "Ванільний",
            "Фісташковий",
            "М\'ятний",
            "Шоколадний"});
            this.comboBox_Syrup.Location = new System.Drawing.Point(274, 198);
            this.comboBox_Syrup.Name = "comboBox_Syrup";
            this.comboBox_Syrup.Size = new System.Drawing.Size(151, 37);
            this.comboBox_Syrup.TabIndex = 17;
            // 
            // radioButton_HotCoffee
            // 
            this.radioButton_HotCoffee.AutoSize = true;
            this.radioButton_HotCoffee.Location = new System.Drawing.Point(274, 260);
            this.radioButton_HotCoffee.Name = "radioButton_HotCoffee";
            this.radioButton_HotCoffee.Size = new System.Drawing.Size(189, 33);
            this.radioButton_HotCoffee.TabIndex = 18;
            this.radioButton_HotCoffee.Text = "Холодна кава";
            this.radioButton_HotCoffee.UseVisualStyleBackColor = true;
            // 
            // radioButton_IceCoffee
            // 
            this.radioButton_IceCoffee.AutoSize = true;
            this.radioButton_IceCoffee.Checked = true;
            this.radioButton_IceCoffee.Location = new System.Drawing.Point(58, 260);
            this.radioButton_IceCoffee.Name = "radioButton_IceCoffee";
            this.radioButton_IceCoffee.Size = new System.Drawing.Size(172, 33);
            this.radioButton_IceCoffee.TabIndex = 19;
            this.radioButton_IceCoffee.TabStop = true;
            this.radioButton_IceCoffee.Text = "Гаряча кава";
            this.radioButton_IceCoffee.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Кількість цукру";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Сиропи";
            // 
            // SpecialCoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_IceCoffee);
            this.Controls.Add(this.radioButton_HotCoffee);
            this.Controls.Add(this.comboBox_Syrup);
            this.Controls.Add(this.numericUpDown_Sugar);
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
            this.Name = "SpecialCoffeeForm";
            this.Text = "SpecialCoffeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoffeeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Close;
        private Button button_ConfirmOrder;
        private Button button_Menu;
        private Button button_Basket;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown_CoffeeAmount;
        private ComboBox comboBox_CoffeeList;
        private NumericUpDown numericUpDown_Sugar;
        private ComboBox comboBox_Syrup;
        private RadioButton radioButton_HotCoffee;
        private RadioButton radioButton_IceCoffee;
        private Label label3;
        private Label label4;
    }
}