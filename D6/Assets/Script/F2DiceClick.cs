using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class F2DiceClick : MonoBehaviour, IPointerDownHandler
{
    public GameManager gameManager;
    public Text bottomText;
    public Image bottomColor;

    public BottomDiceEvent bde;


    // when mouse pressed on this dice
    public void OnPointerDown(PointerEventData eventData)
    {
        // if num condition fits
        if (gameManager.diceF2 - gameManager.bottomDiceNum == 1 || gameManager.diceF2 - gameManager.bottomDiceNum == -5)
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
        else if (gameManager.bottomDiceColorNum == gameManager.colorF2Number)
        {
            transferRToBottom();
            transferRearDiceToF();
            ResetRearDice();
        }


        Debug.Log("f2 clicked");




    }
    void transferRToBottom()
    {
        //transfer num
        gameManager.bottomDiceNum = gameManager.diceF2;
        bottomText.text = gameManager.diceF2.ToString();

        //transfer color
        gameManager.colorBtm = gameManager.colorf2;
        bottomColor.color = gameManager.colorBtm;

        //transfer color number
        gameManager.bottomDiceColorNum = gameManager.colorF2Number;

        //reset reset bottom dice bool
        bde.resetBottom = false;

        //score
        gameManager.score += gameManager.bottomDiceNum;
        gameManager.ScoreText.text = gameManager.score.ToString() + " / 50";
    }


    void transferRearDiceToF()
    {

        //transfer number
        gameManager.diceF2 = gameManager.diceR2;
        gameManager.dicef2text.text = gameManager.diceF2.ToString();

        //transfer color value
        gameManager.colorf2 = gameManager.colorr2;
        gameManager.dicef2color.color = gameManager.colorf2;

        //transfer color number
        gameManager.colorF2Number = gameManager.colorR2Number;

        //chain increase
        gameManager.chain += 1;
        gameManager.ChainText.text = gameManager.chain.ToString() + " CHAIN";


    }

    void ResetRearDice()
    {
        //reset num
        gameManager.diceR2 = Random.Range(1, 7);
        gameManager.dicer2text.text = gameManager.diceR2.ToString();

        //reset color
        gameManager.DiceR2RandomColor();
    }



}
