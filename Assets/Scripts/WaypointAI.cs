using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaypointAI : MonoBehaviour //PascalCasing
{
    [SerializeField] private float speed = 1f; //camelCasing
    [SerializeField] private GameObject[] goal;
    private int indexOfGoal = 0;
    private GameObject currentGoal;
    private void Start()
    {
        currentGoal = goal[indexOfGoal];
    }
    void Update()
    {
        float distance2 = Vector2.Distance(transform.position, currentGoal.transform.position);

        if (distance2 > 0.01f) //are we there yet?
        {
            //the direction from A to B
            //direction = B - A
            Vector2 direction = (currentGoal.transform.position - transform.position).normalized;
            
            //Moves the ai
            Vector2 aiPosition = transform.position;
            aiPosition += direction * speed * Time.deltaTime;
            transform.position = aiPosition;
        }
        else
        {
            indexOfGoal++;
            if (indexOfGoal > goal.Length - 1)
            {
                indexOfGoal = 0;
            }
            
            currentGoal = goal[indexOfGoal];
        }
    }
}