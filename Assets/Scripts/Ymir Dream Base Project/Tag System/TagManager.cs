using UnityEngine;
using System.Collections.Generic;

public static class TagManager
{
    private static Dictionary<GameObject, List<GameTag>> gameObjectTags = new Dictionary<GameObject, List<GameTag>>();

    public static void AddTag(GameObject gameObject, GameTag tag)
    {
        if (!gameObjectTags.ContainsKey(gameObject))
        {
            gameObjectTags[gameObject] = new List<GameTag>();
        }
        gameObjectTags[gameObject].Add(tag);
    }

    public static bool HasTag(GameObject gameObject, GameTag tag)
    {
        if (gameObjectTags.TryGetValue(gameObject, out List<GameTag> tags))
        {
            return tags.Contains(tag);
        }
        return false;
    }

 
}