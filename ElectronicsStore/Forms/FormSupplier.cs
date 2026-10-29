using ElectronicsStore.Entities;
using ElectronicsStore.Repositories;

namespace ElectronicsStore.Forms;

public partial class FormSupplier : Form
{
    private readonly ISupplierRepository _supplierRepository;

    private int? _supplierId;

    public int Id
    {
        set
        {
            try
            {
                var supplier = _supplierRepository.ReadSupplierById(value);
                if (supplier == null)
                {
                    throw new InvalidDataException(nameof(supplier));
                }

                textBoxName.Text = supplier.Name;
                textBoxContactPerson.Text = supplier.ContactPerson;
                textBoxPhone.Text = supplier.Phone;
                _supplierId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormSupplier(ISupplierRepository supplierRepository)
    {
        InitializeComponent();
        _supplierRepository = supplierRepository ?? throw new ArgumentNullException(nameof(supplierRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxContactPerson.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_supplierId.HasValue)
            {
                _supplierRepository.UpdateSupplier(CreateSupplier(_supplierId.Value));
            }
            else
            {
                _supplierRepository.CreateSupplier(CreateSupplier(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Supplier CreateSupplier(int id) =>
        Supplier.CreateEntity(id, textBoxName.Text, textBoxContactPerson.Text, textBoxPhone.Text);
}
