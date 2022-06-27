using Microsoft.Xaml.Behaviors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace Clouder.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Model.MainModel model = null;
        public MainViewModel()
        {
            model = new Model.MainModel();
        }
        public Model.MainModel Model
        {
            get { return model; }
            set { model = value; OnPropertyChanged("Model"); }
        }

        public int Num
        {
            get
            {
                return model.num;
            }
            set
            {
                model.num = value;
                OnPropertyChanged("Num");
            }
        }

        //public void MouseClicked()
        //{
            
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ActionCommand increaseCommand;
        private ActionCommand testcommand;
        public ICommand IncreaseCommand => increaseCommand ??= new ActionCommand(Increase);
        public ICommand OnCircleButtonClicked => testcommand ??= new ActionCommand(IncreaseAfter);

        private void Increase()
        {
            Num++;
            //System.Windows.MessageBox.Show(Num.ToString());
        }
        
        private void IncreaseAfter()
        {
            Num--;
            System.Windows.MessageBox.Show(Num.ToString());
        }
    }
}
