using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneOptions()
    {
        SceneManager.LoadScene("Options");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
