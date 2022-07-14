import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StoreModule as NgrxStoreModule } from '@ngrx/store';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { environment } from '../../environments/environment';
import { StoreRouterConnectingModule, routerReducer } from '@ngrx/router-store';
import { EffectsModule } from '@ngrx/effects';
import { windowReducer } from './window/window.reducer';
import { WindowEffects } from './window/window.effects';
import { gameReducer } from './game/game.reducer';


const reducers = {
	router: routerReducer,
	window: windowReducer,
	game: gameReducer
};

const effects = [
	WindowEffects
];


@NgModule({
	declarations: [],
	imports: [
		CommonModule,
		NgrxStoreModule.forRoot(reducers, {}),
		StoreDevtoolsModule.instrument({ maxAge: 25, logOnly: environment.production }),
		StoreRouterConnectingModule.forRoot(),
		EffectsModule.forRoot(effects)
	]
})
export class StoreModule {}
