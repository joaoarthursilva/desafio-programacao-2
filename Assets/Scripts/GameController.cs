using UnityEngine;
using UnityEditor;


public class GameController : MonoBehaviour
{
    private Sprite _spriteCircle;
    private Sprite _spriteDiamond;
    private Sprite _spriteHexagon;
    private Sprite _spriteSquare;
    private Sprite _spriteTriangle;

    private void Awake()
    {
        _spriteCircle = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Circle.png");
        _spriteDiamond = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Diamond.png");
        _spriteHexagon = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Hexagon.png");
        _spriteSquare = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Square.png");
        _spriteTriangle = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Triangle.png");
    }

    private void Start()
    {
        var largura = Random.Range(80, 121);
        var altura = Random.Range(40, 81);
        var espacamento = Random.Range(.2f, .4f);
        var espacamentoAtualX = espacamento;
        var espacamentoAtualY = espacamento;
        Debug.Log(largura + " " + altura);

        for (var i = 0; i < largura; i++)
        {
            var go1 = CreateHex(espacamentoAtualX, espacamentoAtualY);

            var go1Sprite = go1.AddComponent<SpriteRenderer>().sprite = _spriteHexagon;
            for (var j = 0; j < altura; j++)
            {
                var go2 = CreateHex(espacamentoAtualX, espacamentoAtualY);
                var go2Sprite = go2.AddComponent<SpriteRenderer>().sprite = _spriteHexagon;
                espacamentoAtualY += go2Sprite.bounds.extents.y * 2;
            }

            espacamentoAtualY = espacamento;
            espacamentoAtualX += go1Sprite.bounds.extents.x * 2;
        }
    }

    private GameObject CreateHex(float espacamentoAtualX, float espacamentoAtualY)
    {
        var go1 = new GameObject
        {
            name = "Hex",
            transform =
            {
                position = new Vector3(espacamentoAtualX, espacamentoAtualY)
            }
        };
        return go1;
    }
}