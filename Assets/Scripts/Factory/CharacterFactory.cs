using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory
{
    #region Singleton
    private static readonly Lazy<CharacterFactory> instance = new Lazy<CharacterFactory>(() => new CharacterFactory());

    public static CharacterFactory Instance
    {
        get { return instance.Value; }
    }
    #endregion

    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------
    private Dictionary<MasteryID, Mastery> MasteryDB;

    // PUBLICS PROPERTIES ---------------------------------------------------------------

    // CONSTRUCTOR ----------------------------------------------------------------------
    public CharacterFactory()
    {
        MasteryDB = new Dictionary<MasteryID, Mastery>()
        {
            {MasteryID.Warrior, Resources.Load("ScriptableObject/Mastery/Warrior") as Mastery }
        };
    }

    // PRIVATES METHODS -----------------------------------------------------------------
    private Mastery GetMasteryByID(MasteryID id)
    {
        if (MasteryDB.ContainsKey(id))
        {
            return MasteryDB[id];
        }
        else
        {
            Debug.LogError("This mastery doesn't exist");
            return null;
        }
        
    }

    // PUBLICS METHODS ------------------------------------------------------------------
    public Character CreatePlayer(MasteryID id)
    {
        // Creation du personnage en lui affectant le job souhaité
        Character _product = new Character(GetMasteryByID(id));

        // Initialisation des BaseStat suivant le job du personnage
        _product.Stat = new StatPackage(_product.Job.BaseLife, _product.Job.BaseDamage);

        // Assignation des skill de base du personnage à la création suivant son job
        _product.Skill = new SkillPackage();
        _product.Skill.SkillByID.Add(_product.Job.SkillsAvailable[SkillID.BasicAttack].ID, _product.Job.SkillsAvailable[SkillID.BasicAttack]);

        // Livraison du personnage
        return _product;
    }
}
