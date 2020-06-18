using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMessage : MonoBehaviour
{
    private float _destoryTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _destoryTime);
    }

}
