using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "ScriptableObjects/Items", order = 1)]
public class ItemSO : ScriptableObject
{
    public Sprite image;
    public string weaponName;
    public string description;

    public bool isChargeItem = false;

    public int maxCharge = 1;
    public float shootingRate = 0.2f;
    public float stabilisationDuration = 1;
    public float walkingDestabilisationScale = 1;
    public float baseDamage = 10;
    public float aimingMoveSlowFactor = 0.5f;
    public float reloadTime = 2;
}
