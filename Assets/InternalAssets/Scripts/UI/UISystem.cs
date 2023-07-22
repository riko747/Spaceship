using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.Scripts.UI
{
    public class UISystem : MonoBehaviour, Interfaces.IUiSystem
    {
        [SerializeField] private CreateShipSlotUI createShipSlotUI;
        [SerializeField] private ModifyShipSlotUI modifyShipSlotUI;

        public CreateShipSlotUI GetCreateShipSlotUI() => createShipSlotUI;
        public ModifyShipSlotUI GetModifyShipSlotUI() => modifyShipSlotUI;
    }
}
