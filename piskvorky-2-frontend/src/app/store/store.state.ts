import { Window } from './window/window.types';
import { Game } from './game/game.types';


export type AppState = {
	window: Readonly<Window>;
	game: Readonly<Game>;
};
