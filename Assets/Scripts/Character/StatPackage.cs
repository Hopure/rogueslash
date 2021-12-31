using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatPackage
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    public Statistic Life;
    public Statistic Damage;

    // CONSTRUCTOR ----------------------------------------------------------------------
    public StatPackage(float life, float damage)
    {
        Life = new Statistic(StatID.Life, "Life", life);
        Damage = new Statistic(StatID.Damage, "Damage", damage);
    }

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
}
