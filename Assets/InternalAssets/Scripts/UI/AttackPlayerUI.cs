using InternalAssets.Scripts.Other;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.UI
{
    public class AttackPlayerUI : MonoBehaviour
    {
        [Inject] private Interfaces.IShip _ship;

        [SerializeField] private Button attackShipWithMachineGunButton;
        [SerializeField] private Button attackShipWithPlasmaCannonButton;
        [SerializeField] private Button attackEquipment;
        [SerializeField] private int damageCount;

        private void Start()
        {
            attackShipWithMachineGunButton.onClick.AddListener(() => OnAttackShip(damageCount, false));
            attackShipWithPlasmaCannonButton.onClick.AddListener(() => OnAttackShip(damageCount, true));
            attackEquipment.onClick.AddListener(() => OnAttackEquipment(damageCount));
        }

        private void OnAttackShip(int damage, bool isPlasmaCannon)
        {
            _ship.DamageTheShip(damage, isPlasmaCannon);
        }

        private void OnAttackEquipment(int damage)
        {
            _ship.EquipmentManager.DamageEquipment(damage);
        }

        private void OnDestroy()
        {
            attackShipWithMachineGunButton.onClick.RemoveListener(() => OnAttackShip(damageCount,false));
            attackShipWithPlasmaCannonButton.onClick.RemoveListener(() => OnAttackShip(damageCount,true));
            attackEquipment.onClick.RemoveListener(() => OnAttackEquipment(damageCount));
        }
    }
}
