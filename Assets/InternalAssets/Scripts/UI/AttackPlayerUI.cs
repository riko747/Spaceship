using InternalAssets.Scripts.Other;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.UI
{
    public class AttackPlayerUI : MonoBehaviour
    {
        [Inject] private Interfaces.IShip _ship;

        [SerializeField] private Button attackShip;
        [SerializeField] private Button attackEquipment;
        [SerializeField] private int damageCount;

        private void Start()
        {
            attackShip.onClick.AddListener(() => OnAttackShip(damageCount));
            attackEquipment.onClick.AddListener(() => OnAttackEquipment(damageCount));
        }

        private void OnAttackShip(int damage)
        {
            _ship.DamageTheShip(damage);
        }

        private void OnAttackEquipment(int damage)
        {
            _ship.EquipmentManager.DamageEquipment(damage);
        }

        private void OnDestroy()
        {
            attackShip.onClick.RemoveListener(() => OnAttackShip(damageCount));
            attackEquipment.onClick.RemoveListener(() => OnAttackEquipment(damageCount));
        }
    }
}
