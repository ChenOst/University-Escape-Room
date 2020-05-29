using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public Animation anim;
    static int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim.Play("CameraRotation_anim");
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.isPlaying)
        {
            return;
        }
        else
        {
            if (i == 0)
            {
                Debug.Log("Aniimation stoped");
                i++;
            }
            
        }
    }
}
