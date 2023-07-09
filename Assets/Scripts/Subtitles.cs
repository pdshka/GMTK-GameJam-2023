using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Subtitles : MonoBehaviour
{
    public string[] monologue;
    //public TextMeshPro tmp;
    //public GameObject tmp;
    public TextMeshProUGUI tmp;
    public SpriteRenderer sp;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayMonologue());
    }
    
    public AudioSource audio_src;
    public IEnumerator PlayMonologue()
    {
        yield return new WaitForSeconds(10f);
        foreach (var frase in monologue)
        {
            audio_src.Play();
            for (int i = 0; i < frase.Length; i++)
            {
                tmp.text += frase[i];
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitForSeconds(2f);
            tmp.text = "";
        } 
        yield return ToBrainScene();
    }

    public IEnumerator ToBrainScene()
    {
        Color cl = sp.color;
        while (cl.a < 1f)
        {
            cl.a += 0.05f;
            sp.color = cl;
            yield return new WaitForSeconds(0.05f);
        }
        SceneManager.LoadScene("Brain");
    }
}
