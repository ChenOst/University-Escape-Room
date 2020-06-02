using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstMessage : MonoBehaviour
{
    [SerializeField]
    private Animator CameraAnimator;
    [SerializeField]
    private Animator FadeAnimator;
    [SerializeField]
    private Image Image;
    [SerializeField]
    private Text Text;
    [SerializeField]
    private GameObject CloseBtn;
    private static int once = 0;

    void Start()
    {
        Image.enabled = false;
        Text.enabled = false;
        CloseBtn.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!CameraAnimator.enabled && !FadeAnimator.enabled)
        {
            if (once == 0)
            {
                Image.enabled = true;
                Text.enabled = true;
                CloseBtn.SetActive(true);
                Text.text = "OOPS... You fell a sleep again in class.\n\nWoke up after everyone has left,\nended up alone,\n" +
                    " locked up in the university\nclass without the exit key.\n\nYou now need to find clues\n and figure out a way out\n so you can finally go home."
                    + "\n\nGOOD LUCK!";
                once++;
            }
           
        }
        
    }
}
