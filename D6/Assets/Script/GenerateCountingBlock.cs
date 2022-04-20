using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCountingBlock : MonoBehaviour
{
    // Start is called before the first frame update

    //reset counting system
    //public GameObject countingTop;
    public GameObject countingBottom;
    void Start()
    {
        // reset ui
        // ResetCounting(5);
        Instantiate(countingBottom, transform.position,transform.rotation);


    }
    public void ResetCounting(int countNum)
    {

        for (int i = 0; i < countNum; i++)
        {
            GameObject cointBottomClone = Instantiate(countingBottom, new Vector2(countingBottom.transform.position.x, countingBottom.transform.position.y + 100f), Quaternion.identity);
        }
    }


}
