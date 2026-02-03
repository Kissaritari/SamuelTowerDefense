using UnityEngine;

public class Waypoints : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static Transform[] waypoints;

    // Update is called once per frame
    void Awake ()
    {
        waypoints = new Transform[transform.childCount];
        for (int i =0; i < waypoints.Length; i++)
        {
            waypoints[i] = transform.GetChild(i);
        }   
    }
}
