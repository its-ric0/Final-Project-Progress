using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public ScreenFader screenFader;

    public void OnStartButtonPressed() 
    {
        screenFader.SlideIn();

    }
}
