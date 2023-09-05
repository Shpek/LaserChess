using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	private List<Player> _players;
	private int _currentPlayerIdx = -1;

	private void Start()
	{
		_players = new List<Player>();
		
		Piece piece = new Piece {
			Pos = new Vector2Int(0, 0)
		};

		var player = new Player(this, "Player 1", new List<Piece> { piece });
		_players.Add(player);
		
		piece = new Piece {
			Pos = new Vector2Int(7, 7)
		};
		
		player = new Player(this, "Player 2", new List<Piece> { piece });
		_players.Add(player);
		
		NextPlayer();
	}

	private void Update()
	{
		_players[_currentPlayerIdx].Update();
	}

	public void NextPlayer()
	{
		++ _currentPlayerIdx;

		if (_currentPlayerIdx == _players.Count) {
			_currentPlayerIdx = 0;
		}
		
		_players[_currentPlayerIdx].StartTurn();
	}
}
