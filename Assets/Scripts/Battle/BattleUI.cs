using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------
    private BattleSetup battleSetup;
    private BattleManager battleManager;
    
    private Character _player;
    private Character _monster;

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    public TextMeshProUGUI PlayerLifeUI;
    public TextMeshProUGUI MonsterLifeUI;
    public TextMeshProUGUI lbl_Turn;

    public Button btn_Slot1;

    // UNITY METHODS --------------------------------------------------------------------
    private void Awake()
    {
        battleSetup = GetComponent<BattleSetup>();
        battleManager = GetComponent<BattleManager>();
    }

    // PRIVATES METHODS -----------------------------------------------------------------
    private void RefreshPlayerUI(Statistic stat)
    {
        //PlayerLifeUI.text = _player.Life.CurrentValue + " / " + _player.Life.Value;
    }

    private void RefreshMonsterUI(Statistic stat)
    {
        //MonsterLifeUI.text = _monster.Life.CurrentValue + " / " + _monster.Life.Value;
    }
    // PUBLICS METHODS ------------------------------------------------------------------
    public void SetupUI(Character player, Character monster)
    {
        _player = player;
        _monster = monster;

        //_player.Life.OnCurrentValueChange += RefreshPlayerUI;
        //_monster.Life.OnCurrentValueChange += RefreshMonsterUI;

        //PlayerLifeUI.text = _player.Life.CurrentValue + " / " + _player.Life.Value;
        //MonsterLifeUI.text = _monster.Life.CurrentValue + " / " + _monster.Life.Value;

        //btn_Slot1.onClick.AddListener(() => _player.Attack(_monster));

        battleManager.StartBattle(_player, _monster);
    }

    public void UpdateTurnUI(bool playerTurn)
    {
        if (playerTurn)
        {
            lbl_Turn.text = "Player's Turn";
        }
        else
        {
            lbl_Turn.text = "Monster's Turn";
        }
    }
}
