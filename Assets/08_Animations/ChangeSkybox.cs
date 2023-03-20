using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material SkyBox1;
    public Material SkyBox2;
    public GameObject Animation;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = SkyBox1;
        Animation.SetActive(false);
    }

    void OnTriggerEnter(Collider box) 
    {
        RenderSettings.skybox = SkyBox2;
        Animation.SetActive(true); 
        Debug.Log("switch skybox");
        DynamicGI.UpdateEnvironment();
    }
   
    
}
