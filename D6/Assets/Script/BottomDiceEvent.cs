using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BottomDiceEvent : MonoBehaviour, IPointerClickHandler
{

    public bool resetBottom;
    public GameManager gameManager;

    //game over
    public GameObject gameOverMenu;



    public void Awake()
    {
        resetBottom = true;
    }
    public void OnPointerClick(PointerEventData eventData) // when mouse pressed on this object
    {

        Debug.Log("Bottom on point click");

        gameManager.ResetBottom();

        resetBottom = true;

        gameManager.resetCount -= 1;

        if(gameManager.resetCount == 5)
        {
            gameManager.rcb6.color = new Color32(255, 255, 255, 255);
        }
        else if(gameManager.resetCount == 4)
        {
            gameManager.rcb5.color = new Color32(255, 255, 255, 255);
        }
        else if (gameManager.resetCount == 3)
        {
            gameManager.rcb4.color = new Color32(255, 255, 255, 255);
        }
        else if (gameManager.resetCount == 2)
        {
            gameManager.rcb3.color = new Color32(255, 255, 255, 255);
        }
        else if (gameManager.resetCount == 1)
        {
            gameManager.rcb2.color = new Color32(255, 255, 255, 255);
        }
        else if (gameManager.resetCount == 0)
        {
            gameManager.rcb1.color = new Color32(255, 255, 255, 255);
        }
        else if(gameManager.resetCount < 0)
        {
            Debug.Log("Game over");
            gameOverMenu.SendMessage("GameIsOver");

        }

        //reset chain
        gameManager.resetChain();








    }




}
