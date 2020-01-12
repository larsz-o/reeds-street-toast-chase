using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //SerailizeField gives the ability to map variables onto Unity objects
    [SerializeField] Text textComponent; 
    [SerializeField] State startingState;
  
    State state;
    // Start is called before the first frame update
    void Start()
    {
        //our initial starting text load 
        state = startingState;
        // what will go into the text area where our storytext is displayed
        textComponent.text = state.GetStateStory();
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    private void ManageState()
    {
        var nextStates = state.GetNextStates();
    }
}
