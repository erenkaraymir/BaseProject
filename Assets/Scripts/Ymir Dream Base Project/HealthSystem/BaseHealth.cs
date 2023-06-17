using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseHealth : MonoBehaviour
{
    [SerializeField] private int _health;

    public virtual void TakeDamage(int value)
    {
        _health -= value;
        if(_health <= 0)
        {
            Die();
        }
    }

    public virtual void Heal(int value)
    {
        _health += value;
    }

    public int GetHealthValue()
    {
        return _health;
    }

    public virtual void Die()
    {
        Debug.Log("Die");
    }

}
