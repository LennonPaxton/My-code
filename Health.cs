using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Health : MonoBehaviour
 {
    public static int health = 20;
    [SerializeField] static float maxHealth = 20;
    public static bool CharacterIsDead = false;

    static Slider healthSlider = null;

    private void Start()
    {
        healthSlider = GetComponent<Slider>();
    }

    public static int PlayerHealth
    {
        get 
        { 
            return health;
        }
        set 
        { 
            health = value;
            if(healthSlider)  healthSlider.value = (1 / health) * maxHealth;
        }
    }
}
