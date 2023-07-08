using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraBlink : MonoBehaviour
{
    public SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(help_function());
    }

    public IEnumerator help_function()
    {
        Color cl= Color.black;;
        sp.color = Color.black;
        yield return new WaitForSeconds(3);
        while (cl.a >= 0.5f)
        {
            cl.a -= 0.05f;
            sp.color = cl;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(2);
        while (cl.a < 1f)
        {
            cl.a += 0.05f;
            sp.color = cl;
            yield return new WaitForSeconds(0.1f);
        }
        while (cl.a > 0f)
        {
            cl.a -= 0.05f;
            sp.color = cl;
            yield return new WaitForSeconds(0.1f);
        }
    }

    /*private void FixedUpdate()
    {
        Color cl= Color.black;;
        sp.color = Color.black;
        System.Threading.Thread.Sleep(1000);
        while (cl.a >= 0.5f)
        {
            cl.a -= 0.05f;
            sp.color = cl;
        }
        System.Threading.Thread.Sleep(500 );
        while (cl.a < 1f)
        {
            cl.a += 0.05f;
            sp.color = cl;
        }
        while (cl.a > 0f)
        {
            cl.a -= 0.05f;
            sp.color = cl;
        }
    }*/
}
