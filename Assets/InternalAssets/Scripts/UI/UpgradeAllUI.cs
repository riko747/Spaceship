using InternalAssets.Scripts.Other;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.UI
{
    public class UpgradeAllUI : MonoBehaviour
    {
        [Inject] private Interfaces.IUpgradeableInterfaceManager _upgradeableInterfaceManager;
        [Inject] private Interfaces.IUiSystem _uiSystem;
        
        [SerializeField] private Button upgradeAllButton;

        private void Start()
        {
            _uiSystem.GetCreateShipSlotUI().SlotsCreated += SetUpgradeButtonActive;
            upgradeAllButton.onClick.AddListener(UpgradeAll);
        }

        private void UpgradeAll()
        {
            var upgradeables = _upgradeableInterfaceManager.GetAllUpgradeables();
            foreach (var upgradeable in upgradeables)
                upgradeable.Upgrade();
        }

        private void SetUpgradeButtonActive()
        {
            upgradeAllButton.interactable = true;
        }

        private void OnDestroy()
        {
            upgradeAllButton.onClick.RemoveListener(UpgradeAll);
            _uiSystem.GetCreateShipSlotUI().SlotsCreated -= SetUpgradeButtonActive;
        }
    }
}
