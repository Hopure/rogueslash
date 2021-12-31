using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MasteryID
{
    Warrior
}

//public class SkillsDictionnary : SerializedDictionary<SkillID, Skill> { }

[CreateAssetMenu(menuName = "Mastery/Player/New Mastery")]
public class Mastery : ScriptableObject
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    public MasteryID ID;
    public string Name;
    public Sprite Icon;

    public float BaseLife;
    public float BaseDamage;

    [ShowInInspector]
    public Dictionary<SkillID, Skill> SkillsAvailable;

    // UNITY METHODS --------------------------------------------------------------------
    private void OnEnable()
    {
        SkillsAvailable = new Dictionary<SkillID, Skill>
        {
            {SkillID.BasicAttack, Resources.Load("ScriptableObject/Skill/BasicAttack") as Skill }
        };
    }

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
}
