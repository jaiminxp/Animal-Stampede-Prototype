using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public int amountToBeFed;
    public Slider hungerSlider;
    int currentFedAmount = 0;
    GameManager gameManager;

    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            gameManager.UpdateScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }

    }

    void Update()
    {

    }
}
