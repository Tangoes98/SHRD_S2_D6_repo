using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class F4DiceClick : MonoBehaviour, IPointerDownHandler
{
    public GameManager gameManager;
    public Text bottomText;
    public Image bottomColor;

    public BottomDiceEvent bde;


    // when mouse pressed on this dice
    public void OnPointerDown(PointerEventData eventData)
    {
        // if num condition fits
        if (gameManager.diceF4 - gameManager.bottomDiceNum == 1 || gameManager.diceF4 - gameManager.bottomDiceNum == -5)
        {
            transferRToBottom();
            transferRearDiceToF();
            ResetRearDice();
        }
        // if reset condition fits
        else if (bde.resetBottom == true)
        {
            transferRToBottom();
            transferRearDiceToF();
            ResetRearDice();

        }
        // if color condition fits
        else if (gameManager.bottomDiceColorNum == gameManager.colorF4Number)
        {
            transferRToBottom();
            transferRearDiceToF();
            ResetRearDice();
        }

        Debug.Log("f4 clicked");




    }
    void transferRToBottom()
    {
        //transfer num
        gameManager.bottomDiceNum = gameManager.diceF4;
        bottomText.text = gameManager.diceF4.ToString();

        //transfer color
        gameManager.colorBtm = gameManager.colorf4;
        bottomColor.color = gameManager.colorBtm;

        //transfer color number
        gameManager.bottomDiceColorNum = gameManager.colorF4Number;

        //reset reset bottom dice bool
        bde.resetBottom = false;

        //score
        gameManager.score += gameManager.bottomDiceNum;
        gameManager.ScoreText.text = gameManager.score.ToString() + " / 50";

        //chain increase
        gameManager.chain += 1;
        gameManager.ChainText.text = gameManager.chain.ToString() + " CHAIN";
    }


    void transferRearDiceToF()
    {

        //transfer number
        gameManager.diceF4 = gameManager.diceR4;
        gameManager.dicef4text.text = gameManager.diceF4.ToString();

        //transfer color value
        gameManager.colorf4 = gameManager.colorr4;
        gameManager.dicef4color.color = gameManager.colorf4;

        //transfer color number
        gameManager.colorF4Number = gameManager.colorR4Number;




    }

    void ResetRearDice()
    {
        //reset num
        gameManager.diceR4 = Random.Range(1, 7);
        gameManager.dicer4text.text = gameManager.diceR4.ToString();

        //reset color
        gameManager.DiceR4RandomColor();
    }
}
