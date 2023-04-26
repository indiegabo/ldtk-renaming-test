using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LDtkUnity;

public class LevelTester : MonoBehaviour
{
    #region Inspector

    [SerializeField]
    private LDtkLevelFile _levelFile;

    #endregion

    #region Fields

    private Level _level;

    #endregion

    #region Behaviour

    private void Awake()
    {
        _level = _levelFile.FromJson;
    }

    private void Start()
    {
        Debug.Log($"Succesfully loaded level: {_level.Iid}", this);
    }

    #endregion
}
