using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject targetObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (targetObject.activeSelf)
            {
                targetObject.SetActive(false);
            }
            else
            {
                targetObject.SetActive(true);
            }
        }
    }
}