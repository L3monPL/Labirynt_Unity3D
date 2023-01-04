using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform ball; // referencja do obiektu kuli
    public Vector3 offset; // wektor offsetu, który okreœla odleg³oœæ kamery od kuli

    void Update()
    {
        // ustaw pozycjê kamery za kul¹ z uwzglêdnieniem offsetu
        transform.position = ball.position + offset;
    }
}
