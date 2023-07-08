using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        // здесь должен быть код для пересвечивания  
        
        SceneManager.LoadScene("Scene1");
    }
    
    public void ExitPressed()
    {
        Debug.Log("Exit pressed!");
        Application.Quit();
    }

    public AudioMixer am;
    
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

}
