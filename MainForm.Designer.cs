namespace OnlineCafe
{
    partial class MainForm
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
            this.button_OrderCoffee = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_SpecialCoffee = new System.Windows.Forms.Button();
            this.button_OrderCake = new System.Windows.Forms.Button();
            this.button_AdditionalService = new System.Windows.Forms.Button();
            this.button_ChatRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OrderCoffee
            // 
            this.button_OrderCoffee.Location = new System.Drawing.Point(139, 36);
            this.button_OrderCoffee.Margin = new System.Windows.Forms.Padding(5);
            this.button_OrderCoffee.Name = "button_OrderCoffee";
            this.button_OrderCoffee.Size = new System.Drawing.Size(219, 87);
            this.button_OrderCoffee.TabIndex = 0;
            this.button_OrderCoffee.Text = "Замовити каву";
            this.button_OrderCoffee.UseVisualStyleBackColor = true;
            this.button_OrderCoffee.Click += new System.EventHandler(this.button_OrderCoffee_Click);
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
            // button_SpecialCoffee
            // 
            this.button_SpecialCoffee.Location = new System.Drawing.Point(139, 131);
            this.button_SpecialCoffee.Name = "button_SpecialCoffee";
            this.button_SpecialCoffee.Size = new System.Drawing.Size(219, 87);
            this.button_SpecialCoffee.TabIndex = 9;
            this.button_SpecialCoffee.Text = "Ваша кава";
            this.button_SpecialCoffee.UseVisualStyleBackColor = true;
            this.button_SpecialCoffee.Click += new System.EventHandler(this.button_SpecialCoffee_Click);
            // 
            // button_OrderCake
            // 
            this.button_OrderCake.Location = new System.Drawing.Point(139, 226);
            this.button_OrderCake.Margin = new System.Windows.Forms.Padding(5);
            this.button_OrderCake.Name = "button_OrderCake";
            this.button_OrderCake.Size = new System.Drawing.Size(219, 87);
            this.button_OrderCake.TabIndex = 10;
            this.button_OrderCake.Text = "Замовити тістечко";
            this.button_OrderCake.UseVisualStyleBackColor = true;
            this.button_OrderCake.Click += new System.EventHandler(this.button_OrderCake_Click);
            // 
            // button_AdditionalService
            // 
            this.button_AdditionalService.Location = new System.Drawing.Point(139, 321);
            this.button_AdditionalService.Name = "button_AdditionalService";
            this.button_AdditionalService.Size = new System.Drawing.Size(219, 87);
            this.button_AdditionalService.TabIndex = 11;
            this.button_AdditionalService.Text = "Додаткова послуга";
            this.button_AdditionalService.UseVisualStyleBackColor = true;
            this.button_AdditionalService.Click += new System.EventHandler(this.button_AdditionalService_Click);
            // 
            // button_ChatRoom
            // 
            this.button_ChatRoom.Location = new System.Drawing.Point(139, 414);
            this.button_ChatRoom.Name = "button_ChatRoom";
            this.button_ChatRoom.Size = new System.Drawing.Size(219, 87);
            this.button_ChatRoom.TabIndex = 12;
            this.button_ChatRoom.Text = "Зв\'язатися з менеджером";
            this.button_ChatRoom.UseVisualStyleBackColor = true;
            this.button_ChatRoom.Click += new System.EventHandler(this.button_ChatRoom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.button_ChatRoom);
            this.Controls.Add(this.button_AdditionalService);
            this.Controls.Add(this.button_OrderCake);
            this.Controls.Add(this.button_SpecialCoffee);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_OrderCoffee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_OrderCoffee;
        private Button button_Close;
        private Button button_SpecialCoffee;
        private Button button_OrderCake;
        private Button button_AdditionalService;
        private Button button_ChatRoom;
    }
}