using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHitObserver : MonoBehaviour
{

    void Start()
    {
        FindObjectOfType<ObjectMovement>().PlayerHitsGroundEvent += on_PlayerHitsGround; 
    }

    public void on_PlayerHitsGround(ObjectMovement om)
    {
        print("Oh no we really did hit the ground.");
    }

}
