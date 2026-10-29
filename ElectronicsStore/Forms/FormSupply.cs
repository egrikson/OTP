using ElectronicsStore.Entities;
using ElectronicsStore.Repositories;

namespace ElectronicsStore.Forms;

public partial class FormSupply : Form
{
    private readonly ISupplyRepository _supplyRepository;

    public FormSupply(ISupplyRepository supplyRepository, ISupplierRepository supplierRepository,
        IProductRepository productRepository)
    {
        InitializeComponent();
        _supplyRepository = supplyRepository ?? throw new ArgumentNullException(nameof(supplyRepository));
        ArgumentNullException.ThrowIfNull(supplierRepository);
        ArgumentNullException.ThrowIfNull(productRepository);

        comboBoxSupplier.DataSource = supplierRepository.ReadSuppliers();
        comboBoxSupplier.DisplayMember = "Name";
        comboBoxSupplier.ValueMember = "Id";

        comboBoxProduct.DataSource = productRepository.ReadProducts();
        comboBoxProduct.DisplayMember = "Name";
        comboBoxProduct.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxSupplier.SelectedIndex < 0 ||
                comboBoxProduct.SelectedIndex < 0 ||
                numericUpDownPurchasePrice.Value <= 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _supplyRepository.CreateSupply(Supply.CreateOperation(0,
                (int)comboBoxSupplier.SelectedValue!,
                (int)comboBoxProduct.SelectedValue!,
                Convert.ToInt32(numericUpDownCount.Value),
                numericUpDownPurchasePrice.Value));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
