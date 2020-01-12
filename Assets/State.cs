using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    
    //this is what will display in our storytext area, but it will change depending upon where we are in the story
   [TextArea (10, 14)] [SerializeField] string storyText;
    public string GetStateStory()
    {
        return storyText;
    }
}
