using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent; 
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = (
            "It's finally morning! I've been waiting all night for this. Time for the morning walk! Usually there are lots of street toasts out there and I'm ready for my breakfast. Let's try to get one of the humans to walk us. Who will you choose? 1. Lars - is afraid of other dogs, might not be able to defend against intruders; 2. Sarah - will take a lot of pictures of you - might snatch up your toasts."
            );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
