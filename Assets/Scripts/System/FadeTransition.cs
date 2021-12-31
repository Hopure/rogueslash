using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTransition : MonoBehaviour
{
    // EVENTS ---------------------------------------------------------------------------
    public void OnFadeCompleted()
    {
        GameNavigation.Instance.TransitionCompleted();
    }

    // PRIVATES PROPERTIES --------------------------------------------------------------

    // PUBLICS PROPERTIES ---------------------------------------------------------------

    // UNITY METHODS --------------------------------------------------------------------

    // PRIVATES METHODS -----------------------------------------------------------------

    // PUBLICS METHODS ------------------------------------------------------------------
}
