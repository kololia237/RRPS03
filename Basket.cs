using OnlineCafe.BehavioralPatterns.ChainOfResponsibility;
using OnlineCafe.CreationalPatterns;
using OnlineCafe.CreationalPatterns.FabricMethod;
using OnlineCafe.CreationalPatterns.Prototype;
using OnlineCafe.StructuralPatterns.Composite;
using OnlineCafe.StructuralPatterns.Facade;

namespace OnlineCafe.CreationalForms
{
    public partial class Basket : Form
    {
        OrderFactory orderFactory = null;
        Composite Sum = new Composite("Сума до сплати");
        public Basket(Dictionary<string, int[]> dictorder)
        {
            InitializeComponent();
            foreach (var order in dictorder)
            {
                textBox_YourOrder.Text += $"{order.Key} {order.Value[0]}, Кількість: {order.Value[1]}";

                IntComponent coffeeOrder = new Leaf(order.Key, order.Value[0], order.Value[1]);
                Composite coffee = new Composite("Замовлення");

                coffee.AddComponent(coffeeOrder);
                Sum.AddComponent(coffee);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void TestSingleton(string value)
        {
            FreeWorkers singleton = FreeWorkers.GetInstance(value);
            if (singleton != null)
                MessageBox.Show(singleton.Value);
        }
        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string UserOrder = textBox_YourOrder.Text;
            string emp = "";
            if (radioButton_TakeAway.Checked == true)
            {
                orderFactory = new TakeAwayFactory(1, 100);

                Courier courier = new Courier();
                courier.Name = "Олег";
                courier.Role = "Кур'єр";
                courier.TelephonNumber = "+380961234567";

                Courier courierCopy = (Courier)courier.Clone();
                courierCopy.Name = "Іван";
                courierCopy.TelephonNumber = "+380987654321";

                emp = courier.GetDetails();
                emp = courierCopy.GetDetails();
                TestSingleton("Замовлення в обробці");
            }
            else if (radioButton_EatIn.Checked == true)
            {
                orderFactory = new EatInFactory(2, 20);
                Waiter waiter = new Waiter();
                waiter.Name = "Василь";
                waiter.Role = "Офіціант";

                Waiter waiterCopy = (Waiter)waiter.Clone();
                waiterCopy.Name = "Тетяна";

                emp = waiter.GetDetails();
                emp = waiterCopy.GetDetails();
                TestSingleton("Замовлення в обробці");
            }
            if (radioButton_TakeAway.Checked == false && radioButton_EatIn.Checked == false)
            {
                MessageBox.Show("Оберіть вид замовлення!", "Не обрано", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Order order = orderFactory.GetOrderType();
            MessageBox.Show($"Вартість оформлення замовлення виду {order.Name}: {order.Price}\n" +
                $"Вас буде обслуговувати:{emp}");



            /*Approver larry = new Director();
            Approver sam = new Manager();
            Approver tammy = new Administrator();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);*/


            ConfirmOrder confirmorder = new ConfirmOrder();

            // Evaluate mortgage eligibility for customer

            Customer customer = new Customer("Анна");
            bool confirm = confirmorder.IsEligible(customer, 125000);
            MessageBox.Show($"Зомовлення клієнта {customer.Name} було {(confirm ? "Підтверджено" : "Відмовлено")}");



            MessageBox.Show(Sum.DisplayPrice().ToString(), Sum.Name);

            //Flyweight
            /*string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state

            int pointSize = 10;

            // For each character use a flyweight object

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }*/

            //Proxy
            /*Client cl1 = new Client("Петро", "pass1234", "Постійний клієнт");
            SharedPathToDB folderProxy1 = new SharedPathToDB(cl1);
            folderProxy1.PerformRWOperations();


            Client cl2 = new Client("Василь", "1234pass", "Звичайний клієнт");
            SharedPathToDB folderProxy2 = new SharedPathToDB(cl2);
            folderProxy2.PerformRWOperations();*/
        }
    }
}
