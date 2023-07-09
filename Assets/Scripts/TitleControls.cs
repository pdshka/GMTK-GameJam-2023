using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleControls : MonoBehaviour
{
    private void Start()
	{
		Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
	}
    public void ReturnToMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
