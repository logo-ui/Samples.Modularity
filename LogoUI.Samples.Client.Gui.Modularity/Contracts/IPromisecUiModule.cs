using LogoFX.UI.Navigation;

namespace Promisec.ControlCenter.Client.Gui.Modularity.Contracts
{
    public interface IPromisecUiModule : INavigationModule
    {
        bool IsGroup { get; }
    }
}