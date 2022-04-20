using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class F5DiceClick : MonoBehaviour, IPointerDownHandler
{
    public GameManager gameManager;
    public Text bottomText;
    public Image bottomColor;

    public BottomDiceEvent bde;


    // when mouse pressed on this dice
    public void OnPointerDown(PointerEventData eventData)
    {
        // if num condition fits
        if (gameManager.diceF5 - gameManager.bottomDiceNum == 1 || gameManager.diceF5 - gameManager.bottomDiceNum == -5)
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
        else if (gameManager.bottomDiceColorNum == gameManager.colorF5Number)
        {
            transferRToBottom();
            transferRearDiceToF();
            ResetRearDice();
        }

        Debug.Log("f5 clicked");




    }
    void transferRToBottom()
    {
        //transfer num
        gameManager.bottomDiceNum = gameManager.diceF5;
        bottomText.text = gameManager.diceF5.ToString();

        //transfer color
        gameManager.colorBtm = gameManager.colorf5;
        bottomColor.color = gameManager.colorBtm;

        //transfer color number
        gameManager.bottomDiceColorNum = gameManager.colorF5Number;

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
        gameManager.diceF5 = gameManager.diceR5;
        gameManager.dicef5text.text = gameManager.diceF5.ToString();

        //transfer color value
        gameManager.colorf5 = gameManager.colorr5;
        gameManager.dicef5color.color = gameManager.colorf5;

        //transfer color number
        gameManager.colorF5Number = gameManager.colorR5Number;




    }

    void ResetRearDice()
    {
        //reset num
        gameManager.diceR5 = Random.Range(1, 7);
        gameManager.dicer5text.text = gameManager.diceR5.ToString();

        //reset color
        gameManager.DiceR5RandomColor();
    }
}
