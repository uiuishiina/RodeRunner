using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager_script : MonoBehaviour
{
    [SerializeField, Header("使用するタイルマップ")] public Tilemap usetile;
    [SerializeField, Header("タイルの種類")] public TileData data;
}