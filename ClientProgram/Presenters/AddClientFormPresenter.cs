using ClientProgram.Handlers;
using ClientProgram.Repositories;
using ClientProgram.Views;
using DevExpress.XtraEditors;
using System;

namespace ClientProgram.Presenters
{
    class AddClientFormPresenter
    {
        private readonly IClientForm _clientView;
        private readonly ClientRepository clientRepository = new ClientRepository();

        public AddClientFormPresenter(IClientForm clientView)
        {
            _clientView = clientView ??
                throw new ArgumentNullException(nameof(clientView));

            #region Подписываемся на события
            _clientView.butAddClientAction = new SuperEventHandler(butAddClientAction_Click);
            #endregion
        }

        /// <summary>
        /// Действие, добавления данных о клиенте
        /// </summary>
        private async void butAddClientAction_Click()
        {
            try
            {
                await clientRepository.Create(_clientView.Client);

                XtraMessageBox.Show("Клиент успешно добавлен!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}
