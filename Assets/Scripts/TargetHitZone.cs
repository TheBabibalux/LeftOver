using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitZone : MonoBehaviour
{
    public Enemy self;

    public float damageMultiplier = 1f;
    public GameObject weakPointVisualTest;

    [SerializeField] bool isActive = true;
    
    public float Hit(float damage)
    {
        if (!isActive) return -1;

        float resultingHealth = self.TakeDamage(damage, damageMultiplier);

        return resultingHealth;
    }

    public void SetTargetHitZone(bool onOff)
    {
        isActive = onOff;
    }

    public void SetWeakPointVisual(bool onOff)
    {
        if(weakPointVisualTest != null) weakPointVisualTest.SetActive(onOff);
    }
}
