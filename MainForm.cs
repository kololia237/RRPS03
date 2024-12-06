using OnlineCafe.BehavioralPatterns.Mediator;
using OnlineCafe.CreationalForms;
using OnlineCafe.StructuralForms;

namespace OnlineCafe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_SpecialCoffee_Click(object sender, EventArgs e)
        {
            SpecialCoffeeForm specialCoffee = new SpecialCoffeeForm();
            this.Hide();
            specialCoffee.Show();
        }

        private void button_OrderCoffee_Click(object sender, EventArgs e)
        {
            OrderForm orderCooffee = new OrderForm();
            this.Hide();
            orderCooffee.Show();

        }

        private void button_OrderCake_Click(object sender, EventArgs e)
        {
            CakesForm cakesForm = new CakesForm();
            this.Hide();
            cakesForm.Show();
        }

        private void button_AdditionalService_Click(object sender, EventArgs e)
        {
            BorrowItemForm bif=new BorrowItemForm();
            this.Hide();
            bif.Show();
        }

        private void button_ChatRoom_Click(object sender, EventArgs e)
        {
            Chatroom chatroom = new Chatroom();

            // Create participants and register them

            Participant Manager = new User("Анна");
            Participant Client = new User("Юлія");

            chatroom.Register(Manager);
            chatroom.Register(Client);

            // Chatting participants
            Manager.Send(Client.Name, "Добрий день. Чим можемо допомогти?");
            Client.Send(Manager.Name, "Маю одне прохання.");
            Client.Send(Manager.Name, "Чи не могли б ви відмінити моє замовлення?");
        }
    }
}