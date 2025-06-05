using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    private int i = 0;
    [SerializeField] private float carspeed;
    [SerializeField] private GameObject manager;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(i, 0, 0) * carspeed * Time.deltaTime;
        Destroy(gameObject, 10);
    }
    public void recivedir(int type)
    {
        i = type;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player")
        {
            manager.GetComponent<swichscene>().Dead();
        }
    }
}
