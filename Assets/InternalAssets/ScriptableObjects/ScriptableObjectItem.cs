using System;
using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.ScriptableObjects
{
    [Serializable]
    public class ScriptableObjectItemData
    {
        public Enums.Items item;
        public Enums.EquipmentSlotType equipmentSlotType;
    }

    [CreateAssetMenu(fileName = "ItemData", menuName = "Items")]
    public class ScriptableObjectItem : ScriptableObject
    {
        public List<ScriptableObjectItemData> itemsData;
    }
}
