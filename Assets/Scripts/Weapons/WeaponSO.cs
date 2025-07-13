using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "ScriptableObjects/Items/Weapon", order = 1)]
public class WeaponSO : ScriptableObject
{
    public int maxAmmunitions = 1;
    public float shootingRate = 0.2f;
    public float stabilisationDuration = 1;
    public float walkingDestabilisationScale = 1;
    public float baseDamage = 10;
    public float aimingMoveSlowFactor = 0.5f;
}
