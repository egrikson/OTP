using ElectronicsStore.Repositories;
using Unity;

namespace ElectronicsStore.Forms;

public partial class FormSupplies : Form
{
    private readonly IUnityContainer _container;

    private readonly ISupplyRepository _supplyRepository;

    public FormSupplies(IUnityContainer container, ISupplyRepository supplyRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _supplyRepository = supplyRepository ?? throw new ArgumentNullException(nameof(supplyRepository));
    }

    private void FormSupplies_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormSupply>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _supplyRepository.ReadSupplies();
}
