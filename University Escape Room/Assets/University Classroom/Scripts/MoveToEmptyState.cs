
using System.Collections;
using UnityEngine;

public class MoveToEmptyState : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetTrigger("MoveToEmpty");
            animator.enabled = false;
        }
    }

}
