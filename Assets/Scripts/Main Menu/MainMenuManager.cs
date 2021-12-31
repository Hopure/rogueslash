using Bayat.SaveSystem;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------

    // UNITY METHODS --------------------------------------------------------------------
    private void Start()
    {
        SaveManager.Instance.OnLoaded += LoadScene;
        SaveManager.Instance.OnSaved += LoadScene;
    }

    private void OnDisable()
    {
        SaveManager.Instance.OnSaved -= LoadScene;
        SaveManager.Instance.OnLoaded -= LoadScene;
    }

    // PRIVATES METHODS -----------------------------------------------------------------
    private void LoadScene()
    {
        //PlayerManager.Instance.playerData.Character.RefreshStat();
        GameNavigation.Instance.ChangeScene(Scene.Hub);
    }

    // PUBLICS METHODS ------------------------------------------------------------------
    async public void PlayGame()
    {
        if (await SaveManager.Instance.CheckSave())
        {
            SaveManager.Instance.Load();
        }
        else
        {
            SaveManager.Instance.CreateFirstSave();
        }
    }

    async public void DeleteSave()
    {
        await SaveSystemAPI.ClearAsync();
    }
}
