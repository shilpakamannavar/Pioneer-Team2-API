import { Component } from '@angular/core';
import { SearchDocsService } from '../shared/search-docs.service';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
})
export class HomeComponent {

    searchResults: any[];

    constructor(private searchDocsService: SearchDocsService) {
        this.searchDocsService.resultSubject.subscribe(value => {
            this.searchResults = value;
        });
    }


    getUrl(url:string) {
        return atob(url);
    }
}
