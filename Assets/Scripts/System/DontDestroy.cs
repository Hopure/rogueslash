using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
	// EVENTS ---------------------------------------------------------------------------

	// PUBLICS PROPERTIES ---------------------------------------------------------------

	// PRIVATES PROPERTIES --------------------------------------------------------------
	private static GameObject instance;

	// UNITY ----------------------------------------------------------------------------
	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		if (instance == null)
			instance = gameObject;
		else
			Destroy(gameObject);
	}

	// PRIVATES METHODS -----------------------------------------------------------------

	// PUBLICS METHODS ------------------------------------------------------------------
}