import { createReducer, on } from '@ngrx/store';
import { Game, GameStatus } from './game.types';


export const GAME_INIT_STATE: Readonly<Game> = {
	status: GameStatus.NotStarted,
	players: [],
	activePlayer: null,
	rows: 0,
	cols: 0,
	selectedFields: {},
	winningFields: {}
};


export const gameReducer = createReducer(
	GAME_INIT_STATE
);
