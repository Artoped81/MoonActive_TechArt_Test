using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreStructure : MonoBehaviour
{
    public List<Sprite> imagesStructure;
    public List<GameObject> progressBarStars;

    public GameObject costText;
    public GameObject completeText;

    public GameObject buttonBuy;
    
    public GameObject doubleState;
    public GameObject doubleImage_current;
    public GameObject doubleImage_next;
    
    public GameObject singleState;
    public GameObject singleImage;

    public Image progressBar;
    
    private int currentLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = 0;
        
        doubleState.SetActive(false);
        singleState.SetActive(true);
                
        singleImage.GetComponent<Image>().sprite = imagesStructure[currentLevel];
        
    }

    public void BuildStructure()
    {
        if (currentLevel < imagesStructure.Count -1)
        {
            doubleState.SetActive(true);
            singleState.SetActive(false);
            doubleImage_current.GetComponent<Image>().sprite = imagesStructure[currentLevel];
            doubleImage_next.GetComponent<Image>().sprite = imagesStructure[currentLevel+1];
            
        }
        else
        {
            doubleState.SetActive(false);
            singleState.SetActive(true);
            singleImage.GetComponent<Image>().sprite = imagesStructure[currentLevel - 1];

            buttonBuy.SetActive(false);
            costText.SetActive(false);
            completeText.SetActive(true);
        }
        
        progressBarStars[currentLevel].SetActive(true);
        progressBar.fillAmount = (float) currentLevel / (imagesStructure.Count - 1);
            
        currentLevel++;
        
        int structureCost = 0;
        int.TryParse(costText.GetComponent<Text>().text, out structureCost);
        CashBalance.cashAmount -= structureCost;
    }

}
