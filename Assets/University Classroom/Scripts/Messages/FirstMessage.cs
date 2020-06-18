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
    private GameObject[] Images;
    [SerializeField]
    private GameObject CloseBtn;
    [SerializeField]
    private GameObject ChangeImagesBtn;
    private int once = 0;
    private bool moveToNext = false;

    void Start()
    {
        foreach(GameObject img in Images)
        {
            img.SetActive(false);
        }
        CloseBtn.SetActive(false);
        ChangeImagesBtn.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!CameraAnimator.enabled && !FadeAnimator.enabled)
        {
            if (once == 0)
            {
                Images[0].SetActive(true);
                Images[1].SetActive(true);
                ChangeImagesBtn.SetActive(true);
                once++;
            }
        }
    }

    public void NextImage()
    {
        ChangeImagesBtn.SetActive(false);
        Images[1].SetActive(false);
        Images[2].SetActive(true);
        CloseBtn.SetActive(true);
    }
    public int PlayerReadInstructions()
    {
        return once;
    }
}
