using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class exitScene : MonoBehaviour
{
	public Button exitButton;

	void Start()
	{
		exitButton = gameObject.GetComponent<Button>();
		exitButton.onClick.AddListener(Exit);
	}

	void Exit()
	{
		Application.Quit();
	}
}
