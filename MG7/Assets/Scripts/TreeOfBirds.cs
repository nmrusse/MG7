using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds : MonoBehaviour
{


[SerializeField] private GameObject [] _birds;
[SerializeField] private Transform _player;
[SerializeField] private float _interactionDistance = 5.0f;

private void Update()
{
    Debug.Log(gameObject.name + " Player: " + _player);
    
    for (int i = 0; i < _birds.Length; i++)
    {
        if (Vector3.Distance(_birds[i].transform.position,_player.position) <= _interactionDistance)
        {
            _birds[i].SetActive(true);
        }
    }
}

}