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
    }

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------

}
