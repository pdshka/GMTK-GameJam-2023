using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleControls : MonoBehaviour
{
    
    public void ReturnToMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
