using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //scoring system
    public Text ScoreText;
    public int score;

    //reset counting system
    public int resetCount;
    public Color rcbColor;
    public Image rcb1; //reset count block
    public Image rcb2;
    public Image rcb3;
    public Image rcb4;
    public Image rcb5;
    public Image rcb6;

    //chain system
    public Text ChainText;
    public int chain;



    // text will  be shown as number

    //bottom dice var
    public Text bottomText;
    public Image bottomColor;
    public int bottomDiceNum;
    public int bottomDiceColorNum;
    public Color32 colorBtm;

    //1st front dice var 
    public Text dicef1text; 
    public Image dicef1color;
    public int diceF1;
    public int colorF1Number;
    public Color32 colorf1;

    //1st rear dice var
    public Text dicer1text;
    public Image dicer1color;
    public int diceR1;
    public int colorR1Number;
    public Color32 colorr1;

    //2 front dice var 
    public Text dicef2text;
    public Image dicef2color;
    public int diceF2;
    public int colorF2Number;
    public Color32 colorf2;

    //2 rear dice var
    public Text dicer2text;
    public Image dicer2color;
    public int diceR2;
    public int colorR2Number;
    public Color32 colorr2;

    //3 front dice var 
    public Text dicef3text;
    public Image dicef3color;
    public int diceF3;
    public int colorF3Number;
    public Color32 colorf3;

    //3 rear dice var
    public Text dicer3text;
    public Image dicer3color;
    public int diceR3;
    public int colorR3Number;
    public Color32 colorr3;

    //4 front dice var 
    public Text dicef4text;
    public Image dicef4color;
    public int diceF4;
    public int colorF4Number;
    public Color32 colorf4;

    //4 rear dice var
    public Text dicer4text;
    public Image dicer4color;
    public int diceR4;
    public int colorR4Number;
    public Color32 colorr4;

    //5 front dice var 
    public Text dicef5text;
    public Image dicef5color;
    public int diceF5;
    public int colorF5Number;
    public Color32 colorf5;

    //5 rear dice var
    public Text dicer5text;
    public Image dicer5color;
    public int diceR5;
    public int colorR5Number;
    public Color32 colorr5;



    // Start is called before the first frame update
    public void Awake()
    {
        ResetBottom();

        // starting score
        score = bottomDiceNum;
        ScoreText.text = bottomDiceNum.ToString() + " / 50";

        //chain system
        resetChain();

        // counting block color
        resetCount = 6;
        rcbColor = new Color32(255, 53, 139, 255);
        rcb1.color = rcbColor;
        rcb2.color = rcbColor;
        rcb3.color = rcbColor;
        rcb4.color = rcbColor;
        rcb5.color = rcbColor;
        rcb6.color = rcbColor;

        // dice 1 random number at the beginning 
        diceF1 = Random.Range(1,7);
        dicef1text.text = diceF1.ToString();
        diceR1 = Random.Range(1, 7);
        dicer1text.text = diceR1.ToString();

        diceF2 = Random.Range(1, 7);
        dicef2text.text = diceF2.ToString();
        diceR2 = Random.Range(1, 7);
        dicer2text.text = diceR2.ToString();

        diceF3 = Random.Range(1, 7);
        dicef3text.text = diceF3.ToString();
        diceR3 = Random.Range(1, 7);
        dicer3text.text = diceR3.ToString();

        diceF4 = Random.Range(1, 7);
        dicef4text.text = diceF4.ToString();
        diceR4 = Random.Range(1, 7);
        dicer4text.text = diceR4.ToString();

        diceF5 = Random.Range(1, 7);
        dicef5text.text = diceF5.ToString();
        diceR5 = Random.Range(1, 7);
        dicer5text.text = diceR5.ToString();


        DiceF1RandomColor();
        DiceR1RandomColor();

        DiceF2RandomColor();
        DiceR2RandomColor();
        
        DiceF3RandomColor();
        DiceR3RandomColor();
        
        DiceF4RandomColor();
        DiceR4RandomColor();

        DiceF5RandomColor();
        DiceR5RandomColor();
        
    }


    public void ResetBottom()
    {
        bottomDiceNum = 0;
        bottomText.text = bottomDiceNum.ToString();
        bottomColor.color = new Color32(0, 0, 0, 150);
    }

    public void resetChain()
    {
        chain = 0;
        ChainText.text = chain.ToString() + " CHAIN";

    }



    public void DiceF1RandomColor()
    {

        colorF1Number = Random.Range(1, 7);

        if (colorF1Number == 1)
        {
            colorf1 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorF1Number == 2)
        {
            colorf1 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorF1Number == 3)
        {
            colorf1 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorF1Number == 4)
        {
            colorf1 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorF1Number == 5)
        {
            colorf1 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorF1Number == 6)
        {
            colorf1 = new Color32(255, 53, 139, 255);// pink
        }

        dicef1color.color = colorf1;
    }
    /// <summary>
    /// 1 dice color
    /// </summary>
    public void DiceR1RandomColor()
    {

        colorR1Number = Random.Range(1, 7);

        if (colorR1Number == 1)
        {
            colorr1 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorR1Number == 2)
        {
            colorr1 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorR1Number == 3)
        {
            colorr1 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorR1Number == 4)
        {
            colorr1 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorR1Number == 5)
        {
            colorr1 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorR1Number == 6)
        {
            colorr1 = new Color32(255, 53, 139, 255);// pink
        }

        dicer1color.color = colorr1;
    }
    ////////////////////////////////////
    ///2 dice color
    public void DiceF2RandomColor()
    {

        colorF2Number = Random.Range(1, 7);

        if (colorF2Number == 1)
        {
            colorf2 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorF2Number == 2)
        {
            colorf2 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorF2Number == 3)
        {
            colorf2 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorF2Number == 4)
        {
            colorf2 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorF2Number == 5)
        {
            colorf2 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorF2Number == 6)
        {
            colorf2 = new Color32(255, 53, 139, 255);// pink
        }

        dicef2color.color = colorf2;
    }

    public void DiceR2RandomColor()
    {

        colorR2Number = Random.Range(1, 7);

        if (colorR2Number == 1)
        {
            colorr2 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorR2Number == 2)
        {
            colorr2 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorR2Number == 3)
        {
            colorr2 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorR2Number == 4)
        {
            colorr2 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorR2Number == 5)
        {
            colorr2 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorR2Number == 6)
        {
            colorr2 = new Color32(255, 53, 139, 255);// pink
        }

        dicer2color.color = colorr2;
    }
    //////////////////
    ///3 dice color
    public void DiceF3RandomColor()
    {

        colorF3Number = Random.Range(1, 7);

        if (colorF3Number == 1)
        {
            colorf3 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorF3Number == 2)
        {
            colorf3 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorF3Number == 3)
        {
            colorf3 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorF3Number == 4)
        {
            colorf3 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorF3Number == 5)
        {
            colorf3 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorF3Number == 6)
        {
            colorf3 = new Color32(255, 53, 139, 255);// pink
        }

        dicef3color.color = colorf3;
    }

    public void DiceR3RandomColor()
    {

        colorR3Number = Random.Range(1, 7);

        if (colorR3Number == 1)
        {
            colorr3 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorR3Number == 2)
        {
            colorr3 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorR3Number == 3)
        {
            colorr3 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorR3Number == 4)
        {
            colorr3 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorR3Number == 5)
        {
            colorr3 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorR3Number == 6)
        {
            colorr3 = new Color32(255, 53, 139, 255);// pink
        }

        dicer3color.color = colorr3;
    }
    ///////////
    ///4dice color
    public void DiceF4RandomColor()
    {

        colorF4Number = Random.Range(1, 7);

        if (colorF4Number == 1)
        {
            colorf4 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorF4Number == 2)
        {
            colorf4 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorF4Number == 3)
        {
            colorf4 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorF4Number == 4)
        {
            colorf4 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorF4Number == 5)
        {
            colorf4 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorF4Number == 6)
        {
            colorf4 = new Color32(255, 53, 139, 255);// pink
        }

        dicef4color.color = colorf4;
    }

    public void DiceR4RandomColor()
    {

        colorR4Number = Random.Range(1, 7);

        if (colorR4Number == 1)
        {
            colorr4 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorR4Number == 2)
        {
            colorr4 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorR4Number == 3)
        {
            colorr4 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorR4Number == 4)
        {
            colorr4 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorR4Number == 5)
        {
            colorr4 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorR4Number == 6)
        {
            colorr4 = new Color32(255, 53, 139, 255);// pink
        }

        dicer4color.color = colorr4;
    }
    ///////////////////
    ///5dice color
    public void DiceF5RandomColor()
    {

        colorF5Number = Random.Range(1, 7);

        if (colorF5Number == 1)
        {
            colorf5 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorF5Number == 2)
        {
            colorf5 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorF5Number == 3)
        {
            colorf5 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorF5Number == 4)
        {
            colorf5 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorF5Number == 5)
        {
            colorf5 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorF5Number == 6)
        {
            colorf5 = new Color32(255, 53, 139, 255);// pink
        }

        dicef5color.color = colorf5;
    }

    public void DiceR5RandomColor()
    {

        colorR5Number = Random.Range(1, 7);

        if (colorR5Number == 1)
        {
            colorr5 = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorR5Number == 2)
        {
            colorr5 = new Color32(89, 224, 0, 255);// green
        }
        else if (colorR5Number == 3)
        {
            colorr5 = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorR5Number == 4)
        {
            colorr5 = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorR5Number == 5)
        {
            colorr5 = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorR5Number == 6)
        {
            colorr5 = new Color32(255, 53, 139, 255);// pink
        }

        dicer5color.color = colorr5;
    }






















    /*

    void DiceRandomColor(Color32 color)
    {


        Debug.Log("color num is" + colorNumber);
        if (colorNumber == 1)
        {
            color = new Color32(67, 68, 255, 255);// blue
        }
        else if (colorNumber == 2)
        {
            color = new Color32(89, 224, 0, 255);// green
        }
        else if (colorNumber == 3)
        {
            color = new Color32(255, 157, 53, 255);// orange
        }
        else if (colorNumber == 4)
        {
            color = new Color32(178, 76, 242, 255);// violet
        }
        else if (colorNumber == 5)
        {
            color = new Color32(1, 176, 240, 255);//sky blue
        }
        else if (colorNumber == 6)
        {
            color = new Color32(255, 53, 139, 255);// pink
        }
    }
    */
}
