using ElectronicsStore.Forms;
using Unity;

namespace ElectronicsStore;

public partial class FormElectronicsStore : Form
{
    private readonly IUnityContainer _container;

    public FormElectronicsStore(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
    }

    private void ProductsToolStripMenuItem_Click(object sender, EventArgs e) => ShowForm<FormProducts>();

    private void CustomersToolStripMenuItem_Click(object sender, EventArgs e) => ShowForm<FormCustomers>();

    private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e) => ShowForm<FormSuppliers>();

    private void OrdersToolStripMenuItem_Click(object sender, EventArgs e) => ShowForm<FormOrders>();

    private void SuppliesToolStripMenuItem_Click(object sender, EventArgs e) => ShowForm<FormSupplies>();

    private void ShowForm<TForm>() where TForm : Form
    {
        try
        {
            _container.Resolve<TForm>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
