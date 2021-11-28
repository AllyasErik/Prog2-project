using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectedSkin : MonoBehaviour
{

    public static bool Skin1Selected;
    public static bool Skin2Selected;
    public static bool Skin3Selected;
    public static bool Skin4Selected;
    public void SelectedSkin1()
    {
        Skin1Selected = true;
        Skin2Selected = false;
        Skin3Selected = false;
        Skin4Selected = false;
    }
    public void SelectedSkin2()
    {
        Skin1Selected = false;
        Skin2Selected = true;
        Skin3Selected = false;
        Skin4Selected = false;
    }
    public void SelectedSkin3()
    {
        Skin2Selected = false;
        Skin1Selected = false;
        Skin3Selected = true;
        Skin4Selected = false;
    }
    public void SelectedSkin4()
    {
        Skin2Selected = false;
        Skin1Selected = false;
        Skin3Selected = false;
        Skin4Selected = true;
    }
    public void Next()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
