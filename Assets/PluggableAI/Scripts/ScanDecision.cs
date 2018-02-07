using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "PluggableAI/Decisions/Scan")]
public class ScanDecision : Decision
{

    public override bool Decide(StateController controller)
    {

        bool noEnemyInSight = Scan(controller); //if true means we have not seen any enemy so we go patrolling. Else if false, it means we have not finished the scan, so keep doing it.
        return noEnemyInSight;
        //the player is looking until the scan decision finish.
    }

    private bool Scan(StateController controller)
    {
        controller.navMeshAgent.isStopped = true;
        controller.transform.Rotate(0, controller.enemyStats.searchingTurnSpeed * Time.deltaTime, 0);
        return controller.CheckIfCountDownElapsed(controller.enemyStats.searchDuration);
    }

}
