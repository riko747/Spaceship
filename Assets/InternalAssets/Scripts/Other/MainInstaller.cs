using InternalAssets.Scripts.Ship;
using Zenject;

namespace InternalAssets.Scripts.Other
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Interfaces.IShipData>().To<ShipData>().FromComponentInHierarchy().AsSingle();
        }
    }
}