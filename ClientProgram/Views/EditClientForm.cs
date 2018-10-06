using System;
using System.Windows.Forms;
using ClientProgram.Handlers;
using ClientProgramLib.Models;

namespace ClientProgram.Views
{
    public interface IEditClientForm
    {
        SuperEventHandler butEditClientAction { get; set; }
        Client Client { get; set; }
    }

    public partial class EditClientForm : DevExpress.XtraEditors.XtraForm, IEditClientForm
    {
        private BindingSource _bsEditClientAction = new BindingSource();
        private Client client = new Client();

        public EditClientForm()
        {
            InitializeComponent();

            SetBindings();
        }

        private void SetBindings()
        {
            _bsEditClientAction.DataSource = typeof(SuperEventHandler);
        }
        
        public int ClientCode
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtClientEditCode.Text))
                    throw new Exception("Заполните поле \"Код клиента\"");

                int num;
                if (int.TryParse(txtClientEditCode.Text, out num))
                {
                    return num;
                }
                else
                {
                    throw new Exception("Поле может содержать только числовое значение");
                }
            }
        }

        public string ClientName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(txtClientEditName.Text))
                {
                    return txtClientEditName.Text;
                }
                else
                {
                    throw new Exception("Заполните поле \"Наименование\"");
                }
            }
        }

        public string ClientCity
        {
            get => cmbEditCities.SelectedItem.ToString();
        }
        
        public Client Client
        {
            get => new Client
            {
                Client_Id = client.Client_Id,
                Client_Code = ClientCode,
                Client_Name = ClientName,
                Client_City = ClientCity
            };
            set => client = value;
        }

        public SuperEventHandler butEditClientAction
        {
            get => _bsEditClientAction.Current as SuperEventHandler;
            set
            {
                if (_bsEditClientAction.Count > 0)
                    return;
                _bsEditClientAction.Add(value);
                btnEditClientAction.Click += value.Handler;
            }
        }
    }
}