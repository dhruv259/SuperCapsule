using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

    // public bool gameStart;

    public Canvas mainMenuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        if (gm == null)
        {
            gm = this.GetComponent<GameManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if(gameStart)
        // {
        //     mainMenuCanvas.gameObject.SetActive(false);
        // }
    }
}
