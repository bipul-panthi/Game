using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Complete : MonoBehaviour
{
    public TMP_Text CompleteText;
    public CanvasGroup RetryButton;


    void Start()
    {
        RetryButton.interactable = false;
        RetryButton.alpha = 0;
        RetryButton.blocksRaycasts = false;

    }

    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CompleteText.text = "Complete!! Press Retry to play again";
            RetryButton.interactable = true;
            RetryButton.alpha = 1;
            RetryButton.blocksRaycasts = true;

        }
    }

}
