using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class entities : MonoBehaviour
{
    private int id;

    private int life;
    private bool interactuable;
    private Material mat;
    private Animation anim;

    private List<Item> dropableItemsa;

    public virtual void OnDestroy() {
        print("e sido destruido");
    }
    public virtual void OnInteract() {
        if (interactuable == false)
            return;

    }
}
