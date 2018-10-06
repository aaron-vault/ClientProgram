using System;
using System.Windows.Forms;
using ClientProgram.Handlers;
using ClientProgramLib.Models;

namespace ClientProgram.Views
{
    public interface IClientForm
    {
        SuperEventHandler butAddClientAction { get; set; }
        Client Client { get; }
    }

    public partial class ClientForm : DevExpress.XtraEditors.XtraForm, IClientForm
    {
        private BindingSource _bsAddClientAction = new BindingSource();

        public ClientForm()
        {
            InitializeComponent();

            SetBindings();
        }

        private void SetBindings()
        {
            _bsAddClientAction.DataSource = typeof(SuperEventHandler);
        }

        public int ClientCode
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtClientCode.Text))
                    throw new Exception("Заполните поле \"Код клиента\"");

                int num;
                if (int.TryParse(txtClientCode.Text, out num))
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
                if (!string.IsNullOrWhiteSpace(txtClientName.Text))
                {
                    return txtClientName.Text;
                }
                else
                {
                    throw new Exception("Заполните поле \"Наименование\"");
                }
            }
        }

        public string ClientCity
        {
            get => cmbCities.SelectedItem.ToString();
        }

        public Client Client
        {
            get => new Client
            {
                Client_Code = ClientCode,
                Client_Name = ClientName,
                Client_City = ClientCity
            };
        }

        public SuperEventHandler butAddClientAction
        {
            get => _bsAddClientAction.Current as SuperEventHandler;
            set
            {
                if (_bsAddClientAction.Count > 0)
                    return;
                _bsAddClientAction.Add(value);
                btnAddClientAction.Click += value.Handler;
            }
        }
    }
}