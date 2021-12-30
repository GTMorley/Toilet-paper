using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private Renderer myObject;
    bool needsRoll = false;
    float timer = 10;
    float percentChance = 0.1f;
    //float randomValue = Random.Range(0.0f, 20.0f);
    void Update()
    {
        //Debug.Log(timer);
        if (timer <= 0)
        {
            if (Random.value <= percentChance)
            {
                timer = 10;
                needsRoll = true;
                Debug.Log("needsroll");
                myObject.material.color = Color.red;
            }
        }
        else
        {
            timer -= 1 * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (needsRoll)
        {
            Debug.Log("rollgiven");
            needsRoll = false;
            myObject.material.color = Color.gray;
        }

    }

}