using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scene
{
	MainMenu,
	Hub,
	Battle
}

public class GameNavigation : MonoSingleton<GameNavigation>
{
	// EVENTS ---------------------------------------------------------------------------

	// PRIVATES PROPERTIES --------------------------------------------------------------
	private Dictionary<Scene, string> Scenes;
	private Animator fadeAnimation;
	private Scene sceneToLoad;

	// PUBLICS PROPERTIES ---------------------------------------------------------------
	public GameObject BlackScreen;

	// UNITY METHODS --------------------------------------------------------------------
	private void Awake() {

		Scenes = new Dictionary<Scene, string> {
				{ Scene.MainMenu, "MainMenu" },
				{ Scene.Hub, "Hub" },
				{ Scene.Battle, "Battle" }
			};

		fadeAnimation = BlackScreen.GetComponent<Animator>();
	}

    private void Start()
    {
		ChangeScene(Scene.MainMenu);
    }

	// PRIVATES METHODS -----------------------------------------------------------------

	// PUBLICS METHODS ------------------------------------------------------------------
	public void ChangeScene(Scene scene) 
	{
		sceneToLoad = scene;
		fadeAnimation.SetTrigger("FadeIn");
	}

	public void TransitionCompleted()
    {
		SceneManager.LoadScene(Scenes[sceneToLoad]);
		fadeAnimation.SetTrigger("FadeOut");
	}
}
