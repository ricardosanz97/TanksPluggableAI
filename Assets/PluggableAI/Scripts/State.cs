using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/State")]
public class State : ScriptableObject
{

    public Action[] actions;

    public Color sceneGizmoColor = Color.grey;

	public void UpdateState(StateController controller)//we need the parameter because we receive the info from the Scene Object from parameter.
    {
        DoActions(controller);
    }

    private void DoActions(StateController controller)//the state order to do the actions
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Act(controller);
        }
    }


}
