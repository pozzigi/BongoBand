using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    
    public KeyCode key;
    private SpriteRenderer sr;
    private bool triggerIsActive = false;
    private GameObject note;
    private Color initialColor;
    //End of var declaration

    private void Awake(){
        
        sr = GetComponent<SpriteRenderer>();

    }

    private void Start() {
        
        initialColor = sr.color;

    }

    // Update is called once per frame
    private void Update(){
        
        if(Input.GetKeyDown(key))
            StartCoroutine(ButtonPressed());

        if(Input.GetKeyDown(key) && triggerIsActive)
            Destroy(note);

    }

    private void OnTriggerEnter2D(Collider2D col){

        triggerIsActive = true;
        
        if(col.gameObject.tag == "note")
            note = col.gameObject;


    }

    private void OnTriggerExit2D(Collider2D col) {
        
        triggerIsActive = false;

    }

    IEnumerator ButtonPressed(){
        
        sr.color = new Color(40,150,200);

        yield return new WaitForSeconds(0.1f);
        sr.color = initialColor;

    }

}
