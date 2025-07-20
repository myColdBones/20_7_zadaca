using System.Threading;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabEnemy;
    [SerializeField] private Transform centarSpawnPositionTransform;

    private float timer;
    void Update()
    {
        if(timer < Time.time)
        {
            timer = Time.time+ 1;
            SpawnEnemy();
        }
    }
    public void SpawnEnemy()
    {
        if (centarSpawnPositionTransform != null)
        {
            Vector3 spawnLocation = GetSpawnLocation();
            GameObject createdEnemy = Instantiate(prefabEnemy, spawnLocation, Quaternion.identity);
            createdEnemy.transform.rotation = Quaternion.LookRotation(centarSpawnPositionTransform.position - spawnLocation, Vector3.up);
        }
    }
    public Vector3 GetSpawnLocation()
    {
        float lenght = 8;
        float angleInRadians =Random.Range(0, 360) * Mathf.Deg2Rad;

        return centarSpawnPositionTransform.position + new Vector3(Mathf.Sin(angleInRadians), 0, Mathf.Cos(angleInRadians)) * lenght;
    }
}
