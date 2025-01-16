using Unity.VisualScripting;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    #region DebugLog
    [SerializeField] public bool DebugLogs = false;
    [SerializeField] public bool healthLogs = true;
    #endregion
    public static DataManager Instance;
    public int currentHealth;
    
    void Awake() // independent init; usecase: caching components ie. GetComponent
    {

    }

    void Start() // dependent init; usecase: initialization if dependent on other objects ie. Initialize()
    {
        
    }
}
