import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { AppState } from './store/store.state';
import { selectWindowHeight, selectWindowWidth } from './store/window/window.selectors';
import { listenForResize } from './store/window/window.actions';


@Component({
	selector: 'app-root',
	templateUrl: './app.component.html',
	styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

    windowWidth$: Observable<number> = this.store.select(selectWindowWidth);
    windowHeight$: Observable<number> = this.store.select(selectWindowHeight);

    constructor(
        private readonly store: Store<AppState>
    ) {}

    ngOnInit() {
        this.store.dispatch(listenForResize());
    }

}
