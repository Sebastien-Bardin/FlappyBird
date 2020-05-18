using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    //time before a pipe spawn
    public float maxTime = 1.5f;
    //timer counting the passing time
    private float timer = 0;
    //reference to the pipe object
    public GameObject pipe;
    //Pipe spawn height
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height),0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height),0);
            Destroy(newpipe,10);
            timer = 0;
        }
        
        timer += Time.deltaTime;
    }
}
