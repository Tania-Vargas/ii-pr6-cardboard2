using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class canvas_control : MonoBehaviour
{
    private DragonCollecting dragon;
    private TextMeshProUGUI  scoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject dragonObj = GameObject.FindWithTag("blueDragon");
        if (dragonObj != null)
        {
            dragon = dragonObj.GetComponent<DragonCollecting>();
            if (dragon != null)
            {
                dragon.action += updateScore;
            }
        }

        scoreText = GetComponent<TextMeshProUGUI >();
    }

    void updateScore(string msg)
    {
        if (msg == "score") {
            int newScore = dragon.count;
            scoreText.text = "Points " + newScore;
            scoreText.color = Color.white;
            scoreText.fontSize = 30;
            scoreText.gameObject.SetActive(true);
            Debug.Log(newScore);
        }        
    }
}
