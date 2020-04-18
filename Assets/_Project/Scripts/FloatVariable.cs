using UnityEngine;

[CreateAssetMenu(menuName = "Project/Variable/Float")]
public class FloatVariable : ScriptableObject
{

    public bool infinityValue;
    public float maxValue;
    public float initialValue;
    public float value;

    void OnEnable()
    {
        value = initialValue;
    }

}
