using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
  
    public void SalleA()
    {
        SceneManager.LoadScene("SalleA");
    }
    public void SalleB()
    {
        SceneManager.LoadScene("SalleB");
    }
    public void OptionsLoad()
    {
        SceneManager.LoadScene("Options");
    }

}
