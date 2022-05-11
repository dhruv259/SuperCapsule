using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    public Canvas levelCanvas;
    public Canvas mainMenu;
    
    public void DisplayLevel()
    {
        mainMenu.gameObject.SetActive(false);
        levelCanvas.gameObject.SetActive(true);
    }
}
