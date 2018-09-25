using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointsIndex = 0;

    private void Start()
    {
        target = Tujuans.points[0];

    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position)<= 0.2f)
        {
            GetNextPoint();
        }
    }

    void GetNextPoint()
    {
        if (wavepointsIndex >= Tujuans.points.Length - 1)
        {
            CoreHealth.health--;
            Destroy(gameObject);
            return;
        }
        wavepointsIndex++;
        target = Tujuans.points[wavepointsIndex];
    }
}
