using ElectronicsStore.Entities;
using ElectronicsStore.Repositories;

namespace ElectronicsStore.Forms;

public partial class FormCustomer : Form
{
    private readonly ICustomerRepository _customerRepository;

    private int? _customerId;

    public int Id
    {
        set
        {
            try
            {
                var customer = _customerRepository.ReadCustomerById(value);
                if (customer == null)
                {
                    throw new InvalidDataException(nameof(customer));
                }

                textBoxFullName.Text = customer.FullName;
                textBoxPhone.Text = customer.Phone;
                textBoxEmail.Text = customer.Email;
                _customerId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormCustomer(ICustomerRepository customerRepository)
    {
        InitializeComponent();
        _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_customerId.HasValue)
            {
                _customerRepository.UpdateCustomer(CreateCustomer(_customerId.Value));
            }
            else
            {
                _customerRepository.CreateCustomer(CreateCustomer(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Customer CreateCustomer(int id) =>
        Customer.CreateEntity(id, textBoxFullName.Text, textBoxPhone.Text, textBoxEmail.Text);
}
