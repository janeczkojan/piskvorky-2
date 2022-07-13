import { createSelector } from '@ngrx/store';
import { Window } from './window.types';
import { AppState } from '../store.state';


export const selectWindow = (state: AppState) => state.window;

export const selectWindowWidth = createSelector(
	selectWindow,
	(state: Window) => state.width
);

export const selectWindowHeight = createSelector(
	selectWindow,
	(state: Window) => state.height
);
