using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public Canvas mainMenu;
    
    public void BackToMenu()
    {
        this.gameObject.transform.parent.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }
}
