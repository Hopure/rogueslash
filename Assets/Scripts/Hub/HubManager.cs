using UnityEngine;

public class HubManager : MonoBehaviour
{
    // EVENTS ---------------------------------------------------------------------------

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------

    // UNITY METHODS --------------------------------------------------------------------

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
    public void BackToMenu()
    {
        SaveManager.Instance.Save();
        GameNavigation.Instance.ChangeScene(Scene.MainMenu);
    }

    public void Fight()
    {
        GameNavigation.Instance.ChangeScene(Scene.Battle);
    }
}
