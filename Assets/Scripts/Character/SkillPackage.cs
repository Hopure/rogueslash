using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPackage
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    public Dictionary<SkillID, Skill> SkillByID;

    // CONSTRUCTOR ----------------------------------------------------------------------
    public SkillPackage()
    {
        SkillByID = new Dictionary<SkillID, Skill>();
    }

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
}
