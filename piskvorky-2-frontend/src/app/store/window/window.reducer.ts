import { createReducer, on } from '@ngrx/store';
import { setWindow } from './window.actions';
import { Window } from './window.types';


export const WINDOW_INIT_STATE: Readonly<Window> = {
	width: 0,
	height: 0
};


export const windowReducer = createReducer(
	WINDOW_INIT_STATE,
	on(setWindow, (state, payload) => ({
		...state,
		width: payload.width,
		height: payload.height
	}))
);
