using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailMover : MonoBehaviour
{
    public Transform container; 

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RotateBoxes();
        }
    }

    public void RotateBoxes()
    {
        Transform top = container.GetChild(0);

        top.gameObject.SetActive(false);

        top.SetAsLastSibling();

        top.gameObject.SetActive(true);
    }


}
