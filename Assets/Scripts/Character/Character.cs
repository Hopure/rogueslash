using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    public Mastery Job;
    public StatPackage Stat;
    public SkillPackage Skill;

    // CONSTRUCTOR ----------------------------------------------------------------------
    public Character(Mastery job)
    {
        Job = job;
        Stat = new StatPackage(10);
    }

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------

}
