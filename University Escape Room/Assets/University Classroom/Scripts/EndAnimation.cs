
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MoveToEmptyState : MonoBehaviour
{
    public Animator animator;
    bool AnimationEnded = false;

    // Update is called once per frame
    void Update()
    {
        if (AnimationEnded)
        {
            gameObject.SetActive(false);
        }
    }

    public void AnimatinoStatusUpdate()
    {
        AnimationEnded = true;
    }

}
