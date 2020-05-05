using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
/// 

public class Asteroids : MonoBehaviour
{
    [SerializeField] Sprite[] asteroids = new Sprite[3];
    
    
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = asteroids[Random.Range(0, asteroids.Length)];

        // apply impulse force to get game object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);
    }
}
