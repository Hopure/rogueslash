using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSetup : MonoBehaviour
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------
    private BattleUI battleUI;
    private BattleManager battleManager;

    // PUBLICS PROPERTIES ---------------------------------------------------------------

    [ShowInInspector] public Character Player;
    [ShowInInspector] public Character Monster;

    // UNITY METHODS --------------------------------------------------------------------
    private void Awake()
    {
        battleUI = GetComponent<BattleUI>();
        battleManager = GetComponent<BattleManager>();

        //Player = PlayerManager.Instance.playerData.Character;
        //Monster = MonsterFactory.Instance.Create(100, 10);
    }

    private void Start()
    {
        battleUI.SetupUI(Player, Monster);
    }

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
}
