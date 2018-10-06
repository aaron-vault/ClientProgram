using ClientProgram.Handlers;
using ClientProgram.Repositories;
using ClientProgram.Views;
using DevExpress.XtraEditors;
using System;

namespace ClientProgram.Presenters
{
    class EditClientFormPresenter
    {
        private readonly IEditClientForm _clientEditView;
        private readonly ClientRepository clientRepository = new ClientRepository();

        public EditClientFormPresenter(IEditClientForm clientEditView)
        {
            _clientEditView = clientEditView ??
                throw new ArgumentNullException(nameof(_clientEditView));

            #region Подписываемся на события
            _clientEditView.butEditClientAction = new SuperEventHandler(butEditClientAction_Click);
            #endregion
        }

        /// <summary>
        /// Действие, изменения данных о клиенте
        /// </summary>
        private async void butEditClientAction_Click()
        {
            try
            {
                await clientRepository.Update(_clientEditView.Client);
                
                XtraMessageBox.Show("Данные о клиенте были изменены!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}
