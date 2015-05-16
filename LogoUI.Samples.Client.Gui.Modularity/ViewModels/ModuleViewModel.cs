using System;
using LogoFX.UI.Navigation;
using Promisec.ControlCenter.Client.Gui.Modularity.Contracts;

namespace Promisec.ControlCenter.Client.Gui.Modularity.ViewModels
{
    public class ModuleViewModel
    {
        public ModuleViewModel(IPromisecUiModule model)
        {
            Model = model;
        }

        private IPromisecUiModule Model { get; set; }

        public object RootViewModel
        {
            get { return Model.RootViewModel; }
        }

        public Type RootModelType
        {
            get { return Model.RootModelType; }
        }

        public string Name
        {
            get { return Model.Name; }
        }

        public INavigationService NavigationService
        {
            get { return Model.NavigationService; }
        }

        public int Order
        {
            get { return Model.Order; }
        }
    }
}
