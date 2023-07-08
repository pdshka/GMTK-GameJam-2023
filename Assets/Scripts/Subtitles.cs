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
    public IEnumerator PlayMonologue()
    {
        yield return new WaitForSeconds(10f);
        foreach (var frase in monologue)
        {
            for (int i = 0; i < frase.Length; i++)
            {
                //tmp.GetComponent<Text()
                tmp.text += frase[i];
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitForSeconds(5f);
            tmp.text = "";
        }

        StartCoroutine(ToBrainScene());
    }

    public IEnumerator ToBrainScene()
    {
        Color cl = sp.color;
        while (cl.a < 1f)
        {
            cl.a -= 0.05f;
            sp.color = cl;
            yield return new WaitForSeconds(0.05f);
        }
        SceneManager.LoadScene("Brain");
    }


}
