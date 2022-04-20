using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class F3DiceClick : MonoBehaviour, IPointerDownHandler
{
    public GameManager gameManager;
    public Text bottomText;
    public Image bottomColor;

    public BottomDiceEvent bde;


    // when mouse pressed on this dice
    public void OnPointerDown(PointerEventData eventData)
    {
        // if num condition fits
        if (gameManager.diceF3 - gameManager.bottomDiceNum == 1 || gameManager.diceF3 - gameManager.bottomDiceNum == -5)
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
        else if (gameManager.bottomDiceColorNum == gameManager.colorF3Number)
        {
            transferRToBottom();
            transferRearDiceToF();
            ResetRearDice();
        }

        Debug.Log("f3 clicked");




    }
    void transferRToBottom()
    {
        //transfer num
        gameManager.bottomDiceNum = gameManager.diceF3;
        bottomText.text = gameManager.diceF3.ToString();

        //transfer color
        gameManager.colorBtm = gameManager.colorf3;
        bottomColor.color = gameManager.colorBtm;

        //transfer color number
        gameManager.bottomDiceColorNum = gameManager.colorF3Number;

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
        gameManager.diceF3 = gameManager.diceR3;
        gameManager.dicef3text.text = gameManager.diceF3.ToString();

        //transfer color value
        gameManager.colorf3 = gameManager.colorr3;
        gameManager.dicef3color.color = gameManager.colorf3;

        //transfer color number
        gameManager.colorF3Number = gameManager.colorR3Number;




    }

    void ResetRearDice()
    {
        //reset num
        gameManager.diceR3 = Random.Range(1, 7);
        gameManager.dicer3text.text = gameManager.diceR3.ToString();

        //reset color
        gameManager.DiceR3RandomColor();
    }
}
