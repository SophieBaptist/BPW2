using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWorlds : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NatureWorld;
    public GameObject SetInactiveNature;
    public List<Material> materials;
    public Material SkyBox1;
    public Material SkyBox2;
    bool isInteractable = true;
    public GameObject road;
    public GameObject roadProps;
    public GameObject lanterns;
    public GameObject plane;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isInteractable)
        {
            //visibility stad in
            if (materials[0].GetFloat("_Visibility") > 1)
            {
                foreach (Material mat in materials)
                {
                    mat.SetFloat("_Visibility", 0);
                }
                RenderSettings.skybox = SkyBox1;
                DynamicGI.UpdateEnvironment();
            }
            //visibility in natuur
            else
            {
                foreach (Material mat in materials)
                {
                    mat.SetFloat("_Visibility", 2);
                }
                RenderSettings.skybox = SkyBox2;
                DynamicGI.UpdateEnvironment();
            }
            Invoke("ToggleEnvironment", Time.deltaTime);
            isInteractable = false;
            Invoke("ResetInteractable", 0.1f);
        }
    }

    void ToggleEnvironment()
    {
        road.SetActive(!road.activeSelf);
        roadProps.SetActive(!roadProps.activeSelf);
        lanterns.SetActive(!lanterns.activeSelf);
        plane.SetActive(!plane.activeSelf);
        NatureWorld.SetActive(!NatureWorld.activeSelf);
        SetInactiveNature.SetActive(false);
    }

    void ResetInteractable()
    {
        isInteractable = true;
    }
}
