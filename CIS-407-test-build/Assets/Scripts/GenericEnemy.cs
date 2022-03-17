using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemy : MonoBehaviour
{
    public string unitName;
    public int expYield;
    public int goldYield;

    // These arrays assume index 0 corresponds to Body, 1 to Mind, and 2 to Spirit
    private int body;
    private int mind;
    private int spirit;
    public float[] maxHealth = new float[3];
    public float[] currentHealth = new float[3];
    public float[] offense = new float[3];
    public float[] defense = new float[3];
    public float[] dex = new float[3];
    public float[] speed = new float[3];

    // Add items and item drops??
}
