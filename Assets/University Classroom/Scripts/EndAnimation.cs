
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EndAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    private bool _animationEnded = false;

    // Update is called once per frame
    void Update()
    {
        if (_animationEnded)
        {
            _animator.enabled = false;
        }
    }

    // This funciton called in the end of the waking up animations (Fade_out and Camera_Rotate)
    public void AnimatinoStatusUpdate()
    {
        _animationEnded = true;
    }

}
