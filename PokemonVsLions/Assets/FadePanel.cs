using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePanel : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("FadeToBlack", true);

            // NextLevel();
            Invoke("NextLevel", 2);
        }

       if(Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("FadeToBlack", false);
        }
    }

    void NextLevel()
    {
        Debug.Log("Next LEvel loaded");
    }
}
