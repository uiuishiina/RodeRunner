using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player_Move : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameManager_script gameManager;
    public Vector2 Input(float x,float y)
    {
        var pos = Getpos();
        return new Vector2(pos.x + 1*(x/Mathf.Abs(x)), pos.y + 1 * (y / Mathf.Abs(y)));
    }

    Vector2 Getpos()
    {
        return new Vector2(player.transform.position.x, player.transform.position.y);
    }

    public TileBase CheckTile(Vector2 t)
    {
        var tile = gameManager.usetile;
        var p = tile.WorldToCell(Getpos() + t);
        if (tile.HasTile(p)) {
            return tile.GetTile<TileBase>(p);
        }
        return null;
    }
}
