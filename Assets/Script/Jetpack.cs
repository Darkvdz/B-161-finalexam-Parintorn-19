using UnityEngine;

public class Jetpack : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive)
        {
            player.SetMoveSpeed(100);
        }
    }


}
