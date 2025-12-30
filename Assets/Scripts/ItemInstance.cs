using UnityEngine;

[System.Serializable]
public class ItemInstance
{
    public ItemSO itemSO;

    public int remainingCharges;

    public int ModifyCharges(int changeValue)
    {
        if(!itemSO.isChargeItem)
        {
            return -1;
        }

        remainingCharges += changeValue;

        remainingCharges = Mathf.Max(remainingCharges, 0);
        remainingCharges = Mathf.Min(remainingCharges, itemSO.maxCharge);

        return remainingCharges;
    }

    public void InitCharges()
    {
        remainingCharges = itemSO.maxCharge;
    }
}
