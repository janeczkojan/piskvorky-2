import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { EMPTY, fromEvent, of } from 'rxjs';
import { map, mergeMap, catchError, tap, debounceTime } from 'rxjs/operators';
import { Window } from './window.types';
import { LISTEN_FOR_RESIZE, setWindow } from './window.actions';
import { Store } from '@ngrx/store';


@Injectable()
export class WindowEffects {

	listenForResize$ = createEffect(() => this.actions$.pipe(
		ofType(LISTEN_FOR_RESIZE),
		map(() => this.getWindowSize()),
		tap((windowSize) => this.updateWindowSize(windowSize)),
		mergeMap(() => fromEvent(window, 'resize').pipe(
			debounceTime(10),
			map(() => (this.getWindowSize()))
		)),
		map((windowSize) => setWindow(windowSize))
	));
  

	constructor(
		private readonly actions$: Actions,
		private readonly store: Store
	) {}

	private getWindowSize(): Window {
		return {
			width: window.innerWidth,
			height: window.innerHeight
		};
	}

	private updateWindowSize(size: Window) {
		this.store.dispatch(setWindow(size));
	}

}
