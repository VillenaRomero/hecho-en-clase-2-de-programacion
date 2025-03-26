using UnityEngine;

public enum Mobstace { 
neutral,
    pacefull,
    Agresive
}
public class mobs : entities
{
    private int damage;
    private float speed;
    private Mobstace mobstace;

    private inventary inventary = new inventary();

    public override void OnDestroy()
    {
        base.OnDestroy();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

player 

    mision manager

    objeto
