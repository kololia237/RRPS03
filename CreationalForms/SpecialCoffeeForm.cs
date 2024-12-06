using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OnlineCafe.CreationalPatterns.AbstractFactory;
using OnlineCafe.CreationalPatterns.Builder;


namespace OnlineCafe.CreationalForms
{
    public partial class SpecialCoffeeForm : Form
    {
        Dictionary<string, int[]> dictOrder = new Dictionary<string, int[]>();

        string str = "";
        public SpecialCoffeeForm()
        {
            InitializeComponent();
            ICoffee espressoCoffee = new Espresso();
            Client espresso = new Client(espressoCoffee);
            comboBox_CoffeeList.Items.Add(espresso.NoCofeinDetails());
            comboBox_CoffeeList.Items.Add(espresso.WithCofeinDetails());

            ICoffee amerikanoCoffe = new Amerikano();
            Client amerikano = new Client(amerikanoCoffe);
            comboBox_CoffeeList.Items.Add(amerikano.NoCofeinDetails());
            comboBox_CoffeeList.Items.Add(amerikano.WithCofeinDetails());

            ICoffee cappucinoCoffe = new Cappuccino();
            Client cappucino = new Client(cappucinoCoffe);
            comboBox_CoffeeList.Items.Add(cappucino.NoCofeinDetails());
            comboBox_CoffeeList.Items.Add(cappucino.WithCofeinDetails());

            ICoffee lateCoffe = new Late();
            Client late = new Client(lateCoffe);
            comboBox_CoffeeList.Items.Add(late.NoCofeinDetails());
            comboBox_CoffeeList.Items.Add(late.WithCofeinDetails());

            comboBox_CoffeeList.SelectedIndex = 0;
            comboBox_Syrup.SelectedIndex = 0;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void button_Basket_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket(dictOrder);
            this.Hide();
            basket.Show();
        }

        private void button_ConfirmOrder_Click(object sender, EventArgs e)
        {
            string or = comboBox_CoffeeList.Text;
            int pr = 0;
            Regex regex_price = new Regex(@"\d{2}");
            MatchCollection matches = regex_price.Matches(comboBox_CoffeeList.Text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    pr = Convert.ToInt32(match.Value);
                    or = or.Replace(match.Value, "");
                }


            }
            else
            {
                MessageBox.Show("не знайдено");
            }

            int sugar = Convert.ToInt32(numericUpDown_Sugar.Value);
            string syrup = comboBox_Syrup.Text;
            bool ice;
            if (radioButton_HotCoffee.Checked == true)
            {
                ice = false;
            }
            else ice = false;
            var specialcoffee = new CoffeeCreator(new YourCoffee());

            //Builder
            str += $"{comboBox_CoffeeList.Text} + Кількість: {numericUpDown_CoffeeAmount.Value}\n{specialcoffee.CreateCoffee(sugar, syrup, ice)}\n\n";
            string st = $"{comboBox_CoffeeList.Text} \n{specialcoffee.CreateCoffee(sugar, syrup, ice)}\n\n";
            dictOrder.Add(st, new int[2] { pr, Convert.ToInt32(numericUpDown_CoffeeAmount.Value) });

            DialogResult d;
            d = MessageBox.Show($"{str}\nПродовжити замовлення?", "Ваше замовлення", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                comboBox_CoffeeList.SelectedIndex = 0;
            }
            else
            {
                Basket basket = new Basket(dictOrder);
                this.Hide();
                basket.Show();
            }
        }

    }
}
