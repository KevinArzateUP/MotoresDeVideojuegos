using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    public void Move();
}

public interface IDamagable
{
    public void ReceiveDamage();
}

public interface IShoot
{
    public void Shoot();
}