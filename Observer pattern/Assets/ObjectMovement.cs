using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int force = 200;

    public delegate void PlayerHitsGroundDelegate(ObjectMovement om);
    public event PlayerHitsGroundDelegate PlayerHitsGroundEvent;

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Z))
        {
            UpwardsForce();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        HitTheGround();    
    }
    private void UpwardsForce()
    {
        rb.AddForce(Vector3.up * force);
    }

    public void HitTheGround()
    {
        print("We hit something.");
        PlayerHitsGroundEvent(this);
    }
} //https://medium.com/teamarimac/using-observer-pattern-in-unity-6ebce4fdddf1

