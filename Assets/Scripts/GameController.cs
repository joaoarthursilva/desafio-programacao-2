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
        for (var i = 0; i < largura; i++)
        {
            var go1 = new GameObject
            {
                transform =
                {
                    position = new Vector3(espacamentoAtualX, 0)
                }
            };
            go1.AddComponent<>();
            for (var j = 0; j < altura; j++)
            {
                var go2 = new GameObject
                {
                    transform =
                    {
                        position = new Vector3(0, espacamentoAtualY)
                    }
                };
            }
        }
    }
}