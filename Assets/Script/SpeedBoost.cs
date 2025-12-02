using System;
using UnityEngine;

public class SpeedBoost : PowerUpBase
{


    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive)
        {
            player.SetMoveSpeed(10);
        }
    }

}
