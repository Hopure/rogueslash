using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillID
{
    BasicAttack
}

public class Skill : ScriptableObject
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    public SkillID ID;
    public string Name;
    public int ActionPoint;

    public virtual void Activate(Character parent) {}
    

    // UNITY METHODS --------------------------------------------------------------------

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
}
