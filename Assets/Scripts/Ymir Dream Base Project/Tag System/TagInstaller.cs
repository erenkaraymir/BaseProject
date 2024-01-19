using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagInstaller : MonoBehaviour
{
    [SerializeField] private GameTag _tag;
    private void Awake()
    {
        TagManager.AddTag(gameObject,_tag);
    }
}
