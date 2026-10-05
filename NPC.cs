using UnityEngine;

public class NPC : MonoBehaviour
{
    // Здоровье NPC
    public int health = 5;

    // Уровень NPC
    public int level = 1;

    // Скорость NPC
    public float speed = 1.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Здоровье NPC + уровень c выводом в консоль
        health += level;
        print("Здоровье NPC:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z -= speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
