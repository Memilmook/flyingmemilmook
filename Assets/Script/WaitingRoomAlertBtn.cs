using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaitingRoomAlertBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alertObject;

    private void Start()
    {
        alertObject.SetActive(false);
    }
    public void displayObejct()
    {
        alertObject.SetActive(true);
    }
    public void closeObject()
    {
        alertObject.SetActive(false);
    }
}
