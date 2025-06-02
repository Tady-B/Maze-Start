using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    float maxHealth { set; get; }
    float currentHealth { set; get; }
    float Damage(float damage);
    bool IsDead { set; get; }
    void CheckIsDead();

}
