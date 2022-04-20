using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class F1DiceClick : MonoBehaviour, IPointerDownHandler
{
    public GameManager gameManager;
    public Text bottomText;
    public Image bottomColor;

    public BottomDiceEvent bde;


    // when mouse pressed on this dice
    public void OnPointerDown(PointerEventData eventData) 
    {
        // if num condition fits
        if (gameManager.diceF1 - gameManager.bottomDiceNum == 1 || gameManager.diceF1 - gameManager.bottomDiceNum == -5)
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
        else if (gameManager.bottomDiceColorNum == gameManager.colorF1Number)
        {
            transferRToBottom();
            transferRearDiceToF();
            ResetRearDice();
        }

        Debug.Log("f1 clicked");


        


    }
    void transferRToBottom()
    {
        //transfer num
        gameManager.bottomDiceNum = gameManager.diceF1;
        bottomText.text = gameManager.diceF1.ToString();

        //transfer color
        gameManager.colorBtm = gameManager.colorf1;
        bottomColor.color = gameManager.colorBtm;

        //transfer color number
        gameManager.bottomDiceColorNum= gameManager.colorF1Number;

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
        gameManager.diceF1 = gameManager.diceR1;
        gameManager.dicef1text.text = gameManager.diceF1.ToString();

        //transfer color value
        gameManager.colorf1 = gameManager.colorr1;
        gameManager.dicef1color.color = gameManager.colorf1;

        //transfer color number
        gameManager.colorF1Number = gameManager.colorR1Number;




    }

    void ResetRearDice()
    {
        //reset num
        gameManager.diceR1 = Random.Range(1, 7);
        gameManager.dicer1text.text = gameManager.diceR1.ToString();

        //reset color
        gameManager.DiceR1RandomColor();
    }



}
