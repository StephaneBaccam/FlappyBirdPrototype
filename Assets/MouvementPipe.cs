using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementPipe : MonoBehaviour
{
    public float vit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * vit * Time.deltaTime; //Les pipes se déplacent vers la gauche à une certaine vitesse que l'on peut modifier.
    }
}
