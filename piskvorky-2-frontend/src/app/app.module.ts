import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StoreModule } from './store/store.module';
import { HomeViewComponent } from './views/home-view/home-view.component';
import { GameViewComponent } from './views/game-view/game-view.component';
import { GameSettingsViewComponent } from './views/game-settings-view/game-settings-view.component';
import { HeaderComponent } from './components/header/header.component';
import { HttpClientModule, HttpClient  } from '@angular/common/http';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { environment } from '../environments/environment';


export function HttpLoaderFactory(http: HttpClient) {
    return new TranslateHttpLoader(http);
}


@NgModule({
	declarations: [
		AppComponent,
  		HomeViewComponent,
    	GameViewComponent,
    	GameSettingsViewComponent,
     	HeaderComponent
	],
	imports: [
		BrowserModule,
		HttpClientModule,
		TranslateModule.forRoot({
			defaultLanguage: 'cz',
			loader: {
                provide: TranslateLoader,
                useFactory: HttpLoaderFactory,
                deps: [ HttpClient ]
            }
		}),
		StoreModule,
		AppRoutingModule
	],
	providers: [],
	bootstrap: [ AppComponent ]
})
export class AppModule {}
