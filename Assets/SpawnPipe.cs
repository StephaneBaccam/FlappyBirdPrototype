using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime) //Timer est incrémenté toute les secondes, maxTime est le temps entre le spawn des pipes.
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); //On donne une valeur random de Y à chaque spawn de pipe.
            Destroy(newPipe, 20); //Les pipes se détruisent au bout de 20 secondes
            timer = 0; //Retour à 0
        }
        timer += Time.deltaTime; //incrémentation du timer.
    }
    
}
