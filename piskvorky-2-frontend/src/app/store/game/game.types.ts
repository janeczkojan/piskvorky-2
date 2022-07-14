export enum GameStatus {
	NotStarted = 'NotStarted',
	InSettings = 'InSettings',
	Started = 'Started',
	Finished = 'Finished'
}


export type Player = {
	id: string;
	name: string;
	nation: string;
	image: string;
};


export type Players = [ Player?, Player? ];


export type Field = {
	row: number;
	col: number;
	playerId: string;
};


export type FieldMap = {
	[key: string]: Field;
};


export type Game = {
	status: GameStatus;
	players: Players;
	activePlayer: Player | null;
	cols: number;
	rows: number;
	selectedFields: FieldMap;
	winningFields: FieldMap;
};
