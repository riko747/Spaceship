using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.UI
{
    public class ModifyShipSlotUI : MonoBehaviour
    {
        [Inject] private Interfaces.IShipData _shipData;
        
        [SerializeField] private List<TMP_Dropdown> typeOfSlotDropdowns;
        [SerializeField] private Button createSlotsButton;
    }
}
