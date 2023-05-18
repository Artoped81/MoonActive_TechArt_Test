using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageStructure : MonoBehaviour
{
    public List<GameObject> structureLevels;
    public GameObject buildButtonEnabled;
    public GameObject buildButtonDisabled;
    public GameObject buildEffect;

    int currentLevel;
    

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLevel >= structureLevels.Count)
        {
            buildButtonEnabled.SetActive(false);
            buildButtonDisabled.SetActive(true);
        }
    }

    public void BuildSequence()
    {
        GameObject effect = Instantiate(buildEffect, transform.position, transform.rotation);
        effect.transform.SetParent(gameObject.transform, false);
        StartCoroutine(Delay());
        
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.5f);
        BuildStructure();
    }

    public IEnumerator LevelOutIn(float delay)
    {
        Animator animOut = structureLevels[currentLevel - 1].GetComponent<Animator>();
        animOut.Play("Level_Out");
        yield return new WaitForSeconds(delay);
        structureLevels[currentLevel - 1].SetActive(false);
        LevelIn();
        
    }

    public void LevelIn()
    {
        structureLevels[currentLevel].SetActive(true);
        Animator animIn = structureLevels[currentLevel].GetComponent<Animator>();
        animIn.Play("Level_In");
        StopAllCoroutines();

        currentLevel++;
    }

    public void BuildStructure()
    {
        if (currentLevel < structureLevels.Count)
        {
            buildButtonEnabled.SetActive(true);
            buildButtonDisabled.SetActive(false);

            if (currentLevel > 0)
            {
                StartCoroutine(LevelOutIn(0.7f));
            }
            else
            {
                LevelIn();
            }
            
            
        }
        else
        {
            buildButtonEnabled.SetActive(false);
            buildButtonDisabled.SetActive(true);
        }
        
    }

}
