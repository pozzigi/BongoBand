using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    private Rigidbody2D rb;
    public float beatsPerMinute = 120;
    private float beatsPerSecond, velocity, distance, yAxisValue;
    

    private float getVelocityForY(float beatsPerMinute, GameObject controller){

        beatsPerSecond = beatsPerMinute / 60;
        distance = transform.position.y - controller.transform.position.y;
        velocity = distance * beatsPerSecond;

        return velocity;

    }

    private void Awake() {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Start is called before the first frame update
    void Start(){
        
        GameObject controller = GameObject.FindGameObjectWithTag("controller");
        
        //Setting up the velocity between the note and the controller
        //based on the BPM of the song 

        yAxisValue = getVelocityForY(beatsPerMinute, controller) * -1;
        rb.velocity = new Vector2(0, yAxisValue);

        
    }

    // Update is called once per frame
    void Update(){
        
    }

}
