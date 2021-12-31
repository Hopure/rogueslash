using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------
    private BattleUI battleUI;
    private BattleSetup battleSetup;

    private Character _player;
    private Character _monster;

    // PUBLICS PROPERTIES ---------------------------------------------------------------

    // UNITY METHODS --------------------------------------------------------------------

    private void Awake()
    {
        battleUI = GetComponent<BattleUI>();
        battleSetup = GetComponent<BattleSetup>();
    }

    private void OnDisable()
    {
        
    }

    // PRIVATES METHODS -----------------------------------------------------------------
    private void PlayerTurn()
    {
        battleUI.UpdateTurnUI(true);
        battleUI.btn_Slot1.enabled = true;
    }

    private void MonsterTurn()
    {
        CheckBattleEnd();

        battleUI.UpdateTurnUI(false);
        battleUI.btn_Slot1.enabled = false;

        //_monster.Attack(_player);

        CheckBattleEnd();

        PlayerTurn();
    }

    private void CheckBattleEnd()
    {
        //if(_monster.Life.CurrentValue <= 0)
        //{
        //    Victory();
        //}
        //else if(_player.Life.CurrentValue <= 0)
        //{
        //    GameOver();
        //}
    }

    private void Victory()
    {
        battleUI.lbl_Turn.text = "GG";
    }

    private void GameOver()
    {
        battleUI.lbl_Turn.text = "Vas t'acheter un plus gros E-Penis";
    }

    // PUBLICS METHODS ------------------------------------------------------------------
    public void StartBattle(Character player, Character monster)
    {
        //    _player = player;
        //    _monster = monster;

        //    _player.OnActionDone += MonsterTurn;
        //    PlayerTurn();
    }
}
