using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] Player playerOne;
    [SerializeField] Player playerTwo;



    void Update()
    {
        time -= Time.deltaTime;
        time = Mathf.Clamp(time, 0, 1000);

        if (time == 0)
        {
            Time.timeScale = 0;
            
            
            if (playerOne.score > playerTwo.score)
            {
                timerText.text = "¡JUGADOR 1 GANADOR!";
            }
            else if (playerOne.score < playerTwo.score)
            {
                timerText.text = "¡JUGADOR 2 GANADOR!";
            }
            else
            {
                timerText.text = "¡EMPATE!";
            }
        }
        else
        {
            timerText.text = $"{(int)time}";
        }
    }
}
