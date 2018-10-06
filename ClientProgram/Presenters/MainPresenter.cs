using ClientProgram.Handlers;
using ClientProgram.Views;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientProgramLib.Data;
using ClientProgram.Repositories;
using System.Data;
using ClientProgramLib.Models;

namespace ClientProgram.Presenters
{
    class MainPresenter
    {
        private readonly IMainForm _mainView;
        private readonly ClientRepository clientRepository = new ClientRepository();
        private readonly CityContext cities = new CityContext();

        public MainPresenter(IMainForm mainView)
        {
            _mainView = mainView ?? 
                throw new ArgumentNullException(nameof(mainView));

            #region Подписываемся на события
            _mainView.inpSearchTextChange = new MainEventHandler(OnTextChanged);
            _mainView.loadMainForm = new MainEventHandler(LoadMainForm);

            _mainView.butAddClient = new SuperEventHandler(butAddClient_Click);
            _mainView.butEditClient = new SuperEventHandler(butEditClient_Click);
            _mainView.butDeleteClient = new SuperEventHandler(butDeleteClient_Click);
            #endregion
        }

        /// <summary>
        /// Действие при загрузки формы MainForm 
        /// с выгрузкой данных из БД
        /// </summary>
        private void LoadMainForm()
        {
            try
            {
                _mainView.DgvClientList = clientRepository.GetClients();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        /// <summary>
        /// Открытие формы для добавления объекта типа Client
        /// </summary>
        private void butAddClient_Click()
        {
            var main = Application.OpenForms.OfType<XtraForm>().First(f => f.Name.Equals("MainForm"));
            var client = new ClientForm();

            client.Owner = main;
            client.StartPosition = FormStartPosition.CenterParent;

            cities._cities.ForEach(c => client.cmbCities.Items.Add(c));
            client.cmbCities.SelectedItem = cities._cities.First();

            var clientPresenter = new AddClientFormPresenter(client);
            client.ShowDialog();
        }

        /// <summary>
        /// Открытие формы с передачей объекта типа Client
        /// </summary>
        private void butEditClient_Click()
        {
            Client client = _mainView.SelectedClient;
            
            var main = Application.OpenForms.OfType<XtraForm>().First(f => f.Name.Equals("MainForm"));
            var clientEdit = new EditClientForm();

            clientEdit.Owner = main;
            clientEdit.StartPosition = FormStartPosition.CenterParent;

            clientEdit.Client = client;

            clientEdit.txtClientEditCode.Text = client.Client_Code.ToString();
            clientEdit.txtClientEditName.Text = client.Client_Name;

            cities._cities.ForEach(c => clientEdit.cmbEditCities.Items.Add(c));
            clientEdit.cmbEditCities.SelectedItem = client.Client_City;

            var clientEditPresenter = new EditClientFormPresenter(clientEdit);
            clientEdit.ShowDialog();
        }

        /// <summary>
        /// Удаление выделенного элемента
        /// </summary>
        private async void butDeleteClient_Click()
        {
            try
            {
                Client client = _mainView.SelectedClient;
                await clientRepository.Delete(client.Client_Id);

                XtraMessageBox.Show($"Клиент с кодом \"{client.Client_Code}\" был удален из базы данных",
                    "Удаление завершено");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        /// <summary>
        /// Изменение текста в текстбоксе
        /// </summary>
        private void OnTextChanged()
        {
            try
            {
                var data = clientRepository.GetClients();
                if (string.IsNullOrWhiteSpace(_mainView.SeacrhField))
                {
                    _mainView.DgvClientList = data;
                }
                else
                {
                    _mainView.DgvClientList = 
                        data.Where(s => s.Client_Name.Contains(_mainView.SeacrhField)).ToList();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}
