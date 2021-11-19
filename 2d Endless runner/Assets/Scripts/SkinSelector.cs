using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class SkinSelector : MonoBehaviour
{
    /*public SpriteRenderer bodyPart;
    public List<Sprite> options = new List<Sprite>();
    private int currentOption = 0;

    public void NextOption() 
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }
        bodyPart.sprite = options[currentOption];
    }
    public void PreviousOption()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }
        bodyPart.sprite = options[currentOption];
    }
    */

    public SpriteRenderer head;
    public SpriteRenderer body;
    public SpriteRenderer sword;
    public List<Sprite> headskins = new List<Sprite>();
    public List<Sprite> bodyskins = new List<Sprite>();
    public List<Sprite> swordskins = new List<Sprite>();
    private int currentOption = 0;
    public GameObject headskin;
    public GameObject bodyskin;
    public GameObject swordskin;
    public GameObject playerskin;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= headskins.Count)
        {
            currentOption = 0;
        }
        head.sprite = headskins[currentOption];
        body.sprite = bodyskins[currentOption];
        sword.sprite = swordskins[currentOption];
    }
    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <= 0)
        {
            currentOption = headskins.Count - 1;
        }
        head.sprite = headskins[currentOption];
        body.sprite = bodyskins[currentOption];
        sword.sprite = swordskins[currentOption];
    }

    public void SelectSkin()
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Ghost1.prefab");
        SceneManager.LoadScene("Main Menu");
    }
}
