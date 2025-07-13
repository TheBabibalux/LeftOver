using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public float Health { 
        get { return Health; }
        set { Health = value;} }

    float Damage(float damage, float damageMultiplier);

}
