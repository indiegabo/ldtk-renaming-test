using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LDtkUnity;

public class ProjectTester : MonoBehaviour
{
    #region Inspector

    [SerializeField]
    private LDtkProjectFile _projectFile;

    #endregion

    #region Fields

    private LdtkJson _json;

    #endregion

    #region Behaviour

    private void Awake()
    {
        _json = _projectFile.FromJson;
    }

    private void Start()
    {
        Debug.Log($"Succesfully loaded project: {_json.Iid}", this);
    }

    #endregion
}
