using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitZone : MonoBehaviour
{
    public Enemy self;

    public float damageMultiplier = 1f;
    
    public float Hit(float damage)
    {
        float resultingHealth = self.TakeDamage(damage, damageMultiplier);

        return resultingHealth;
    }
    
}
