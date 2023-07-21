using Zenject;

namespace InternalAssets.Scripts.Other
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Interfaces.IShip>().To<ShipLogic.Ship>().FromComponentInHierarchy().AsSingle();
        }
    }
}