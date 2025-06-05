using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float speed;
   
    private Vector3 target;
    [SerializeField] GameObject targetmark;
    [SerializeField] private GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(transform.position.x, 0, transform.position.z);
        GameObject mark = Instantiate(targetmark, target, Quaternion.identity);
        Destroy(mark, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
        if (transform.position.y < 0.2f)
        {

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            manager.GetComponent<swichscene>().Dead();
        }
    }
}
