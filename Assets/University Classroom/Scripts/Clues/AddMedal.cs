using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddMedal : MonoBehaviour
{
    [SerializeField]
    Clue[] clues;
    [SerializeField]
    Image[] medals;
    [SerializeField]
    Sprite sprite;

    // Update is called once per frame
    void Update()
    {
        foreach(Clue cl in clues)
        {
            if (cl.getClueIsComplete())
            {
                switch (cl.getClueId())
                {
                    case 1:
                        medals[0].sprite = sprite;
                        break;
                    case 2:
                        medals[1].sprite = sprite;
                        break;
                    case 3:
                        medals[2].sprite = sprite;
                        break;
                    case 4:
                        medals[3].sprite = sprite;
                        break;
                    case 5:
                        medals[4].sprite = sprite;
                        break;
                    case 6:
                        medals[5].sprite = sprite;
                        break;
                    default:
                        // code block
                        break;
                }
            }
        }
    }
}
