import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GameSettingsViewComponent } from './views/game-settings-view/game-settings-view.component';
import { GameViewComponent } from './views/game-view/game-view.component';
import { HomeViewComponent } from './views/home-view/home-view.component';


const routes: Routes = [
	{
		path: '',
		component: HomeViewComponent
	},
	{
		path: 'game-settings',
		component: GameSettingsViewComponent
	},
	{
		path: 'game',
		component: GameViewComponent
	}
];


@NgModule({
	imports: [ RouterModule.forRoot(routes) ],
	exports: [ RouterModule ]
})
export class AppRoutingModule {}
