using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class canvas : MonoBehaviour
{
    public GameObject canvasPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void see() { 

        canvasPrefab.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
