import { createAction, props } from '@ngrx/store';
import { Window } from './window.types';


export const SET_WINDOW = '[Window] setWindow';
export const LISTEN_FOR_RESIZE = '[Window] listenForResize';


export const setWindow = createAction(
	SET_WINDOW,
	props<Window>()
);

export const listenForResize = createAction(LISTEN_FOR_RESIZE);

