using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    [SerializeField] private GameObject manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            manager.GetComponent<swichscene>().NextLevel();
        }
    }
    //לעלות שלב 

}
