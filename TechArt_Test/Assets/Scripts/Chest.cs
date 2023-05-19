using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Chest : MonoBehaviour
{
    [SerializeField] Button button;   

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(FirstOpen);
    }

    public void FirstOpen()
    {
        Animator firstOpenAnim = GetComponent<Animator>();
        firstOpenAnim.Play("chest_first_open");
        button.onClick.AddListener(OpenChest);
        
    }

    public void OpenChest()
    {
        Animator openAnim = GetComponent<Animator>();
        openAnim.Play("chest_open");
    }

    public void DisableInteraction()
    {
        button.interactable = false;
    }

    public void EnableInteraction()
    {
        button.interactable = true;
    }

}
