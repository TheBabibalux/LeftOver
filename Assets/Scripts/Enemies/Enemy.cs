using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField]
    public float Health
    {
        get { return health; }
        set { health = value; }
    }

    public float health;
    public ThirdPersonController target;


    private void Awake()
    {

    }

    private void FixedUpdate()
    {
        Pursuit();
    }

    public void GetTarget()
    {

    }

    public void Pursuit()
    {

    }

    public void Move()
    {
        

    }

    public float Damage(float damage, float damageMultiplier)
    {
        health -= damage * damageMultiplier;

        if(health <= 0)
        {
            Die();
        }

        Debug.Log(damage * damageMultiplier + " damage dealt to " + this.gameObject.name + " / Health remaining : " + health);
        return health;
    }

    public void Die()
    {
        this.gameObject.SetActive(false);
    }
}
