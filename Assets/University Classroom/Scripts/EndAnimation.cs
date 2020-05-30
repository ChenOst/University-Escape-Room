
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EndAnimation : MonoBehaviour
{
    public Animator animator;
    bool AnimationEnded = false;

    // Update is called once per frame
    void Update()
    {
        if (AnimationEnded)
        {
            animator.enabled = false;
        }
    }

    public void AnimatinoStatusUpdate()
    {
        AnimationEnded = true;
    }

}
