using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Final Exam #3
 * 
 *  Make this script inherit the PickUp Class.
 * Attach this script to the yellow arrow that is on the track
 * Override the Activate() method to:
 *      - Save the original speed of the player
 *      - increase the speed of the car to 5
 *      - Wait for 2 seconds (Write a coroutine)
 *      - Change the speed back to the originalSpeed
 * 
 */
public class SpeedPickup : PickUp
{
    public float originalSpeed;
    public float boostedSpeed = 5;
    public float timeToWait = 2;

    public override void Activate()
    {
        StartCoroutine(GoFastOrSomethingLikeThat());
    }


    IEnumerator GoFastOrSomethingLikeThat()
    {
        originalSpeed = player.moveSpeed;

        player.moveSpeed = boostedSpeed;
        yield return new WaitForSeconds(timeToWait);
        player.moveSpeed = originalSpeed;
    }
}
