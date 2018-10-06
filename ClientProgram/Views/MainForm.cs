using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClientProgram.Handlers;
using ClientProgramLib.Models;

namespace ClientProgram.Views
{
    public interface IMainForm
    {
        SuperEventHandler butAddClient { get; set; }
        SuperEventHandler butEditClient { get; set; }
        SuperEventHandler butDeleteClient { get; set; }
        MainEventHandler inpSearchTextChange { get; set; }
        MainEventHandler loadMainForm { get; set; }
        IEnumerable<Client> DgvClientList { get; set; }
        string SeacrhField { get; set; }
        Client SelectedClient { get; }
    }

    public partial class MainForm : DevExpress.XtraEditors.XtraForm, IMainForm
    {
        private BindingSource _bsAddNewClientClick = new BindingSource();
        private BindingSource _bsEditClientClick = new BindingSource();
        private BindingSource _bsDeleteClientClick = new BindingSource();
        private BindingSource _bsChangeClient = new BindingSource();

        private MainEventHandler _inpSearchTextChange;
        private MainEventHandler _loadMainForm;

        public MainForm()
        {
            InitializeComponent();
            SetBindings();
        }

        /// <summary>
        /// Привязки
        /// </summary>
        private void SetBindings()
        {
            _bsAddNewClientClick.DataSource = typeof(SuperEventHandler);
            _bsEditClientClick.DataSource = typeof(SuperEventHandler);
            _bsDeleteClientClick.DataSource = typeof(SuperEventHandler);

            _bsChangeClient.DataSource = typeof(SuperEventHandler);
        }

        /// <summary>
        /// Получаем выделенного клиента на гриде
        /// </summary>
        public Client SelectedClient
        {
            get => new Client
            {
                Client_Id = (int)dgvClientsList.CurrentRow.Cells[0].Value,
                Client_Code = (int)dgvClientsList.CurrentRow.Cells[1].Value,
                Client_Name = (string)dgvClientsList.CurrentRow.Cells[2].Value,
                Client_City = (string)dgvClientsList.CurrentRow.Cells[3].Value
            };
        }

        /// <summary>
        /// Текст, введенный в поле поиска
        /// </summary>
        public string SeacrhField
        {
            get => txtSearch.Text;
            set => txtSearch.Text = value;
        }

        /// <summary>
        /// Набор данных с грида
        /// </summary>
        public IEnumerable<Client> DgvClientList
        {
            get => (IEnumerable<Client>)this.dgvClientsList.DataSource;
            set => this.dgvClientsList.DataSource = value;
        }

        /// <summary>
        /// Свойство для кнопки "Добавить"
        /// </summary>
        public SuperEventHandler butAddClient
        {
            get => _bsAddNewClientClick.Current as SuperEventHandler;
            set
            {
                if (_bsAddNewClientClick.Count > 0)
                    return;
                _bsAddNewClientClick.Add(value);
                btnAddNewClient.Click += value.Handler;
            }
        }

        /// <summary>
        /// Свойство для кнопки "Редактировать"
        /// </summary>
        public SuperEventHandler butEditClient
        {
            get => _bsEditClientClick.Current as SuperEventHandler;
            set
            {
                if (_bsEditClientClick.Count > 0)
                    return;
                _bsEditClientClick.Add(value);
                btnEditClient.Click += value.Handler;
            }
        }

        /// <summary>
        /// Свойство для кнопки "Удалить"
        /// </summary>
        public SuperEventHandler butDeleteClient
        {
            get => _bsDeleteClientClick.Current as SuperEventHandler;
            set
            {
                if (_bsDeleteClientClick.Count > 0)
                    return;
                _bsDeleteClientClick.Add(value);
                btnDeleteClient.Click += value.Handler;
            }
        }

        /// <summary>
        /// Свойство для поля поиска
        /// </summary>
        public MainEventHandler inpSearchTextChange
        {
            get => _inpSearchTextChange;
            set
            {
                if (_inpSearchTextChange != null)
                    return;
                _inpSearchTextChange = value;
                txtSearch.TextChanged += value.Handler;
            }
        }

        /// <summary>
        /// Свойство для загрузки формы
        /// </summary>
        public MainEventHandler loadMainForm
        {
            get => _loadMainForm;
            set
            {
                if (_loadMainForm != null)
                    return;
                _loadMainForm = value;
                this.Load += value.Handler;
            }
        }
    }
}