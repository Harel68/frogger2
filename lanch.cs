using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanch : MonoBehaviour
{
    
    [SerializeField] private float Timetowait;
    [SerializeField] private float realTimetowait;
    [SerializeField] private int dir;
    [SerializeField] private int type;//1 רכבת 0    מכונית 


    [SerializeField] private GameObject[] cars;
    [SerializeField] private GameObject train;

    // Start is called before the first frame update
    void Start()
    {   
        if(type == 0)
        {
            Timetowait = 3 * Timetowait;
        }
        realTimetowait = Timetowait;
        
    }
    // Update is called once per frame
    void Update()
    {
        int j = Random.Range(0,4);
        if (realTimetowait < 0)
        {
            
              GameObject newcar = Instantiate(cars[j], transform.position, Quaternion.identity);
              newcar.GetComponent<car>().recivedir(dir);
              realTimetowait = Timetowait;
            
        }
        else
        {   
           
            realTimetowait -= Time.deltaTime;
        }
        
        
    }
    
}
