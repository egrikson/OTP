using ElectronicsStore.Entities;
using ElectronicsStore.Entities.Enums;
using ElectronicsStore.Repositories;

namespace ElectronicsStore.Forms;

public partial class FormOrder : Form
{
    private readonly IOrderRepository _orderRepository;

    private readonly List<Product> _products;

    public FormOrder(IOrderRepository orderRepository, ICustomerRepository customerRepository,
        IProductRepository productRepository)
    {
        InitializeComponent();
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        ArgumentNullException.ThrowIfNull(customerRepository);
        ArgumentNullException.ThrowIfNull(productRepository);

        comboBoxCustomer.DataSource = customerRepository.ReadCustomers();
        comboBoxCustomer.DisplayMember = "FullName";
        comboBoxCustomer.ValueMember = "Id";

        comboBoxDeliveryType.DataSource = Enum.GetValues(typeof(DeliveryType));

        _products = productRepository.ReadProducts().ToList();
        ColumnProduct.DataSource = _products;
        ColumnProduct.DisplayMember = "Name";
        ColumnProduct.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            var orderItems = CreateListOrderItemsFromDataGrid();
            if (orderItems.Count == 0 ||
                comboBoxCustomer.SelectedIndex < 0 ||
                comboBoxDeliveryType.SelectedIndex < 1 ||
                (comboBoxDeliveryType.SelectedItem is DeliveryType.Courier &&
                    string.IsNullOrWhiteSpace(textBoxDeliveryAddress.Text)))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _orderRepository.CreateOrder(Order.CreateOperation(0,
                (int)comboBoxCustomer.SelectedValue!,
                (DeliveryType)comboBoxDeliveryType.SelectedItem!,
                textBoxDeliveryAddress.Text,
                orderItems));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private List<OrderItem> CreateListOrderItemsFromDataGrid()
    {
        var list = new List<OrderItem>();
        foreach (DataGridViewRow row in dataGridViewProducts.Rows)
        {
            if (row.Cells["ColumnProduct"].Value == null || row.Cells["ColumnCount"].Value == null)
            {
                continue;
            }

            var productId = Convert.ToInt32(row.Cells["ColumnProduct"].Value);
            list.Add(OrderItem.CreateElement(0, productId,
                Convert.ToInt32(row.Cells["ColumnCount"].Value),
                _products.First(product => product.Id == productId).Price));
        }

        return list;
    }
}
