using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateShaders : MonoBehaviour
{
    public List<Material> materials;
    public float value;

    // Update is called once per frame
    void Update()
    {
        foreach (Material mat in materials)
        {
            mat.SetFloat("_Visibility", value);
        }
    }
}
