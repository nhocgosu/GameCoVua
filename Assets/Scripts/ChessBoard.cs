
using UnityEngine;


public class ChessBoard : MonoBehaviour
{
    [SerializeField] private GameObject whiteTilePrefab ;
    [SerializeField] private GameObject blackTilePrefab;
    [Header ("white")]
    [SerializeField] private GameObject whitePawnPrefab  ;
    [SerializeField] private GameObject whiteRookPrefab  ;
    [SerializeField] private GameObject whiteKnightPrefab  ;
    [SerializeField] private GameObject whiteBishopPrefab  ;
    [SerializeField] private GameObject whiteQueenPrefab  ;
    [SerializeField] private GameObject whiteKingPrefab  ;
    [Header("Black")]
    [SerializeField] private GameObject blackPawnPrefab ;
    [SerializeField] private GameObject blackRookPrefab ;
    [SerializeField] private GameObject blackKnightPrefab ;
    [SerializeField] private GameObject blackBishopPrefab ;
    [SerializeField] private GameObject blackQueenPrefab ;
    [SerializeField] private GameObject blackKingPrefab ;

    private int rows = 8;
    private int colums = 8;
    private float titleSize = 1.0f;

    private GameObject[,] chessPieces = new GameObject[8,8];


    private void Start() {
        GenerateChessBoard();
        PlacePieces();
    }

    private void GenerateChessBoard (){
        for (int i = 0 ;  i < rows ; i++){
            for (int j = 0 ; j < colums; j ++){
                float xPos = j * titleSize;
                float yPos = i * titleSize;

                GameObject tilePrefab = (i + j ) % 2 == 0 ? whiteTilePrefab : blackTilePrefab;
                GameObject tile = Instantiate (tilePrefab , new Vector3 (xPos, yPos , 0 ), Quaternion.identity) ;
                tile.transform.parent = transform ;
            }

        }
        

    }
    private void PlacePieces(){
        chessPieces[0,0] = Instantiate(whiteRookPrefab , GetTileCenter(0,0), Quaternion.identity);
        chessPieces[0,1] = Instantiate (whiteKnightPrefab , GetTileCenter(0,1), Quaternion.identity);
        chessPieces[0,2] = Instantiate(whiteBishopPrefab , GetTileCenter(0,2),Quaternion.identity);
        chessPieces[0,3] = Instantiate (whiteQueenPrefab , GetTileCenter(0,3),Quaternion.identity);
        chessPieces[0,4] = Instantiate (whiteKingPrefab , GetTileCenter(0,4),Quaternion.identity);
        chessPieces[0,5] = Instantiate (whiteBishopPrefab , GetTileCenter (0,5) , Quaternion.identity);
        chessPieces[0,6] = Instantiate (whiteKnightPrefab,GetTileCenter(0,6), Quaternion.identity);
        chessPieces[0,7] = Instantiate (whiteRookPrefab , GetTileCenter(0,7) , Quaternion.identity);

        for (int i = 0 ; i < 8 ; i ++){
            chessPieces [1, i ] = Instantiate (whitePawnPrefab , GetTileCenter (1 , i) , Quaternion.identity);
        }

        chessPieces[7,0] = Instantiate (blackRookPrefab , GetTileCenter (7, 0), Quaternion.identity);
        chessPieces[7,1] = Instantiate (blackKnightPrefab , GetTileCenter (7,1),Quaternion.identity);
        chessPieces[7,2] = Instantiate (blackBishopPrefab , GetTileCenter (7,2) , Quaternion.identity );
        chessPieces[7,3] = Instantiate (blackKingPrefab , GetTileCenter (7,3) , Quaternion.identity);
        chessPieces[7,4] = Instantiate (blackQueenPrefab , GetTileCenter (7,4) , Quaternion.identity);
        chessPieces[7,5] = Instantiate (blackBishopPrefab , GetTileCenter (7,5) , Quaternion.identity);
        chessPieces[7,6] = Instantiate (blackKnightPrefab , GetTileCenter (7,6),Quaternion.identity);
        chessPieces[7,7] = Instantiate (blackRookPrefab , GetTileCenter (7,7) , Quaternion.identity);
        
        for (int i = 0 ; i < 8 ; i++){
            chessPieces [6 , i] = Instantiate (blackPawnPrefab  , GetTileCenter (6,i) , Quaternion.identity);
        }
    }
    private Vector3 GetTileCenter (int row, int col){
        float xPos = col * titleSize;
        float yPos = row * titleSize;
        return new Vector3 (xPos, yPos,0);

    }

    
}
