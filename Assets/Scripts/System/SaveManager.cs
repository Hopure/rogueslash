using Bayat.SaveSystem;
using System;
using System.Threading.Tasks;

public class SaveManager
{
    #region Singleton
    private static readonly Lazy<SaveManager> instance = new Lazy<SaveManager>(() => new SaveManager());

    public static SaveManager Instance
    {
        get { return instance.Value; }
    }
    #endregion

    // EVENTS ---------------------------------------------------------------------------
    public event Action OnLoaded;
    public event Action OnSaved;
    public void LoadedTrigger()
    {
        OnLoaded?.Invoke();
    }

    public void SavedTrigger()
    {
        OnSaved?.Invoke();
    }

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------

    // UNITY METHODS --------------------------------------------------------------------

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
    async public Task<bool> CheckSave()
    {
        return await SaveSystemAPI.ExistsAsync(PlayerManager.Instance.playerData.SaveID);
    }

    async public void Save()
    {
        await SaveSystemAPI.SaveAsync(PlayerManager.Instance.playerData.SaveID, PlayerManager.Instance.playerData);
        SavedTrigger();
    }

    async public void Load()
    {
        PlayerManager.Instance.playerData = new PlayerData();
        PlayerManager.Instance.playerData = await SaveSystemAPI.LoadAsync<PlayerData>(PlayerManager.Instance.playerData.SaveID);
        LoadedTrigger();
    }

    public void CreateFirstSave()
    {
        PlayerManager.Instance.playerData.Characters.Add(CharacterFactory.Instance.CreatePlayer(MasteryID.Warrior));
        Save();
    }
}
