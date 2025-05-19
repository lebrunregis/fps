using System;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int life = 100;
    public Action OnDamage;

    public void TakeDamage(int damage)
    {
        life -= damage;
        if (life <= 0)
        {
            transform.gameObject.SetActive(false);
        }
    }

}
