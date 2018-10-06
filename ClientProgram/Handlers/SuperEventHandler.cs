using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientProgram.Handlers
{
    public class SuperEventHandler : MainEventHandler, INotifyPropertyChanged
    {
        private Func<bool> _setterProperty;

        public SuperEventHandler(Action handlerExecutor) : this(handlerExecutor, null)
        {
        }
        public SuperEventHandler(Action handlerExecutor, Func<bool> setterProperty) : base(handlerExecutor)
        {
            if (setterProperty == null)
            {
                _setterProperty = () => true;
            }
            else
            {
                _setterProperty = setterProperty;
            }
        }
        
        /// <summary>
        /// На случай, если необходимо изменить свойство объекта (кнопки, формы и т.д.)
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
