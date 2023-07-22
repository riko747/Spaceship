using InternalAssets.Scripts.UI;
using Zenject;

namespace InternalAssets.Scripts.Other
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Interfaces.IShip>().To<ShipLogic.Ship>().FromComponentInHierarchy().AsSingle();
            Container.Bind<Interfaces.IUiSystem>().To<UISystem>().FromComponentInHierarchy().AsSingle();
            Container.Bind<Interfaces.IUpgradeableInterfaceManager>().To<UpgradeableInterfaceManager>().FromComponentInHierarchy().AsSingle();
        }
    }
}