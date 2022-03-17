using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPC : MonoBehaviour
{
    // VITAL INFO
    public string unitName;
    public int unitLevel;
    public string role;     // Classic RPG 'class'
    public int exp;         // Current exp

    // STATISTIC ARRAYS | These arrays assume index 0 corresponds to Body, 1 to Mind, and 2 to Spirit
    private int body;
    private int mind;
    private int spirit;
    public float[] maxHealth = new float[3];
    public float[] currentHealth = new float[3];
    public float[] offense = new float[3];
    public float[] defense = new float[3];
    public float[] dex = new float[3];
    public float[] speed = new float[3];

    // Add skills, equipment, expertise, resistances, and items later!
}
