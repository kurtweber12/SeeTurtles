using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LightingDropdown : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;
    public Toggle toggle;

    void Update()
    {
        RenderSettings.skybox = toggle.isOn ? daySkybox : nightSkybox;
    }
}
