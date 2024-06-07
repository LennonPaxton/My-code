using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{

    private int damage = 5;

    
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Sam")
        {
            if (Input.GetMouseButtonDown(0))
            {
                collider.GetComponent<HealthSam>().Health -= damage;
            }

        }
    }
}
