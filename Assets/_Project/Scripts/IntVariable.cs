using UnityEngine;

[CreateAssetMenu(menuName = "Project/Variable/Int")]
public class IntVariable : ScriptableObject
{

    public int maxValue;
    public int initialValue;
    public int value;

    void OnEnable()
    {
        value = initialValue;
    }
}
