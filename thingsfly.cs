using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thingsfly : MonoBehaviour
{
    private int x;
    private int z;
    [SerializeField] private GameObject pl;
    [SerializeField] private GameObject ball;

    [SerializeField] private float Timetowait;
    [SerializeField] private float realTimetowait;



    // Start is called before the first frame update
    void Start()
    {
        realTimetowait = Timetowait;

    }
    // Update is called once per frame
    void Update()
    {
        if (realTimetowait < 0)
        {
            x = Random.Range(-15, 15);
            int plxInt = Mathf.CeilToInt(pl.transform.position.z);
            int plzInt = Mathf.CeilToInt(pl.transform.position.z);
            z = Random.Range(plxInt - 2, plzInt + 4);
            Vector3 where = new Vector3(x, 20, z);
            Instantiate(ball, where, Quaternion.identity);

            realTimetowait = Timetowait;
        }
        else
        {
            realTimetowait -= Time.deltaTime;
        }
      



     }
}
