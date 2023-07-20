using InternalAssets.Scripts.UI;
using Zenject;

namespace InternalAssets.Scripts.Other
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Interfaces.IUISystem>().To<UISystem>().FromComponentInHierarchy().AsSingle();
        }
    }
}