using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject terrainPrefab;
    public int iterations = 10; 

    private Vector3 currentPosition; 

    void Start()
    {
        currentPosition = transform.position;
        GenerateTerrains();
    }

    void GenerateTerrains()
    {
        for (int i = 0; i < iterations; i++)
        {
            int randomDirectionX = UnityEngine.Random.Range(-1, 2);
            int randomDirectionY = UnityEngine.Random.Range(-1, 2);
            Vector3 direction = new Vector3(randomDirectionX, 0f, randomDirectionY);

         
            currentPosition += direction * 10;
            GameObject newTerrain = Instantiate(terrainPrefab, currentPosition, Quaternion.identity);
        }
    }
}
