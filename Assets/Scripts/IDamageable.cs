using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public float Health { 
        get { return Health; }
        set { Health = value;} }

    float TakeDamage(float damage, float damageMultiplier);

}
