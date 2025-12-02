using System;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool IsEffectActive=false;

    //abtract 
    public abstract void ApplyEffect(Player player);

    internal void ApplyEffect(Collider2D player)
    {
        throw new NotImplementedException();
    }
}
