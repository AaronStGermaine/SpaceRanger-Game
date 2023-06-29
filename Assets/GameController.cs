using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public int maxStars = 0;

    public void GameOver()
    {
        GameOverScreen.Setup(maxStars);
    }

}
