using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform ball; // referencja do obiektu kuli
    public Vector3 offset; // wektor offsetu, kt�ry okre�la odleg�o�� kamery od kuli

    void Update()
    {
        // ustaw pozycj� kamery za kul� z uwzgl�dnieniem offsetu
        transform.position = ball.position + offset;
    }
}
