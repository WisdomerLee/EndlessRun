using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : Consumable
{
    public override string GetConsumableName() => "DESTROYER";

    public override ConsumableType GetConsumableType() => ConsumableType.DESTROYER;


    public override int GetPremiumCost() => 0;

    public override int GetPrice() => 70;

    public override IEnumerator Started(CharacterInputController c)
    {
        yield return base.Started(c);
        c.trackManager.invincible = true;
        c.currentLife = c.maxLife;
    }
    public override void Ended(CharacterInputController c)
    {
        base.Ended(c);
        c.trackManager.invincible = false;
    }
}
