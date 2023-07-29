using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class NavScript : MonoBehaviour
{
    public Text btnNavegacion;
    public string escena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gotoScene(){
        SceneManager.LoadScene(escena);
    } 
}
