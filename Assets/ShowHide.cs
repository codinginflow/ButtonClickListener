using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    bool visible = true;

    public void ToggleVisibility(string logMessage)
    {
        visible = !visible;
        GetComponent<MeshRenderer>().enabled = visible;
        Debug.Log(logMessage);
    }
}
