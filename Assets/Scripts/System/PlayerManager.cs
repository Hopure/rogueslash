using Sirenix.OdinInspector;

public class PlayerManager : MonoSingleton<PlayerManager>
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    [ShowInInspector]
    public PlayerData playerData;

    // UNITY METHODS --------------------------------------------------------------------
    void Awake()
    {
        playerData = new PlayerData();
    }

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
    
}
