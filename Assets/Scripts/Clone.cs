using UnityEngine;

public class Clone : MonoBehaviour
{
    GameObject mother;
    GameObject[] Clones;

    void Start()
    {
        mother = GameObject.Find("Collectibles");
        Clones = new GameObject[3000];

        for (int i = 0; i < 3000; i++)
        {
            Clones[i] = GameObject.Instantiate(mother);

          
            Clones[i].transform.position = new Vector3(Random.Range(-2f, 2f), 0.5f, i);
        }
    }
}
