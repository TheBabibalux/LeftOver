using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

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
    public NavMeshAgent agent;

    public enum BehaviourState { Idle, Searching, Pursuit, Pause, Attack}
    public BehaviourState state;

    public float attackRange = 1;
    public float attackCooldown = 2;


    private void Awake()
    {

    }

    private void FixedUpdate()
    {
        StateManagement();
    }

    #region Behaviour
    private void StateManagement()
    {
        switch(state)
        {
            case BehaviourState.Idle:
                Idle();
                break;
            case BehaviourState.Searching:

                break;
            case BehaviourState.Pursuit:
                Pursuit();
                break;
            case BehaviourState.Pause:

                break;
            case BehaviourState.Attack:
                Attack();
                break;
        }
    }

    public void Idle()
    {
        if (target != null)
        {
            state = BehaviourState.Pursuit;
        }
    }

    public void Pursuit()
    {
        agent.destination = target.transform.position;

        if(Vector3.Distance(this.transform.position,target.transform.position) <= attackRange)
        {
            state = BehaviourState.Attack;
        }
    }

    public void Attack()
    {

        StartCoroutine(PauseBehaviour(attackCooldown, BehaviourState.Pursuit));
    }

    IEnumerator PauseBehaviour(float duration, BehaviourState exitState)
    {
        state = BehaviourState.Pause;
        SetMovePause(false);

        yield return new WaitForSeconds(duration);
        state = exitState;
        SetMovePause(true);
    }

    public void SetMovePause(bool state)
    {
        agent.isStopped = !state;
    }
    #endregion

    public float TakeDamage(float damage, float damageMultiplier)
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
