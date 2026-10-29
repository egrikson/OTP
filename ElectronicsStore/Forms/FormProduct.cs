using ElectronicsStore.Entities;
using ElectronicsStore.Entities.Enums;
using ElectronicsStore.Repositories;

namespace ElectronicsStore.Forms;

public partial class FormProduct : Form
{
    private readonly IProductRepository _productRepository;

    private int? _productId;

    public int Id
    {
        set
        {
            try
            {
                var product = _productRepository.ReadProductById(value);
                if (product == null)
                {
                    throw new InvalidDataException(nameof(product));
                }

                textBoxName.Text = product.Name;
                textBoxManufacturer.Text = product.Manufacturer;
                comboBoxCategory.SelectedItem = product.Category;
                foreach (ProductFeatures feature in Enum.GetValues(typeof(ProductFeatures)))
                {
                    if ((feature & product.Features) != 0)
                    {
                        checkedListBoxFeatures.SetItemChecked(checkedListBoxFeatures.Items.IndexOf(feature), true);
                    }
                }

                numericUpDownPrice.Value = product.Price;
                _productId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormProduct(IProductRepository productRepository)
    {
        InitializeComponent();
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));

        comboBoxCategory.DataSource = Enum.GetValues(typeof(ProductCategory));
        foreach (ProductFeatures feature in Enum.GetValues(typeof(ProductFeatures)))
        {
            if (feature != ProductFeatures.None)
            {
                checkedListBoxFeatures.Items.Add(feature);
            }
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxManufacturer.Text) ||
                comboBoxCategory.SelectedIndex < 1 ||
                numericUpDownPrice.Value <= 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_productId.HasValue)
            {
                _productRepository.UpdateProduct(CreateProduct(_productId.Value));
            }
            else
            {
                _productRepository.CreateProduct(CreateProduct(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Product CreateProduct(int id)
    {
        var features = ProductFeatures.None;
        foreach (var feature in checkedListBoxFeatures.CheckedItems)
        {
            features |= (ProductFeatures)feature;
        }

        return Product.CreateEntity(id, textBoxName.Text, textBoxManufacturer.Text,
            (ProductCategory)comboBoxCategory.SelectedItem!, features, numericUpDownPrice.Value);
    }
}
