using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : BaseHealth
{
    public override void Die()
    {
        Debug.Log("Enemy");
    }

    private void Start()
    {
        TakeDamage(1000);
    }
}
