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
        // get all of the next states possible
        var nextStates = state.GetNextStates();
        // if they press 1, move to the first state in the array, and so on
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            textComponent.text = state.GetStateStory();
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha2)){
            state = nextStates[1];
            textComponent.text = state.GetStateStory();
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha3)){
            state = nextStates[2];
            textComponent.text = state.GetStateStory();
        }
    }
}
