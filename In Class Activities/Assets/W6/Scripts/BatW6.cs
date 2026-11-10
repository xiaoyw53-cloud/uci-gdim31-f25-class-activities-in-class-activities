using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform cat;
    [SerializeField] private float speed = 2f;

    private bool isChasing;
    private void Update()
    {
        if (!isChasing || cat == null)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(
            transform.position,
            cat.position,
            speed * Time.deltaTime
            );
    }

    public void StartChasing()
    {
        isChasing = true;
    }

    public void StopChasing()
    {
        isChasing = false;
    }
}
