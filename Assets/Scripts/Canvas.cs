using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    [SerializeField] Text pointsCounter;

    void Update()
    {
        pointsCounter.text = $"£{GameManager.points}";
    }
}
