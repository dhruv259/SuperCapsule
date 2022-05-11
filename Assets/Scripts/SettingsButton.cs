using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public Canvas settingsCanvas;
    public Canvas mainMenu;
    
    public void DisplaySettings()
    {
        mainMenu.gameObject.SetActive(false);
        settingsCanvas.gameObject.SetActive(true);
    }
}
