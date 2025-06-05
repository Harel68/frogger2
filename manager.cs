using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manager : MonoBehaviour
{
    [SerializeField] private TMP_Text textmoney;
    private int money;
    [SerializeField] private GameObject player;
    [SerializeField] private Renderer plren;
    // Start is called before the first frame update
    void Start()
    {
        plren = player.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        textmoney.text = "" + money;
    }
    public void setmoney(int money)
    {
        this.money += money;
    }

    public void changecolor(string color)
    {
        if ("green" == color)
        {
            plren.material.color = Color.green;

        }
        if ("black" == color)
        {
            plren.material.color = Color.black;

        }
        if ("red" == color)
        {
            plren.material.color = Color.red;

        }
        if ("blue" == color)
        {
            plren.material.color = Color.blue;

        }
    }




}
