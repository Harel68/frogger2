using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swichscene : MonoBehaviour
{
    [SerializeField]private GameObject howtoplay_ob;
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HowtoPlay()
    {
        howtoplay_ob.SetActive(true);
    }
    public void exitHowtoPlay()
    {
        howtoplay_ob.SetActive(false);
    }
    public void Dead( )
    {
        SceneManager.LoadScene("startscene");
    }


}
